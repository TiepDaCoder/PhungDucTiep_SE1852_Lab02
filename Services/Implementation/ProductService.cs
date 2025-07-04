﻿using BusinessObjects;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;
        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }
        public void DeleteProduct(Product p)
        {
            iProductRepository.DeleteProduct(p);
        }
        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }
        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }
        public void SaveProduct(Product p)
        {
            iProductRepository.SaveProduct(p);
        }
        public void UpdateProduct(Product p)
        {
            iProductRepository.UpdateProduct(p);
        }
    }
}
