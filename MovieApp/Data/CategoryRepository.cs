using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category(){Id=1,Name="Action"},
                new Category(){Id=2,Name="Comedy"},
                new Category(){Id=3,Name="Drama"},
                new Category(){Id=4,Name="Horror"},
                new Category(){Id=5,Name="Romance"},
                new Category(){Id=6,Name="Sci-Fi"},
                new Category(){Id=7,Name="Thriller"},
                new Category(){Id=8,Name="Western"},
                new Category(){Id=9,Name="Animation"},
                new Category(){Id=10,Name="Adventure"},
                new Category(){Id=11,Name="Crime"},
                new Category(){Id=12,Name="Fantasy"},
                new Category(){Id=13,Name="Mystery"},
            };
        }

        public static IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }

    }
}