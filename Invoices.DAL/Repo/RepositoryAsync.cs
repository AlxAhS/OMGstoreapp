using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Invoices.DAL.Repo
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly DatabaseContext context;
        //private readonly DbSet<T> entitySet;
        public RepositoryAsync(DatabaseContext dbContext)
        {
            context = dbContext;
            
        }

        protected DbSet<T> entitySet
        {
            get
            {
                return context.Set<T>();
            }
        }



        public async Task<IEnumerable<T>> GetAll()
        {
            return await entitySet.ToListAsync();
        }

        public async Task<T> GetbyId(int? id)
        {
            return await entitySet.FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            entitySet.Add(entity);
            await Save();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = await entitySet.FindAsync(id);
            entitySet.Remove(entity);
            await Save();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            entitySet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await Save();
            return entity;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }


        public async Task<T> Find(Expression<Func<T, bool>> expr)
        {
            return await entitySet.AsNoTracking().FirstOrDefaultAsync(expr);
        }


        //need to find a way this method doesn't crash the app
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
