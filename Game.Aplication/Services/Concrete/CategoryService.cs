using Game.Aplication.Dto.Category;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository category)
        {
            _categoryRepository = category;
        }
        public async Task AddAsync(CategoryAddRequest AddRequestcategory)
        {
            Category category = new Category
            {
                Name = AddRequestcategory.Name
            };
            await _categoryRepository.CreateAsync(category);
        }

        public async Task DeleteByIdAsync(int id)
        {
           var category = await _categoryRepository.FindByIdAsync(id);
            await _categoryRepository.DeActivate(category);
        }

        public async Task EditAsync(CategoryUpdateRequest category)
        {
            Category category1 = new Category
            {
                Id =  category.Id,
                Name = category.Name
            };
            await _categoryRepository.UpdateAsync(category1);
        }

        public async Task<CategoryTableResponse> GetCategoryById(int id)
        {
           var category=  await _categoryRepository.FindByIdAsync(id);
            CategoryTableResponse res = new CategoryTableResponse
            {
                Id = category.Id,
                Name = category.Name,
                CreatedDate = category.CreatedDate,

            };
            return res;
        }

        public async Task<List<CategoryTableResponse>> GetTable()
        {
            List<Category> category=   await _categoryRepository.FindAllActiveAsync();
            List<CategoryTableResponse> res = new List<CategoryTableResponse>();

            foreach (Category item in category)
            {
                CategoryTableResponse ct = new CategoryTableResponse 
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedDate = item.CreatedDate,
                };
                res.Add(ct);
            }
            return res;
        }
    }
}
