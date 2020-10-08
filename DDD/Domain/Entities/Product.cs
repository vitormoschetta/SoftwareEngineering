using System;

namespace Domain.Entities
{
    public class Product
    {
        public Product(Guid id, string name, decimal? price) // <- Create
        {
            Id = id;
            Name = name;
            Price = price;

            Validate();
        }
        public Product(string name, decimal? price) // <- Create
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;

            Validate();
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal? Price { get; private set; }

        public void Update(string name, decimal? price)
        {
            Name = name;
            Price = price;

            Validate();
        }
        public void UpdatePrice(decimal? price)
        {
            Price = price;

            Validate();
        }

        public void UpdatePromotionPrice(decimal? price)
        {
            if (price > Price)
                throw new Exception("Promotional price higher than current price. ");

            Validate();
        }

        public void Validate()
        {
            if (Name.Length < 5)
                throw new Exception("Name must be 5 (five) characters. ");

            if (Price == null || Price <= 0)
                throw new Exception("Invalid price. ");

        }

    }
}