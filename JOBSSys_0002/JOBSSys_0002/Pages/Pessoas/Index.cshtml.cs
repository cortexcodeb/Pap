using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JOBSSys_0002.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JOBSSys_0002.Pages.Pessoas
{
    public class IndexModel : PageModel
    {
        private readonly JOBSSys_0002.Models.PessoaContext _context;

        public IndexModel(JOBSSys_0002.Models.PessoaContext context)
        {
            _context = context;
        }

        public List<Pessoa> Pessoa;
        public SelectList Cidades;
        public string PessoaCidade { get; set; }

        //public IList<Pessoa> Pessoa { get;set; }

        public async Task OnGetAsync(string searchString, string cidadePessoa)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> buscaCidade = from p in _context.Pessoa
                                            orderby p.Cidade
                                            select p.Cidade;

            var pessoas = from p in _context.Pessoa
                         select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                pessoas = pessoas.Where(s => s.Profissao.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(cidadePessoa))
            {
                pessoas = pessoas.Where(x => x.Cidade == cidadePessoa);
            }
            Cidades = new SelectList(await buscaCidade.Distinct().ToListAsync());
            Pessoa = await pessoas.ToListAsync();
        }
    }
}
