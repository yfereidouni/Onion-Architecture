using Onion_Architecture.Core.Contracts;
using Onion_Architecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_Architecture.Core.ApplicationServices
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var categoryInDb = _categoryRepository.FindByName(name);

                if (categoryInDb == null || categoryInDb.CategoryId < 1)
                {
                    var category = new Category()
                    {
                        Name = name
                    };
                    _categoryRepository.Add(category);
                }
            }
        }
    }
}
