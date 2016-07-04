using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFighter.Models
{
    public class CodeFighterGame
    {
        public int VidaJugador1;
        public int VidaJugador2;
        public int EnergiaJugador1;
        public int EnergiaJugador2;

        public CodeFighterGame()
        {
            VidaJugador1 = 200;
            VidaJugador2 = 200;
            EnergiaJugador1 = 0;
            EnergiaJugador2 = 0;
        }

        public void GolpePuñoJugador1()
        {
            VidaJugador2 = VidaJugador2 - 10;
            EnergiaJugador1 = EnergiaJugador1 + 5;
        }

        public void GolpePuñoJugador2()
        {
            VidaJugador1 = VidaJugador1 - 10;
            EnergiaJugador2 = EnergiaJugador2 + 5;
        }

        public void GolpeEspecialJugador1()
        {
            VidaJugador2 = VidaJugador2 - 30;
            EnergiaJugador1 = 15;
        }

        public void GolpeEspecialJugador2()
        {
            VidaJugador1 = VidaJugador1 - 30;
            EnergiaJugador2 = 15;
        }

        public void Jugador1Curacion()
        {
            VidaJugador1 = VidaJugador1 > 150 ? 200: VidaJugador1 + 50;
            EnergiaJugador1 = 0;
        }

        public void Jugador2Curacion()
        {
            VidaJugador2 = VidaJugador2 > 150 ? 200 : VidaJugador2 + 50;
            EnergiaJugador2 = 0;
        }

        public bool Jugador1GanaPuntajePerfecto()
        {
            return VidaJugador1 == 200 && VidaJugador2 == 0;
        }
        public bool Jugador2GanaPuntajePerfecto()
        {
            return VidaJugador2 == 200 && VidaJugador1 == 0;
        }
    }
}   
