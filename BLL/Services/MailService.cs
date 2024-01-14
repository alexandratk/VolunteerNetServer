using Azure;
using Azure.Communication.Email;
using BLL.Interfaces;
using BLL.Models.Options;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BLL.Services
{
    public class MailService : IMailService
    {
        private readonly EmailClient emailClient;
        private readonly ILogger<MailService> logger;
        private readonly EmailOptions emailOptions;

        public MailService(EmailClient emailClient,
            IOptions<EmailOptions> emailOptions,
            ILogger<MailService> logger)
        {
            this.emailClient = emailClient;
            this.logger = logger;
            this.emailOptions = emailOptions.Value;
        }

        public async Task<bool> SendMail(string recepient, string subject, string body)
        {
            string noReplyAddress = emailOptions.VerifiedNoReplyAddress;
            if (string.IsNullOrWhiteSpace(noReplyAddress))
            {
                throw new Exception("Mail configuration 'VerifiedNoReplyAddress' is missing");
            }

            try
            {
                EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                    wait: Azure.WaitUntil.Completed,
                    senderAddress: noReplyAddress,
                    recipientAddress: recepient,
                    subject: subject,
                    htmlContent: body);

                if (emailSendOperation.Value.Status == EmailSendStatus.Succeeded)
                {
                    return true;
                }
                else 
                {
                    logger.LogWarning($"Email send operation (id: {emailSendOperation.Id}) failed with status: {emailSendOperation.Value.Status.ToString()}");
                    return false;
                }
            }
            catch (RequestFailedException ex)
            {
                logger.LogError($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
                return false;
            }
            catch (Exception ex) 
            {
                logger.LogError($"Something went wrong during message sending: {ex.Message}");
                return false;
            }

        }
    }
}
