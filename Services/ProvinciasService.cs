using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test1.Data;
using test1.Models;

namespace test1.Services
{
    public class ProvinciasService
    {
        private readonly AppDbContext _context;

        public ProvinciasService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Provincias>> GetAllAsync()
        {
            return await _context.Provincias.ToListAsync();
        }

        public async Task<Provincias> GetByIdAsync(int id)
        {
            return await _context.Provincias.FindAsync(id);
        }
    }
}
