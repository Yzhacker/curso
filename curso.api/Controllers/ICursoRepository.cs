using System.Collections.Generic;

namespace curso.api.Controllers
{
    internal interface ICursoRepository
    {
        IEnumerable<object> ObterPorUsuario(int codigoUsuario);
    }
}