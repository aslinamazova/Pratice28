using _28._04_Pratice.Services.Interfaces.ProductInterface;

namespace _28._04_Pratice.Services.Implementations.Product
{
    internal class ProductService : IProductService
    {
        Models.Product[] products = new Models.Product[0];
        public void Create(string name)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = new Models.Product(name);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Models.Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}
