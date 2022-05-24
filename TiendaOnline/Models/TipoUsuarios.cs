using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaOnline.Models
{
    public class TipoUsuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int TipoUsuarioId { get; set; }
        public string Tipo { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
