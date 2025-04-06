using sportx_api.Models;

namespace sportx_api.DTOs.AdminDTOs
{
    public class VoucherRequestDto
    {
        public string? Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpiryDate { get; set; }


    }
}
