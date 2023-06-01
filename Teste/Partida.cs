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
            if (this.Jogadores == null)
            {
                this.Jogadores = new List<Jogador>();
            }

            JogoService service = new JogoService();

            (List<Jogador> Jogadores, string msgErro) = service.pegarJogadores(this.id, this.Jogadores.Count);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Jogador jogador in Jogadores)
            {
                this.Jogadores.Add(jogador);
            }
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
                historico.pegarJogador(Jogadores);

                if (historico.tipo != TiposHistorico.Pular && historico.idJogador != jogador.id)
                {
                    Peao peaoMover = tabuleiro[historico.origem].peoes.Find(peao => peao.jogador == historico.Jogador);

                    peaoMover.posicao = historico.destino;

                    int peoesDestino = tabuleiro[historico.destino].peoes.Count;

                    if (peoesDestino == 0)
                    {
                        historico.Jogador.cartas[Cartas.Esqueleto]--;
                    }
                    else if (peoesDestino == 1)
                    {
                        historico.Jogador.cartas[Cartas.Esqueleto]++;
                    }
                    else if (peoesDestino == 2)
                    {
                        historico.Jogador.cartas[Cartas.Esqueleto] += 2;
                    }

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

            if (retornoVez.status == Status.Encerrada)
            {
                this.status = Status.Encerrada;
            }

            this.vez = retornoVez;

            vez.pegarJogador(Jogadores);
        }
    }
}
