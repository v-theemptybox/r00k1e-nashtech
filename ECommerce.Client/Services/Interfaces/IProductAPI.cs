using ECommerce.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Client.Services.Interfaces
{
    public interface IProductAPI
    {
        Task<IList<ProductVm>> GetProducts();
        Task<IList<ProductVm>> GetProduct(int id);
        Task<IList<ProductVm>> GetProductByCategory(int idCate);

    }
}
