using CodeFighter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFighter.Controllers
{
    public class JugarController : Controller
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
        // GET: Jugar
        public ActionResult Index()
        {
            ViewBag.NombreJugadorUno = CodeFighterGame.Jugador1.Nombre;
            ViewBag.VidaJugadorUno = CodeFighterGame.Jugador1.Vida;
            ViewBag.EnergiaJugadorUno = CodeFighterGame.Jugador1.Energia;
            ViewBag.NombreJugadorDos = CodeFighterGame.Jugador2.Nombre;
            ViewBag.VidaJugadorDos = CodeFighterGame.Jugador2.Vida;
            ViewBag.EnergiaJugadorDos = CodeFighterGame.Jugador2.Energia;
            return View();
        }

        #region actiones

        // GET: Jugar
        [HttpPost]
        public ActionResult Golpear(string hddJugador)
        {
            if (hddJugador == "1")
            {

            }
            else
            {

            }
            return View();
        }

        // GET: Jugar
        [HttpPost]
        public ActionResult Patear(string hddJugador)
        {
            if (hddJugador == "1")
            {

            }
            else
            {

            }
            return View();
        }

        // POST: Especial
        [HttpPost]
        public ActionResult Especial(string hddJugador)
        {
            if (hddJugador == "1")
            {

            }
            else
            {

            }
            return View();
        }

        // POST: Curar
        [HttpPost]
        public ActionResult Curar(string hddJugador)
        {
            if (hddJugador == "1")
            {

            }
            else
            {

            }
            return View();
        }

        #endregion
    }
}