using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Adaptor adaptor = new Adaptor(adaptee);
            Client client = new Client(adaptor);

            client.MetodoC();
        }
    }    

    

   
}
