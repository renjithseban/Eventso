using System;
using System.Collections.Generic;
using BusinessEntities.Vendor;
using AutoMapper;
using DataAccess;
using DataAccess.Helper;

namespace BusinessService.Vendor
{
    public class VendorServices : IVendorServices
    {
        private readonly UnitOfWork unitOfWork;
        public VendorServices()
        {
        }

        public VendorServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddVendor(VendorEntity vendorEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool DropVendor(int vendorEntityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendorEntity> GetAllVendors()
        {
            try
            {
                var vendors = unitOfWork.VendorRepository.Get();
                if (vendors != null)
                {
                    var vendorEntities = Mapper.Map<IEnumerable<DataAccess.Vendor>, IEnumerable<VendorEntity>>(vendors);
                    return vendorEntities;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public VendorEntity GetVendorById(int vendorEntityId)
        {
            try
            {
                var vendor = unitOfWork.VendorRepository.Find(vendorEntityId);
                if (vendor != null)
                {
                    var vendorEntity = Mapper.Map<DataAccess.Vendor, VendorEntity>(vendor);
                    return vendorEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public VendorEntity GetVendorByName(string vendorEntityName)
        {
            try
            {
                var vendor = unitOfWork.VendorRepository.FirstOrDefault(c=>c.VendorName == vendorEntityName);
                if (vendor != null)
                {
                    var vendorEntity = Mapper.Map<DataAccess.Vendor, VendorEntity>(vendor);
                    return vendorEntity;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateVendor(VendorEntity vendorEntity)
        {
            throw new NotImplementedException();
        }
    }
}
