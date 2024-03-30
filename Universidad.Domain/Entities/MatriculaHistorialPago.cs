namespace Universidad.Domain.Entities
{
    public class MatriculaHistorialPago
    {
        /// <summary>
        /// Identificador único del historial de pago.
        /// </summary>
        public int MatriculaHistorialPagoId { get; set; }

        /// <summary>
        /// Relación con la tabla Matricula (clave foránea).
        /// </summary>
        public int MatriculaId { get; set; }

        /// <summary>
        /// Fecha en la que se realizó el pago.
        /// </summary>
        public DateTime MatriculaFechaPago { get; set; }

        /// <summary>
        /// Valor del pago realizado.
        /// </summary>
        public decimal MatriculaValor { get; set; }

    }
}
