using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectM
{
    internal class MyMonster
    {
        private string name;
        private int power;
        private int health;

        public MyMonster(string name, int power, int health)
        {
            this.name = name;
            this.power = power;
            this.health = health;
        }

        public string GetName() { return name; }
        public int GetPower() { return power; }
        public int GetHealth() { return health; }
        public bool IsAlive() { return health > 0; }
        public int Attack() { return power; }

        public void TakeDamage(int damage)
        {
            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }
        }

        public void Heal(int points)
        {
            health = health + points;
        }

        public void PowerUp(int extraPower)
        {
            power = power + extraPower;
        }

        public void Roar()
        {
            Console.WriteLine(name + " ROARS!!!");
            int[] sounds = { 300, 360, 420, 500, 420, 360, 280 };
            int[] times = { 120, 120, 150, 220, 150, 120, 250 };

            for (int i = 0; i < sounds.Length; i++)
            {
                Console.Beep(sounds[i], times[i]);
            }
        }

        public void ShowMonster()
        {
            Console.WriteLine("############################");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Health: " + health);

            if (IsAlive())
                Console.WriteLine("Status: Alive");
            else
                Console.WriteLine("Status: Dead");

            Console.WriteLine("############################");
        }
    }
}
