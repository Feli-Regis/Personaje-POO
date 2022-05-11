using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    abstract class Personaje : IMoverse
    {
        public string? Nombre;
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public abstract int CalcularDanio();
        public virtual void Atacar()
        {
        }
        public void MoverseEjeX()
        {
            Console.WriteLine($"{Nombre} se mueve en los casilleros del eje X ");
        }
        public void MoverseEjeY()
        {
            Console.WriteLine($"{ Nombre} se mueve en los casilleros del eje Y ");
        }
    }
}
