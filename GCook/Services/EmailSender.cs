using System.Net;
using System.Net.Mail;
using GCook.Services;

namespace Gcook.Services;
public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string emailAddress, string subject, string htmlMessage)
    {
        var mail = "gcook.app@outlook.com";
        var pw = "QV3E4khpZBEcL7k";

        var client = new SmtpClient("smpt-mail.outlook.com", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential(mail, pw)
        };

        MailMessage sendMail = new(
            from: mail,
            to: emailAddress,
            subject,
            htmlMessage
        );
        sendMail.IsBodyHtml = true;
        await client.SendMailAsync(sendMail);
    }
}