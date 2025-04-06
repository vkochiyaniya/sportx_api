using sportx_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sportx_api.Controllers.UserControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly MyDbContext _dbContext;
        public CategoryController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            var AllCategory = _dbContext.Categories.ToList();

            if (!AllCategory.Any())
            {
                return NotFound("No categories found.");
            }

            return Ok(AllCategory);
        }
    }
}
