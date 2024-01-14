namespace DAL.Entities.Cache
{
    public enum TokenType 
    {
        ResetPassword,
        ConfirmEmail
    }

    public class PendingUserCache
    {
        public Guid UserId { get; set; }
        public string ConfirmationToken { get; set; }
        public TokenType TokenType { get; set; }
    }
}
