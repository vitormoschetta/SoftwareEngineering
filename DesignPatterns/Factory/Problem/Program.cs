using System;
using Problem.Models;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Problema: Dependendo da escolha do usuário devo instanciar 
            um objeto diferente, que executa porém um método. Ou seja, 
            as classes possuem um método em comum, fazem parte de um mesmo
            contexto. 

            Veja como ficaria sem o uso do padrão Factory:
            */
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("01 - Inglês \n");
            Console.WriteLine("02 - Espanhol \n");
            Console.WriteLine("03 - Alemão \n");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "01":
                    new EnglishAloMundo().FalaAlo();
                    break;
                case "02":
                    new SpanishAloMundo().FalaAlo();
                    break;
                case "03":
                    new GermanAloMundo().FalaAlo();
                    break;
                default:
                    new EnglishAloMundo().FalaAlo();
                    break;
            }
        }
    }
}
