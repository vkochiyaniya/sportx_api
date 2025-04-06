using sportx_api.Models;

namespace sportx_api.DTOs.AdminDTOs
{
    public class CategoryAdminDTO
    {

        public string? Name { get; set; }

        public IFormFile? Image { get; set; }

        public string? Description { get; set; }


    }
}
