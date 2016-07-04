using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterGame
    {
        public Jugador Jugador1 { get; set; }
        public Jugador Jugador2 { get; set; }

        public CodeFighterGame()
        {
            Jugador1 = new Jugador();
            Jugador2 = new Jugador();
        }

        public void GolpePuñoJugador1()
        {
            Jugador1.GolpePuño(Jugador2);
        }

        public void GolpePuñoJugador2()
        {
            Jugador2.GolpePuño(Jugador1);
        }

        public void GolpePatadaJugador1()
        {
            Jugador1.GolpePatada(Jugador2);
        }

        public void GolpePatadaJugador2()
        {
            Jugador2.GolpePatada(Jugador1);
        }

        public void GolpeEspecialJugador1()
        {
            Jugador1.GolpeEspecial(Jugador2);
        }

        public void GolpeEspecialJugador2()
        {
            Jugador2.GolpeEspecial(Jugador1);
        }

        public void Jugador1Curacion()
        {
            Jugador1.Curacion();
        }

        public void Jugador2Curacion()
        {
            Jugador2.Curacion();
        }

        public bool Jugador1GanaPuntajePerfecto()
        {
            return Jugador1.Vida == 200 && Jugador2.Vida == 0;
        }
        public bool Jugador2GanaPuntajePerfecto()
        {
            return Jugador2.Vida == 200 && Jugador1.Vida == 0;
        }
    }
}   
