using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherControl.Models
{
    public class Nacionalidades
    {
        [Key]
        public int NacionalidadId { get; set; }
        public string Nacionalidad { get; set; }
    }
}
