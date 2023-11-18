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
