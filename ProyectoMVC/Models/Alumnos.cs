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
        public string Nombres { get; set; }
        [NotNull]
        public string Apellidos { get; set; }
        [NotNull]
        public int Edad { get; set; }
        [NotNull]
        public required string Carnet { get; set; }
        public int CantidadMaterias { get; set; }
        public int Ciclo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        public string NombreCompleto { get; set; }
        #endregion Propiedades

        #region Constructor
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


    



