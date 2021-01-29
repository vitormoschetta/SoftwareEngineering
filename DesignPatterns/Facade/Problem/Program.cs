using System;
using Problem.Models;
using Problem.Repositories;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {            
            var spc = new SPC();
            var serasa = new Serasa();
            var credito = new Credito();

            var cliente = new Cliente("12345678911", "Fulano");

            var restricao = false;

            restricao = spc.Consulta(cliente.CPF);
            restricao = serasa.Consulta(cliente.CPF);

            if (restricao) {
                Console.WriteLine("Cliente com restrição...");  
                return;
            }

            var limiteCredito = credito.LimiteCredito(cliente.CPF);
            Console.WriteLine("Cliente {0} possui limite de crédito no valor de: {1}", cliente.Nome, limiteCredito);


            /*
            veja a complexisdade que ficou o método acima. O objetivo do Facade/Fachada é limpar isso, abstraindo 
            as operações em um nível mais alto para o usuário.

            Implementar esse padrão será como implementar um Handler/Manipulador, como fazemos ao aplicar o Domain
            Driven Design (DDD).
            */
        }
    }
}
