using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGKillerApp.Models
{
    public class Player
    {
        public int hp { get; private set; }
        public int atk { get; private set; }
        public string name { get; private set; }

        public Player(int Hp, int Atk, string Name)
        {
            hp = Hp;
            atk = Atk;
            name = Name;
        }

        public void Attack(Enemy enemy)
        {
            int dmg = hp * 2;
            enemy.TakeDamage(dmg);
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }
    }
}