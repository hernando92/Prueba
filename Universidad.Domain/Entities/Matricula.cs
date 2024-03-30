namespace Universidad.Domain.Entities
{
    public class Matricula
    {
        /// <summary>
        /// Identificador único de la matrícula.
        /// </summary>
        public int MatriculaId { get; set; }

        /// <summary>
        /// Fecha de registro de la matrícula del aspirante.
        /// </summary>
        public DateTime MatriculaFechaRegistro { get; set; }

        /// <summary>
        /// Semestre actual en el cual ingresaría el aspirante.
        /// </summary>
        public int MatriculaSemestreActual { get; set; }

        /// <summary>
        /// Valor inicial del semestre (opcional).
        /// </summary>
        public decimal? MatriculaValorSemestre { get; set; }

        /// <summary>
        /// Indica si el aspirante se matriculó efectivamente.
        /// </summary>
        public bool? MatriculaIngresoEfectivo { get; set; }

        /// <summary>
        /// Relación con la tabla Aspirante (clave foránea).
        /// </summary>
        public int AspiranteId { get; set; }

        /// <summary>
        /// Relación con la tabla ProgramaAcademico (clave foránea).
        /// </summary>
        public int ProgramaAcademicoId { get; set; }

        /// <summary>
        /// Aspirante asociado a esta matrícula.
        /// </summary>
        public virtual Aspirante Aspirante { get; set; }

        /// <summary>
        /// Programa Academico asociado a esta matrícula.
        /// </summary>
        public virtual ProgramaAcademico ProgramaAcademico { get; set; }

    }
}
