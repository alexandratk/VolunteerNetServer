namespace BLL.Models.Options
{
    public class EmailOptions
    {
        public string? VerifiedNoReplyAddress { get; set; }
        public int MailVerificationHoursOffset { get; set; }
        public string ConfirmationUrl { get; set; }
    }
}
