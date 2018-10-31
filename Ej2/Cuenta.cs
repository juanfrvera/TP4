using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        //Propiedades
        public double Saldo
        {
            get { return this.iSaldo; }
            private set { this.iSaldo = value; }
        }
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            private set { this.iAcuerdo = value; }
        }

        //Constructores
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.Saldo = pSaldoInicial;
            this.Acuerdo = pAcuerdo;
        }

        public Cuenta(double pAcuerdo)
        {
            this.Acuerdo = pAcuerdo;
        }
        //Metodos
        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo >= 0)
                this.Saldo += pSaldo;
            else
                throw new SaldoInvalidoException("El saldo a acreditar no puede ser negativo");
        }

        public void DebitarSaldo(double pSaldo)
        {
            if(pSaldo >= 0)
            {
                if (this.Saldo + this.Acuerdo >= pSaldo)
                {
                    this.Saldo -= pSaldo;
                }
                else
                    throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            else
                throw new SaldoInvalidoException("El saldo a debitar no puede ser negativo");
        }




    }
}
