using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace ASC.Solution.Services
{
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        // Gửi email
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // TODO: Thêm code gửi email thực tế (SMTP, SendGrid, v.v.)
            return Task.CompletedTask;
        }

        // Gửi tin nhắn SMS
        public Task SendSmsAsync(string number, string message)
        {
            // TODO: Thêm code gửi SMS thực tế
            return Task.CompletedTask;
        }
    }
}
