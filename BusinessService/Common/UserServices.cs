using System;
using System.Collections.Generic;
using BusinessEntities.Common;
using DataAccess.Helper;
using AutoMapper;
using DataAccess;
using System.Linq;

namespace BusinessService.Common
{
    public class UserServices : IUserServices
    {
        private readonly UnitOfWork unitOfWork;

        public UserServices()
        {
        }

        public UserServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddUser(UserEntity userEntity)
        {
            try
            {
               //.ForMember(c => c.Districts, options => options.Ignore()));
                var user = Mapper.Map<UserEntity, User>(userEntity);
                var newUser = unitOfWork.UserRepository.Add(user);
                unitOfWork.Save();
                if (newUser != null)
                    return newUser.UserId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    unitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool DropUser(int userEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.UserRepository.Remove(userEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            try
            {
                var users = unitOfWork.UserRepository.Get();
                if (users != null)
                {
                    if (users.Any())
                    {
                        var userEntities = Mapper.Map<IEnumerable<User>, IEnumerable<UserEntity>>(users);
                        return userEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UserEntity GetUserById(int userEntityId)
        {
            try
            {
                var user = unitOfWork.UserRepository.Find(userEntityId);
                if (user != null)
                {
                    var userEntity = Mapper.Map<User, UserEntity>(user);
                    return userEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UserEntity GetUserByUserName(string userEntityUserName)
        {
            try
            {
                var user = unitOfWork.UserRepository.FirstOrDefault(u => u.UserEmail == userEntityUserName);
                if (user != null)
                {
                    var userEntity = Mapper.Map<User, UserEntity>(user);
                    return userEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateUser(UserEntity userEntity)
        {
            try
            {
                var user = Mapper.Map<UserEntity, User>(userEntity);
                bool isEditted = unitOfWork.UserRepository.Update(user);
                unitOfWork.Save();
                return isEditted;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
