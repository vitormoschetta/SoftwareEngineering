## Introdução
Em todos os patterns existem duas pastas basicas: 
1. Problem:
Onde implementamos o código naturalmente, sem usar o padrão referenciado. Identificaremos nele os pontos a serem melhorados.

2. "Pattern":
Onde implementamos a mesma solução implementada em "Problem" porém utilizando o design pattern referenciado.
<br>

## Factory 
O padrão de fábrica é usado para abstrair a construção/instância de classes diferentes que estão em um mesmo contexto, e que executam um método/ação em comum. 

Geralmente existe uma variável/parâmetro a ser avaliado para que se seja decidido qual classe instanciar.

A classe que servirá de Fábrica é responsável por construir e retornar objetos. Observe que para que esse objeto retornado possa ser "conhecido" mesmo podendo ser de diferentes tipos, se faz necessário ter uma abstração, que no nosso caso é uma _interface_ implementada por todas as classes.
É exatamente essa interface que os tornam comuns. Através dela todos implementam, obrigatoriamente, um determinado método, apesar de que cada um 
tem a sua própria implementação e portanto um retorno diferente. 
<br>


    