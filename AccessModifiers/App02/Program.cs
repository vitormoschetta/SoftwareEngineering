using System;
using App.Private;
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

            Console.WriteLine("*********************************************\n");

            var privateProduct = new PrivateProduct();

        }
    }
}
