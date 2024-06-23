using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Paginas_Enchiladas.DAL;
using Paginas_Enchiladas.Models;

namespace Paginas_Enchiladas.Pages.EnchiladaMaster
{
    public class IndexModel : PageModel
    {
        private readonly Paginas_Enchiladas.DAL.TiendaContext _context;

        public IndexModel(Paginas_Enchiladas.DAL.TiendaContext context)
        {
            _context = context;
        }

        public IList<Enchilada> Enchilada { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if(_context.Enchiladas != null)
            {
                Enchilada = await _context.Enchiladas.ToListAsync();
            }
            
        }
    }
}
