using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre_, int agilidad_, int magia_)
        {
            Nombre = nombre_;
            Agilidad = agilidad_;
            Magia = magia_;
            Fuerza = 100;
        }
        public override int CalcularDanio()
        {
            return Fuerza * 2 + Magia * 2 * Agilidad;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño ");
        }
    }
}
