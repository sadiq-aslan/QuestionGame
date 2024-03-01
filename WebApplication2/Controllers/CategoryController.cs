using Game.Aplication.Dto.Category;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost("addCategory")]
        public async Task<IActionResult> addCategory(CategoryAddRequest addRequest)
        {
            await _categoryService.AddAsync(addRequest);
            return Ok();
        }
        [HttpPost("DeleteById")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _categoryService.DeleteByIdAsync(id);
            return Ok();
        }
        [HttpPost("EditCategory")]
        public async Task<IActionResult> EditCategory(CategoryUpdateRequest request)
        {
            await _categoryService.EditAsync(request);
            return Ok();
        }
        [HttpGet("getById")]
        public async Task<IActionResult> GetById(int id)
        {
          CategoryTableResponse res =  await _categoryService.GetCategoryById(id);
            return Ok(res);
        }
        [HttpGet("GetallCategories")]
        public async Task<IActionResult> GetallCategories()
        {
            List<CategoryTableResponse> res = await _categoryService.GetTable();
            return Ok(res);
        }
    }
}
