using System;
using Pattern.Models;
using Pattern.Repositories;

namespace Pattern.Handlers
{
    public class Facade
    {
        private Serasa _serasa;
        private SPC _spc;
        private Credito _credito;
        public Facade(Serasa serasa, SPC spc, Credito credito)
        {
            _serasa = serasa;
            _spc = spc;
            _credito = credito;
        }

        public void ConsultarCredito(Cliente cliente)
        {
            var restricao = false;

            restricao = _spc.Consulta(cliente.CPF);
            restricao = _serasa.Consulta(cliente.CPF);

            if (restricao)
            {
                Console.WriteLine("Cliente com restrição...");
                return;
            }

            var limiteCredito = _credito.LimiteCredito(cliente.CPF);
            Console.WriteLine("Cliente {0} possui limite de crédito no valor de: {1}", cliente.Nome, limiteCredito);
        }


    }
}