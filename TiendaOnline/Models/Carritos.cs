using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOnline.Models
{
    public class Carritos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarritoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ArticuloID { get; set; }
        public Articulos Articulo { get; set; }

        public int ClienteID { get; set; }
        public Clientes Cliente { get; set; }
    }
}
