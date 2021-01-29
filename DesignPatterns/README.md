![alt text](images/quadro.jpg?raw=true=250x250 "Title")
<br>

## Introdução
Em todos os patterns existem duas pastas basicas: 

1. **Problem**:
Onde implementamos o código naturalmente, sem usar o padrão referenciado. Identificaremos nele os pontos a serem melhorados.

2. **Pattern**:
Onde implementamos a mesma solução implementada em "Problem" porém utilizando o design pattern referenciado.

Obs: Os comentários que esclarecem o problema estão localizados no arquivo **Program.cs**.

obs 2: Alguns padrões podem ter mais de uma pasa 'Pattern'. Isto significa que há mais de uma forma de aplicar o design patter.
<br>


## Adapter
O padrão Adapter tem o objetivo de converter a interface de uma classe em outra interface esperada pelos clientes. Ou seja, permite a comunicação entre classes que não poderiam trablhar juntas devido à incompatibilidade de suas interfaces.

Há duas formas de aplicar o padrão Adapter:

1. Um **adaptador de classe** usa herança múltipla (estendendo uma classe e / ou implementando uma ou mais classes) para adaptar uma interface a outra. 

2. Um **adaptador de objeto** depende agregação de objetos.

#### Onde usar?
- Quando você deseja usar uma classe existente, e sua interface não corresponde ao que você precisa.
<br>



## Facade
Este padrão de design fornece uma interface unificada para um conjunto de interfaces em um subsistema. Ele define uma interface de nível superior que torna o subsistema mais fácil de usar. Uma fachada é um objeto que fornece uma interface simplificada para um corpo maior de código, como uma biblioteca de classes. 

Um bom cenário para exemplo de uso seria envolver várias APIs mal projetadas com uma única API bem projetada, agrupando-as por contexto por exemplo.

namespace Facade
{
    // Facade é o mesmo conceito usado no Handler do DDD.
    // Uma classe gerencia todo o processo, servindo de 'Fachada', facilitando as coisas.
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância do Facade
            Facade concedeCredito = new Facade();

            // Cria uma instância de um  novo Cliente informando o nome
            Cliente cliente1 = new Cliente("Fulano");

            //Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeCredito.ConcederEmprestimo(cliente1, 199000.00);

            //exibe o resultado
            Console.WriteLine("O empréstimo pleiteado pelo cliente " + cliente1.Nome + " foi  " + (resultado ? "Aprovado" : "Negado"));

            //aguarda
            Console.ReadKey();
        }
    }
}

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

