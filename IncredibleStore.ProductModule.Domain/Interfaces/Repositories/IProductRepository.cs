using IncredibleStore.ProductModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncredibleStore.ProductModule.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        void Create(Product product);
        Product Read(Guid id);
        IEnumerable<Product> ReadAll();
        void Update(Product product);
        void Delete(Product product);
    }
}
