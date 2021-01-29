using System;

namespace Pattern.Repositories
{
    public class Serasa
    {
        public bool Consulta(string cpf)
        {
            Console.WriteLine("SERASA - consultando CPF {0}...", cpf);  
            return false;                   
        }
    }
}