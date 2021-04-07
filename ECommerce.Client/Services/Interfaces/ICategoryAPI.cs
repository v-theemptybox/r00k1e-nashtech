using ECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Client.Services.Interfaces
{
    public interface ICategoryAPI
    {
        Task<IList<CategoryVm>> GetCategories();
    }
}
