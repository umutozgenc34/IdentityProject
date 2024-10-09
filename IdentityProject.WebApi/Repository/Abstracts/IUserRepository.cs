using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Repository.Abstracts;

public interface IUserRepository : IEntityRepository<User>
{
    
    User GetByEmail(string email);
    List<User> GetAllByUserNameContains(string text);

}
