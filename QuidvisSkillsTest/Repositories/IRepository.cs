namespace QuidvisSkillsTest.Repositories;

public interface IRepository {
    public IEnumerable<Client> GetClients();
    public IEnumerable<Property> GetProperties();
    public IEnumerable<Audit> GetAudits();
}