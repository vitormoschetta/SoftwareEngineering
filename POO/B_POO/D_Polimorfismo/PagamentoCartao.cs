using System;

namespace POO_Console.B_POO.D_Polimorfismo
{
    public class PagamentoCartao: Pagamento
    {
        public string CodigoCartao { get; set; }
        public string NumeroCartao { get; set; }

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