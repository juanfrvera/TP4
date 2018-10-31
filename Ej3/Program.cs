using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaUsuarios lista = new ListaUsuarios();
            Usuario us1 = new Usuario("1000", "Heraldo de la Grieta", "hg10@gmail.com");
            Usuario us2 = new Usuario("999", "Coronel Ansaldi", "ansaldi42@hotmail.com");
            Usuario us3 = new Usuario("998", "Sargento Dilatro", "brillantinaEh@hotmail.com");
            lista.ObtenerPorCodigo("ansaldi");
            lista.Agregar(us1);
            lista.Agregar(us2);
            lista.Agregar(us3);
            IList<Usuario> listaOrd = lista.ObtenerOrdenadosPor(new ComparadorCorreo());
            //IList<Usuario> listaOrd = lista.ObtenerTodos();
            foreach (Usuario us in listaOrd)
            {
                Console.WriteLine(us.Codigo+" "+us.NombreCompleto+" "+us.CorreoElectronico);
            }
            Console.ReadKey();
        }
    }
}
