using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace DataAccess.Helper
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private member variables...

        private EventsoEntities context = null;
        private GenericRepository<State> stateRepository;
        private GenericRepository<District> districtRepository;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<Vendor> vendorRepository;
        private GenericRepository<User> userRepository;
        private GenericRepository<Role> roleRepository;
        private GenericRepository<Testimonial> testimonialRepository;
        private GenericRepository<OfficeAddress> officeAddressRepository;
        private GenericRepository<VendorCategory> vendorCategoryRepository;
        private GenericRepository<Viewership> viewershipRepository;
        private GenericRepository<CategoryFilter> filterRepository;

        #endregion

        public UnitOfWork()
        {
            context = new EventsoEntities();
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for State repository.
        /// </summary>
        public GenericRepository<State> StateRepository
        {
            get
            {
                if (this.stateRepository == null)
                    this.stateRepository = new GenericRepository<State>(context);
                return stateRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for District repository.
        /// </summary>
        public GenericRepository<District> DistrictRepository
        {
            get
            {
                if (this.districtRepository == null)
                    this.districtRepository = new GenericRepository<District>(context);
                return districtRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for Category repository.
        /// </summary>
        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                    this.categoryRepository = new GenericRepository<Category>(context);
                return categoryRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for Crew repository.
        /// </summary>
        public GenericRepository<Vendor> VendorRepository
        {
            get
            {
                if (this.vendorRepository == null)
                    this.vendorRepository = new GenericRepository<Vendor>(context);
                return vendorRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for User repository.
        /// </summary>
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                    this.userRepository = new GenericRepository<User>(context);
                return userRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for Role repository.
        /// </summary>
        public GenericRepository<Role> RoleRepository
        {
            get
            {
                if (this.roleRepository == null)
                    this.roleRepository = new GenericRepository<Role>(context);
                return roleRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for CrewTestimonial repository.
        /// </summary>
        public GenericRepository<Testimonial> VendorTestimonialRepository
        {
            get
            {
                if (this.testimonialRepository == null)
                    this.testimonialRepository = new GenericRepository<Testimonial>(context);
                return testimonialRepository;
            }
        }
        
        /// <summary>
        /// Get/Set Property for CrewTestimonial repository.
        /// </summary>
        public GenericRepository<OfficeAddress> VendorOfficeAddressRepository
        {
            get
            {
                if (this.officeAddressRepository == null)
                    this.officeAddressRepository = new GenericRepository<OfficeAddress>(context);
                return officeAddressRepository;
            }
        }
        
        /// <summary>
        /// Get/Set Property for CrewCategory repository.
        /// </summary>
        public GenericRepository<VendorCategory> VendorCategoryRepository
        {
            get
            {
                if (this.vendorCategoryRepository == null)
                    this.vendorCategoryRepository = new GenericRepository<VendorCategory>(context);
                return vendorCategoryRepository;
            }
        }
        
        /// <summary>
        /// Get/Set Property for CrewViewership repository.
        /// </summary>
        public GenericRepository<Viewership> VendorViewershipRepository
        {
            get
            {
                if (this.viewershipRepository == null)
                    this.viewershipRepository = new GenericRepository<Viewership>(context);
                return viewershipRepository;
            }
        }
        
        /// <summary>
        /// Get/Set Property for Category filters repository.
        /// </summary>
        public GenericRepository<CategoryFilter> FilterRepository
        {
            get
            {
                if (this.filterRepository == null)
                    this.filterRepository = new GenericRepository<CategoryFilter>(context);
                return filterRepository;
            }
        }
        
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //Debug.WriteLine("UnitOfWork is being disposed");
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}