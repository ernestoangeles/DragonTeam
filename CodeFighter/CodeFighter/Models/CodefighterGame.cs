﻿using System;
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
    }
}