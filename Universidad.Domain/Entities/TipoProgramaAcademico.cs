namespace Universidad.Domain.Entities
{
    public class TipoProgramaAcademico
    {
        // Propiedad para el identificador del tipo de programa académico
        public int TipoProgramaAcademicoId { get; set; }

        // Propiedad para la descripción del tipo de programa académico
        public string TipoProgramaAcademicoDescripcion { get; set; }

        //Relacion
        public virtual ICollection<ProgramaAcademico> ProgramaAcademicos { get; set; }

    }
}
