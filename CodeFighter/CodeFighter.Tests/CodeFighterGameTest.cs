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


    }
}
