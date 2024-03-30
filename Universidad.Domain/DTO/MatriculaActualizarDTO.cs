using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Universidad.Domain.DTO
{
    public class MatriculaActualizarDTO
    {
        /// <summary>
        /// Identificador único de la matrícula.
        /// </summary>
        [Required]
        public int MatriculaId { get; set; }

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

        /// <summary>
        /// Indica si el aspirante se matriculó efectivamente.
        /// </summary>
        public bool? MatriculaIngresoEfectivo { get; set; }

    }
}
