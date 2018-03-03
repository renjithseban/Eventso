using System;
using System.Collections.Generic;
using System.Linq;
using BusinessEntities.Master;
using AutoMapper;
using DataAccess;
using DataAccess.Helper;

namespace BusinessService.Master
{
    public class StateServices : IStateServices
    {
        private readonly UnitOfWork unitOfWork;

        public StateServices()
        {
        }

        public StateServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddState(StateEntity stateEntity)
        {
            try
            {
                var state = Mapper.Map<StateEntity, State>(stateEntity);
                var newState = unitOfWork.StateRepository.Add(state);
                unitOfWork.Save();
                if (newState != null)
                    return newState.StateId;
                return 0;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public bool DropState(int stateEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.StateRepository.Remove(stateEntityId);
                unitOfWork.Save();
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateState(StateEntity stateEntity)
        {
            try
            {
                var state = Mapper.Map<StateEntity, State>(stateEntity);
                bool isEditted = unitOfWork.StateRepository.Update(state);
                unitOfWork.Save();
                return isEditted;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public IEnumerable<StateEntity> GetAllStates()
        {
            try
            {
                var states = unitOfWork.StateRepository.Get();
                if (states != null)
                {
                    if (states.Any())
                    {
                        var stateEntities = Mapper.Map<IEnumerable<State>, IEnumerable<StateEntity>>(states);
                        return stateEntities;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public StateEntity GetStateById(int stateEntityId)
        {
            try
            {
                var state = unitOfWork.StateRepository.Find(stateEntityId);
                if (state != null)
                {
                    var stateEntity = Mapper.Map<State, StateEntity>(state);
                    return stateEntity;
                }
                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public StateEntity GetStateByName(string stateEntityName)
        {
            try
            {
                var state = unitOfWork.StateRepository.FirstOrDefault(s => s.StateName == stateEntityName);
                if (state != null)
                {
                    var stateEntity = Mapper.Map<State, StateEntity>(state);
                    return stateEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null; 
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

       
    }
}
