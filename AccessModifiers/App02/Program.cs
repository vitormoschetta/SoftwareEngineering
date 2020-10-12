using System;
using App.InternalProtected;
using App.Private;
using App.Protected;
using App.Public;

namespace App02
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicProduct = new PublicProduct();
            publicProduct.Name = "Product A";
            Console.WriteLine($"Public Product: {publicProduct.Name}");

            var publicProductB = new PublicProductB();
            Console.WriteLine($"Public Product: {publicProductB.Name}");

            var publicProductC = new PublicProductC();
            publicProductC.SetName("Product C");
            Console.WriteLine($"Public Product: {publicProductC.Name}");

            var publicProductD = new PublicProductD("Product D");
            Console.WriteLine($"Public Product: {publicProductD.Name}");


            Console.WriteLine("\n******************************************** \n");


            var privateProduct = new PrivateProduct();

            var privateProductB = new PrivateProductB();
            privateProductB.SetName("Product B");
            Console.WriteLine($"Private Product: {privateProductB.GetName()}");

            var privateProductC = new PrivateProductC("Product C");
            Console.WriteLine($"Private Product: {privateProductC.GetName()}");

            Console.WriteLine("\n******************************************** \n");

            var protectedProductB = new ProtectedProductB();

            var internalProtectedProduct = new InternalProtectedProductDerived();
            internalProtectedProduct.SetName("Teste");
            Console.WriteLine($"Private Product: {internalProtectedProduct.GetName()}");

        }
    }

    public class InternalProtectedProductDerived : InternalProtectedProduct
    {
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }

}
