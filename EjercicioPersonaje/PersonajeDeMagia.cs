using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonaje
{
    internal class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre_, int fuerza_, int agilidad_, int magia_)
        {
            Nombre = nombre_;
            Fuerza = fuerza_;
            Agilidad = agilidad_;
            Magia = magia_;
        }
        public PersonajeDeMagia(string nombre_, int fuerza_, int agilidad_)
        {
            Nombre = nombre_;
            Fuerza = fuerza_;
            Agilidad = agilidad_;
            Magia = 60;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia ");
        }
        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }

    }
}
