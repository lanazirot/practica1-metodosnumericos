using System; // Funciones basicas
/// <summary>
/// Namespace principal
/// </summary>
/// <author>
///     Alan Peña Ortiz 19100234 ITNLD
/// </author>
namespace Tipos_de_error {
    /// <summary>
    /// TipoDeErrores
    /// </summary>
    /// <author>Alan Peña Ortiz 19100234</author>
    public class TiposDeError {
        /// <summary>
        /// Propiedad para almacenar el valor aproximado
        /// </summary>
        public double ValorAproximado { get; set; }
        /// <summary>
        /// Propiedad para almacenar el valor verdadero;
        /// </summary>
        public double ValorVerdadero { get; set; }
        /// <summary>
        /// Crear un objeto de tipo TipoDeErrores, para poder hacer
        /// los tres tipos de calculos de error basicos
        /// Error absoluto, relativo, y relativo porcentual
        /// </summary>
        /// <param name="dblValorAproximado">Valor aproximado</param>
        /// <param name="dblValorVerdadero">Valor verdadero</param>
        public TiposDeError(double dblValorAproximado, double dblValorVerdadero) {
            ValorAproximado = dblValorAproximado;
            ValorVerdadero = dblValorVerdadero;
        }
        /// <summary>
        /// Calcular el error absoluto entre dos numeros 
        /// </summary>
        /// <example>
        ///     ValorVerdadero = 10
        ///     ValorAproximado = 9
        ///     CalcularValorAbsoluto() => 1
        /// </example>
        /// <returns>La diferencia absoluta entre dos numeros (float)</returns>
        public double CalcularErrorAbsoluto() => Math.Abs(ValorVerdadero - ValorAproximado);
        /// <summary>
        /// Calcular el error relativo en base a un error absoluto y un valor
        /// verdadero
        /// </summary>
        /// <example>
        ///     ErrorAbsoluto = 1
        ///     ValorVerdadero = 10
        ///     CalcularErrorRelativo() => 0.1
        /// </example>
        /// <see cref="CalcularErrorAbsoluto"/>
        /// <returns>La division entre el error absoluto y valor verdadero</returns>
        public double CalcularErrorRelativo() => CalcularErrorAbsoluto() / ValorVerdadero;
        /// <summary>
        /// Calcular el error relativo porcentual, en base a un error relativo
        /// </summary>
        /// <example>
        ///     ErrorRelativo = 0.1
        ///     CalculaErrorRelativoPorcentual() => 10
        /// </example>
        /// <see cref="CalcularErrorRelativo"/>
        /// <returns>Error relativo porcentual * 100</returns>
        public double CalcularErrorRelativoPorcentual() => CalcularErrorRelativo() * 100;
    }
}
