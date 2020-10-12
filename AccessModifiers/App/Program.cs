using System;
using App.Heranca;
using App.Ineternal;
using App.Private;
using App.Public;

namespace App
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

            var privateUserB = new PrivateUserB();
            privateUserB.SetName("User B");
            Console.WriteLine($"Private User: {privateUserB.GetName()}");


            Console.WriteLine("\n***************** HERANÇA ************************** \n");

            var productHeranca = new ProductHeranca();
            productHeranca.SetName("Herança");
            Console.WriteLine($"Private User: {productHeranca.Name}");

            var productHerancaB = new ProductHerancaB();
            productHerancaB.SetName("Herança B");
            Console.WriteLine($"Private User: {productHerancaB.GetName()}");

            var productHerancaC = new ProductHerancaC();
            productHerancaC.SetNameDerivado("Herança C");
            Console.WriteLine($"Private User: {productHerancaC.GetNameDerivado()}");




        }
    }

}
