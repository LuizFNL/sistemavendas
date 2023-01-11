using System;
using sistemavendas.Enums;
using System.ComponentModel.DataAnnotations;

namespace sistemavendas.Models
{
    public class ItensModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? URLImagemItem { get; set; }
        public TipoItemEnum Tipo { get; set; }
        public decimal Preco { get; set; }

    }
}