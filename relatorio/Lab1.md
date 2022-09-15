- Exercicio 1 - Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

Resolução: Em uma estrutura de repetição onde, depois descobri o resto da divisão dele por 100 e também a divisão dele por 100
então, ao descobrir as duas informações, desmembrei o número e fiz a soma dos dois resultados encontrados. Então, peguei a soma dos dois
resultados e, fiz o quadrado dela. Depois, validei se o quadrado era igual ao número e se fosse, eu mostraria na tela.

 Imagem da Resolução: ![Resultado - Lab 1 - Exe1](https://user-images.githubusercontent.com/101759772/189239888-a4b242f2-d3a6-4de5-b562-3629bfc50a3f.jpg)

- Exercicio 2 - Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.

Resolução: O exericio de números perfeitos, criei duas estruturas de repetição, onde uma controla até quantos números desejo saber quais são perfeitos e outra que controla quais números vou dividir por ele, essa segunda o número que será dividido está sempre a frente do outro e se o resto dessa divisão for igual a zero, armazeno o divisor dentro da variavel acumuladora, quando minha segunda estrutura de repetição estiver com o número igual ao da primeira, ele não faz mais o processo (se eu colocasse para fazer daria errado, nunca teria nenhum número perfeito) e então valida se o acumulador é igual ao número que estou verificando ou não; O exercicio de números primos foi resolvido da seguinte maneira: Criei uma função que recebia um número digitado 
pelo usuário na main. Depois de digitar esse número, validei 4 coisas antes de mostrar se era primo ou não primeiro validei se o resto da divisão
dele por 2 ou 3 era igual a 1 e se o número era 2 ou 3. Se caisse em uma dessas 4 comparações, esse número seria primo.

Imagem da Resolução: ![Exercicio_Lista1_Exe2_AnaClaraBertoldo](https://user-images.githubusercontent.com/101759772/189510825-151fb8f9-86bd-4657-a4dd-ba12d4aea899.PNG)

- Exercicio 3: Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Resolução: Criei 5 vetores inteiros com quantidade de casas 5, li primeiro todos os espaços do vetor A e logo após li todos os espaços do vetos B, criando um for.
Depois, dentro de outro for, comparei o vetor A na posição informada com o vetor B na posição informada. Se o valor informado em A na posição informada fosse o mesmo que B na posição informada, armazenava no Vetor C, que também foi criado com o tipo inteiro. Senão, armazenava o valor no outro vetor, da mesma caracteristica do vetor C porém, de nomeclatura D;

Imagem da Resolução: ![Print resolução = Exercicio 3 - Ana Clara Bertoldo](https://user-images.githubusercontent.com/101759772/189797287-34cf68b6-feec-4282-99bc-aea12378b218.jpg)

- Exercicio 4: Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Resolução: Criei duas funções onde uma calculava a soma das linhas e a outra a soma das colunas. Na soma das linhas o for percorre toda a linha da matriz, e soma as mesmas, passa para a proxima linha e repete o processo. Na soma das colunas o for passa por todas as colunas e soma as mesmas. Na main criei um random para preencher a matriz com números aleatórios e depois, mostro as somas.

Imagem da Resolução: ![Resolucao](https://user-images.githubusercontent.com/101759772/190521921-0574a145-7488-4746-b9ce-9bf0fab800df.JPG)

- Exercicio 5: Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Resolução: Criei uma função que recebesse o número digitado pelo usuário na Main para calcular o fatorial do número, depois, na função criei um for onde a variavel Fatorial, que é um acumulador e uma variavel I que é um contador, esse contador é inicializado com o valor digitado na Main menos um, onde começa o calculo do Fatorial. A variavel Fatorial acumula a multiplicação do Numero digitado menos um e vai decrementando até que o contador chegue no valor 2. Declarei 2 pois, um numero vezes 1 é igual a ele mesmo. Dessa forma poupei memória na execução do código.

Imagem da Resolução: ![image](https://user-images.githubusercontent.com/101759772/189798003-6c3b723f-703c-4db3-ad06-3e42a2896e33.png)


- Exercicio 6: Faça um programa que chame uma função capaz de calcular  , sendo  e  inteiros. Utilize passagem de parâmetros por referência. 

Resolução: Criei uma função que recebia os dois valores recebidos na main pelo usuário, depois usando o recurso Math.Pow realizei a operação da potência que é o mesmo que um número elevado ao outro e então retornei o valor calculado. Depois, na main criei uma variavel Resultado que recebia o valor retornado pela função e mostrei ele na tela, juntamente com os números informados pelo usuário.

Imagem da Resolução: ![Print resolução - - Ana Clara Bertoldo](https://user-images.githubusercontent.com/101759772/189798224-49f475dd-662d-4dea-9241-4fa1ff734549.jpg)


