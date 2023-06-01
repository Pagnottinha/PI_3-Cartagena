using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public enum TiposHistorico {
        Mover,
        Voltar,
        Pular
    }

    public class Historico
    {
        public TiposHistorico tipo { get; }
        public int idJogador { get; }
        public Jogador Jogador { get; private set; }
        public int numJogada { get; }
        public Cartas carta { get; }
        public int origem { get; }
        public int destino { get; }

        public Historico(int idJogador, int numJogada, Cartas carta, int origem, int destino)
        {
            this.tipo = TiposHistorico.Mover;
            this.idJogador = idJogador;
            this.numJogada = numJogada;
            this.carta = carta;
            this.origem = origem;
            this.destino = destino;
        }

        public Historico(int idJogador, int numJogada)
        {
            this.tipo = TiposHistorico.Pular;
            this.idJogador = idJogador;
            this.numJogada = numJogada;
        }

        public Historico(int idJogador, int numJogada, int origem, int destino)
        {
            this.tipo = TiposHistorico.Voltar;
            this.idJogador = idJogador;
            this.numJogada = numJogada;
            this.origem = origem;
            this.destino = destino;
        }

        public void pegarJogador(List<Jogador> jogadores)
        {
            foreach (Jogador jogador in jogadores)
            {
                if (jogador.id == idJogador)
                {
                    Jogador = jogador;
                    return;
                }
            }
        }

        public override string ToString()
        {
            string retorno = "";

            if (Jogador == null)
            {
                switch(tipo)
                {
                    case TiposHistorico.Pular:
                        retorno = $"{idJogador} ({numJogada}) pulou";
                        break;
                    case TiposHistorico.Mover:
                        retorno = $"{idJogador} ({numJogada}) -> {carta} | {origem} -> {destino}";
                        break;
                    case TiposHistorico.Voltar:
                        retorno = $"{idJogador} ({numJogada}) voltou | {origem} -> {destino}";
                        break;
                }
            }
            else
            {
                switch (tipo)
                {
                    case TiposHistorico.Pular:
                        retorno = $"{Jogador.nome} - {Jogador.id} ({numJogada}) pulou";
                        break;
                    case TiposHistorico.Mover:
                        retorno = $"{Jogador.nome} - {Jogador.id} ({numJogada}) -> {carta} | {origem} -> {destino}";
                        break;
                    case TiposHistorico.Voltar:
                        retorno = $"{Jogador.nome} - {Jogador.id} ({numJogada}) voltou | {origem} -> {destino}";
                        break;
                }
            }

            return retorno;
        }
    }
}
