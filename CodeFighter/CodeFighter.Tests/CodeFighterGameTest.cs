using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFighter.Models;

namespace CodeFighter.Tests
{
    [TestClass]
    public class CodeFighterGameTest
    {
        CodeFighterGame game;
        [TestInitialize]
        public void Setup()
        {
            game = new CodeFighterGame();
        }

        #region golpe puño
        [TestMethod]
        public void Jugador1GolpePuñoJugador2Menos10Vida()
        {
            //arrange
            //act
            game.GolpePuñoJugador1();
            var vida = game.VidaJugador2;
            //assert
            Assert.AreEqual(190, vida);
        }

        [TestMethod]
        public void Jugador2GolpePuñoJugador1Menos10Vida()
        {
            //arrange
            //act
            game.GolpePuñoJugador2();
            var vida = game.VidaJugador1;
            //assert
            Assert.AreEqual(190, vida);
        }

        [TestMethod]
        public void Jugador1GolpePuñoGana5DeEnergia()
        {
            //arrange
            //act
            game.GolpePuñoJugador1();
            var energia1 = game.EnergiaJugador1;
            //assert
            Assert.AreEqual(5, energia1);
        }

        [TestMethod]
        public void Jugador2GolpePuñoGana5DeEnergia()
        {
            //arrange
            //act
            game.GolpePuñoJugador2();
            var energia1 = game.EnergiaJugador2;
            //assert
            Assert.AreEqual(5, energia1);
        }
        #endregion

        #region golpe especial
        [TestMethod]
        public void Jugador1GolpeEspecialJugador2Menos30Vida()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador2();
            game.GolpeEspecialJugador1();
            var vida = game.VidaJugador2;
            //assert
            Assert.AreEqual(170, vida);
        }
        [TestMethod]
        public void Jugador2GolpeEspecialJugador1Menos30Vida()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador1();
            game.GolpeEspecialJugador2();
            var vida = game.VidaJugador1;
            //assert
            Assert.AreEqual(170, vida);
        }

        [TestMethod]
        public void Jugador1GolpeEspecialGana15DeEnergia()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador1();
            game.GolpeEspecialJugador1();
            var energia = game.EnergiaJugador1;
            //assert
            Assert.AreEqual(15, energia);
        }

        [TestMethod]
        public void Jugador2GolpeEspecialGana15DeEnergia()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador2();
            game.GolpeEspecialJugador2();
            var energia = game.EnergiaJugador2;
            //assert
            Assert.AreEqual(15, energia);
        }
        #endregion

        #region curacion
        [TestMethod]
        public void Jugador1CuracionGana50DeVida()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador1();
            game.GolpePuñoJugador2();
            game.Jugador1Curacion();
            var vida = game.VidaJugador1;
            //assert
            Assert.AreEqual(200, vida);
        }
        [TestMethod]
        public void Jugador2CuracionGana50DeVida()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador2();
            game.GolpePuñoJugador1();
            game.Jugador2Curacion();
            var vida = game.VidaJugador2;
            //assert
            Assert.AreEqual(200, vida);
        }

        [TestMethod]
        public void Jugador1CuracionPierde100Energia()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador1();
            game.Jugador1Curacion();
            var energia = game.EnergiaJugador1;
            //assert
            Assert.AreEqual(0, energia);
        }

        [TestMethod]
        public void Jugador2CuracionPierde100Energia()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador2();
            game.Jugador2Curacion();
            var energia = game.EnergiaJugador2;
            //assert
            Assert.AreEqual(0, energia);
        }
        #endregion

        #region perfect
        [TestMethod]
        public void Jugador1HizoPuntajePerfecto()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador1();
            //assert
            Assert.IsTrue(game.Jugador1GanaPuntajePerfecto());
        }
        [TestMethod]
        public void Jugador2HizoPuntajePerfecto()
        {
            //arrange
            //act
            for (int i = 0; i < 20; i++)
                game.GolpePuñoJugador2();
            //assert
            Assert.IsTrue(game.Jugador2GanaPuntajePerfecto());
        }
        #endregion
    }
}
