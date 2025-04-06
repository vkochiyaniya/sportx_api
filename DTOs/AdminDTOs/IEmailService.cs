namespace sportx_api.DTOs.AdminDTOs
{
    public interface IEmailService
    {
            void SendEmail(string to, string subject, string body);

    }
}
