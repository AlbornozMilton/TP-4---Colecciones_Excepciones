using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCuentas iFachada = new FachadaCuentas();
            byte iOpcion;

            //Menú
            do
            {
                Console.Clear();
                Console.WriteLine("MOVIMIENTOS BANCARIOS");
                MostrarCuentas(iFachada);
                Console.WriteLine();
                Console.WriteLine("OPERACIONES ");
                Console.WriteLine("1- Acreditar ");
                Console.WriteLine("2- Debitar");
                Console.WriteLine("3- Transferir");
                Console.WriteLine("4- Salir");

                iOpcion = Convert.ToByte(Console.ReadLine());
                switch (iOpcion)
                {
                    case 1://Acreditar
                        {
                            Console.WriteLine("Antes de realizar la operación, eliga la cuenta.");
                            Console.WriteLine("1- Caja de Ahorro");
                            Console.WriteLine("2- Cuenta Corriente ");
                            iOpcion = Convert.ToByte(Console.ReadLine());
                            try
                            {
                                if (iOpcion == 1)
                                {
                                    AcreditarCuenta(iFachada, 1); // 1 = caja de ahorro
                                }
                                else if (iOpcion == 2)
                                {
                                    AcreditarCuenta(iFachada, 2); // 2 = cuenta corriente
                                }
                            }
                            catch (ExcepcionDeMonto pE)
                            {
                                Console.WriteLine(pE.Message);
                            }

                            MostrarCuentas(iFachada);

                            break;
                        }
                    case 2: //Debitar
                        {
                            Console.WriteLine("Antes de realizar la operación, eliga la cuenta.");
                            Console.WriteLine("1- Caja de Ahorro");
                            Console.WriteLine("2- Cuenta Corriente ");
                            iOpcion = Convert.ToByte(Console.ReadLine());

                            try
                            {
                                if (iOpcion == 1)
                                {
                                    DebitarCuenta(iFachada, 1); // 1 = caja de ahorro
                                }
                                else if (iOpcion == 2)
                                {
                                    DebitarCuenta(iFachada, 2); // 2 =cuenta corriente
                                }
                            }
                            catch (ExcepcionDeMonto pE)
                            {
                                Console.WriteLine(pE.Message);
                                Console.ReadKey();
                            }
                            MostrarCuentas(iFachada);

                            break;
                        }
                    case 3: //transferir
                        {
                            Console.WriteLine("¿Desde qué Cuenta transferir?");
                            Console.WriteLine("1- Caja de Ahorro a Cuenta Corriente");
                            Console.WriteLine("2- Cuenta Corriente a Caja de Ahorro");
                            iOpcion = Convert.ToByte(Console.ReadLine());

                            Console.WriteLine("Ingrese Monto: ");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());

                            try
                            {
                                if (iOpcion == 1)
                                {
                                    iFachada.Transferir(1, iSaldo);
                                }
                                else if (iOpcion == 2)
                                {
                                    iFachada.Transferir(2, iSaldo);
                                }
                                MostrarCuentas(iFachada);
                            }
                            catch (ExcepcionDeMonto pE)
                            {
                                Console.WriteLine(pE.Message);
                                Console.ReadKey();
                            }

                            break;
                        }

                } //fin switch 2

            } while (iOpcion != 4);

        } //fin de Main

        //Métodos del Program

        private static void MostrarCuentas(FachadaCuentas mFachada)
        {
            //    Console.Clear();
            Console.WriteLine();
            Console.WriteLine("ESTADO ACTUAL");
            Console.WriteLine("Propietario: " + mFachada.Cuenta.Cliente.Nombre);
            Console.WriteLine("CAJA DE AHORRO");
            Console.WriteLine("Saldo: " + mFachada.Cuenta.CajaAhorro.Saldo);
            Console.WriteLine("Acuerdo: " + mFachada.Cuenta.CajaAhorro.Acuerdo);
            Console.WriteLine("CUENTA CORRIENTE");
            Console.WriteLine("Saldo: " + mFachada.Cuenta.CuentaCorriente.Saldo);
            Console.WriteLine("Acuerdo: " + mFachada.Cuenta.CuentaCorriente.Acuerdo);
        }

        private static void AcreditarCuenta(FachadaCuentas pF, int pCuenta)
        {
            try
            {
                Console.WriteLine("Ingrese monto a ACREDITAR:");
                int iSaldo = Convert.ToInt32(Console.ReadLine());
                pF.AcreditarCuenta(pCuenta, iSaldo);
                Console.WriteLine("Saldo Acreditado");         
            }

            catch (FormatException) //EL USUARIO INGRESA CADENA DE STRING O CADENAS QUE NO SON CONVERTIBLES A DOUBLE
            {
                Console.WriteLine("Ingrese Monto Correcto");
            }
        }

        private static void DebitarCuenta(FachadaCuentas pF, int pCuenta)
        {
            try
            {
                Console.WriteLine("Ingrese monto a DEBITAR:");
                int iSaldo = Convert.ToInt32(Console.ReadLine());
                pF.DebitarCuenta(pCuenta, iSaldo);
            }
            catch (FormatException) //EL USUARIO INGRSA CADENA DE STRING O CADENAS QUE NO SON CONVERTIBLES A DOUBLE
            {
                Console.WriteLine("Ingrese Monto Correcto");
            }
        }
    }//fin de Program
}