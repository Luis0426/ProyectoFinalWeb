using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Paginas_Enchiladas.DAL;
using Paginas_Enchiladas.Models;

namespace Paginas_Enchiladas.Pages.EnchiladaMaster
{
    public class CreateModel : PageModel
    {
        private readonly Paginas_Enchiladas.DAL.TiendaContext _context;

        public CreateModel(Paginas_Enchiladas.DAL.TiendaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Enchilada Enchilada { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enchiladas.Add(Enchilada);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
