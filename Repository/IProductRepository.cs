using System.Collections.Generic;
using Abbas_Rahimzadeh.Models;

namespace Abbas_Rahimzadeh.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductById(int id);
        void AddProduct(Products product);
        void UpdateProduct(Products product);
        void DeleteProduct(int id);
    }
}