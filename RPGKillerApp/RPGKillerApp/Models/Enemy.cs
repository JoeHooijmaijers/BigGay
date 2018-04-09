using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGKillerApp.Models
{
    public class Enemy
    {
        public int hp { get; private set; }
        public int atk { get; private set; }
        public string name { get; private set; }

        public Enemy(int Hp, int Atk, string Name)
        {
            hp = Hp;
            atk = Atk;
            name = Name;
        }

        public void Attack(Player player)
        {
            int dmg = hp * 2;
            player.TakeDamage(dmg);
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }
    }
}