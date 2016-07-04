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
            return View();
        }
    }
}