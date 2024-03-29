using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
            => CategoryDAO.Instance.GetCategories();

        public Category GetCategoryById(int id)
            => CategoryDAO.Instance.GetCategoryById(id);

        public Category GetCategoryByName(string name)
            => CategoryDAO.Instance.GetCategoryByName(name);
    }
}
