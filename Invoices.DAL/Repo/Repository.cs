using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Invoices.DAL.Repo
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly DatabaseContext context;
        private readonly DbSet<T> entitySet;
        public Repository(DatabaseContext dbContext)
        {
            context = dbContext;
            entitySet = context.Set<T>();
        }

        //public Repository(DbContextOptions<T> options) : base(options))
        //{

        //}

        

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

        public async Task Update(T entity)
        {
            entitySet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await Save();
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }


        public async Task<T> Find(Expression<Func<T, bool>> expr)
        {
            return await entitySet.AsNoTracking().FirstOrDefaultAsync(expr);
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
