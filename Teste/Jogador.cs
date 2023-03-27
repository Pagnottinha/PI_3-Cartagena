using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public enum Cartas { 
        Esqueleto,
        Faca,
        Garrafa,
        Tricornio,
        Chave,
        Pistola
    }

    public class Jogador
    {
        public int id {  get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }

        public Dictionary<Cartas, int> cartas = new Dictionary<Cartas, int>();

        public Jogador(int id, string nome, string cor)
        {
            this.id = id;
            this.nome = nome;
            this.cor = cor;
        }

        public Jogador(string nome)
        {
            this.nome = nome;
        }

        public void entrarPartida(Partida partida, string senha)
        {
            JogoService service = new JogoService();

            Jogador retorno = service.entrarPartida(partida.id, this.nome, senha);

            this.id = retorno.id;
            this.cor = retorno.cor;
            this.senha = retorno.senha;

            partida.jogador = this;
            partida.senha = senha;
        }
        public void consultarMao()
        {
            JogoService service = new JogoService();
            this.cartas = service.consultarMao(this.id, this.senha);
        }

        public void Jogar(string jogar, int posicao, string carta)
        {
            string ret;

            if (posicao == -1)
            {
                ret = Jogo.Jogar(this.id, this.senha);
            }
            else if (jogar == "Mover para frente")
            {
                ret = Jogo.Jogar(this.id, this.senha, posicao, carta);
            }
            else
                ret = Jogo.Jogar(this.id, this.senha, posicao);

            System.Windows.Forms.MessageBox.Show(ret);
        }
    }
}
