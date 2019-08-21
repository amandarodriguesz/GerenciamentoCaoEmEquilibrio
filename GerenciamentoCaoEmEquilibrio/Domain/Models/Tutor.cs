using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoCaoEmEquilibrio.Models
{
    public class Tutor: EntityBase
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

    }
}
