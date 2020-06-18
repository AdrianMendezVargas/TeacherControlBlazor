using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherControl.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Range(minimum:1, maximum:10,ErrorMessage ="Seleccione un semestre")]
        public int Semestre { get; set; }

        public int NacionalidadId { get; set; }

        [ForeignKey("NacionalidadId")]
        public virtual Nacionalidades Nacionalidad { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual List<EstudiantesDetalle> EstudiantesDetalle { get; set; } = new List<EstudiantesDetalle>();

    }

    public class EstudiantesDetalle
    {
        [Key]
        public int  Id { get; set; }
 
        public int EstudianteId { get; set; }
      
        public int TipoId { get; set; }

        [ForeignKey("TipoId")]
        public TiposTelefonos TipoTelefono { get; set; }

        public string Telefono { get; set; }

    }
}
