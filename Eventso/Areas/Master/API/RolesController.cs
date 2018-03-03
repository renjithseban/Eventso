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
    [RoutePrefix("api/Admin/Roles")]
    public class RolesController : ApiController
    {
        readonly IRoleServices roleServices;

        public RolesController()
        { }

        public RolesController(RoleServices roleServices)
        {
            this.roleServices = roleServices;
        }

        // GET: api/Roles
        [Route("")]
        public IEnumerable<RoleViewModel> GetAllRoles()

        {
            var roleEntities = roleServices.GetAllRoles();
            if (roleEntities != null)
            {
                if (roleEntities.Any())
                {
                    Mapper.Initialize(cfg => cfg.CreateMap<RoleEntity, RoleViewModel>());
                    var roles = Mapper.Map<IEnumerable<RoleEntity>, IEnumerable<RoleViewModel>>(roleEntities);
                    return roles;
                }
            }
            return null;
        }

        // GET: api/Roles/5
        [Route("{roleId}")]
        public RoleViewModel Get(int roleId)
        {
            var roleEntity = roleServices.GetRoleById(roleId);
            if (roleEntity != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<RoleEntity, RoleViewModel>());
                var role = Mapper.Map<RoleEntity, RoleViewModel>(roleEntity);
                return role;
            }
            return null;
        }

        // GET: api/Roles/Admin
        [Route("Find/{roleName}")]
        public RoleViewModel Get(string roleName)
        {
            var roleEntity = roleServices.GetRoleByName(roleName);
            if (roleEntity != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<RoleEntity, RoleViewModel>());
                var role = Mapper.Map<RoleEntity, RoleViewModel>(roleEntity);
                return role;
            }
            return null;
        }

        // POST: api/Roles
        [Route("Add")]
        public int Post([FromBody]RoleViewModel role)
        {
            if (role != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<RoleViewModel, RoleEntity>());
                var roleEntity = Mapper.Map<RoleViewModel, RoleEntity>(role);
                return roleServices.AddRole(roleEntity);
            }
            return 0;
        }

        // PUT: api/Roles/5
        [Route("Update/{roleId}")]
        public bool Put(int userId, [FromBody]RoleViewModel role)
        {
            if (role != null)
            {
                Mapper.Initialize(cfg => cfg.CreateMap<RoleViewModel, RoleEntity>());
                var roleEntity = Mapper.Map<RoleViewModel, RoleEntity>(role);
                return roleServices.UpdateRole(roleEntity);
            }
            return false;
        }

        [Route("Drop/{roleId}")]
        // DELETE: api/States/5
        public void Delete(int roleId)
        {
            try
            {
                if (roleId > 0)
                {
                    roleServices.DropRole(roleId);
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
