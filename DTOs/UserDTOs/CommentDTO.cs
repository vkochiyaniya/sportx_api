namespace sportx_api.DTOs.UserDTOs
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public string Comment1 { get; set; }
        public int Rating { get; set; }
        public DateOnly Date { get; set; }
        public string UserName { get; set; }
    }
}
