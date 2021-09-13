using Catalog.API.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProduct();
        Task<IEnumerable<Product>> GetProducts();
        Task DeleteProduct(ObjectId id);
        Task<Product> GetProductByName(string name);
        Task<Product> GetProductById(string id);
        Task<IEnumerable<Product>> GetProductsByCategory(string category);
        Task<bool> updateProduct(Product product);
        Task<bool> createProduct(Product product);
    }
}
