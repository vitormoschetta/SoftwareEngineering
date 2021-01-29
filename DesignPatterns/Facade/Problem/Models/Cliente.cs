namespace Problem.Models
{
    public class Cliente
    {
        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; set; }   
        public string Nome { get; set; }        
           
    }
}