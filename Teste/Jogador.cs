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
            string retorno = Jogo.EntrarPartida(partida.id, this.nome, senha);

            if (retorno.StartsWith("ERRO")) { throw new Exception(retorno); }

            else
            {
                string[] retornoArray = retorno.Split(',');

                this.id = Convert.ToInt32(retornoArray[0]);
                this.senha = retornoArray[1];
                this.cor = retornoArray[2];

                partida.Jogadores = new List<Jogador>();
                
                partida.Jogadores.Add(this);
            }
            
        }
        public void consultarMao()
        {
            string[] ret = Jogo.ConsultarMao(id, senha).Replace("\r", "")
                .Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            cartas.Clear();

            foreach (string item in ret)
            {
                string[] retornoConsultMao = item.Split(',');

                string carta = retornoConsultMao[0];
                int qtd = Convert.ToInt32(retornoConsultMao[1]);

                if (carta == "E") { cartas.Add(Cartas.Esqueleto, qtd); }

                else if (carta == "T") { cartas.Add(Cartas.Tricornio, qtd); }

                else if (carta == "G") { cartas.Add(Cartas.Garrafa, qtd); }

                else if (carta == "F") { cartas.Add(Cartas.Faca, qtd); }

                else if (carta == "P") { cartas.Add(Cartas.Pistola, qtd); }

                else if(carta == "C") { cartas.Add(Cartas.Chave, qtd); }
            }
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
