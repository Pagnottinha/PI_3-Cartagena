# Projeto Integrador 3 - Cartagena

<h2> O que é o projeto? </h2>

<p> O projeto consiste no desenvolvimento de um sistema autônomo. Esse sistema teve como base, uma competição entre grupos dos alunos de Ciência da Computação do Centro Universitário Senac do terceiro semestre. O objetivo era criar um sistema autônomo baseado em um jogo de tabuleiro chamado Cartagena, ou seja, cada grupo deveria criar uma estratégia para jogar um contra o outro no final do semestre.</p>

<h3> O que seria esse jogo? </h3>

<p> O Cartagena é um jogo baseado na temática na fuga de piratas da fortaleza de Cartagena, localixado na Colômbia, em 1672. Cada jogador tem um grupo de seis piratas e o objetivo é fazer com que todos os seis piratas fujam através da passagem subterrânea que liga a fortaleza para o porto, onde uma pequena embarcação está esperando por eles. </p>

<h3> Regras do Jogo </h3>

<h4> Preparação </h4>

<p> O jogo é composto com 2 até 4 jogadores, cada um com sua respectiva cor (amarelo, azul, vermelho e verde). Existem duas versões, a Tortuga e a Jamaica. A versão Tortuga tem como base o raciocínio, pois os jogadores deixam suas cartas à mostra na mesa, sabendo quais são os próximos passos de seus adversários. Porém, a versão que estamos usando é a Jamaica, que tem como base a sorte. Cada jogador recebe 6 cartas aleatórias, sem que o adversário saiba, podendo ser elas um esqueleto, um tricórnio, uma faca, uma pistola, uma chave ou uma garrafa. O tabuleiro é gerado aleatoriamente, com um total de 38 casas (a primeira sem símbolo (prisão), pois é o ponto inicial e a última sendo o barco ou melhor dizendo, a linha de chegada) tendo em cada casa um desses 6 símbolos. A cada 6 casas obrigatoriamente todos os símbolos devem ter aparecido. </p>

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
<p> Quando um movimento de voltar um pirata for selecionado, ele irá parar na primeira casa que contenha um peão (pirata). Caso a casa que o peão for voltar tenha mais de 2 peões, ele irá voltar para a próxima casa que contenha um peão. Se todas as possibilidades do peão voltar estiverem comprometidas e ele tentar voltar para antes do início do jogo (para a prisão), essa jogada não poderá ser efetuada. Caso o peão ja esteja no barco, o pirata poderá voltar para comprar cartas para que seus outros piratas cheguem ao barco. Cada peão pode comprar até duas cartas por rodada. Se a casa que o pirata voltar tiver apenas um peão, ele receberá uma carta. Caso contenha dois peões, o pirata receberá 2 cartas. </p> 

<h4> Fim do Jogo </h4>
<p> O jogo é finalizado quando o primeiro jogador colocar todos seus piratas no barco, fugindo assim da prisão de Cartagena.</p>

<h2> Como foi desenvolvido o nosso sistema autônomo? </h2>
<p> O nosso projeto do terceiro semestre foi desenvolvido no Windows Forms, ou seja, usamos a linguagem C# com .NET framework para a construção e desenvolvimento do nosso programa. A plataforma que usamos para fazer o desenvolvimento foi o VisualStudio (não é o VisualStudioCode, hein), onde ela é uma IDE (Ambiente de Desenvolvimento Integrado) que facilita e ajuda muito no desenvolvimento de seus códigos, além de ser bem amigável ao programador. O Forms auxilia a programação em C#, pois ele é event-driven (parecido com o JavaScript, caso você seja do primeiro semestre :D), onde você pode navegar entre formulários e definir o que cada ação do usuário interfere em seu sistema. Você pode adicionar campos de texto, botões, listas e etc. apenas com o arraste do conteúdo que você deseja. O Forms cria este objeto definindo suas propriedades e métodos. </p>

<h2> Mas como foi feita a nossa estratégia? </h2>
<p> Para começar, durante todo o semestre tivemos aulas de POO (Programção Orientada a Objeto) e queríamos usar os conceitos de POO no nosso projeto. Portanto, para início criamos uma classe chamada Estratégia, onde ela é abstract, ou seja, não pode ser estanciada. Fizemos isso com o objetivo de essa classe ser pai das nossas outras classes que teriam efetivamente a estratégia que queríamos que fosse executada. Essa classe contém o tabuleiro, o jogador e em qual jogada nós estamos, além de contar com métodos que iriam ser usados na implementação das nossas outras classe. </p>

<p> Tendo a classe Estratégia criada, pensamos em como poderíamos diversificar a nossa estratégia. Pensamos em seguir em duas linhas de raciocínio, tendo uma estratégia defensiva e um estratégia ofensiva, além de ter uma estratégia apenas para o início do jogo.</p>
