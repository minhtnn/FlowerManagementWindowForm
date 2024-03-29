using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static object lockOject = new object();
        public CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }
        public List<Category> GetCategories()
        {
            using var db = new FStoreDBContext();
            return db.Categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            using var db = new FStoreDBContext();
            return db.Categories.SingleOrDefault(f => f.CategoryId.Equals(id));
        }
        public Category GetCategoryByName(string name)
        {
            using var db = new FStoreDBContext();
            return db.Categories.SingleOrDefault(f => f.CategoryName.Equals(name));
        }
    }
}
