using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        // connection string for db
        private readonly string _connectionString;

        // constructor and dependencies can be injected
        public IssuesController(IConfiguration configuration)
        {
            // initialize connection string from configuration
            // if the connection string is not found, it will be set to an empty string
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";



        }
    }
}
