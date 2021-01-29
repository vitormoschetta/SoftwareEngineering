using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log01 = FileLogger.GetInstance();
            log01.Text = "Log01";
            Console.WriteLine(log01.Text);

            var log02 = FileLogger.GetInstance();            
            Console.WriteLine(log02.Text);


            /*
            Para garantir que haja apenas uma instancia da classe FileLogger tornamos privado o Construtor.
            Logo, não é possível executar o código abaixo:
                var log = new FileLogger();

            Definimos o método 'GetInstance' o meio pelo qual FileLogger será instanciado. 
            No corpo deste método verificamos se já existe uma instancia da classe. Em caso
            negativo, intanciamos. Em caso positivo, retornamos a instancia já existente.

            */
        }
    }
}
