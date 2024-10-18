using System.ComponentModel.Design;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace QuidvisSkillsTest.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;
    private readonly IConfiguration _configuration;

    public TestController(
        ILogger<TestController> logger,
        IConfiguration configuration
        )
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet(Name = "GetClients")]
    public IEnumerable<Client> GetClients()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Clients";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            var clients = connection.Query<Client>(sql).ToList();
            return clients.ToArray();
        }
    }

    [HttpGet(Name = "GetProperties")]
    public IEnumerable<Property> GetProperties()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Properties";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            var properties = connection.Query<Property>(sql).ToList();
            return properties.ToArray();
        }
    }

    [HttpGet(Name = "GetAudits")]
    public IEnumerable<Audit> GetAudits()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Audits";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            var audits = connection.Query<Audit>(sql).ToList();
            return audits.ToArray();
        }
    }

    [HttpGet(Name = "GetClientProperties")]
    public IEnumerable<Property> GetClientProperties(string clientId)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Properties WHERE clientId = @clientId";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            var properties = connection.Query<Property>(sql, new { clientId = clientId}).ToList();
            return properties.ToArray();
        }
    }

    [HttpGet(Name = "GetPropertyAudits")]
    public IEnumerable<Audit> GetPropertyAudits(string propertyId)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Audits WHERE propertyId = @propertyId";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            var audits = connection.Query<Audit>(sql, new { propertyId = propertyId}).ToList();
            return audits.ToArray();
        }
    }
}
