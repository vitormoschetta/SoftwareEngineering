namespace POO_Console.B_POO.B_Heranca
{
    // Essa classe é abstrata, portanto não pode ser instanciada (new), apenas herdada
    public abstract class Pagamento
    {
        public decimal Valor { get; set; } = 180.00m;  
    }
}