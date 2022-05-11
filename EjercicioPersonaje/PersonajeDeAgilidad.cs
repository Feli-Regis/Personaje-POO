using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre_, int fuerza_, int agilidad_, int magia_)
        {
            Nombre = nombre_;   
            Fuerza = fuerza_;   
            Agilidad = agilidad_;
            Magia = magia_; 
        }
        public override int CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño ");
        }
    }
}
