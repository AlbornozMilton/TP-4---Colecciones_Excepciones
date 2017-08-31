using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class FachadaCuentas
    {
        //1 = Caja de Ahorro | 2= Cuenta Corriente
        private CuentasS iCuentas = new CuentasS();

        public CuentasS Cuenta
        {
            get { return this.iCuentas; }
        }
        

        public Cuenta MostrarCuenta(int pCuenta)
        {
            if (pCuenta == 1)//CAJA DE AHORRO
                return this.iCuentas.CajaAhorro;
            else
                return this.iCuentas.CuentaCorriente; //CUENTA CORRIENTE
        }

        public void AcreditarCuenta(int pCuenta, double pMonto)
        {
            if (pCuenta == 1) iCuentas.CajaAhorro.AcreditarSaldo(pMonto); //CAJA DE AHORRO
            else iCuentas.CuentaCorriente.AcreditarSaldo(pMonto); //CUENTA CORRIENTE
        }

        public void DebitarCuenta(int pCuenta, double pMonto)
        {
            if (pMonto <= 0) throw new ExcepcionDeMonto("Monto Inválido. El monto no puede ser cero");
            //si la excecion es lanzada ya no siguen las lineas y la expceion es tratada

            switch (pCuenta)
            {
                case 1://CAHA DE AHORRO
                    {
                        iCuentas.CajaAhorro.DebitarSaldo(pMonto);
                        break;
                    }
                case 2://CUENTA CORRIENTE
                    {
                        iCuentas.CuentaCorriente.DebitarSaldo(pMonto);
                        break;
                    }
            }
        }

        public void Transferir(int pCuenta1, double pMonto)
        {
            if (pMonto <= 0) throw new ExcepcionDeMonto("Monto Inválido. El monto no puede ser cero");
            //si la excecion es lanzada ya no siguen las lineas y la expceion es tratada

            switch (pCuenta1) 
            {
                case 1://TRASFERENCIAS DESDE CAJAHORRO A CUENTA CORRIENTE
                    {
                        this.DebitarCuenta(1,pMonto);
                        this.AcreditarCuenta(2, pMonto);
                        break;
                    }
                case 2://TRASFERENCIAS DESDE CUENTA CORRIENTE A CAJAHORRO 
                    {
                        this.DebitarCuenta(2, pMonto);
                        this.AcreditarCuenta(1, pMonto);
                        break;
                    }
            }
        }
    }
}