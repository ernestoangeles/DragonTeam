using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class Jugador
    {
        public int Vida { get; set; }
        public int Energia { get; set; }
        public int Nombre { get; set; }

        public Jugador()
        {
            Vida = 200;
            Energia = 0;
        }

        public void GolpePuño(Jugador jugadorGolpeado)
        {
            jugadorGolpeado.Vida -= 10;
            Energia += 5;
        }

        public void GolpePatada(Jugador jugadorGolpeado)
        {
            jugadorGolpeado.Vida = Vida - 20;
            Energia = Energia + 8;
        }

        public void GolpeEspecial(Jugador jugadorGolpeado)
        {
            jugadorGolpeado.Vida = jugadorGolpeado.Vida - 30;
            Energia = 15;
        }

        public void Curacion()
        {
            Vida = Vida > 150 ? 200 : Vida + 50;
            Energia = 0;
        }
    }
}