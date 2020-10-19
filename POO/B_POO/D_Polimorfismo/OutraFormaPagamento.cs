namespace POO_Console.B_POO.D_Polimorfismo
{
    public class OutraFormaPagamento: Pagamento
    {
        // Estamos sobre-escrevendo a variável Valor, graças a classe pai (Pagamento) nos permitir isso,
        // através da palavra chave 'virtual' em sua propriedade 'Valor' 
        // Sobre-escrevemos usando a palavra chave 'override'
        public override decimal Valor { get; set; } = 200.00m; 
    }
}