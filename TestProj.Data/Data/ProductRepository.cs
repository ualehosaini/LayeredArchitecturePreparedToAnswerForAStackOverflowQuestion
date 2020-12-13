using TestProj.Data.Interfaces;
using TestProj.Data.Model;

namespace TestProj.Data.Data
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            //Subject code here

            //Dummy code:
            var product = new Product
            {
                Id = 1,
                Name = "Product 1"
            };

            return product;
        }
    }
}
