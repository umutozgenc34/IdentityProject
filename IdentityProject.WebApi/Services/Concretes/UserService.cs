﻿using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Models.Dtos.Users.Request;
using IdentityProject.WebApi.Models.Dtos.Users.Response;
using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Repository.Abstracts.Concrates;
using IdentityProject.WebApi.Services.Abstracts;

namespace IdentityProject.WebApi.Services.Concretes;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User Add(AddUserRequestDto dto)
    {
        User user =(User) dto;

         User created = _userRepository.Add(user);
         return created;
    }

    public User Delete(int id)
    {
        User user = _userRepository.Delete(id);
        return user;
    }

    public List<UserResponseDto> GetAllUsers()
    {
        return _userRepository.GetAll().Select(x=> (UserResponseDto)x).ToList();
    }

    public User GetByEmail(string email)
    {
        User user = _userRepository.GetByEmail(email);
        return user;
    }

    public User GetById(int id)
    {
        User user = _userRepository.GetById(id);
        return user;
    }

    public User Update(User user)
    {
        User updatedUser = _userRepository.Update(user);
        return updatedUser;
    }
}
