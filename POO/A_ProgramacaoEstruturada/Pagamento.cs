using System;

namespace POO_Console.A_ProgramacaoEstruturada
{
    public class Pagamento
    {
        public decimal Valor = 180.00m;            


        /////////////////// Boleto
        public DateTime Vencimento = Convert.ToDateTime("2020-08-13");
        public string CodigoBarras = "00000AAAAA0000000000BBBBBBB000000";

        public bool PodePagar() {
            if (Vencimento >= DateTime.Now)
                return true;
            
            return false;
        }

        public void PagamentoBoleto() {
            if (PodePagar())
                Console.WriteLine("Pagamento Efetuado.  Codigo Barras: " + CodigoBarras + 
                    ". Valor: " + Valor);
            else
                Console.WriteLine("Boleto Vencido");

        }       
        
        
    
        /////////////////// Cartao    
        
        public bool CartaoValido(string numeroCartao, string codigoCartao) {
            if (numeroCartao == ClienteNumeroCartao && codigoCartao == ClienteCodigoCartao)
                return true;
            
            return false;
        }

        public void PagamentoCartao(string numeroCartao, string codigoCartao) {
            if (CartaoValido(numeroCartao, codigoCartao))
                Console.WriteLine("Pagamento Efetuado. Nr Cartao: " + ClienteNumeroCartao + ". Valor: " + Valor);
            else   
                Console.WriteLine("Cartão Inválido");
        }



        /////////////////// Cliente        
        public string ClienteCodigoCartao = "000";
        public string ClienteNumeroCartao = "0000-0000-0000-0000";
        
        
    }
}