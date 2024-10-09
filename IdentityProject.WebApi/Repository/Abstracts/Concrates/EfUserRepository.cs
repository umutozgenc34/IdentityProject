using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebApi.Repository.Abstracts.Concrates;

public class EfUserRepository : IUserRepository
{

    //Method Injection
    // Constructor Arg Injection
    private MsSqlContext _context;
    public EfUserRepository(MsSqlContext context)
    {
        _context = context;
    }
    public User Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }

    public User Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllByUserNameContains(string text)
    {
        List<User> users = _context.Users.
            Where(x=> x.UserName.Contains(text,StringComparison.OrdinalIgnoreCase))
            .ToList();
        return users;
    }

    public User GetByEmail(string email)
    {
        User? user = _context.Users.SingleOrDefault(x => x.Email == email);
        return user;
        
    }

    public User? GetById(int id)
    {
        User? user = _context.Users.Find(id);
        return user;

    }

    public User Update(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();

        return user;
    }
}
