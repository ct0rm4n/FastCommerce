﻿using Core.Entities.Domain.User;

namespace Data.Interfaces
{
    public interface IUserService 
    {
        bool Add(User user);
        List<User> GetAll();
        User Get(int Id);
        bool Update(User user);
        bool Delete(User user);        
    }
}
