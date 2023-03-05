
using LasPepas.Abstracciones;

namespace LasPepas.Repositorio
{
    public interface IRepositorio<T> : ICrud<T> where T : class
    {

    }
}
