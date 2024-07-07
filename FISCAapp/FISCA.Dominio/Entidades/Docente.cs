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
    public class Docente
    {
<<<<<<< HEAD
        [Key]
        public int IdDocente { get; set; }

        [Required]
        [StringLength(50)]
        public string NombresDocente { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidosDocente { get; set; }

        [Required]
        [StringLength(16)]
        public string CedulaDocente { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoDocente { get; set; }

        [Required]
        [StringLength(8)]
        public string CelularDocente { get; set; }

        [Required]
        [StringLength(8)]
        public string TelefonoDocente { get; set; }

        [Required]
        [StringLength(250)]
        public string DireccionDocente { get; set; }

        [Required]
        public int Estado { get; set; }

        [StringLength(100)]
        public string Foto { get; set; }
=======
        [Key] public int IdDocente { get; set; }
        public string? NombresDocente { get; set; }
        public string? ApellidosDocente { get; set; }
        public string? CedulaDocente { get; set; }
        public string? CorreoDocente { get; set; }
        public string? CelularDocente { get; set; }
        public string? TelefonoDocente { get; set; }
        public string? DireccionDocente { get; set; }
        public int Estado { get; set; }
        public string? Foto { get; set; }
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
    }
}
