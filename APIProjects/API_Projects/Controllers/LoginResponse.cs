namespace API_Projects.Controllers
{
    public  class LoginResponse
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public int expires_in { get; set; }
        public int refresh_expires_in { get; set; }
    }
}
