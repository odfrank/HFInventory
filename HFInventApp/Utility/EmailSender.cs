using Microsoft.AspNetCore.Identity.UI.Services;

namespace HFInventApp.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //In future, put the logic for sending emails here
            return Task.CompletedTask;
        }
    }
}
