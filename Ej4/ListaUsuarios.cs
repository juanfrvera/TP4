using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej3;

namespace Ej4
{
    public class ListaUsuarios : IRepositorioUsuarios
    {
        IList<Usuario> lista;

        public ListaUsuarios()
        {
            this.lista = new List<Usuario>();
        }

        public void Actualizar(Usuario pUsuario)
        {
            try
            {
                lista[ObtenerPorCodigoIndice(pUsuario.Codigo)] = pUsuario;
            }
            catch (CodigoNoEncontradoException)
            {
                throw;
            }
        }
        //Chequear si ese codigo ya esta en la lista o no?
        public void Agregar(Usuario pUsuario)
        {
            try
            {
                ObtenerPorCodigo(pUsuario.Codigo);
                throw new CodigoRepetidoException();
            }
            catch (CodigoNoEncontradoException)
            {
                lista.Add(pUsuario);
            }
        }

        public int Compare(Usuario x, Usuario y)
        {
            return x.CompareTo(y);
        }

        public void Eliminar(string pCodigo)
        {
            try
            {
                lista.RemoveAt(ObtenerPorCodigoIndice(pCodigo));
            }
            catch (CodigoNoEncontradoException)
            {
                throw;
            }
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ordenada = (List<Usuario>)lista;
            ordenada.Sort(pComparador);
            return ordenada;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            try
            {
                int indice = ObtenerPorCodigoIndice(pCodigo);
                return lista[indice];
            }
            catch (CodigoNoEncontradoException)
            {
                throw;
            }
        }
        /// <summary>
        /// Usado internamente, si no lo encuentra tira una CodigoNoEncontradoException
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <returns></returns>
        private int ObtenerPorCodigoIndice(string pCodigo)
        {
            bool encontrado = false;
            int i = 0;
            while (!encontrado && i < lista.Count)
            {
                if (lista[i].Codigo == pCodigo)
                    encontrado = true;
                else
                    i++;
            }
            if (encontrado) return i;
            else throw new CodigoNoEncontradoException();
        }

        public IList<Usuario> ObtenerTodos()
        {
            return (List<Usuario>)lista;
        }

        public IList<Usuario> ObtenerAproximado(String pNombreCompleto)
        {
            IList < Usuario > resultado = new List<Usuario>();
            ObtenerAproximado(lista, pNombreCompleto, resultado );
            return resultado;
        }
        /// <summary>
        /// Realiza una copia defensiva de cada usuario devuelto en la lista
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        private void ObtenerAproximado(IList<Usuario> pListaTemp, String pNombre, IList<Usuario> pListaSal)
        {
            IList<Usuario> usuariosAprox = new List<Usuario>();
            if (pNombre.Length > 3)
            {
                foreach (Usuario us in pListaTemp)
                {
                    if (us.NombreCompleto.Contains(pNombre))
                        usuariosAprox.Add(us);
                }
                foreach (Usuario us in usuariosAprox)
                {
                    pListaTemp.Remove(us);
                    pListaSal.Add(new Usuario(us.Codigo, us.NombreCompleto, us.CorreoElectronico));
                }
                ObtenerAproximado(pListaTemp, pNombre.Substring(0, pNombre.Length - 1), pListaSal);
            }
            else
            {
                foreach (Usuario us in pListaTemp)
                {
                    if (us.NombreCompleto.Contains(pNombre))
                        pListaSal.Add(new Usuario(us.Codigo, us.NombreCompleto, us.CorreoElectronico));
                }
            }
        }
    }
}