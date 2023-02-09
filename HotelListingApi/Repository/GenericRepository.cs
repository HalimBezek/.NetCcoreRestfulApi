﻿using HotelListingApi.Data;
using HotelListingApi.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListingDbContext _context;

        public GenericRepository(HotelListingDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Set<T>().Remove((T)entity);

            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);

            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            List<T> data = await _context.Set<T>().ToListAsync();

            return data;
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id is null)
                return null;

            return await _context.Set<T>().FindAsync(id); ;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
