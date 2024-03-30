namespace Universidad.Domain.DTO
{
    public class AspiranteConsultarDTO
    {
        /// <summary>
        /// Identificador único del aspirante.
        /// </summary>
        public int AspiranteId { get; set; }

        /// <summary>
        /// Documento de identidad del aspirante.
        /// </summary>
        public string AspiranteDocumentoIdentidad { get; set; }

        /// <summary>
        /// Nombres del aspirante.
        /// </summary>
        public string AspiranteNombre { get; set; }

        /// <summary>
        /// Apellidos del aspirante.
        /// </summary>
        public string AspiranteApellido { get; set; }

        /// <summary>
        /// Número de celular del aspirante (opcional).
        /// </summary>
        public string AspiranteCelular { get; set; }

        /// <summary>
        /// Correo electrónico del aspirante (opcional).
        /// </summary>
        public string AspiranteCorreo { get; set; }

        /// <summary>
        /// Indica si el aspirante está activo o inactivo.
        /// </summary>
        public bool AspiranteActivo { get; set; }

        /// <summary>
        /// Relación con la tabla TipoDocumento (clave foránea).
        /// </summary>
        public virtual TipoDocumentoDTO TipoDocumento { get; set; }

    }
}
