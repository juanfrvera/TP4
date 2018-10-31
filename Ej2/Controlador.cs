using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Controlador
    {
        private static Cuentas cCuentas;

        // M

        private static void Inicializar(Cliente.TipoDocumento pTipoDocumento, string pNumeroDoc, string pNombre)
        {
            cCuentas = new Cuentas(new Cliente(pTipoDocumento, pNumeroDoc, pNombre));
        }
        public static void Inicializar()
        {
            Inicializar(Cliente.TipoDocumento.DNI, "38456932", "Traitar");
        }

        public static double ConsultarSaldoCC()
        {
            return cCuentas.CuentaCorriente.Saldo;
        }
        public static double ConsultarSaldoCA()
        {
            return cCuentas.CajaAhorro.Saldo;
        }

        public static void AcreditarSaldoCC(double pSaldo)
        {
            cCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
        }
        public static void DebitarSaldoCC(double pSaldo)
        {
            cCuentas.CuentaCorriente.DebitarSaldo(pSaldo);
        }
        public static void AcreditarSaldoCA(double pSaldo)
        {
            cCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
        }
        public static void DebitarSaldoCA(double pSaldo)
        {
           cCuentas.CajaAhorro.DebitarSaldo(pSaldo);
        }
        

        private static void Transferencia(Cuenta pCuentaOrigen, Cuenta pCuentaDestino, double pSaldo)
        {
            pCuentaOrigen.DebitarSaldo(pSaldo);

            pCuentaDestino.AcreditarSaldo(pSaldo);
        }

        public static void TransferenciaCorrienteACaja(double pSaldo)
        {
            Transferencia(cCuentas.CuentaCorriente, cCuentas.CajaAhorro, pSaldo);
        }

        public static void TransferenciaCajaACorriente(double pSaldo)
        {
             Transferencia(cCuentas.CajaAhorro, cCuentas.CuentaCorriente, pSaldo);
        }

    }
}
