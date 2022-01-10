using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Operacao : Base
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int tipo_id { get; set; }
        public bool st_ativo { get; set; }
    }
}