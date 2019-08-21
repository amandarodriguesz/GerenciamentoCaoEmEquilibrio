using GerenciamentoCaoEmEquilibrio.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace GerenciamentoCaoEmEquilibrio.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly GerenciamentoCaoEmEquilibrioContext _db;

        public GenericRepository(GerenciamentoCaoEmEquilibrioContext db)
        {
            _db = db;
        }

        public async Task<TEntity> BuscarPorId(int id)
        {
            return await _db.Set<TEntity>().FirstOrDefaultAsync(e =>e.Id == id);
        }

        public async Task Editar(int id, TEntity e)
        {
            e.UpdatedData = DateTime.Now;
            _db.Set<TEntity>().Update(e);
            _db.Entry(e).Property(x => x.CreatedDate).IsModified = false;
            await _db.SaveChangesAsync();
        }

        public async Task Excluir(int id)
        {
            var procura = await BuscarPorId(id);
            _db.Set<TEntity>().Remove(procura);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await _db.Set<TEntity>().AnyAsync(e => e.Id == id);
        }

        public async Task Inserir(TEntity e)
        {
            e.CreatedDate = DateTime.Now;
            await _db.Set<TEntity>().AddAsync(e);
            await _db.SaveChangesAsync();
        }

        public async Task<IList<TEntity>> Listar()
        {
            var query = _db.Set<TEntity>().ToList();

            return await _db.Set<TEntity>().ToListAsync();
        }
    }
}
