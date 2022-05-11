using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class Enemigo : IMoverse
    {
        public int Vida;
        public int Nivel;
        public void MoverseEjeX()
        {
            Console.WriteLine("El enemigo se mueve en los casilleros del eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("El enemigo se mueve en los casilleros del eje Y");
        }
    }
}
