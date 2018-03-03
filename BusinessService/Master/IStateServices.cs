using BusinessEntities.Master;
using System;
using System.Collections.Generic;

namespace BusinessService.Master
{
    public interface IStateServices : IDisposable
    {
        IEnumerable<StateEntity> GetAllStates();
        StateEntity GetStateById(int stateEntityId);
        int AddState(StateEntity stateEntity);
        bool UpdateState(StateEntity stateEntity);
        bool DropState(int stateEntityId);
        StateEntity GetStateByName(string stateEntityName);
    }
}
