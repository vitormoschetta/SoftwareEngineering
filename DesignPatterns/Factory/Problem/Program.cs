using System;
using Problem.Models;

namespace Problem
{
    class Program
    {
        /* 
            Problema: 
            Imagine que temos um grupo de classes semelhantes, em um mesmo contexto
            (as classes estão na pasta 'Models').
            
            Imagine também que de acordo com o parâmetro fornecido pelo usuário, 
            o nosso código deve identificar qual classe desse grupo deve ser 
            instanciada.           
            
            Vamos ver como ficaria SEM o uso do padrão Factory:
        */

        static void Main(string[] args)
        {            

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
