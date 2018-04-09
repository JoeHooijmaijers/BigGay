using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGKillerApp.Models
{
    public class BattleViewModel
    {
        public Player player = new Player(100, 12, "Bob");
        public Enemy enemy = new Enemy(50, 4, "Dogger");
    }
}