using System;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Entities
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Product_price_value_zero_exception()
        {
            string exception = null;

            try
            {
                var product = new Product("Produto A", 0);
            }
            catch (Exception ex)
            {
                exception = ex.Message.ToString();
            }

            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Product_name_empty_exception()
        {
            string exception = null;

            try
            {
                var product = new Product("", 5);
            }
            catch (Exception ex)
            {
                exception = ex.Message.ToString();
            }

            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Product_name_null_exception()
        {
            string exception = null;

            try
            {
                var product = new Product(null, 5);
            }
            catch (Exception ex)
            {
                exception = ex.Message.ToString();
            }

            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Product_name_less_than_5_characters_exception()
        {
            string exception = null;

            try
            {
                var product = new Product("prod", 5);
            }
            catch (Exception ex)
            {
                exception = ex.Message.ToString();
            }

            Assert.IsNotNull(exception);
        }
    }
}