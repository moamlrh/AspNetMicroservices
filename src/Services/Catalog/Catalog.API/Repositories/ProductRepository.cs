using Catalog.API.Data;
using Catalog.API.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatelogContext productContext;

        public ProductRepository(ICatelogContext productContext)
        {
            this.productContext = productContext;
        }
        public async Task<bool> createProduct(Product product)
        {
            await productContext.Products.InsertOneAsync(product);
            return true;
        }

        public Task DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
