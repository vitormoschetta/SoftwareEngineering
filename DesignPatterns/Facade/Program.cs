using System;

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
