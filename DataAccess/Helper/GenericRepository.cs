using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Helper
{
    public class GenericRepository<T> where T: class
    {
        private EventsoEntities context;

        private DbSet<T> dbSet;

        public GenericRepository(EventsoEntities context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            try
            {
                if(entity!=null)
                {
                    T newEntity = dbSet.Add(entity);
                    dbSet.Attach(newEntity);
                    context.Entry(newEntity).State = EntityState.Added;
                    return newEntity;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public virtual bool Remove(int id)
        {
            try
            {
                if(id > 0)
                {
                    T entity = dbSet.Find(id);
                    if (entity != null)
                    {
                        return Remove(entity);
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual bool Remove(T entity)
        {
            try
            {
                if (context.Entry(entity).State == EntityState.Detached)
                    dbSet.Attach(entity);
                dbSet.Remove(entity);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public virtual bool Update(T entity)
        {
            try
            {
                if (entity != null)
                {
                    dbSet.Attach(entity);
                    context.Entry(entity).State = EntityState.Modified;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual IEnumerable<T> Get()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public virtual T Find(int id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// generic method to get many record on the basis of a condition.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetMany(Func<T, bool> where)
        {
            try
            {
                if (where != null)
                    return dbSet.Where(where).ToList();
                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }

        // <summary>
        /// generic method to get many record on the basis of a condition but query able.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetManyQueryable(Func<T, bool> where)
        {
            try
            {
                if (where != null)
                    return dbSet.Where(where).AsQueryable();
                return null;
            }
            catch (Exception)
            {
                return null; 
            }
        }

        /// <summary>
        /// generic get method , fetches data for the entities on the basis of condition.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T FirstOrDefault(Func<T, bool> predicate)
        {
            try
            {
                if (predicate != null)
                    return dbSet.Where(predicate).FirstOrDefault();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// generic delete method , deletes data for the entities on the basis of condition.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual void Remove(Func<T, bool> predicate)
        {
            try
            {
                if (predicate != null)
                {
                    IQueryable<T> objects = dbSet.Where(predicate).AsQueryable();
                    foreach (T obj in objects)
                        Remove(obj);
                }
            }
            catch(Exception)
            { }
        }

        /// <summary>
        /// Generic method to check if entity exists
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public bool Exists(object primaryKey)
        {
            try
            {
                if (primaryKey != null)
                    return dbSet.Find(primaryKey) != null;
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a single record by the specified criteria (usually the unique identifier)
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single record that matches the specified criteria</returns>
        public T Single(Func<T, bool> predicate)
        {
            try
            {
                if (predicate != null)
                    return dbSet.Single(predicate);
                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// The first record matching the specified criteria
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single record containing the first record matching the specified criteria</returns>
        public T First(Func<T, bool> predicate)
        {
            try
            {
                if (predicate != null)
                    return dbSet.First<T>(predicate);
                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
