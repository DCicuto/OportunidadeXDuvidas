using System.Data.Entity;

namespace Models
{
    public class Duvida : DbContext
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDuvida { get; set; }
    }
}
