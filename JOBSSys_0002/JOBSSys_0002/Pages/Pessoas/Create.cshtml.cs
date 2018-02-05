using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JOBSSys_0002.Models;

namespace JOBSSys_0002.Pages.Pessoas
{
    public class CreateModel : PageModel
    {
        private readonly JOBSSys_0002.Models.PessoaContext _context;

        public CreateModel(JOBSSys_0002.Models.PessoaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pessoa.Add(Pessoa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}