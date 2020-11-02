using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using blazorapp.Data;

namespace blazorapp.Services
{
    public interface ITesoroService 
    {
        Task<List<Tesoro>> GetAllTesoro (Guid Uid);
        Task<Tesoro> GetTesoro(Guid Tid);
        Task<bool> SetTesoro (Tesoro T);
        Task<Coordinate> GetCoordinate(Guid Tid);
        Task<List<Coordinate>> GetAllCoordinate(Guid Uid);
    }
    public class TesoroService : ITesoroService
    {
        private readonly ApplicationDbContext db;
        public TesoroService(ApplicationDbContext _dbContext)
        {
            db = _dbContext;
        }
        public Task<List<Coordinate>> GetAllCoordinate(Guid Uid)
        {
            List<Coordinate> coordinates = db.Coordinates.Where(c => c.Uid.Equals(Uid)).ToList<Coordinate>();
            return Task.FromResult(coordinates);
        }

        public async Task<List<Tesoro>> GetAllTesoro(Guid Uid)
        {
            List<Tesoro> tesoros = await db.Tesoros.Where(t => t.Uid.Equals(Uid)).ToListAsync<Tesoro>();
            return await Task.FromResult(tesoros);

        }

        public Task<Coordinate> GetCoordinate(Guid Tid)
        {
            Coordinate coordinate = db.Coordinates.Where(c => c.Tid.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(coordinate);
        }

        public Task<Tesoro> GetTesoro(Guid Tid)
        {
            Tesoro tesoro = db.Tesoros.Where(t => t.Id.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(tesoro);
        }

        public Task<bool> SetTesoro(Tesoro T)
        {
            bool status = false;
            try 
            {
                db.Tesoros.Add(T);
                db.SaveChanges();
                status = true;
                
            }catch (Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }
    }
}