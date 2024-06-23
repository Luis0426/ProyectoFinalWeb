using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Paginas_Enchiladas.DAL;
using Paginas_Enchiladas.Models;

namespace Paginas_Enchiladas.Pages.EnchiladaMaster
{
    public class EditModel : PageModel
    {
        private readonly Paginas_Enchiladas.DAL.TiendaContext _context;

        public EditModel(Paginas_Enchiladas.DAL.TiendaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enchilada Enchilada { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Enchiladas == null)
            {
                return NotFound();
            }

            var enchilada =  await _context.Enchiladas.FirstOrDefaultAsync(m => m.id_Enchilada == id);
            if (enchilada == null)
            {
                return NotFound();
            }
            Enchilada = enchilada;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Enchilada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnchiladaExists(Enchilada.id_Enchilada))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EnchiladaExists(int id)
        {
            return _context.Enchiladas.Any(e => e.id_Enchilada == id);
        }
    }
}
