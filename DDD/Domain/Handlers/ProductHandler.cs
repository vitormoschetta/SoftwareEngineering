using System;
using Domain.Commands;
using Domain.Contracts;
using Domain.Entities;
using Shared;

namespace Domain.Handlers
{
    public class ProductHandler
    {
        private readonly IRepository<Product> _repository;
        public ProductHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public DataResult Create(ProductCommand command)
        {
            try
            {
                var entity = new Product(command.Name, command.Price);

                var dataResult = _repository.Create(entity);

                if (dataResult.Success)
                    return new DataResult(true, dataResult.Message, dataResult.Data);
                else
                    return new DataResult(false, dataResult.Message, null);
            }
            catch (Exception ex)
            {
                return new DataResult(false, ex.Message.ToString(), null);
            }
        }

        public DataResult UpdatePrice(ProductCommand command)
        {
            try
            {
                var entity = _repository.GetById(command.Id);

                entity.UpdatePrice(command.Price);

                var dataResult = _repository.Update(entity);

                if (dataResult.Success)
                    return new DataResult(true, dataResult.Message, dataResult.Data);
                else
                    return new DataResult(false, dataResult.Message, null);
            }
            catch (Exception ex)
            {
                return new DataResult(false, ex.Message.ToString(), null);
            }
        }

        public DataResult UpdatePromotionPrice(ProductCommand command)
        {
            try
            {
                var entity = _repository.GetById(command.Id);

                entity.UpdatePromotionPrice(command.Price);

                var dataResult = _repository.Update(entity);

                if (dataResult.Success)
                    return new DataResult(true, dataResult.Message, dataResult.Data);
                else
                    return new DataResult(false, dataResult.Message, null);
            }
            catch (Exception ex)
            {
                return new DataResult(false, ex.Message.ToString(), null);
            }
        }
    }
}