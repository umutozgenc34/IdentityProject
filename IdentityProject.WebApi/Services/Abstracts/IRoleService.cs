using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Services.Abstracts;

public interface IRoleService
{
    List<Role> GetAllRoles();
    Role GetById(int id);
    Role Add(Role role);
    Role Update(Role role);
    Role Delete(int id);
}
