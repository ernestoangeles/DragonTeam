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

    }
}