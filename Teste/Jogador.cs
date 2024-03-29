﻿using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
        public int qntCartas { get; set; }

        public List<Peao> peoes { get; private set; }

        public Jogador(int id, string nome, Color cor) : this(nome)
        {
            this.id = id;
            this.cor = cor;
        }

        public Jogador(string nome)
        {
            this.nome = nome;
            qntCartas = 6;
        }

        public Jogador(int id, string senha, string nome, Color cor) : this(id, nome, cor)
        {
            this.senha = senha;
        }

        public bool entrarPartida(Partida partida, string senha)
        {
            JogoService service = new JogoService();

            partida.listarJogadores();

            (Jogador retorno, string msgErro) = service.entrarPartida(partida.id, this.nome, senha);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.id = retorno.id;
            this.cor = retorno.cor;
            this.senha = retorno.senha;

            partida.jogador = this;
            partida.senha = senha;

            partida.Jogadores.Add(this);
            return true;
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

            (Dictionary<Cartas, int> cartas, string msgErro) = service.consultarMao(this.id, this.senha);

            if (msgErro != null)
            {
                MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.cartas = cartas;
        }

        // Pular vez
        public void Jogar()
        {
            string retorno = Jogo.Jogar(this.id, this.senha);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno);
                return;
            }
        }

        // Mover para frente
        public void Jogar(int posicao, string carta, Dictionary<int, Casa> tabuleiro)
        {
            string retorno = Jogo.Jogar(this.id, this.senha, posicao, carta);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno);
                return;
            }

            Cartas cartaEscolhida;
            switch (carta)
            {
                case "E":
                    cartaEscolhida = Cartas.Esqueleto;
                    break;
                case "T":
                    cartaEscolhida = Cartas.Tricornio;
                    break;
                case "G":
                    cartaEscolhida = Cartas.Garrafa;
                    break;
                case "F":
                    cartaEscolhida = Cartas.Faca;
                    break;
                case "P":
                    cartaEscolhida = Cartas.Pistola;
                    break;
                case "C":
                    cartaEscolhida = Cartas.Chave;
                    break;
                default:
                    MessageBox.Show("CArta inválida");
                    return;
            }

            cartas[cartaEscolhida]--;
            qntCartas--;

            Peao peaoMover = peoes.Find(peao => peao.posicao == posicao);

            Casa casa = null;

            for (int i = posicao + 1; i < tabuleiro.Count && casa == null; i++)
            {
                if (tabuleiro[i].carta == cartaEscolhida && tabuleiro[i].peoes.Count == 0)
                {
                    casa = tabuleiro[i];
                    peaoMover.posicao = i;
                }
            }

            if (casa == null)
            {
                casa = tabuleiro[tabuleiro.Count - 1];
                peaoMover.posicao = tabuleiro.Count - 1;
            }
         
            tabuleiro[posicao].peoes.Remove(peaoMover);
            casa.peoes.Add(peaoMover);
        }

        // Voltar
        public void Jogar(int posicao, Dictionary<int, Casa> tabuleiro)
        {
            string retorno = Jogo.Jogar(this.id, this.senha, posicao);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show(retorno);
                return;
            }

            Peao peaoMover = peoes.Find(peao => peao.posicao == posicao);

            Casa casa = null;

            for (int i = posicao - 1; i > 0 && casa == null; i--)
            {
                if (tabuleiro[i].peoes.Count > 0 && tabuleiro[i].peoes.Count < 3)
                {
                    casa = tabuleiro[i];
                    peaoMover.posicao = i;

                    switch(casa.peoes.Count)
                    {
                        case 1:
                            qntCartas++;
                            break;
                        case 2:
                            qntCartas += 2;
                            break;
                    }
                }
            }

            tabuleiro[posicao].peoes.Remove(peaoMover);
            casa.peoes.Add(peaoMover);

            consultarMao();
        }

        public override string ToString()
        {
            return $"{nome} ({id} - {cor.Name})";
        }
    }
}
