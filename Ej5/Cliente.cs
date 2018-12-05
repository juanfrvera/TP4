using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    public class Cliente
    {
        #region Definiciones
        public enum Tipo { NoCliente, Cliente, ClienteGold, ClientePlatinum};
        #endregion

        //Variables
        private String iNombre;
        private String iApellido;
        private DateTime iFechaNacimiento;
        private Empleo iEmpleo;
        private Tipo iTipoCliente;
        //Constructores
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
            this.iTipoCliente = Tipo.NoCliente;
        }

        //Propiedades
        public String Nombre { get { return iNombre; } private set { } }
        public String Apellido { get { return iApellido; } private set {} }
        public DateTime FechaNacimiento { get { return iFechaNacimiento; } private set { } }
        public Empleo Empleo { get { return iEmpleo; } private set { } }
        public Tipo TipoCliente { get { return iTipoCliente; } set { iTipoCliente = value; } }
    }
}
