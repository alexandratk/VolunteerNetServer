namespace BLL.Models.Options
{
    public class ResetPasswordOptions
    {
        public int ResetTokenExpirationHoursOffset { get; set; }
        public string PasswordResetUrl { get; set; }
    }
}
