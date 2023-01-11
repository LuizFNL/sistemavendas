using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistemavendas.Models
{
    public class CarrinhoModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        [ForeignKey("ItemId")]
        public int ItensModelId { get; set; }
        public virtual ItensModel ItensModel { get; set; }
    }
}