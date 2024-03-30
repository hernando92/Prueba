using System.ComponentModel.DataAnnotations;

namespace Universidad.Domain.DTO
{
    public class AspiranteCrearDTO
    {

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
        /// Relación con la tabla TipoDocumento (clave foránea).
        /// </summary>
        [Required]
        public int TipoDocumentoId { get; set; }

    }
}
