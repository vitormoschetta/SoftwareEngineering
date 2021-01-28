using System;

namespace Pattern02
{
    class Program
    {
        /*            
            Neste segundo exemplo utilizamos herança ao invés de composição. 
            'ClientAdapter' herda de 'MySqlCommands' para poder acessar seus métodos.                        
        */
        static void Main(string[] args)
        {
            var client = new ClientAdapter();
            client.Insert();
        }
    }
}
