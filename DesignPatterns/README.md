![alt text](images/quadro.jpg?raw=true=250x250 "Title")
<br>

## Introdução
Em todos os patterns existem duas pastas basicas: 
1. **Problem**:
Onde implementamos o código naturalmente, sem usar o padrão referenciado. Identificaremos nele os pontos a serem melhorados.

2. **Pattern**:
Onde implementamos a mesma solução implementada em "Problem" porém utilizando o design pattern referenciado.

Obs: Os comentários que esclarecem o problema estão localizados no arquivo **Program.cs**.
<br>


## Factory 
O padrão de fábrica é usado para abstrair a construção/instância de classes diferentes que estão em um mesmo contexto, e que executam um método/ação em comum. 

Permite a criação de familias de objetos relacionados ou dependentes, atraves de uma única interface e sem que a classe concreta seja especificada.

A fábrica pode retornar uma instância de uma das várias classes possíveis (em um hierarquia de subclasse), dependendo dos dados fornecidos a ela.

#### Onde Usar?
- Quando uma classe não pode antecipar que tipo de classe de objeto deve criar.
- Quando você tem classes que são derivadas das mesmas subclasses, ou eles podem na verdade ser classes não relacionadas que apenas compartilham a mesma interface. 

#### Benefícios
- O cliente não precisa conhecer todas as subclasses de objetos que deve criar. Ele só precisa de uma referência à classe / interface abstrata e à fábrica de objetos.
- A fábrica encapsula a criação de objetos. Isso pode ser útil se o processo de criação é muito complexo.
<br>


