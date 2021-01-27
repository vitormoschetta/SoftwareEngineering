using System;

namespace Pattern
{
    class Program
    {
        /*
            Usando o padrão Factory:

            Perceba que passamos à classe 'AloFactory' a tarefa de instanciar a classe correta.
            Passamos a ela o parâmetro fornecido pelo usuário, para que em tempo de execução ela
            decida a classe a ser instanciada.

            Perceba também que, como uma fábrica, ela fornece/retorna um objeto. Esse objeto pode
            ser a instancia de qualquer uma das classes do contexto (classes na pasta models).            
            Todas essas classes possuem um método em comum (FalaAlo). 

            O que fizemos foi criar uma abastração para esse método, ou seja, uma Interface na qual
            todas as classes do contexto devem implementar. Logo, temos a certeza de que, independente
            da classe instanciada e fornecida pela Fabrica (AloFactory), teremos a disposição o método 
            'FalaAlo'.            
        */
        static void Main(string[] args)
        {            
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("01 - Inglês \n");
            Console.WriteLine("02 - Espanhol \n");
            Console.WriteLine("03 - Alemão \n");
            var opcao = Console.ReadLine();
            var fabrica = new AloFactory();
            var item = fabrica.CriaAloMundo(opcao);
            item.FalaAlo();

        }
    }
}
