using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Services.Abstracts;

namespace IdentityProject.WebApi.Services.Concretes;

public class RoleService : IRoleService
{
    private IRoleRepository _roleRepository;
    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    public Role Add(Role role)
    {
        Role addRole = _roleRepository.Add(role);
        return addRole;
    }

    public Role Delete(int id)
    {
        Role role = _roleRepository.Delete(id);
        return role;
    }

    public List<Role> GetAllRoles()
    {
        return _roleRepository.GetAll();
    }

    public Role GetById(int id)
    {
        return _roleRepository.GetById(id);
    }

    public Role Update(Role role)
    {
        return _roleRepository.Update(role);
    }
}

