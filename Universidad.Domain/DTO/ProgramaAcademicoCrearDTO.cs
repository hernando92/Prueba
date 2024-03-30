using System.ComponentModel.DataAnnotations;

namespace Universidad.Domain.DTO
{
    public class ProgramaAcademicoCrearDTO
    {

        /// <summary>
        /// Código único del programa académico.
        /// </summary>
        [Required]
        public string ProgramaAcademicoCodigo { get; set; }

        /// <summary>
        /// Descripción del programa académico.
        /// </summary>
        [Required]
        public string ProgramaAcademicoDescripcion { get; set; }

        /// <summary>
        /// Relación con la tabla TipoProgramaAcademico (clave foránea).
        /// </summary>
        [Required]
        public int TipoProgramaAcademicoId { get; set; }

    }
}
