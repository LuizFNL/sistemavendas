namespace sistemavendas.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public virtual ICollection<ItensVenda> ItensVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
    }
}