using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class ListaUsuarios : IRepositorioUsuarios
    {
        private IDictionary<String, Usuario> lista;

        /// <summary>
        /// Constructor
        /// </summary>
        public ListaUsuarios()
        {
            this.lista = new SortedDictionary<String, Usuario>();
        }
        /// <summary>
        /// Actualiza el elemento de la lista cuya clave es el codigo de pUsuario
        /// </summary>
        /// <param name="pUsuario"></param>
        public void Actualizar(Usuario pUsuario)
        {
            lista[pUsuario.Codigo] = pUsuario;
        }

        public void Agregar(Usuario pUsuario)
        {
            lista.Add(pUsuario.Codigo, pUsuario);
        }

        /// <summary>
        /// Compara segun la comparacion por defecto que implementa Usuario
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Usuario x, Usuario y)
        {
            return x.CompareTo(y);
        }

        public void Eliminar(string pCodigo)
        {
            lista.Remove(pCodigo);
        }
        /// <summary>
        /// Devuelve una lista ordenandola segun la comparacion pasada como parametro
        /// </summary>
        /// <param name="pComparador"></param>
        /// <returns></returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ordenada = lista.Values.ToList<Usuario>();
            ordenada.Sort(pComparador);
            return ordenada;
        }
        /// <summary>
        /// Devuelve el elemento cuya clave sea pCodigo
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return lista[pCodigo];
        }

        public IList<Usuario> ObtenerTodos()
        {
            return lista.Values.ToList<Usuario>();
        }
    }
}
