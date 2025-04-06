namespace sportx_api.DTOs.UserDTOss
{
    public interface IEmailService
    {
            void SendEmail(string to, string subject, string body);

    }
}
