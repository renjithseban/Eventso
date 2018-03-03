using AutoMapper;
using BusinessEntities.Common;
using BusinessService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EventsoServices.Controllers.Common
{
    [RoutePrefix("api/Admin/Users")]
    public class UsersController : ApiController
    {
        readonly IUserServices userServices;

        public UsersController()
        { }

        public UsersController(UserServices stateServices)
        {
            this.userServices = stateServices;
        }

        // GET: api/Users
        [Route("")]
        public IEnumerable<UserEntity> GetAllStates()

        {
            var userEntities = userServices.GetAllUsers();
            if (userEntities != null)
            {
                //if (userEntities.Any())
                //{
                //    Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                //    var users = Mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(userEntities);
                //    return users;
                //}
                return userEntities;
            }
            return null;
        }

        // GET: api/Users/5
        [Route("{userId}")]
        public UserEntity Get(int userId)
        {
            var userEntity = userServices.GetUserById(userId);
            if (userEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                //var user = Mapper.Map<UserEntity, UserViewModel>(userEntity);
                //return user;
                return userEntity;
            }
            return null;
        }

        // GET: api/Users/renjithseban@gmail.com
        [Route("Find/{userName}")]
        public UserEntity Get(string userName)
        {
            var userEntity = userServices.GetUserByUserName(userName);
            if (userEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                //var user = Mapper.Map<UserEntity, UserViewModel>(userEntity);
                //return user;
                return userEntity;
            }
            return null;
        }

        // POST: api/Users
        [Route("Add")]
        public int Post([FromBody]UserEntity user)
        {
            if (user != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<UserViewModel, UserEntity>());
                //var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                return userServices.AddUser(user);
            }
            return 0;
        }

        // PUT: api/Users/5
        [Route("Update/{userId}")]
        public bool Put(int userId, [FromBody]UserEntity user)
        {
            if (user != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<UserViewModel, UserEntity>());
                //var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                return userServices.UpdateUser(user);
            }
            return false;
        }

        [Route("Drop/{userId}")]
        // DELETE: api/States/5
        public void Delete(int userId)
        {
            try
            {
                if (userId > 0)
                {
                    userServices.DropUser(userId);
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
