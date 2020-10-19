using System;

namespace POO_Console.B_POO.B_Heranca
{
    // Esta classe herda da classe pai (Pagamento), logo pode fazer uso da propriedade 'Valor', mesmo sem a ter declarado.
    public class PagamentoCartao: Pagamento 
    {           
        public string ClienteCodigoCartao { get; set; } = "000";
        public string ClienteNumeroCartao { get; set; }  = "0000-0000-0000-0000";    
                                  
        public bool CartaoValido(string numeroCartao, string codigoCartao) {
            if (numeroCartao == ClienteNumeroCartao && codigoCartao == ClienteCodigoCartao)
                return true;
            
            return false;
        }

        public void EfetuarPagamento(string numeroCartao, string codigoCartao) {
            if (CartaoValido(numeroCartao, codigoCartao)) 
                Console.WriteLine("Pagamento Efetuado. Nr Cartao: " + ClienteNumeroCartao + 
                        ". Valor: " + Valor); // => A propriedade Valor foi herdada da classe pai (Pagamento)
            else   
                Console.WriteLine("Cartão Inválido");
        }
    }
}