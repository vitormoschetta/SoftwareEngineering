using System;
using POO_Console.B_POO.C_Encapsulamento;
using POO_Console.A_ProgramacaoEstruturada;

namespace POO_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção para testar:");
            Console.WriteLine("01 - Programação Estruturada - usuário bem intencionado:");
            Console.WriteLine("02 - Programação Estruturada - usuário mal intencionado:");
            Console.WriteLine("03 - POO: Abstração - usuário bem intencionado:");
            Console.WriteLine("04 - POO: Abstração - usuário mal intencionado:");
            Console.WriteLine("05 - POO: Encapsulamento - não é possível agir de má fé.");
            var escolha = Console.ReadLine();

            switch (escolha)
            {
                case "01":
                    Estruturada_BemIntencionado();
                    break;
                case "02":
                    Estruturada_MalIntencionado();
                    break;
                case "03":
                    Abstracao_BemIntencionado();
                    break;
                case "04":
                    Abstracao_MalIntencionado();
                    break;
                case "05":
                    Encapsulamento();
                    break;

            }
        }


        static void Estruturada_BemIntencionado()
        {
            var pagamento = new POO_Console.A_ProgramacaoEstruturada.Pagamento();
            pagamento.PagamentoCartao("0000-0000-0000-0000", "000");
        }
        static void Estruturada_MalIntencionado()
        {
            // Na programação estruturada uma variável pode ser acessada de qualquer lugar, ninguém é de ninguém, e tudo fica 
            // difícil de gerenciar, tornando a segurança algo difícil de lidar...

            var pagamento = new POO_Console.A_ProgramacaoEstruturada.Pagamento();
            pagamento.ClienteCodigoCartao = "999";
            pagamento.ClienteNumeroCartao = "9999-9999-9999-9999";
            pagamento.Valor = 1000000000000000000000.00m;
            pagamento.PagamentoCartao("9999-9999-9999-9999", "999");
        }




        static void Abstracao_BemIntencionado()
        {
            // Utilizando a abstração da POO podemos organizar melhor o nosso código, mas ainda não é suficiente para resolver
            // a questão da segurança, pois ainda temos acesso externo às propriedades da classe PagamentoCartao, que podem ser
            // manipuladas...

            var pagamentoCartao = new POO_Console.B_POO.A_Abstracao.PagamentoCartao();
            var cliente = new POO_Console.B_POO.A_Abstracao.Cliente();

            pagamentoCartao.EfetuarPagamento(cliente, "0000-0000-0000-0000", "000");
        }
        static void Abstracao_MalIntencionado()
        {
            // Utilizando a abstração da POO podemos organizar melhor o nosso código, mas ainda não é suficiente para resolver
            // a questão da segurança, pois ainda temos acesso externo às propriedades da classe PagamentoCartao, que podem ser
            // manipuladas...

            var pagamentoCartao = new POO_Console.B_POO.A_Abstracao.PagamentoCartao();
            var cliente = new POO_Console.B_POO.A_Abstracao.Cliente();


            cliente.ClienteCodigoCartao = "999";                 //}   
            cliente.ClienteNumeroCartao = "9999-9999-9999-9999";  //}=>  Aqui está a má intenção: Manipular informações 
            pagamentoCartao.Valor = 1000000000000000000000.00m;  //}     

            pagamentoCartao.EfetuarPagamento(cliente, "9999-9999-9999-9999", "999");
        }




        static void Encapsulamento()
        {
            // O Encapsulamento do POO resolve muito da questão de organização e também de segurança.
            // Veja que não é possível alterar as propriedades da classe. Somente seus próprios métodos podem fazer isso, 
            // utilizando as suas próprias regras e validações contidas no método construtor (único ponto de entrada).             
            // Não iremos conseguir manipular, por exemplo, o valor, usando: 
            // pagamentoCartao.Valor = 1000000000000000000000.00m;       
            // As propriedades estão encapsuladas.  

            var pagamentoCartao = new POO_Console.B_POO.C_Encapsulamento.PagamentoCartao("000", "0000-0000-0000-0000");
            pagamentoCartao.EfetuarPagamento();

        }
    }
}
