using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var file01 = new FileLogger();
            var file02 = new FileLogger();
            var file03 = new FileLogger();
            
            Console.WriteLine(file01.GetInstance());

            /*
            Podemos instanciar qualquer classe quantas vezes quisermos.

            Pense porém que seja necessário limitar o nº de instancias de uma determinada clase. 

            Podemos imaginar que essa classe é um serviço, acessado por centenas de milhares de usuários.
            Se cada usuário que acessa esse serviço gerar uma instancia dessa classe na memória do servidor,
            certamente teremos uma sobrecarga de memória.

            Como podemos limitar o nº de instancias dessa classe?

            Dica: O "metodo" Construtor sempre é chamado ao se instanciar uma classe.
            */
            
        }
    }
}
