using FISCA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FISCA.Infraestructura.Data
{
    public class AplicacionDbContexto : DbContext
    {
        public AplicacionDbContexto(DbContextOptions<AplicacionDbContexto> options) : base(options) { }

<<<<<<< HEAD
        public DbSet<Inscripciones_Asignaturas> InscripcionesAsignaturas { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Numeros_Asignaciones> NumerosAsignaciones { get; set; }
        public DbSet<Cuatrimestre> Cuatrimestres { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }
        public DbSet<PlanEstudio> PlanEstudios { get; set; }
=======
        //DIEGO
        public DbSet<Material_Didactico> materialDidacticos { get; set; }
        public DbSet<Inscripciones_Asignaturas> inscripcionesAsignaturas { get; set; }
        public DbSet<Mensajes> mensajes { get; set; }
        public DbSet<Niveles> niveles { get; set; }
        public DbSet<Numeros_Asignaciones> numeros_Asignaciones { get; set; }
        
        //KENYI
        public DbSet<Asignacion> asignaciones { get; set; }
        public DbSet<Asignatura> asignaturas { get; set; }
        public DbSet<Carrera> carreras { get; set; }
        public DbSet<Cuatrimestre> cuatrimestres { get; set; }
        public DbSet<Docente> docentes { get; set; }
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
<<<<<<< HEAD
            // Configuración adicional de la base de datos si es necesario
=======

            //Inscripciones_Asignatura
            modelBuilder.Entity<Inscripciones_Asignaturas>().HasData(

                new Inscripciones_Asignaturas
                {
                    IdInscripcion = 1,
                    IdAsignatura = 1,
                    IdEstudiante = 1,
                    FechaInscripcion = DateTime.ParseExact("01/02/2024", "dd/MM/yyyy", null),
                    Observaciones = "JAJAJAJA"
                },
                new Inscripciones_Asignaturas
                    {
                        IdInscripcion = 2,
                        IdAsignatura = 2,
                        IdEstudiante = 2,
                        FechaInscripcion = DateTime.ParseExact("01/02/2025", "dd/MM/yyyy", null),
                        Observaciones = "JEJEJEJE"
                }

            );

            //Material_Didactico
            modelBuilder.Entity<Material_Didactico>().HasData(
                new Material_Didactico
                {
                    IdMaterialDidactico = 1,
                    Descripcion = "Hotel 01",
                    Archivo = "Hotel 1 star",
                    CodigoMaterial = 1,
                    FechaSubida = DateTime.ParseExact("01/02/2023", "dd/MM/yyyy", null),
                    IdNumeroAsignacion = 1,
                    IdDocente = 1
                },
                new Material_Didactico
                {
                    IdMaterialDidactico = 2,
                    Descripcion = "Hotel 02",
                    Archivo = "Hotel 2 star",
                    CodigoMaterial = 2,
                    FechaSubida = DateTime.ParseExact("01/02/2023", "dd/MM/yyyy", null),
                    IdNumeroAsignacion = 2,
                    IdDocente = 2
                }
            );

            //Mensaje
            modelBuilder.Entity<Mensajes>().HasData(
                new Mensajes
                {
                    IdMensaje = 1,
                    Remitente = "Juan",
                    Correo = "diego@gmail.com",
                    Remitio = "Pedro",
                    Mensaje = "Anuel AA",
                    FechaEnvio = DateTime.ParseExact("01/02/2026", "dd/MM/yyyy", null),

                },
                 new Mensajes
                 {
                     IdMensaje = 2,
                     Remitente = "Juana",
                     Correo = "die@gmail.com",
                     Remitio = "Pedra",
                     Mensaje = "Anuela AA",
                     FechaEnvio = DateTime.ParseExact("01/02/2027", "dd/MM/yyyy", null),
                 }
            );

            //Niveles
            modelBuilder.Entity<Niveles>().HasData(
                new Niveles
                {
                    IdNivel = 1,
                    NombreNivel = "pollo",
                },
                 new Niveles
                 {
                     IdNivel = 2,
                     NombreNivel = "Gumball",
                 }
            );

            //Numeros_Asignaciones
            modelBuilder.Entity<Numeros_Asignaciones>().HasData(
                new Numeros_Asignaciones
                {
                    IdNumerosAsignaciones = 1,
                    NumeroAsignado = 1,
                    IdDocente = 1
                }
            );

            //KENYI
            //Asignacion
            modelBuilder.Entity<Asignacion>().HasData(
                new Asignacion 
                { 
                    IdAsignacion = 1,
                    Descripcion = "Waos",
                    IdDocente = 1,
                    IdAsignatura = 1,
                    IdGrupo = 1,
                    IdTurno = 1,
                    IdHorario = 1,
                    Estado = "Activo",
                    NumeroAsignacion = 1
                }
            );

            //Asignatura
            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura
                {
                    IdAsignatura = 1,
                    NombreAsignatura = "Analisis Matematico",
                    IdCarrera = 1,
                    IdGrupo = 1,
                    IdCuatrimestre = 1
                }
            );

            //Carrera
            modelBuilder.Entity<Carrera>().HasData(
                new Carrera
                {
                    IdCarrera = 1,
                    NombreCarrera = "Waza"
                }
            );

            //Cuatrimestre
            modelBuilder.Entity<Cuatrimestre>().HasData(
                new Cuatrimestre
                {
                    IdCuatrimestre = 1,
                    NombreCuatrimestre = "Pruebita"
                }
            );

            //Docente
            modelBuilder.Entity<Docente>().HasData(
                new Docente
                {
                   IdDocente = 1,
                   NombresDocente = "Pedro",
                   ApellidosDocente = "Gimenez Garcilazo",
                   CedulaDocente = "72546978",
                   CorreoDocente = "pedro@upla.edu.pe",
                   CelularDocente = "978456123",
                   TelefonoDocente = "064526",
                   DireccionDocente = "Psje. Chifuentes",
                   Estado = 1,
                   Foto = ""
                }
            );
>>>>>>> 41ab709e84eb9b653c1f1d1d60f2ec54779318e1
        }
    }
}
