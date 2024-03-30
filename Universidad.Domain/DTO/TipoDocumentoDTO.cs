namespace Universidad.Domain.DTO
{
    public class TipoDocumentoDTO
    {
        /// <summary>
        /// Identificador único del tipo de documento.
        /// </summary>
        public int TipoDocumentoId { get; set; }

        /// <summary>
        /// Descripción del tipo de documento (por ejemplo, "Cédula de ciudadanía", "Pasaporte", etc.).
        /// </summary>
        public string TipoDocumentoDescripcion { get; set; }

    }
}
