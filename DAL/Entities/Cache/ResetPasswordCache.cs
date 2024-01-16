namespace DAL.Entities.Cache
{
    public class ResetPasswordCache: PendingUserCache
    {
        public string UserEmail { get; set; }
    }
}
