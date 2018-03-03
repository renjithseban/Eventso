using System;
using System.Collections.Generic;
using System.Linq;
using BusinessEntities.Master;
using DataAccess.Helper;
using AutoMapper;
using DataAccess;

namespace BusinessService.Master
{
    public class RoleServices : IRoleServices
    {
        private readonly UnitOfWork unitOfWork;

        public RoleServices()
        {
        }

        public RoleServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddRole(RoleEntity roleEntity)
        {
            try
            {
                var role = Mapper.Map<RoleEntity, Role>(roleEntity);
                var newRole = unitOfWork.RoleRepository.Add(role);
                unitOfWork.Save();
                if (newRole != null)
                    return newRole.RoleId;
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

        public bool DropRole(int roleEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.RoleRepository.Remove(roleEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<RoleEntity> GetAllRoles()
        {
            try
            {
                var roles = unitOfWork.RoleRepository.Get();
                if (roles != null)
                {
                    if (roles.Any())
                    {
                        var roleEntities = Mapper.Map<IEnumerable<Role>, IEnumerable<RoleEntity>>(roles);
                        return roleEntities;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RoleEntity GetRoleById(int roleEntityId)
        {
            try
            {
                var role = unitOfWork.RoleRepository.Find(roleEntityId);
                if (role != null)
                {
                    var roleEntity = Mapper.Map<Role, RoleEntity>(role);
                    return roleEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RoleEntity GetRoleByName(string roleEntityName)
        {
            try
            {
                var role = unitOfWork.RoleRepository.FirstOrDefault(r => r.RoleName == roleEntityName);
                if (role != null)
                {
                    var roleEntity = Mapper.Map<Role, RoleEntity>(role);
                    return roleEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateRole(RoleEntity roleEntity)
        {
            try
            {
                var role = Mapper.Map<RoleEntity, Role>(roleEntity);
                bool isEditted = unitOfWork.RoleRepository.Update(role);
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
