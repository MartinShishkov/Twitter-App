using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private DbContext dbContext;
        private IDbSet<T> set;

        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.set = dbContext.Set<T>();
        }

        public IDbSet<T> Set
        {
            get { return this.set; }
        }

        public IQueryable<T> All()
        {
            return this.set;
        }

        public T Find(object id)
        {
            return this.set.Find(id);
        }

        public void Add(T entity)
        {
            this.ChangeState(entity, EntityState.Added);
        }

        public void Update(T entity)
        {
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Remove(T entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public T Remove(object id)
        {
            var entity = this.Find(id);
            this.Remove(entity);
            return entity;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private void ChangeState(T entity, EntityState state)
        {
            var entry = this.dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }
    }
}
