using System;

namespace Adapter
{

    class Adaptee
    {
        public void MetodoA()
        {
            Console.WriteLine("Imprimir");
        }
    }

    class Adaptor
    {
        private Adaptee _adaptee;
        public Adaptor(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void MetodoB()
        {
            _adaptee.MetodoA();
        }
    }

    class Client
    {
        private Adaptor _adaptor;
        public Client(Adaptor adaptor)
        {
            _adaptor = adaptor;
        }

        public void MetodoC()
        {
            _adaptor.MetodoB();
        }
    }

    
}