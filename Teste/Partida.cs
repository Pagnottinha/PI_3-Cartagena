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
        public Status status { get; }
        public List<Jogador> Jogadores { get; private set; }

        public Jogador jogador { get; set; }
        public Jogador vez { get; set; }

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

            if (retorno.StartsWith("ERRO")) throw new Exception(retorno);

            this.id = Convert.ToInt32(retorno);
            this.nome = nome;
            this.senha = senha;
            this.data = DateTime.Now.ToString("d");
            this.status = Status.Aberta;
        }

        public void listarJogadores()
        {
            JogoService service = new JogoService();

            Jogadores = service.pegarJogadores(this.id);
        }

        public void comecarPartida()
        {
            JogoService service = new JogoService();

            try
            {
                this.listarJogadores();
                int idJogadorVez = service.iniciarPartida(jogador.id, jogador.senha);
                this.vez = Jogadores.Find(jogador => jogador.id == idJogadorVez);
            }
            catch (PartidaAbertaException)
            {
                this.verificarVez();
            }
            finally
            {

                for (int i = 0; i < Jogadores.Count; i++)
                {
                    if (Jogadores[i].id == jogador.id)
                    {
                        Jogadores[i] = jogador;
                    }
                }

                this.historicos = new List<Historico>();

                jogador.consultarMao();
            }
         
        }

        public void listarTabuleiro(Panel pnlTabuleiro)
        {
            tabuleiro = new JogoService().pegarTabuleiro(this.id, pnlTabuleiro);
        }

        public void pegarHistorico()
        {

            List<Historico> novoHistorico = new JogoService().pegarHistorico(this.id, this.historicos.Count);

            foreach(Historico historico in novoHistorico)
            {

                if (historico.tipo != TiposHistorico.Pular && historico.idJogador != jogador.id)
                {
                    Jogador jogadorHistorico = null;

                    Jogadores.ForEach((jogador) =>
                    {
                        if (jogador.id == historico.idJogador)
                        {
                            jogadorHistorico = jogador;
                        }
                    });

                    if (jogadorHistorico == null)
                        throw new Exception("Ocorreu um erro ao tentar pegar o jogador através do histórico.");

                    Peao peaoMover = tabuleiro[historico.origem].peoes.Find(peao => peao.jogador == jogadorHistorico);

                    tabuleiro[historico.origem].peoes.Remove(peaoMover);

                    tabuleiro[historico.destino].peoes.Add(peaoMover);
                }

                historicos.Add(historico);
            }
        }

        public void verificarVez()
        {
            int idJogadorVez = new JogoService().verificarVez(id);
            this.vez = this.Jogadores.Find(jogador => jogador.id == idJogadorVez);
        }
    }
}
