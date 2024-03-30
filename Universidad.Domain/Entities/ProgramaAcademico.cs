namespace Universidad.Domain.Entities
{
    public class ProgramaAcademico
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
        public int TipoProgramaAcademicoId { get; set; }

        /// <summary>
        /// Relación con la tabla TipoProgramaAcademico (clave foránea).
        /// </summary>
        public virtual TipoProgramaAcademico TipoProgramaAcademico { get; set; }

        //Relacion
        public virtual ICollection<Matricula> Matriculas { get; set; }

    }
}
