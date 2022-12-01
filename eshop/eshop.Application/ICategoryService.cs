﻿using eshop.Entities;

namespace eshop.Application
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
    }
}