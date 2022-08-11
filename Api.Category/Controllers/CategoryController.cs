using Api.Category.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Shared.Models.CategoryModels;

namespace Api.Category.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [Route("Add")]
        [HttpPost]
        public async Task<StatusCodeResult> Add(CategoryAddModel entity)
        {
            var rst = await _service.AddAsync(entity);

            if (rst)
                return Ok();
            else
                return BadRequest();
        }

        [Route("Update")]
        [HttpPut]
        public async Task<StatusCodeResult> Update(CategoryUpdateModel entity)
        {
            var rst = await _service.Update(entity);

            if (rst)
                return Ok();
            else
                return BadRequest();
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<IEnumerable<CategoryViewModel>?> GetAll() => await _service.GetAllAsync();

        [Route("GetById")]
        [HttpGet]
        public async Task<CategoryViewModel?> GetById([FromRoute]int id) => await _service.GetById(id);

    }
}
