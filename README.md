# Projeto Integrador 3 - Cartagena

<h2> O que é o projeto? </h2>

<p> O projeto consiste no desenvolvimento de um sistema autônomo. Esse sistema teve como base, uma competição entre grupos dos alunos de Ciência da Computação do Centro Universitário Senac do terceiro semestre. O objetivo era criar um sistema autônomo que era baseado em um jogo de tabuleiro chamado Cartagena.</p>

<h3> O que seria esse jogo? </h3>

<p> O Cartagena é um jogo baseado na temática na fuga de piratas da fortaleza de Cartagena, localixado na Colômbia, em 1672. Cada jogador tem um grupo de seis piratas e o objetivo é fazer com que todos os seis piratas fujam através da passagem subterrânea que liga a fortaleza para o porto, onde uma pequena embarcação está esperando por eles. </p>

<h3> Regras do Jogo </h3>

<h4> Preparação </h4>

<p> O jogo é composto com 2 até 4 jogadores, cada um com sua respectiva cor (amarelo, azul, vermelho e verde). Existem duas versões, a Tortuga e a Jamaica. A versão Tortuga tem como base o raciocínio, pois os jogadores deixam suas cartas à mostra na mesa, sabendo quais são os próximos passos de seus adversários. Porém, a versão que estamos usando é a Jamaica, que tem como base a sorte. Cada jogador recebe 6 cartas aleatórias, sem que o adversário saiba, podendo ser elas um esqueleto, um tricórnio, uma faca, uma pistola, uma chave ou uma garrafa. O tabuleiro é gerado aleatoriamente, com um total de 38 casas (a primeira sem símbolo, pois é o ponto inicial e a última sendo o barco ou melhor dizendo, a linha de chegada) tendo em cada casa um desses 6 símbolos. A cada 6 casas obrigatoriamente todos os símbolos devem ter aparecido. </p>

<h4> Como jogar </h4>

<p> O jogo é dividido em rodadas. Em cada rodada o jogador tem direito a 3 jogadas, podendo escolher em qualquer jogada o movimento que ele deseja fazer.</p>
<p> Existem 3 tipos de movimentos possíveis dentro do jogo:</p>
<ul>
  <li> Jogar uma carta e avançar um pirata; </li>
  <li> Voltar um pirata e comprar até duas cartas; </li>
  <li> Pular a vez. </li>
</ul>

<h4> 1. Jogar uma carta e avançar um pirata </h4>
<p> Para avançar um pirata, é necessário selecionar um dos seus piratas e escolher uma das cartas que você tiver na mão naquele momento. Tendo isso escolhido, o pirata vai avançar para a primeira casa vazia em que aquele símbolo se encontra. </p>

<h4> 2. Voltar um pirata e comprar até duas cartas </h4>
<p> Voltando um pirata ele vai parar na primeira casa que contenha um peão (pirata). Caso a casa que o peão for voltar tenha mais de 2 peões, ele irá voltar para a próxima casa que contenha um peão. Se todas as possibilidades do peão voltar estiverem comprometidas e ele tentar voltar para antes do início do jogo (para a prisão), essa jogada não poderá ser efetuada. Cada peão pode comprar até duas cartas por rodada. Se a casa que o pirata voltar tiver apenas um peão, ele receberá uma carta. Caso contenha dois peões, o pirata receberá 2 cartas. </p> 

<h4> Fim do Jogo </h4>
<p> O jogo é finalizado quando o primeiro jogador colocar todos seus piratas no barco, fugindo assim da prisão de Cartagena.</p>
