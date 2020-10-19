using System;

namespace POO_Console.B_POO.A_Abstracao
{
    public class PagamentoCartao
    {
        public decimal Valor { get; set;} = 180.00m;                          

        public bool CartaoValido(Cliente cliente, string numeroCartao, string codigoCartao) {
            if (numeroCartao == cliente.ClienteNumeroCartao && codigoCartao == cliente.ClienteCodigoCartao)
                return true;
            
            return false;
        }

        public void EfetuarPagamento(Cliente cliente, string numeroCartao, string codigoCartao) {
            if (CartaoValido(cliente, numeroCartao, codigoCartao)) 
                Console.WriteLine("Pagamento Efetuado. Nr Cartao: " + cliente.ClienteNumeroCartao + ". Valor: " + Valor);
            else   
                Console.WriteLine("Cartão Inválido");
        }
    }
}