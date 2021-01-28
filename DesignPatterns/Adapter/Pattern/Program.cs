using System;
using Pattern.Models;

namespace Pattern
{
    class Program
    {
        /*
            Criamos uma classe (MySqlAdapter) para adaptar o acesso aos métodos da classe 
            'MySqlCommands' através da interface 'IDbAdapter'.
        */

        static void Main(string[] args)
        {
            var client = new MySqlAdapter(new MySqlCommands());
            client.Insert();
        }
    }
}
