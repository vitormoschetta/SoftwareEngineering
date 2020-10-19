using System;

namespace POO_Console.B_POO.C_Encapsulamento
{
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(string codigoCartao, string numeroCartao) // Unico ponto de entrada (Metodo Construtor)
    {                                                                    // Garante que minhas validações sejam aplicadas.
            if (string.IsNullOrEmpty(codigoCartao)) {
                Console.WriteLine("Informe o código do cartão");                
            } 
            if (string.IsNullOrEmpty(numeroCartao)) {
                Console.WriteLine("Informe o número do cartão");                
            }

            CodigoCartao = codigoCartao;
            NumeroCartao = numeroCartao;
        }
        
        public string CodigoCartao { get; private set; }   
        public string NumeroCartao { get; private set; }  // => priva set impede que minhas propriedades sejam modificadas fora da classe


        public bool CartaoValido()
        {
            if (NumeroCartao == "0000-0000-0000-0000" && CodigoCartao == "000")
                return true;

            return false;
        }

        public void EfetuarPagamento()
        {
            if (CartaoValido())
                Console.WriteLine("Pagamento Efetuado. Nr Cartao: " + NumeroCartao +
                    ". Valor: " + Valor);
            else
                Console.WriteLine("Cartão Inválido");
        }
    }
}