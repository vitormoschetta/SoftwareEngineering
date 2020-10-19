using System;

namespace POO_Console.B_POO.D_Polimorfismo
{
    public class Pagamento
    {
        // quando usamos a palavra-chave 'virtual', permitimos que a classe filha possa sobre-escrever a propriedade 
        // ou método, isto é, declará-la novamente, usando seus próprios procedimentos e valores.
        public virtual decimal Valor { get; set; } = 180.00m;            
        
    }
}