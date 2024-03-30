using System.ComponentModel.DataAnnotations;

namespace Universidad.Domain.DTO
{
    public class AspiranteActualizarDTO
    {
        /// <summary>
        /// Identificador único del aspirante.
        /// </summary>
        [Required]
        public int AspiranteId { get; set; }

        /// <summary>
        /// Documento de identidad del aspirante.
        /// </summary>
        [Required]
        public string AspiranteDocumentoIdentidad { get; set; }

        /// <summary>
        /// Nombres del aspirante.
        /// </summary>
        [Required]
        public string AspiranteNombre { get; set; }

        /// <summary>
        /// Apellidos del aspirante.
        /// </summary>
        [Required]
        public string AspiranteApellido { get; set; }

        /// <summary>
        /// Número de celular del aspirante (opcional).
        /// </summary>
        public string AspiranteCelular { get; set; }

        /// <summary>
        /// Correo electrónico del aspirante (opcional).
        /// </summary>
        [EmailAddress]
        public string AspiranteCorreo { get; set; }

        /// <summary>
        /// Indica si el aspirante está activo o inactivo.
        /// </summary>
        [Required]
        public bool AspiranteActivo { get; set; }

        /// <summary>
        /// Relación con la tabla TipoDocumento (clave foránea).
        /// </summary>
        [Required]
        public int TipoDocumentoId { get; set; }

    }
}
