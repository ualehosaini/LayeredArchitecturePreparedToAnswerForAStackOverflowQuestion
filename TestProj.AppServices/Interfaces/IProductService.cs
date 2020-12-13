using TestProj.AppServices.Models;

namespace TestProj.AppServices.Interfaces
{
    public interface IProductService
    {
        Product GetById(int id);
    }
}
