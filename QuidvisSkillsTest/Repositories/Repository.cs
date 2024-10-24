using Microsoft.Data.SqlClient;
using Dapper;

namespace QuidvisSkillsTest.Repositories;


public class Repository : IRepository {

    private readonly IConfiguration _configuration;

    public Repository (
        IConfiguration configuration
        )
    {
        _configuration = configuration;
    }

    public IEnumerable<Client> GetClients()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = "SELECT * FROM Clients";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
           return connection.Query<Client>(sql).ToList();
        }
    }

    public IEnumerable<Property> GetProperties()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql =  @"SELECT Properties.*, Clients.name client FROM Properties 
            INNER JOIN Clients ON Properties.clientId = Clients.clientId";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            return  connection.Query<Property>(sql).ToList();
        }
    }

    public IEnumerable<Audit> GetAudits()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        var sql = @"SELECT Audits.*, Properties.name propertyName FROM Audits 
            INNER JOIN Properties ON Audits.propertyId = Properties.propertyId";

        // Connect to the database 
        using (var connection = new SqlConnection(connectionString)) 
        { 
	
            // Use the Query method to execute the query and return a list of objects    
            return  connection.Query<Audit>(sql).ToList();
        }
    }

}