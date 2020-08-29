using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uplift.DataAccess.IRepository;
using Uplift.Models;
using UpLiftApp.DataAccess.Data;

namespace Uplift.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<SelectListItem> GetCateforyListForDropDown()
        {
            return dbContext.Categories.Select(c => new SelectListItem()
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });
        }

        public void Update(Category category)
        {
            var cat = dbContext.Categories.Attach(category);
            cat.State = EntityState.Modified;
        }
    }
}
