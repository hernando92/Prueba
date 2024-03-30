using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Universidad.Domain.Entities;

namespace Universidad.Domain.DTO
{
    public class MatriculaCrearDTO
    {
        /// <summary>
        /// Relación con la tabla Aspirante (clave foránea).
        /// </summary>
        [Required]
        public int AspiranteId { get; set; }

        /// <summary>
        /// Relación con la tabla ProgramaAcademico (clave foránea).
        /// </summary>
        [Required]
        public int ProgramaAcademicoId { get; set; }

        /// <summary>
        /// Indica si el aspirante se matriculó efectivamente.
        /// </summary>
        public bool? MatriculaIngresoEfectivo { get; set; }

        /// <summary>
        /// Semestre actual en el cual ingresaría el aspirante.
        /// </summary>
        [Range(1, 12)]
        public int MatriculaSemestreActual { get; set; }

        /// <summary>
        /// Valor inicial del semestre (opcional).
        /// </summary>
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? MatriculaValorSemestre { get; set; }

    }
}
