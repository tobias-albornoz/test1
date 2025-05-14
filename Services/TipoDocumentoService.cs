using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test1.Data;
using test1.Models;

namespace test1.Services
{
    public class TipoDocumentoService
    {
        private readonly AppDbContext _context;

        public TipoDocumentoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoDocumento>> GetAllAsync()
        {
            return await _context.TipoDocumento.ToListAsync();
        }

        public async Task<TipoDocumento> GetByIdAsync(int id)
        {
            return await _context.TipoDocumento.FindAsync(id);
        }
    }
}
