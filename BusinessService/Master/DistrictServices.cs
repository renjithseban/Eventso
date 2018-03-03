using System;
using System.Collections.Generic;
using System.Linq;
using BusinessEntities.Master;
using AutoMapper;
using DataAccess;
using DataAccess.Helper;

namespace BusinessService.Master
{
    public class DistrictServices : IDistrictServices
    {

        private readonly UnitOfWork unitOfWork;

        public DistrictServices()
        {
        }

        public DistrictServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddDistrict(DistrictEntity districtEntity)
        {
            try
            {
                var district = Mapper.Map<DistrictEntity, District>(districtEntity);
                var newDistrict = unitOfWork.DistrictRepository.Add(district);
                if (newDistrict != null)
                    return newDistrict.DistrictId;
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DropDistrict(int districtEntityId)
        {
            try
            {
                bool isDropped = unitOfWork.DistrictRepository.Remove(districtEntityId);
                return isDropped;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<DistrictEntity> GetAllDistricts()
        {
            try
            {
                Mapper.Initialize(cfg => { cfg.CreateMissingTypeMaps = true;   });
                var districts = unitOfWork.DistrictRepository.Get();
                if (districts != null)
                {
                    if (districts.Any())
                    {
                        var districtEntities = Mapper.Map<IEnumerable<District>, IEnumerable<DistrictEntity>>(districts);
                        return districtEntities;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public DistrictEntity GetDistrictById(int districtEntityId)
        {
            try
            {
                var district = unitOfWork.DistrictRepository.Find(districtEntityId);
                if (district!=null)
                {
                    var districtEntity = Mapper.Map<District, DistrictEntity>(district);
                    return districtEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public DistrictEntity GetDistrictByName(string districtEntityName)
        {
            try
            {
                var district = unitOfWork.DistrictRepository.FirstOrDefault(d => d.DistrictName == districtEntityName);
                if (district != null)
                {
                    var districtEntity = Mapper.Map<District, DistrictEntity>(district);
                    return districtEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<DistrictEntity> GetDistrictByStateName(string stateEntityName)
        {
            try
            {
                var districts = unitOfWork.DistrictRepository.GetMany(d => d.State.StateName == stateEntityName);
                if (districts != null)
                {
                    if (districts.Any())
                    {
                        var districtEntities = Mapper.Map<IEnumerable<District>, IEnumerable<DistrictEntity>>(districts);
                        return districtEntities;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<DistrictEntity> GetDistrictByStateId(int stateEntityId)
        {
            try
            {
                var districts = unitOfWork.DistrictRepository.GetMany(d => d.State.StateId == stateEntityId);
                if (districts != null)
                {
                    if (districts.Any())
                    {
                        var districtEntities = Mapper.Map<IEnumerable<District>, IEnumerable<DistrictEntity>>(districts);
                        return districtEntities;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateDistrict(DistrictEntity districtEntity)
        {
            try
            {
                var district = Mapper.Map<DistrictEntity, District>(districtEntity);
                bool isEditted = unitOfWork.DistrictRepository.Update(district);
                return isEditted;
            }
            catch (Exception)
            {
                return false;
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
