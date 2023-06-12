# Projeto Integrador 3 - Cartagena

### Grupo: Bello
### Participantes: Erick Reimberg, Felipe Macena, Gustavo Pagnotta, Gustavo Silva e Murilo Oliveira

<h2> O que é o projeto? </h2>

<p> O projeto consiste no desenvolvimento de um sistema autônomo. Esse sistema teve como base, uma competição entre grupos dos alunos de Ciência da Computação do Centro Universitário Senac do terceiro semestre. O objetivo era criar um sistema autônomo baseado em um jogo de tabuleiro chamado Cartagena, ou seja, cada grupo deveria criar uma estratégia para jogar um contra o outro no final do semestre.</p>

<h3> O que seria esse jogo? </h3>

<p> O Cartagena é um jogo baseado na temática na fuga de piratas da fortaleza de Cartagena, localixado na Colômbia, em 1672. Cada jogador tem um grupo de seis piratas e o objetivo é fazer com que todos os seis piratas fujam através da passagem subterrânea que liga a fortaleza para o porto, onde uma pequena embarcação está esperando por eles. </p>

<h3> Regras do Jogo </h3>

<h4> Preparação </h4>

<p> O jogo é composto com 2 até 4 jogadores, cada um com sua respectiva cor (amarelo, azul, vermelho e verde). Existem duas versões, a Tortuga e a Jamaica. A versão Tortuga tem como base o raciocínio, pois os jogadores deixam suas cartas à mostra na mesa, sabendo quais são os próximos passos de seus adversários. Porém, a versão que estamos usando é a Jamaica, que tem como base a sorte. Cada jogador recebe 6 cartas aleatórias, sem que o adversário saiba, podendo ser elas um esqueleto, um tricórnio, uma faca, uma pistola, uma chave ou uma garrafa. O tabuleiro é gerado aleatoriamente, com um total de 38 casas (a primeira sem símbolo (prisão), pois é o ponto inicial e a última sendo o barco ou melhor dizendo, a linha de chegada) tendo em cada casa um desses 6 símbolos. A cada 6 casas obrigatoriamente todos os símbolos devem ter aparecido. </p>

<figure>
    <img src="https://tablegames.com.br/wp-content/uploads/2017/10/20171128_230947.jpg"
         alt="Tabuleiro Cartagena">
    <figcaption>An elephant at sunset</figcaption>
</figure>

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
<p> Para começar, durante todo o semestre tivemos aulas de POO (Programção Orientada a Objeto) e queríamos usar os conceitos de POO no nosso projeto. Portanto, para início criamos uma classe chamada Estratégia, onde ela seria a base para a nossa estratégia e além disso ela é abstract, ou seja, não pode ser estanciada. Fizemos isso com o objetivo de essa classe ser pai das nossas outras classes que teriam efetivamente a estratégia que queríamos que fosse executada. Essa classe contém o tabuleiro, o jogador e em qual jogada nós estamos, além de contar com métodos que iriam ser usados na implementação das nossas outras classe. </p>

<p> Tendo a classe Estratégia criada, pensamos em como poderíamos diversificar a nossa estratégia. Pensamos em seguir em duas linhas de raciocínio, tendo uma estratégia defensiva e um estratégia ofensiva, além de ter uma estratégia apenas para o início do jogo, criando uma classe para cada uma das estratégias, herdando sempre da classe Estratégia inicialmente criada.</p>

<h3> Estratégia Inicial </h3>

