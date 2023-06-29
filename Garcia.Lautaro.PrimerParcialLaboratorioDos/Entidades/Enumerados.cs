using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

/// <summary>
/// Enumerado de los tipos de Vuelos nacionales que puede llegar a haber
/// </summary>
public enum ENacional
{
    Santa_Rosa,
    Bariloche,
    Corrientes,
    Cordoba,
    Jujuy,
    Mendoza,
    Neuquen,
    Posadas,
    Iguazu,
    Salta,
    Santiago_Del_Estero,
    Trelew,
    Tucuman,
    Puerto_Madryn,
    Ushuaia,
}

/// <summary>
/// Enumerado de los tipos de Vuelos internacionales que puede llegar a haber
/// </summary>
public enum EInternacional
{
    Recife,
    Roma,
    Acapulco,
    Miami
}
/// <summary>
/// Enumerado de los tipos de estado que puede llegar a tener un vuelo
/// </summary>
public enum ETipoEstadoVuelo
{ 
    Proximo,
    Despego,
    Finalizado

}
