﻿using YB.Mall.Data.Infrastructure;
using YB.Mall.Data.Repositories;
using YB.Mall.Model;
namespace YB.Mall.Service
{
    public class UserService : IUserService
    {
        private IUserRepository repository;
        private IUnitOfWork unitOfWork;
        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public UserInfo Register(UserInfo user)
        {
            repository.Add(user);
            unitOfWork.SaveChanges();
            return user;
        }
        public UserInfo Login(string username, string password)
        {
            return repository.Single(s => s.UserName.Equals(username) && s.PassWord.Equals(password));
        }
    }
}