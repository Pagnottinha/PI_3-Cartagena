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
        public int id {  get; private set; }
        public string senha { get; private set; }
        public string nome { get; private set; }
        public Color cor { get; private set; }

        public Dictionary<Cartas, int> cartas { get; private set; }

        public List<Peao> peoes { get; private set; }

        public Jogador(int id, string nome, Color cor)
        {
            this.id = id;
            this.nome = nome;
            this.cor = cor;
        }

        public Jogador(string nome)
        {
            this.nome = nome;
        }

        public Jogador(int id, string senha, string nome, Color cor)
        {
            this.id = id;
            this.senha = senha;
            this.nome = nome;
            this.cor = cor;
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

        public void iniciarPeoes(Dictionary<int, Casa> tabuleiro)
        {
            this.peoes = new List<Peao>(6);

            for (int i = 0; i < 6; i++)
            {
                Peao peao = new Peao(this);
                this.peoes.Add(peao);
                tabuleiro[0].peoes.Add(peao);
            }
        }

        public void consultarMao()
        {
            JogoService service = new JogoService();
            this.cartas = service.consultarMao(this.id, this.senha);
        }

        // Pular vez
        public void Jogar()
        {
            Jogo.Jogar(this.id, this.senha);
        }

        // Mover para frente
        public void Jogar(int posicao, string carta, Dictionary<int, Casa> tabuleiro)
        {
            Peao peaoMover = verificarPeaoCasa(tabuleiro, posicao);

            if (peaoMover == null)
            {
                throw new Exception("Não tem peão seu na casa");
            }

            Casa casa = null;

            Cartas destino;
            switch (carta)
            {
                case "E":
                    destino = Cartas.Esqueleto;
                    break;
                case "T":
                    destino = Cartas.Tricornio;
                    break;
                case "G":
                    destino = Cartas.Garrafa;
                    break;
                case "F":
                    destino = Cartas.Faca;
                    break;
                case "P":
                    destino = Cartas.Pistola;
                    break;
                case "C":
                    destino = Cartas.Chave;
                    break;
                default:
                    throw new Exception("Carta inválida!");
            }

            for (int i = posicao + 1; i < tabuleiro.Count && casa == null; i++)
            {
                if (tabuleiro[i].carta == destino && tabuleiro[i].peoes.Count == 0)
                {
                    casa = tabuleiro[i];
                }
            }

            if (casa == null) casa = tabuleiro[tabuleiro.Count - 1];

            tabuleiro[posicao].peoes.Remove(peaoMover);
            casa.peoes.Add(peaoMover);

            Jogo.Jogar(this.id, this.senha, posicao, carta);

            consultarMao();
        }

        // Voltar
        public void Jogar(int posicao, Dictionary<int, Casa> tabuleiro)
        {
            Peao peaoMover = verificarPeaoCasa(tabuleiro, posicao);

            if (peaoMover == null)
            {
                throw new Exception("Não tem peão seu na casa");
            }

            Casa casa = null;

            for (int i = posicao - 1; i > 0 && casa == null; i--)
            {
                if (tabuleiro[i].peoes.Count > 0 && tabuleiro[i].peoes.Count < 3)
                {
                    casa = tabuleiro[i];
                }
            }

            if (casa == null)
            {
                throw new Exception("Não tem para onde o peão voltar");
            }

            tabuleiro[posicao].peoes.Remove(peaoMover);
            casa.peoes.Add(peaoMover);

            Jogo.Jogar(this.id, this.senha, posicao);

            consultarMao();
        }

        Peao verificarPeaoCasa(Dictionary<int, Casa> tabuleiro, int posicao)
        {
            Peao peaoMover = null;

            foreach(Peao peao in tabuleiro[posicao].peoes)
            {
                if (peao.jogador == this)
                {
                    peaoMover = peao;
                }
            }

            return peaoMover;
        }

        public override string ToString()
        {
            return $"{nome} ({id} - {cor})";
        }
    }
}
