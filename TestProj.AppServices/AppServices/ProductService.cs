using TestProj.AppServices.Interfaces;
using TestProj.AppServices.Models;
using TestProj.Data.Interfaces;

namespace TestProj.AppServices.AppServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public Product GetById(int id)
        {
            //Subject code here

            //Dummy code:
            var productFromDataLayer = _repository.GetById(id);

            //Mapping (You can use AutoMapper NuGet)
            //Some may say the mapping is the reposnibility of controller but in the question scenario it should not.
            //Reference Question https://stackoverflow.com/questions/65275658/how-will-i-resolve-dependency-of-interfaces-which-is-on-3rd-or-4rth-layer
            var product = new Product
            {
                Id = productFromDataLayer.Id,
                Name = productFromDataLayer.Name
            };

            return product;
        }
    }
}
