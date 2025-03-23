//🔴 Risk: The above query is vulnerable to SQL Injection.
//✅ Fix: Use parameterized queries or Entity Framework.


using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace VulnerableWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly string _connectionString = "Your_Connection_String_Here";

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            // ❌ SQL Injection Risk! User input is directly used in SQL query
            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            if (reader.HasRows)
                return Content("Login successful!");
            else
                return Unauthorized();
        }
    }
}


