using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class OperacaoDto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int tipo_id { get; set; }
        public bool st_ativo { get; set; }
    }
}