using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uplift.Models;

namespace Uplift.DataAccess.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCateforyListForDropDown();
        void Update(Category category);
    }
}
