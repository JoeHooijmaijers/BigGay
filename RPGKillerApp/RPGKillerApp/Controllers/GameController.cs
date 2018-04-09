using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPGKillerApp.Models;

namespace RPGKillerApp.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Play()
        {
            return View();
        }

        public PartialViewResult Battle()
        {
            BattleViewModel battle = new BattleViewModel();
            return PartialView("_FightPartial", battle);
        }

        public PartialViewResult Fight()
        {
            BattleViewModel battle = new BattleViewModel();
            battle.player.Attack(battle.enemy);
            battle.enemy.Attack(battle.player);
            return PartialView("_FightPartial", battle);
        }
    }
}