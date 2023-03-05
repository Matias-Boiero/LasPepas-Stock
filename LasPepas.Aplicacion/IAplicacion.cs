using LasPepas.Abstracciones;

namespace LasPepas.Aplicacion
{
    public interface IAplicacion<T> : ICrud<T> where T : class
    {

    }
}
