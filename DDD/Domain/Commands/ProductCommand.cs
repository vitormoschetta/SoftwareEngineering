using System;

namespace Domain.Commands
{
    public class ProductCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}