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
                    string query = "INSERT INTO Issues (title, description, status) VALUES (@title, @description, @status)";


                    // create a sql command with the query and connection
                    using (var command = new SqlCommand(query, connection))
                    {
                        // add parameters to the command to prevent sql injection
                        command.Parameters.AddWithValue("@title", issues.title);
                        command.Parameters.AddWithValue("@description", issues.description);
                        command.Parameters.AddWithValue("@status", "Open"); // default status
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

            return Ok("Issue created successfully.");
        }

        // http get method to retrieve all issues
        [HttpGet]
        public IActionResult GetIssues()
        {
            // try catch for error handling
            try
            {

                // list of issues
                List<IssuesCr> issuesList = new List<IssuesCr>();

                //try catch for database connection and retrieval
                try
                {
                    // connecting to the database using the connection string
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        // open the connection to db
                        connection.Open();
                        // query to select all issues from the database
                        string query = "SELECT id, title, description, status, createdAt FROM Issues";
                        // create a sql command with the query and connection
                        using (var command = new SqlCommand(query, connection))
                        {
                            // execute the command and read the results
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // create an issue object from the data and add it to the list
                                    var issue = new IssuesCr
                                    {
                                        id = reader.GetInt32(0),
                                        title = reader.GetString(1),
                                        description = reader.GetString(2),
                                        status = reader.GetString(3),
                                        createdAt = reader.GetDateTime(4)
                                    };
                                    issuesList.Add(issue);
                                }
                            }
                        }
                        // close the connection after use
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    // log the exception
                    ModelState.AddModelError("Exception", ex.Message);
                    return BadRequest(ModelState);
                }

                return Ok(issuesList);
            }
            catch (Exception ex)
            {
                // log the exception
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // http function to get a specific issue by id
        [HttpGet("{id}")]
        public IActionResult GetIssueById(int id)
        {
            // class instance to hold the issue data
            IssuesCr issuesCr = new IssuesCr();

            // try catch for error handling
            try
            {

                // connecting to the database using the connection string
                using (var connection = new SqlConnection(_connectionString))
                {
                    // open the connection to db
                    connection.Open();
                    // query to select the issue with the specified id from the database
                    string query = "SELECT id, title, description, status, createdAt FROM Issues WHERE id=@id";
                    // create a sql command with the query and connection
                    using (var command = new SqlCommand(query, connection))
                    {
                        // add parameter to the command to prevent sql injection
                        command.Parameters.AddWithValue("@id", id);
                        // execute the command and read the result
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // create an issue object from the data
                                issuesCr.id = reader.GetInt32(0);
                                issuesCr.title = reader.GetString(1);
                                issuesCr.description = reader.GetString(2);
                                issuesCr.status = reader.GetString(3);
                                issuesCr.createdAt = reader.GetDateTime(4);
                            }
                            else
                            {
                                return NotFound("Issue not found.");
                            }
                        }
                    }
                    // close the connection after use
                    connection.Close();
                }

                return Ok(issuesCr);
            }
            catch (Exception ex)
            {
                // log the exception
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // http put method to update an existing issue
        [HttpPut("{id}")]
        public IActionResult UpdateIssue(int id, Issues issues)
        {
            // try catch for error handling
            try
            {
                // connecting to the database using the connection string
                using (var connection = new SqlConnection(_connectionString))
                {
                    // open the connection to db
                    connection.Open();
                    // query to update the issue with the specified id in the database
                    string query = "UPDATE Issues SET title=@title, description=@description, status=@status WHERE id=@id";
                    // create a sql command with the query and connection
                    using (var command = new SqlCommand(query, connection))
                    {
                        // add parameters to the command to prevent sql injection
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@title", issues.title);
                        command.Parameters.AddWithValue("@description", issues.description);
                        command.Parameters.AddWithValue("@status", issues.status);
                        // execute the command to update the issue in the database
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return NotFound("Issue not found.");
                        }
                    }
                    // close the connection after use
                    connection.Close();
                }
                return Ok("Issue updated successfully.");
            }
            catch (Exception ex)
            {
                // log the exception
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }

        }

        // http delete method to delete an issue by id
        [HttpDelete("{id}")]
        public IActionResult DeleteIssue(int id) {

            // try catch for error handling
            try
            {
                // connecting to the database using the connection string
                using (var connection = new SqlConnection(_connectionString))
                {
                    // open the connection to db
                    connection.Open();
                    // query to delete the issue with the specified id from the database
                    string query = "DELETE FROM Issues WHERE id=@id";
                    // create a sql command with the query and connection
                    using (var command = new SqlCommand(query, connection))
                    {
                        // add parameter to the command to prevent sql injection
                        command.Parameters.AddWithValue("@id", id);
                        // execute the command to delete the issue from the database
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return NotFound("Issue not found.");
                        }
                    }
                    // close the connection after use
                    connection.Close();
                }

                return Ok("Issue deleted successfully.");
            }
            catch (Exception ex)
            {
                // log the exception
                ModelState.AddModelError("Exception", ex.Message);
                return BadRequest(ModelState);
            }
        }


    }
}
