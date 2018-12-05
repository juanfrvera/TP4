using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public interface IRepositorioUsuarios : IComparer<Usuario>
    {
        void Agregar(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        void Eliminar(String pCodigo);
        IList<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(String pCodigo);
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
    }
}
