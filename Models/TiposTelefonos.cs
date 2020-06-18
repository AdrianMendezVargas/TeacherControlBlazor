using System.ComponentModel.DataAnnotations;

namespace TeacherControl.Models
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; } 
        public string Descripcion { get; set; }
    }
}
