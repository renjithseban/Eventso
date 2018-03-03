using BusinessEntities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Common
{
    public interface IUserServices : IDisposable
    {
        IEnumerable<UserEntity> GetAllUsers();
        UserEntity GetUserById(int userEntityId);
        int AddUser(UserEntity userEntity);
        bool UpdateUser(UserEntity userEntity);
        bool DropUser(int userEntityId);
        UserEntity GetUserByUserName(string userEntityUserName);
    }
}
