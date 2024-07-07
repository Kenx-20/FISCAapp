using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISCA.Dominio.Entidades
{
    public class Asignacion
    {
<<<<<<< HEAD
        [Key]
        public int IdAsignacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public int IdDocente { get; set; }

        [Required]
        public int IdAsignatura { get; set; }

        [Required]
        public int IdGrupo { get; set; }

        [Required]
        public int IdTurno { get; set; }

        [Required]
        public int IdHorario { get; set; }

        [Required]
        [StringLength(11)]
        public string Estado { get; set; }

        [Required]
        public int NumeroAsignacion { get; set; }

        
=======
        [Key] public int IdAsignacion { get; set; }
        public string? Descripcion { get; set; }
        public int IdDocente { get; set; }
        public int IdAsignatura { get; set; }
        public int IdGrupo { get; set; }
        public int IdTurno { get; set; }
        public int IdHorario { get; set; }
        public string? Estado { get; set; }
        public int NumeroAsignacion { get; set; }
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
    }
}
