using AutoMapper;
using BusinessEntities.Master;
using BusinessService.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EventsoServices.Controllers.Master
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
        public IEnumerable<RoleEntity> GetAllRoles()

        {
            var roleEntities = roleServices.GetAllRoles();
            if (roleEntities != null)
            {
                if (roleEntities.Any())
                {
                    return roleEntities;
                }
            }
            return null;
        }

        // GET: api/Roles/5
        [Route("{roleId}")]
        public RoleEntity Get(int roleId)
        {
            var roleEntity = roleServices.GetRoleById(roleId);
            if (roleEntity != null)
            {
                return roleEntity;
            }
            return null;
        }

        // GET: api/Roles/Admin
        [Route("Find/{roleName}")]
        public RoleEntity Get(string roleName)
        {
            var roleEntity = roleServices.GetRoleByName(roleName);
            if (roleEntity != null)
            {
                return roleEntity;
            }
            return null;
        }

        // POST: api/Roles
        [Route("Add")]
        public int Post([FromBody]RoleEntity role)
        {
            if (role != null)
            {
                return roleServices.AddRole(role);
            }
            return 0;
        }

        // PUT: api/Roles/5
        [Route("Update/{roleId}")]
        public bool Put(int userId, [FromBody]RoleEntity role)
        {
            if (role != null)
            {
                return roleServices.UpdateRole(role);
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
