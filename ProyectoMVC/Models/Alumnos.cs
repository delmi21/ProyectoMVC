using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoMVC.Models
{
    public class Alumnos : BaseModel
    {
        #region Propiedades
        [Key]
        public int AlumnoId { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Name es requerido.")]
        public string Nombres { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Apellido es requerido.")]
        public string Apellidos { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Edad es requerido.")]
        public int Edad { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Carnet es requerido.")]
        public  string Carnet { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Materias es requeridod.")]
        public int? CantidadMaterias { get; set; }
        [Required(ErrorMessage = "Ciclo es requerido.")]
        public int? Ciclo { get; set; }
        [Required(ErrorMessage = "FechaNacimiento es requerido.")]
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        public string? NombreCompleto { get; set; }
        #endregion Propiedades

        #region Constructor
        public Alumnos()
        {
            FechaNacimiento = DateTime.Now.Date;
            IsActive = true;
            Created = DateTime.Now;
            CreatedBy = "ADMIN";

        }
        public Alumnos(string nombres, string apellidos, int edad, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            FechaNacimiento = fechaNacimiento;
            NombreCompleto = $"{Nombres} {Apellidos}";
        }
            #endregion Constructor

            #region Funciones 
            public bool EsMayorDeEdad()
            {
                return Edad > 18;
            }
            #endregion
        }
    }


    



