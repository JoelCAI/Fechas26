using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas26
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una Fecha");

            Console.Clear();
            Console.WriteLine("\n La fecha ingresada es: " + fecha.ToLongDateString());
   
            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
