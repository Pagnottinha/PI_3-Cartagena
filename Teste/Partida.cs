using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Teste
{
    public enum Status {
        Aberta,
        Jogando,
        Encerrada
    }
    public class Partida
    {
        public int id { get; }
        public string nome { get; }
        public string senha { get; set; }
        public string data { get; }
        public Status status { get; private set; }
        public List<Jogador> Jogadores { get; private set; }

        public Jogador jogador { get; set; }
        public Vez vez { get; set; }

        public List<Historico> historicos { get; private set; }

        public Dictionary<int, Casa> tabuleiro { get; private set; }

        public Partida(int id, string nome, string data, Status status)
        {
            this.id = id;
            this.nome = nome;
            this.data = data;
            this.status = status;
        }

        public Partida(string nome, string senha)
        {
            string retorno = Jogo.CriarPartida(nome, senha);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            this.id = Convert.ToInt32(retorno);
            this.nome = nome;
            this.senha = senha;
            this.data = DateTime.Now.ToString("d");
            this.status = Status.Aberta;
        }

        public void listarJogadores()
        {
            JogoService service = new JogoService();

            (List<Jogador> Jogadores, string msgErro) = service.pegarJogadores(this.id);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Jogadores = Jogadores;
        }

        public bool comecarPartida()
        {
            JogoService service = new JogoService();

            this.status = Status.Jogando;

            this.listarJogadores();

            (int idJogadorVez, string msgErro) = service.iniciarPartida(jogador.id, jogador.senha);

            if (msgErro == "ERRO:Partida não está aberta")
            {
                this.verificarVez();
            }
            else if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                this.vez = new Vez(status, idJogadorVez, 1);
            }
            
            for (int i = 0; i < Jogadores.Count; i++)
            {
                if (Jogadores[i].id == jogador.id)
                {
                    Jogadores[i] = jogador;
                }
            }

            this.historicos = new List<Historico>();

            jogador.consultarMao();

            return true;
        }

        public void listarTabuleiro(Panel pnlTabuleiro)
        {
            (Dictionary<int, Casa> tabuleiro, string msgErro) = new JogoService().pegarTabuleiro(this.id, pnlTabuleiro);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.tabuleiro = tabuleiro;
        }

        public void pegarHistorico()
        {

            (List<Historico> novoHistorico, string msgErro) = new JogoService().pegarHistorico(this.id, this.historicos.Count);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Historico historico in novoHistorico)
            {

                if (historico.tipo != TiposHistorico.Pular && historico.idJogador != jogador.id)
                {
                    Jogador jogadorHistorico = Jogadores.Find(jogador => jogador.id == historico.idJogador);

                    if (jogadorHistorico == null)
                        throw new Exception("Ocorreu um erro ao tentar pegar o jogador através do histórico.");

                    Peao peaoMover = tabuleiro[historico.origem].peoes.Find(peao => peao.jogador == jogadorHistorico);

                    peaoMover.posicao = historico.destino;

                    tabuleiro[historico.origem].peoes.Remove(peaoMover);

                    tabuleiro[historico.destino].peoes.Add(peaoMover);
                }

                historicos.Add(historico);
            }
        }

        public void verificarVez()
        {
            (Vez retornoVez, string msgErro) = new JogoService().verificarVez(id);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vez.status == Status.Encerrada)
            {
                this.status = Status.Encerrada;
            }

            this.vez = retornoVez;
        }

        public string stringVez()
        {
            string vez = this.vez.ToString();
            string strIdJogadorVez = vez.Substring(0, vez.IndexOf(" "));

            int idJogadorVez = Convert.ToInt32(strIdJogadorVez);

            Jogador jogador = Jogadores.Find(j => j.id == idJogadorVez);

            return vez.Replace(strIdJogadorVez, jogador.ToString());
        }
    }
}
