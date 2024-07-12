using TempProduct.Models;

namespace TempProduct.Repository
{
    public interface IProductManager
    {
        void Insert(Products products);

        List<Products> GetAll();

        Products GetById(int id);

        void Update(Products products);

        void Delete(int id);
    }
}
