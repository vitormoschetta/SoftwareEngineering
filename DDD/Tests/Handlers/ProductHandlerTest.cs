using System;
using Domain.Commands;
using Domain.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Mocks;

namespace Tests.Handlers
{
    [TestClass]
    public class ProductHandlerTest
    {
        [TestMethod]
        public void ProductHandler_create_sucess()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Name = "Product D";
            command.Price = 5;
            var dataResult = handler.Create(command);
            Assert.IsTrue(dataResult.Success);
        }

        [TestMethod]
        public void ProductHandler_create_productName_empty_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Name = "";
            command.Price = 5;
            var dataResult = handler.Create(command);
            Assert.IsFalse(dataResult.Success);
        }

        [TestMethod]
        public void ProductHandler_create_productName_null_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Name = null;
            command.Price = 5;
            var dataResult = handler.Create(command);
            Assert.IsFalse(dataResult.Success);
        }

        [TestMethod]
        public void ProductHandler_create_productName_less_than_5_characters_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Name = "Prod";
            command.Price = 5;
            var dataResult = handler.Create(command);
            Assert.IsFalse(dataResult.Success);
        }


        [TestMethod]
        public void ProductHandler_updatePrice_sucess()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            command.Name = "Product A";
            command.Price = 99;
            var dataResult = handler.UpdatePrice(command);
            Assert.IsTrue(dataResult.Success);
        }

        [TestMethod]
        public void ProductHandler_updatePrice_zero_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            command.Name = "Product A";
            command.Price = 0;
            var dataResult = handler.UpdatePrice(command);
            Assert.IsFalse(dataResult.Success);
        }

        [TestMethod]
        public void ProductHandler_updatePrice_null_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            command.Name = "Product A";
            command.Price = null;
            var dataResult = handler.UpdatePrice(command);
            Assert.IsFalse(dataResult.Success);
        }


        [TestMethod]
        public void ProductHandler_updatePromotionPrice_higherPrice_invalid()
        {
            var handler = new ProductHandler(new FakeProductRepository());
            var command = new ProductCommand();
            command.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            command.Name = "Product A";
            command.Price = 99;
            var dataResult = handler.UpdatePromotionPrice(command);
            Assert.IsFalse(dataResult.Success);
        }
    }
}