<p> Como estratégia inicial, primeiro verificamos se conseguimos comprar alguma carta, se conseguimos, voltamos para comprar a quantidade de cartas que nós podemos. Caso o tabuleiro esteja vazio (ou seja, nós fomos sorteados como o primeiro jogador a jogar) ou não conseguimos voltar para comprar cartas ultizamos a seguinte estratégia que visualizamos em diversas partidas no <a href="http://youplay.it/">You Play It</a>, lá contém diversos jogos de tabuleiro que podem ser jogados contra outras pessoas ao redor do mundo, incluindo o Cartagena.</p>
<p> Lá vimos que em diversas partidas a estratégia inicial era a mesma, verificar se temos duas cartas de algum símbolo. Caso tivéssemos, nós usamos as duas primeiras jodadas para mover os dois peões para os símbolos correspondentes. Na terceira jogada, verificamos se o peão que ficou mais para trás consegue ir para frente e ficar na posição ao lado do peão que jogamos, tanto em uma posição à frente ou uma posição atrás como no exemplo a seguir: Temos duas cartas com o símbolo de tricórnio. Eles estão distribuidos no tabuleiro respectivamente nas posições 5 e 10. Jogamos o primeiro peão para a posição 5 e usamos a segunda jogada para mover outro peão do início para a posição 10. Tendo isso, verificamos os símbolos que estão ao lado do peão que esta na casa de número 10. Se tivermos alguma das cartas e pudermos jogar (não tenha nenhum peão nas casas ao lado), jogamos o símbolo que temos, a prioridade sempre vai ser jogar o peão mais longe, portanto tentamos jogar ele a frente do peão na casa 10.</p>
<p> Caso não seja possível atingir nenhuma dessas possibilidades, jogamos o peão da casa 5 para a posição mais longe possível. Essa estratégia acaba quando todos os peões saiem da posição inicial, onde iniciamos a estratégia defensiva.</p>

<h3> Estratégia Defensiva </h3>

<p> A estratégia defensiva escolhida pelo nosso sistema autônomo é extremamente simples, focamos em aproveitar ao máximo as oportunidades de compra de cartas. </p>
<p> Para isso, nossos piratas executam a ação de voltar sempre que possível, preferencialmente para aquelas casas que dão oportunidade para comprarmos 2 cartas. Caso não seja possível voltarmos para comprar 2 cartas em apenas uma jogada, verificamos se podemos voltar 2 peões,  e se conseguimos colocar o máximo de peões na mesma casa, para comprar o máximo de cartas possíveis em apenas duas jogadas </p>
<p>Esta escolha mais defensiva nos permite manter uma postura conservadora e minimizar os riscos de escassez de cartas durante o jogo, permitindo que acumulemos a maior quantidade de cartas para vencermos o jogo</p>
<p>Em resumo, nossa estratégia defensiva se concentra exclusivamente em voltar para comprar cartas, sem visar outros objetivos além disso. Essa abordagem nos permite manter nossos piratas em posições mais seguras, acumular recursos e adaptar-nos às mudanças no jogo, para que no futuro, possamos avançar com uma postura ofensiva, visando o avanço dos piratas. 
É importante ressaltar que o nosso sistema troca de estratégia, quando validamos que todos os piratas conseguem chegar no barco e quando a compra de cartas não é mais possível</p>

<h3> Estratégia Ofensiva </h3>
<p> Enfim chegamos na estratégia ofensiva, que foi desenvolvida no seguinte pensamento: como poderíamos vencer o jogo da forma mais eficiente?  Pensamos em diversas maneiras, e a mais interessante delas foi a de acumular uma quantidade suficiente de cartas para que todos os nossos piratas cheguem ao barco. Ou seja, a medida que cada rodada avança, nós ordenamos os nossos peões de maneira crescente, o que quer dizer que o peão mais longe do barco fica na primeira posição do nosso vetor. Com esse primeiro peão em destaque, nós tentamos jogá-lo o mais longe possível, ficando o mais próximo do barco ou até mesmo dentro do barco. Caso nós não tenhamos mais cartas para serem jogadas e nem todos os peões chegado no barco, nós voltamos para a estratégia defensiva.</p>

<p> Essa foi a nossa estratégia. Focamos em deixá-la o mais coesa e objetiva possível, para que pudéssemos aumentar as nossas chances de vencer a competição ao final do semestre, tendo a melhor estratégia em prática. </p>

<h2> Considerações Finais </h2>

<p> Contudo, concluímos que é importante destacar o aprendizado de programação orientada a objetos e a utilização do Windows Forms ao longo do semestre para a implementação do projeto. As estratégias que adotamos praticam uma abordagem equilibrada, alternando entre a busca por recursos (cartas) e a movimentação eficiente dos piratas em direção ao objetivo final. Com isso finalizamos este artigo, foi uma experiência única e gratificante em poder desenvolver este projeto com todos do grupo, discutindo diversas estratégias de como vencer o jogo. Agradecimento especial ao orientador do projeto e coordenador do curso, Thiago Claro.
 </p>
