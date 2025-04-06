using sportx_api.Models;

namespace sportx_api.DTOs.UserDTOss
{
    public class CategoryRequestDTO
    {

        public string? Name { get; set; }

        public IFormFile? Image { get; set; }

        public string? Description { get; set; }


    }
}
