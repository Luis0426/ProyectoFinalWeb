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
    public class DeleteModel : PageModel
    {
        private readonly Paginas_Enchiladas.DAL.TiendaContext _context;

        public DeleteModel(Paginas_Enchiladas.DAL.TiendaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enchilada Enchilada { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enchilada = await _context.Enchiladas.FirstOrDefaultAsync(m => m.id_Enchilada == id);

            if (enchilada == null)
            {
                return NotFound();
            }
            else
            {
                Enchilada = enchilada;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var enchilada = await _context.Enchiladas.FindAsync(id);
            if (enchilada != null)
            {
                Enchilada = enchilada;
                _context.Enchiladas.Remove(Enchilada);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
