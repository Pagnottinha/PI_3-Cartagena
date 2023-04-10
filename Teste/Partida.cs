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
        Encerada
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
        public int vez { get; set; }

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

        public void listarTabuleiro(Panel pnlTabuleiro)
        {
            tabuleiro = new JogoService().pegarTabuleiro(this.id, pnlTabuleiro);
        }
    }
}
