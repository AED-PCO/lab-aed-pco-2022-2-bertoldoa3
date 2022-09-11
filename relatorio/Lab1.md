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


