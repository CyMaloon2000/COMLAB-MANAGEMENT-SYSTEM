using CapstoneProj.Model.dbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq.Expressions;
using System.Diagnostics;

namespace CapstoneProj.Model
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal CLMSEntities context;
        internal DbSet<TEntity> dbSet;

        private DbSet<TEntity> privateDbSet;
        public GenericRepository(CLMSEntities context) 
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual void Insert(TEntity entity)
        {

            try
            {
                dbSet.Add(entity);
                Save();
            }
            catch (Exception e)
            {
                throw new Exception("Errors found:" + e.Message + ",  " + e.InnerException.ToString());  
            }

        }

        public virtual void Update(TEntity entity)
        {
            //using (var context2 = new CLMSEntities())
            //{
            //    context2.
            //    // Now, updatedData will contain the latest data from the database
            //}

            CLMSEntities privateContext = new CLMSEntities();
            try
            {
                this.dbSet = privateContext.Set<TEntity>();
                this.dbSet.Attach(entity);
                privateContext.Entry(entity).State = EntityState.Modified;
                privateContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw new ArgumentException("System Encounters Error While Updating Object.");
            }
        }

        public virtual bool Delete(object id)
        {
            try
            {
                TEntity entityToDelete = dbSet.Find(id);
                Delete(entityToDelete);
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw new ArgumentException("System Encounters Error While Deleting Object with id = " + id + ". Please double check if the object Exists.");
            }
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);

            }
            dbSet.Remove(entityToDelete);
            try
            {
                Save();
            }
            catch
            {
                throw new ArgumentException("System Encounters Error While Deleting Object " + entityToDelete.ToString() + ". Please double check if the object Exists.");
            }
        }


        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                try
                {
                    return query;
                }
                catch
                {
                    throw new ArgumentException("Please consider checking the parameters.");
                }
            }
        }

        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int iDisplayStart = 0, int iDisplayLength = 0, string includeProperties = "", string sortProperty = "", string sortOrder = "")
        {
            IEnumerable<TEntity> tEntities = null;

            tEntities = Get(filter: filter, orderBy: orderBy, includeProperties: includeProperties);
            tEntities = GetIEnumerableRange(tEntities, iDisplayStart, iDisplayLength);

            if (!string.IsNullOrEmpty(sortProperty) && !string.IsNullOrEmpty(sortOrder))
            {
                tEntities = Sorter(tEntities, sortProperty, sortOrder);
            }

            return tEntities.ToList();
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
        {
            try
            {
                return Get(filter: filter, includeProperties: includeProperties).SingleOrDefault();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Please check if the object exists." + e.Message);
            }
        }

        public virtual IEnumerable<TEntity> GetIEnumerableRange(IEnumerable<TEntity> tEntities, int iDisplayStart, int iDisplayLength)
        {
            return iDisplayLength > 0 ? tEntities.Skip(iDisplayStart).Take(iDisplayLength) : tEntities;
        }

        public virtual IEnumerable<TEntity> Sorter(IEnumerable<TEntity> tEntities, string sortProperty, string sortOrder)
        {
            var sorter = EntitySorter<TEntity>.OrderBy(sortProperty);

            if (sortProperty.Length > 1 && sortOrder.Equals("desc", StringComparison.OrdinalIgnoreCase))
            {
                sorter = EntitySorter<TEntity>.OrderByDescending(sortProperty);
            }
            return sorter.Sort(tEntities.AsQueryable<TEntity>());

        }

        public void Save()
        {
            context.SaveChanges();
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
        }
    }
}
