namespace API_Projects.Controllers
{
    public class TokenResult
    {
        public string AccessToken { get; set; }
        public string RefreshTiken { get; set; }
        public DateTime AccessTokenExpiredTiem { get; set; }
        public DateTime RefreshTokenExpireTime { get; set; }
    }
}
