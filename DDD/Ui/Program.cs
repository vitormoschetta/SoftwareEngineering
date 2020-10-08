using System;
using Domain.Commands;
using Domain.Handlers;
using Tests.Mocks;

namespace Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new ProductCommand();
            product.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            product.Name = "Product E";
            product.Price = 99;

            var handler = new ProductHandler(new FakeProductRepository());
            var dataResult = handler.UpdatePromotionPrice(product);

            if (dataResult.Success)
            {
                Console.WriteLine(dataResult.Message);
                Console.WriteLine(dataResult.Data);
            }
            else
            {
                Console.WriteLine(dataResult.Message);
            }
        }
    }


}
