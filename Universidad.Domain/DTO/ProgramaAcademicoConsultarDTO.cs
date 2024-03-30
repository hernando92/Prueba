using Universidad.Domain.Entities;

namespace Universidad.Domain.DTO
{
    public class ProgramaAcademicoConsultarDTO
    {
        /// <summary>
        /// Identificador único del programa académico.
        /// </summary>
        public int ProgramaAcademicoId { get; set; }

        /// <summary>
        /// Código único del programa académico.
        /// </summary>
        public string ProgramaAcademicoCodigo { get; set; }

        /// <summary>
        /// Descripción del programa académico.
        /// </summary>
        public string ProgramaAcademicoDescripcion { get; set; }

        /// <summary>
        /// Estado del programa académico (Activo o Inactivo).
        /// </summary>
        public bool ProgramaAcademicoActivo { get; set; }

        /// <summary>
        /// Relación con la tabla TipoProgramaAcademico (clave foránea).
        /// </summary>
        public virtual TipoProgramaAcademicoDTO TipoProgramaAcademico { get; set; }

    }
}
