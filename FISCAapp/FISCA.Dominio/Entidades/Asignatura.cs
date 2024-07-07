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
    public class Asignatura
    {
<<<<<<< HEAD
        [Key]
        public int IdAsignatura { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreAsignatura { get; set; }

        [Required]
        public int IdCarrera { get; set; }

        [Required]
        public int IdGrupo { get; set; }

        [Required]
        public int IdCuatrimestre { get; set; }

=======
        [Key] public int IdAsignatura { get; set; }
        public string? NombreAsignatura { get; set; }
        public int IdCarrera { get; set; }
        public int IdGrupo { get; set; }
        public int IdCuatrimestre { get; set; }
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
    }
}
