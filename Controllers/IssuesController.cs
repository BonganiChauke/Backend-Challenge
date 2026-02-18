using Backend_Challenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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

        // http post method to create a new issue
        [HttpPost]
        public IActionResult CreateIssue(Issues issues)
        {

            // try catch for error handling
            try
            {

                // connecting to the database using the connection string
                using (var connection = new SqlConnection(_connectionString))
                {
                    // open the connection to db
                    connection.Open();

                    // query to insert the issue into the database
                    string query = "INSERT INTO Issues (title, description, status, createdAt) VALUES (@title, @description, @status, @createdAt)";


                    // create a sql command with the query and connection
                    using (var command = new SqlCommand(query, connection))
                    {
                        // add parameters to the command to prevent sql injection
                        command.Parameters.AddWithValue("@title", issues.title);
                        command.Parameters.AddWithValue("@description", issues.description);
                        command.Parameters.AddWithValue("@status", "Open"); // default status
                        command.Parameters.AddWithValue("@createdAt", DateTime.UtcNow); // current time
                        // execute the command to insert the issue into the database
                        command.ExecuteNonQuery();
                    }

                    // close the connection after use
                    connection.Close();

                }

                // validate the issue object
                if (issues == null || string.IsNullOrEmpty(issues.title) || string.IsNullOrEmpty(issues.description))
                {
                    return BadRequest("Invalid issue data.");
                }

            }
            catch (Exception ex)
            {
                // log the exception
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }

            // here you would typically save the issue to the database using the connection string
            // for demonstration purposes, we will just return a success response
            return Ok("Issue created successfully.");
        }

    }
}
