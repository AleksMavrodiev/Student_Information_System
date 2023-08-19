using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Services.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message, string username)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("martineli.aleksandyr@gmail.com", "Example User");
            var to = new EmailAddress(email, username);
            var plainTextContent = message;
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
