using TestProj.Data.Model;

namespace TestProj.Data.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
    }
}
