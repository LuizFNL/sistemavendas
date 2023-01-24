using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemavendas.Models
{
    public class ItensVenda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ItensModelId { get; set; }
        public virtual ItensModel ItensModel { get; set; }
        public int? VendaModelId { get; set; }
        public bool EmAberto { get; set; }
    }
}