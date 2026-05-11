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

            return Ok(responseBody);
        }
    }
}
