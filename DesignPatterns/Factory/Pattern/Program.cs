using System;

namespace Pattern
{
    class Program
    {
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


            /* 
            Perceba que o que fizemos foi criar uma abstração/interface 
            que possui o método em comum às três classes (English, German
            e SpanishAloMundo).

            Em seguida criamos uma classe (AloFactory) que fabrica objetos.
            Ou seja, ela é quem instancia uma das três classes, decidindo 
            qual instanciar pelo parâmetro recebido.             
            */
        }
    }
}
