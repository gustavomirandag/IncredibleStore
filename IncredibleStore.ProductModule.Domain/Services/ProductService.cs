using IncredibleStore.ProductModule.Domain.Entities;
using IncredibleStore.ProductModule.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IncredibleStore.ProductModule.Domain.Services
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void RegisterProduct(Product product)
        {
            _productRepository.Create(product);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public Product GetProduct(Guid id)
        {
            return _productRepository.Read(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.ReadAll();
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            return GetAllProducts().Where(product => product.Name
                .ToLower()
                .Contains(name.ToLower())
                );
        }

        public void RemoveProduct(Product product)
        {
            _productRepository.Delete(product);
        }
    } 
}
