using Onion_Architecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_Architecture.Core.Contracts
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category FindByName(string name);
    }
}
