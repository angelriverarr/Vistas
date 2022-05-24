using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class Municipios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MunicipioId { get; set; }
        public string Nombre { get; set; }

        public ICollection <Clientes> Clientes { get; set; }
        public ICollection<Empleados> Empleados { get; set; }
        public ICollection<Proveedores> Proveedores { get; set; }
    }
}
