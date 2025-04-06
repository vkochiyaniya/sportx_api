namespace sportx_api.DTOs.UserDTOs
{
    public class addCartItemRequestDTO
    {
        public int? CartId { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }

    }
}
