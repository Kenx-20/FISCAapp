using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
=======
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1

namespace FISCA.Dominio.Entidades
{
    public class Cuatrimestre
    {
<<<<<<< HEAD
        [Key]
        public int IdCuatrimestre { get; set; }
        public string NombreCuatrimestre { get; set; }

=======
        [Key] public int IdCuatrimestre { get; set; }
        public string? NombreCuatrimestre { get; set; }
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
    }
}
