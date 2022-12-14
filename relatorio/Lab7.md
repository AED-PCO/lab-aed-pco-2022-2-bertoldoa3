### Exercicio 1 - Modele, projete e calcule a complexidade de um programa que:

+ A) Leia as linhas de um arquivo chamado "arq1.txt". 
+ B) Peça para o usuario inserir um texto no terminal//console.
+ C) Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos IGUAIS e DIFERENTE.
+ D) Descreva as operacoes relevantes.
     
      1.1 Operações Relevantes: Comparação e Atribuição.

      1.2 Complexidade: O(n2)

      1.3 Modelagem: O programa iria iniciar abrindo o arquivo informando o lugar que está e seu respectivo nome, depois 
      utilizando um método to char transformaria a frase do arquivo em vetor e a frase digitada também em vetor depois que os 
      dois estivessem em vetor iria comparar as palavras que estivessem nas posições do vetor e mostraria na tela colocando as iguais e diferentes.

     1.4 Print da Resolucao: ![Print da Resolucao - Exercicio 1 - Lab 7 - Ana Clara Bertoldo A  Pereira](https://user-images.githubusercontent.com/101759772/197848326-936313b7-7527-46dc-8d7e-d41cebdeb325.jpg)
     - Arquivo analisado: [Arq1.txt](https://github.com/AED-PCO/lab-aed-pco-2022-2-bertoldoa3/files/9862779/Arq1.txt)
     - Gráfico: ![Grafico EXE1_Lab7 - Ana Clara Bertoldo Anastacio ](https://user-images.githubusercontent.com/101759772/198013245-c9e32a2a-0751-4ef4-b3ec-884bad1fca8f.jpg)

### Exercicio 2 - Dado o código a seguir, responda:

+ a) Quantos e quais sao os casos base//condicao de parada para a funcao funcRec1()?
+ b) Explique com suas palavras o que a funcao funcRec1 calcula.
+ c) Represente a pilha de execucao para a chamada funcRec1(6).

      2.1 O caso base é quando temos um número igual a 1 no qual o resultado é o 0 e a condicao de parada é quando A é igual ou menor a 1 e também quando estoura o array.

      2.2 A funcao calcula o ponto de partida 'A' acumulado ao número 3. 

2.3 ![Pilha de Execucao AEDs](https://user-images.githubusercontent.com/101759772/197531988-d92f7dc7-0869-4574-a199-42ad81fbd0a2.jpg)
  
### Exercicio 3 - Modele, projete e calcule a complexidade de um programa que:
+ a) Leia a primeira linha de um arquivo chamado "entrada.txt"
+ b) Escreva em um arquivo chamado "saida.txt"o conteudo lido no arquivo de entrada ao contrário.
+ c) Descreva quais as operacoes relevantes.

      3.1 Modelagem: Iriamos iniciar lendo o arquivo, armazenando as letras do arquivo em um vetor utilizando o método to.char e depois, fecharia o arquivo. Entao abriria um novo arquivo chamado "saida.txt" e colocaria no arquivo as posicoes do vetor iniciando da ultima para a primeira. Depois mostraria na tela.

      3.2 Complexidade: O(n2)

      3.3 Operacoes relevantes: Atribuicao.
    
  3.4 Print da Resolução: ![Print da Resolução - Exercicio 2 - AEDs](https://user-images.githubusercontent.com/101759772/198067626-c54d78ed-f815-486f-acb8-86261be7f95d.jpg)

  - Arquivos Analisados: [saida.txt](https://github.com/AED-PCO/lab-aed-pco-2022-2-bertoldoa3/files/9870921/saida.txt)
                         [entrada.txt](https://github.com/AED-PCO/lab-aed-pco-2022-2-bertoldoa3/files/9870922/entrada.txt)
  - Gráfico: ![Grafico EXE2_Lab7 - Ana Clara Bertoldo Anastacio ](https://user-images.githubusercontent.com/101759772/198068622-9fbd3953-7372-45fb-b9d2-a60612a1eef3.jpg)


### Exercicio 4 - Um banco enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerencia está a localizacao das contas dos seus titulares nas listagens e nos relatorios impressos em diferentes situacoes. Um especialista de TI sugeriu ordenar as contas por meio dos CPF dos seus n titulares antes das impressoes. Dentre alguns algoritmos pré seleconados para essa ordenacao o especialista escolheu o algoritmo de ordenacao por insercao. Se voce fosse o especialista, responda:

+ a) O especialista escolheu um bom algoritmo?
+ b) Qual algoritmo de ordenacao utilizaria?
+ c) Descreva quais operacoes relevantes.
+ d) Demonstre a viabilidade de sua solucao para 10 registros.

      4.1 Nao pois o algoritmo escolhido pelo analista compara todos os numeros ordenando de trás para a frente.

      4.2 MergeSort seria o algoritmo usado, uma vez que sua complexidade é Log(n). O problema é partidos em problemas pequenos facilitando a solucao deles. E, entao otimizando os processos do banco.

      4.3 Comparacao, atribuicao.

4.4 Print da Resolucao: ![PrintdaResolução_Laboratorio7_Exercicio4](https://user-images.githubusercontent.com/101759772/201218310-1ff72e58-025e-426e-8ca2-8b39dd85d066.PNG)

- Gráfico: ![Grafico_Exercicio4_Lab7](https://user-images.githubusercontent.com/101759772/201218714-994b8285-309e-41c5-a617-9f665e2de9c1.PNG)


### Exercicio 5 - O código a seguir implementa uma funcao recursiva. Analise-o indique o que será retornado pela funcao, caso os parametros possuam os seguintes dados: V={10,5,7,15,22,9,30} e A =6.

    5.1 30.



