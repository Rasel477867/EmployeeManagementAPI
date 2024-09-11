using EmployeeAPI.Entity.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository.Core
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        public DbSet<T> table
        {
            get
            {
                return _db.Set<T>();
            }
        }
        public virtual async Task Add(T Entity)
        {

            await table.AddAsync(Entity);
            await _db.SaveChangesAsync();
        }

        public virtual async Task Delete(T Entity)
        {
            await Task.Run(() =>
            {
                Entity.IsDeleted = true;
                table.Update(Entity);
                _db.SaveChanges();
            });
            await _db.SaveChangesAsync();

        }

        public virtual async Task<List<T>> GetAll()
        {
            return await table.Where(c => !c.IsDeleted).ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public virtual async Task Update(T Entity)
        {
            await Task.Run(() =>
            {

                table.Update(Entity);

            });
            await _db.SaveChangesAsync();
        }
    }
}
