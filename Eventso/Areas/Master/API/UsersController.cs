using AutoMapper;
using BusinessEntities.Admin;
using BusinessService.Admin;
using Evento.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Evento.Areas.Admin.API
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
        public IEnumerable<UserViewModel> GetAllStates()

        {
            var userEntities = userServices.GetAllUsers();
            if (userEntities != null)
            {
                if (userEntities.Any())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                    var users = Mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserViewModel>>(userEntities);
                    return users;
                }
            }
            return null;
        }

        // GET: api/Users/5
        [Route("{userId}")]
        public UserViewModel Get(int userId)
        {
            var userEntity = userServices.GetUserById(userId);
            if (userEntity != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                var user = Mapper.Map<UserEntity, UserViewModel>(userEntity);
                return user;
            }
            return null;
        }

        // GET: api/Users/renjithseban@gmail.com
        [Route("Find/{userName}")]
        public UserViewModel Get(string userName)
        {
            var userEntity = userServices.GetUserByUserName(userName);
            if (userEntity != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
                var user = Mapper.Map<UserEntity, UserViewModel>(userEntity);
                return user;
            }
            return null;
        }

        // POST: api/Users
        [Route("Add")]
        public int Post([FromBody]UserViewModel user)
        {
            if (user != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserViewModel, UserEntity>());
                var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                return userServices.AddUser(userEntity);
            }
            return 0;
        }

        // PUT: api/Users/5
        [Route("Update/{userId}")]
        public bool Put(int userId, [FromBody]UserViewModel user)
        {
            if (user != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<UserViewModel, UserEntity>());
                var userEntity = Mapper.Map<UserViewModel, UserEntity>(user);
                return userServices.UpdateUser(userEntity);
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
