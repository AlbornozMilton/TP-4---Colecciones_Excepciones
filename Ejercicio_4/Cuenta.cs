using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Cuenta
    {
        //atributos............................
        private double iSaldo;
        private double iAcuerdo;
        //Acuerdo: cantidad limite en el que se produce o no el descubierto

        //contructores
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = 0;

        }
        public Cuenta(double pMontoInicial, double pAcuerdo)
        {
            this.iSaldo = pMontoInicial;
            this.iAcuerdo = pAcuerdo;
        }

        //propiedades---------------------------
        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        //metodos-------------------------------

        public void AcreditarSaldo(double pMonto) //EL SALDO ES NEGATIVO O CERO
        {
            this.iSaldo += pMonto;
        }

        //el metodo trabaja con iSaldo negtivo/positivo
        public void DebitarSaldo(double pMonto) 
        {
            if (this.iSaldo >= 0) //saldo positivo--------------------
            {
                if (pMonto > this.iSaldo + this.iAcuerdo)
                {
                    throw new ExcepcionDeMonto("Se produce Descubierto"); ;
                }
                //no se produce descubierto
                this.iSaldo -= pMonto;
            }
            else //saldo negativo---------------------------------------
            {
                // ejemplo de this.iSaldo + this.iAcuerdo: -1000 + 2000 = 1000. 
                // Cuando saldo + acuerdo < 0, significa que lo debitado supera el Acuerdo
                // ejemplo: -3000 + 2000 = -1000 < 0.
                if ((this.iSaldo -= pMonto) + this.iAcuerdo < 0)
                {
                    throw new ExcepcionDeMonto("Se porduce Descubierto");
                }
                //no se produce descubierto
                this.iSaldo -= pMonto;
            }
        }
    }
}