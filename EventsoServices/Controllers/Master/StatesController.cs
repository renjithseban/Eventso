using System.Collections.Generic;
using System.Web.Http;
using BusinessEntities.Master;
using AutoMapper;
using BusinessService.Master;
using System;

namespace EventsoServices.Controllers.Master
{
    [RoutePrefix("api/Admin/States")]
    public class StatesController : ApiController
    {
        readonly IStateServices stateServices;

        public StatesController(StateServices stateServices)
        {
            this.stateServices = stateServices;
        }

        // GET: api/States
        [Route("")]
        public IEnumerable<StateEntity> GetAllStates()

        {
            var statesEntities = stateServices.GetAllStates();
            if (statesEntities != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<StateEntity, StateViewModel>());
                //var states = Mapper.Map<IEnumerable<StateEntity>, IEnumerable<StateViewModel>>(statesEntities);
                return statesEntities;
            }
            return null;
        }

        // GET: api/States/5
        [Route("{stateId}")]
        public StateEntity Get(int stateId)
        {
            var stateEntity = stateServices.GetStateById(stateId);
            if (stateEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<StateEntity, StateViewModel>());
                //var state = Mapper.Map<StateEntity, StateViewModel>(stateEntity);
                return stateEntity;
            }
            return null;
        }

        // GET: api/States/Kerala
        [Route("Find/{stateName}")]
        public StateEntity Get(string stateName)
        {
            var stateEntity = stateServices.GetStateByName(stateName);
            if (stateEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<StateEntity, StateViewModel>());
                //var state = Mapper.Map<StateEntity, StateViewModel>(stateEntity);
                return stateEntity;
            }
            return null;
        }

        // POST: api/States
        [Route("Add")]
        public int Post([FromBody]StateEntity stateEntity)
        {
            if (stateEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<StateViewModel, StateEntity>());
                //var stateEntity = Mapper.Map<StateViewModel, StateEntity>(state);
                return stateServices.AddState(stateEntity);
            }
            return 0;
        }

        // PUT: api/States/5
        [Route("Update/{id}")]
        public bool Put(int id, [FromBody]StateEntity stateEntity)
        {
            if (stateEntity != null)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<StateViewModel, StateEntity>());
                //var stateEntity = Mapper.Map<StateViewModel, StateEntity>(state);
                return stateServices.UpdateState(stateEntity);
            }
            return false;
        }

        [Route("Drop/{stateId}")]
        // DELETE: api/States/5
        public void Delete(int stateId)
        {
            try
            {
                if (stateId > 0)
                {
                    stateServices.DropState(stateId);
                }
            }
            catch (Exception)
            {
            }
            
        }
    }
}
