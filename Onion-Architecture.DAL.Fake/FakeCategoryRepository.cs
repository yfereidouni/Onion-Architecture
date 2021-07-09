using Onion_Architecture.Core.Contracts;
using Onion_Architecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Onion_Architecture.DAL.Fake
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> Categories = new List<Category>();

        public void Add(Category category)
        {
            Categories.Add(category);
        }

        public Category FindByName(string name)
        {
            return Categories.FirstOrDefault(c => c.Name == name);
        }
    }
}
