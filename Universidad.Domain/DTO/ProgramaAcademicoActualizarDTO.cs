using System.ComponentModel.DataAnnotations;

namespace Universidad.Domain.DTO
{
    public class ProgramaAcademicoActualizarDTO
    {
        /// <summary>
        /// Identificador único del programa académico.
        /// </summary>
        [Required]
        public int ProgramaAcademicoId { get; set; }

        /// <summary>
        /// Descripción del programa académico.
        /// </summary>
        [Required]
        public string ProgramaAcademicoDescripcion { get; set; }

        /// <summary>
        /// Estado del programa académico (Activo o Inactivo).
        /// </summary>
        [Required]
        public bool ProgramaAcademicoActivo { get; set; }

        /// <summary>
        /// Relación con la tabla TipoProgramaAcademico (clave foránea).
        /// </summary>
        [Required]
        public int TipoProgramaAcademicoId { get; set; }

    }
}
