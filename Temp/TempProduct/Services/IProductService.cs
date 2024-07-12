using TempProduct.Models;

namespace TempProduct.Services
{
    public interface IProductService
    {
        void Insert(Products products);

        List<Products> GetAll();

        Products GetById(int id);

        void Update(Products products);

        void Delete(int id);
    }
}
