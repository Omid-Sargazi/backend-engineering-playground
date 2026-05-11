using API_Projects.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace API_Projects.APIInvoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController:ControllerBase
    {
        private string _token;
        private static string _accessToken;
        private static string _refreshToken;
        private static DateTime _accessTokenExpire;
        private static DateTime _refreshTokenExpire;
        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            var logingInformation = new
            {
                userName = "LoanUser",
                password = "@LoanUser#1404",
                granttype = "password",
                clientId="LoanClientId",
                clientSecret = "@TestSecret123456@TestSecret123456@TestSecret123456@TestSecret123456@TestSecret123456@TestSecret123456@TestSecret123456@TestSecret123456"
            };

            var url = "http://10.0.85.160:8888/gw/api/v1/Auth/Login";

            var jsonLoging = JsonSerializer.Serialize(logingInformation);


            var httpClient = new HttpClient();
            var content = new StringContent(jsonLoging, Encoding.UTF8, "application/json");

            var response =  await httpClient.PostAsync(url, content);

            var responseBody = await response.Content.ReadAsStringAsync();

            if(!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, responseBody);
            }

            if(string.IsNullOrEmpty(responseBody))
            {
                return BadRequest("Login response is empty.");
            }

            var tokenResponse = JsonSerializer.Deserialize<LoginResponse>(responseBody);

            _accessToken = tokenResponse.access_token;
            _refreshToken = tokenResponse.refresh_token;
            _accessTokenExpire = DateTime.Now.AddSeconds(tokenResponse.expires_in);
            _refreshTokenExpire = DateTime.Now.AddSeconds(tokenResponse.refresh_expires_in);

            if (tokenResponse ==null || string.IsNullOrEmpty(tokenResponse.access_token))
            {
                return BadRequest("Token not received.");
            }
            _token = tokenResponse.access_token;

            return Ok(responseBody);
        }

       

        private async Task RefreshToken()
        {
            var data = new
            {
                refreshToken = _refreshToken
            };

            var json = JsonSerializer.Serialize(data);

            var httpClient = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("Refresh_URL", content);

            var body = await response.Content.ReadAsStringAsync();
            var toeknReposne = JsonSerializer.Deserialize<LoginResponse>(body);
        }
    }
}
