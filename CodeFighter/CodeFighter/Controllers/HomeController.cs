using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFighter.Models;

namespace CodeFighter.Controllers
{
    public class HomeController : Controller
    {
        public CodeFighterGame CodeFighterGame
        {
            get
            {
                if (Session["CodeFighterGame"] == null)
                {
                    Session.Add("CodeFighterGame", new CodeFighterGame());
                }
                return (CodeFighterGame)Session["CodeFighterGame"];
            }
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StartGame(string nombrePlayer1, string nombrePlayer2)
        {
            CodeFighterGame.Jugador1.Nombre = nombrePlayer1;
            CodeFighterGame.Jugador2.Nombre = nombrePlayer2;
            return RedirectToAction("Index", "Jugar");
        }
    }
}