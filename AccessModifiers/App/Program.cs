using System;
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


            var privateProduct = new PrivateProduct();

        }
    }
}
