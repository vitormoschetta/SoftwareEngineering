using System;
using Problem.Models;

namespace Problem
{
    class Program
    {        
        static void Main(string[] args)
        {
            var client = new Commands();
            client.Insert();            

            /*
                Problema: Como fazer com que o 'client' acesse os Métodos 'InsertMySql', 'UpdateMySql'
                e 'DeleteMySql' da classe 'MySQLCommands' implementando os métodos da interface 'IDbAdapter'?

                Perceba que o nome dos métodos são diferentes.

                Obs: Não vale instanciar a classe 'MySQLCommands'.
            */

        }
    }
}
