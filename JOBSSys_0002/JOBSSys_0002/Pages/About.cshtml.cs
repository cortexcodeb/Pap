using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBSSys_0002.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public string Message1 { get; set; }

        public void OnGet()
        {
            Message = "Encontre os melhores profissionais num click.";
            Message1 = "O site JOBS dispõe de uma lista de contatos de profissionais autônomos que prestam serviços nas áreas voltadas para " +
                "manutenções residenciais como pintura, elétrica, hidraulica, jardinagem, montagem de móveis e outras.";
        }
    }
}
