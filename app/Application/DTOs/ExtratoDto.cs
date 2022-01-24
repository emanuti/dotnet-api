using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ExtratoDto
    {
        public string agencia { get; set; }
        public string conta_corrente { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
    }
}