Exercicio 1 - Modele, projete e calcule a complexidade de um programa que:

a) Leia as linhas de um arquivo chamado "arq1.txt".

b) Peca para o usuario inserir um texto no terminal//console.

c) Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos IGUAIS e DIFERENTE.

d) Descreva as operacoes relevantes.

1.1 Operações Relevantes: Comparação e Atribuição.

1.2 Complexidade: O(n2)

1.3 Modelagem: O programa iria iniciar abrindo o arquivo informando o lugar que está e seu respectivo nome, depois 
utilizando um método to char transformaria a frase do arquivo em vetor e a frase digitada também em vetor depois que os 
dois estivessem em vetor iria comparar as palavras que estivessem nas posições do vetor e mostraria na tela colocando as iguais e diferentes.

1.4 Print da Resolucao:

Exercicio 2 - Dado o código a seguir, responda:

a) Quantos e quais sao os casos base//condicao de parada para a funcao funcRec1()?

b) Explique com suas palavras o que a funcao funcRec1 calcula.

c) Represente a pilha de execucao para a chamada funcRec1(6).

2.1 O caso base é quando temos um número igual a 1 no qual o resultado é o 0 e a condicao de parada é quando A é igual ou menor a 1 e também quando estoura o array.

2.2 A funcao calcula o ponto de partida 'A' acumulado ao número 3. 

2.3 Pilha de execucao: 9\12\15\18\21\24\27\30\33\36\to be continue...
  
Exercicio 3 - Modele, projete e calcule a complexidade de um programa que:

a) Leia a primeira linha de um arquivo chamado "entrada.txt"

b) Escreva em um arquivo chamado "saida.txt"o conteudo lido no arquivo de entrada ao contrário.

c) Descreva quais as operacoes relevantes.

3.1 Modelagem: Iriamos iniciar lendo o arquivo, armazenando as letras do arquivo em um vetor utilizando o método to.char e depois, fecharia o arquivo. Entao abriria um novo arquivo chamado "saida.txt" e colocaria no arquivo as posicoes do vetor iniciando da ultima para a primeira. Depois mostraria na tela.

3.2 Complexidade: O(n2)

3.3 Operacoes relevantes: Atribuicao.

  








