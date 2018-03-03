using BusinessEntities.Master;
using System;
using System.Collections.Generic;

namespace BusinessService.Master
{
    public interface IRoleServices : IDisposable
    {
        IEnumerable<RoleEntity> GetAllRoles();
        RoleEntity GetRoleById(int roleEntityId);
        int AddRole(RoleEntity roleEntity);
        bool UpdateRole(RoleEntity roleEntity);
        bool DropRole(int roleEntityId);
        RoleEntity GetRoleByName(string roleEntityName);
    }
}
