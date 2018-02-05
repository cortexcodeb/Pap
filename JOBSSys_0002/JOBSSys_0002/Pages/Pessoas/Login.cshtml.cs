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
    public class LoginModel : PageModel
    {
        private readonly JOBSSys_0002.Models.PessoaContext _context;

        public LoginModel(JOBSSys_0002.Models.PessoaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; }

    }
}