using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.ObjectPool;
using QuidvisSkillsTest.Repositories;

namespace QuidvisSkillsTest.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;
    private readonly IRepository _repository;
    public TestController(
        ILogger<TestController> logger,
        IRepository repository
        )
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet(Name = "GetClients")]
    public IEnumerable<Client> GetClients()
    {
        return _repository.GetClients().ToArray();
    }

    [HttpGet(Name = "GetProperties")]
    public IEnumerable<Property> GetProperties()
    {
        return _repository.GetProperties().ToArray();
    }

    [HttpGet(Name = "GetAudits")]
    public IEnumerable<Audit> GetAudits()
    {
        return _repository.GetAudits().ToArray();
    }

}
