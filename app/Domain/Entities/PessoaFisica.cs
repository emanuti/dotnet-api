using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PessoaFisica : Base
    {
        private DateTime hoje = DateTime.Today;
        public int? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dt_nascimento { get; set; }
        public int nu_sexo { get; set; }
        public bool st_ativo { get; set; }
        
    }
}