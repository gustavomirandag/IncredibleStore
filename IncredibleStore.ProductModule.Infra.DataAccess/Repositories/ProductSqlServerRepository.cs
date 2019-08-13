using IncredibleStore.ProductModule.Domain.Entities;
using IncredibleStore.ProductModule.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncredibleStore.ProductModule.Infra.DataAccess.Repositories
{
    public class ProductSqlServerRepository : IProductRepository
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
