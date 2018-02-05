using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JOBSSys_0002.Models;

namespace JOBSSys_0002.Pages.Pessoas
{
    public class DeleteModel : PageModel
    {
        private readonly JOBSSys_0002.Models.PessoaContext _context;

        public DeleteModel(JOBSSys_0002.Models.PessoaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa = await _context.Pessoa.SingleOrDefaultAsync(m => m.ID == id);

            if (Pessoa == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa = await _context.Pessoa.FindAsync(id);

            if (Pessoa != null)
            {
                _context.Pessoa.Remove(Pessoa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
