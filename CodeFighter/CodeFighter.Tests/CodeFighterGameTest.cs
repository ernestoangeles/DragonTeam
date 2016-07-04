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

        //[TestMethod]
        //public void Jugador2Con10VidaMenosDespuesDePuñoJugador1()
        //{
        //    //arrange
        //    //act
        //    game.GolpePuñoJugador1();
        //    var vida2 = game.VidaJugador2;
        //    //assert
        //    Assert.AreEqual("190", vida2);
        //}

        //[TestMethod]
        //public void Jugador1Con10VidaMenosDespuesDePuñoJugador2()
        //{
        //    //arrange
        //    //act
        //    game.GolpePuñoJugador2();
        //    var vida1 = game.VidaJugador1;
        //    //assert
        //    Assert.AreEqual("190", vida1);
        //}
        
        //[TestMethod]
        //public void Jugador1Con5sDespuesDePuñoJugador2()
        //{
        //    //arrange
        //    //act
        //    game.GolpePuñoJugador2();
        //    var vida1 = game.VidaJugador1;
        //    //assert
        //    Assert.AreEqual("190", vida1);
        //}
    }
}
