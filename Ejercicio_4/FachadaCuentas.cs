using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class FachadaCuentas
    {

        private CuentasS iCuentas = new CuentasS();

        public Cuenta IngresarACuenta(bool pTipoCuenta)
        {
            if (pTipoCuenta == false)         // caja de ahorro es pTipoCuenta=false
            { return (iCuentas.CajaAhorro); }
            else  //
            { return (iCuentas.CuentaCorriente); }
        }

        public CuentasS MostrarCuentas
        {
            get { return this.iCuentas; }
        }
        
        public void AcreditarCuenta(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.AcreditarSaldo(pSaldo);
        }

        public Boolean DebitarCuenta(Cuenta pCuenta, double pSaldo)
        {
            if (pCuenta.DebitarSaldo(pSaldo))
                return true;
            else
                return false;
        }

        public Boolean Transferir(Cuenta pCuenta1, Cuenta pCuenta2, double pSaldo)
        {
            if (DebitarCuenta(pCuenta1, pSaldo))
            {
                pCuenta2.AcreditarSaldo(pSaldo);
                return true;
            }
            else return false;
        }
    }
}