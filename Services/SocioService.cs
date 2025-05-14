using System.Collections.Generic;
using System.Threading.Tasks;
using test1.Data;
using test1.Models;
using Microsoft.EntityFrameworkCore;

namespace test1.Services
{
    public class SocioService
    {
        private readonly AppDbContext _context;

        public SocioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CrearSocioAsync(Socio socio)
        {
            _context.Socio.Add(socio);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Socio>> ObtenerSociosAsync()
        {
            return await _context.Socio.ToListAsync();
        }

        public async Task<Socio> ObtenerSocioPorIdAsync(int id)
        {
            return await _context.Socio.FindAsync(id);
        }
    }
}
