using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class PessoaFisicaDto
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dt_nascimento { get; set; }
        public int nu_sexo { get; set; }
        public bool st_ativo { get; set; }
    }
}