using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSSys_0002.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        [Display(Name = "Taxa de Visitação")]
        public string TaxaVisitacao { get; set; }

        [Display(Name = "Avaliação")]
        public string Avaliacao { get; set; }
    }
}
