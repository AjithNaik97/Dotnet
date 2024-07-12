using TempProduct.Models;
using TempProduct.Repository;

namespace TempProduct.Services
{
    public class ProductService : IProductService
    {
        IProductManager productManager =new ProductManager();

        public void Insert(Products products)
        {
            productManager.Insert(products);
        }

        public List<Products> GetAll()
        {
            return productManager.GetAll();
        }

        public Products GetById(int id)
        {
            return productManager.GetById(id);
        }

        public void Update(Products products)
        {
            productManager.Update(products);
        }

        public void Delete(int id)
        {
            productManager.Delete(id);
        }
    }
}
