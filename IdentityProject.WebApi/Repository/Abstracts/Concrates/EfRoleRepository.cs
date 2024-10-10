using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Repository.Abstracts.Concrates
{
    public class EfRoleRepository : IRoleRepository
    {
        private MsSqlContext _context;
        public EfRoleRepository(MsSqlContext context)
        {
            _context = context;
        }
        public Role Add(Role user)
        {
            _context.Roles.Add(user);
            _context.SaveChanges();
            return user;
        }

        public Role Delete(int id)
        {
            Role role = _context.Roles.Find(id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return role;
        }

        public List<Role> GetAll()
        {
            List<Role> roles = _context.Roles.ToList();
            return roles;
        }

        public Role? GetById(int id)
        {
            Role role = _context.Roles.Find(id);
            return role;

        }

        public Role Update(Role user)
        {
            _context.Roles.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
