using System;
using System.Collections.Generic;
using Domain.Contracts;
using Domain.Entities;
using Shared;

namespace Tests.Mocks
{
    public class FakeProductRepository : IRepository<Product>
    {
        private readonly List<Product> Products;
        public FakeProductRepository()
        {
            Products = new List<Product>() {
                new Product(new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537"), "Product A", 5),
                new Product(new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0538"), "Product B", 8),
                new Product(new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0539"), "Product C", 25),
            };
        }

        public DataResult Create(Product entity)
        {
            Products.Add(entity);
            return new DataResult(true, "Register Success. ", entity);
        }

        public DataResult Delete(Guid id)
        {
            foreach (var item in Products)
            {
                if (id == item.Id)
                {
                    Products.Remove(item);
                    return new DataResult(true, "Delete Success. ", item);
                }
            }
            return new DataResult(false, "Product not found . ", null);
        }

        public IList<Product> GetAll()
        {
            return Products;
        }

        public Product GetById(Guid id)
        {
            foreach (var item in Products)
            {
                if (id == item.Id)
                    return item;
            }
            return null;
        }

        public DataResult Update(Product entity)
        {
            foreach (var item in Products)
            {
                if (entity.Id == item.Id)
                {
                    Products.Remove(item);
                    Products.Add(entity);
                    return new DataResult(true, "Update Success. ", entity);
                }
            }
            return new DataResult(false, "Product not found. ", null);
        }

        public DataResult Exists(Guid id)
        {
            foreach (var item in Products)
            {
                if (id == item.Id)
                    return new DataResult(true, "Product exists. ", item);
            }
            return new DataResult(false, "Product not found. ", null);
        }

    }
}