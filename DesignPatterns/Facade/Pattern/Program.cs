using System;
using Pattern.Handlers;
using Pattern.Models;
using Pattern.Repositories;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("12345678911", "Fulano");
            var facade = new Facade(
                new Serasa(), 
                new SPC(), 
                new Credito());

            facade.ConsultarCredito(cliente);

            // Veja como ficou lindo o método acima. Simples. Ficou como uma bela "Fachada".
            // É isso que o padrão Facade faz, deixa uma bela "Fachada para o usuário, enquanto
            // o processo mais complexo ocorre "por baixo dos panos".
        }
    }
}
