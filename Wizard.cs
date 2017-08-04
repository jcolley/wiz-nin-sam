using System;

namespace wiz_nin_sam
{
    public class Wizard : Human
    {

        public Wizard(string person, int str, int intel, int dex, int hp) : base(string.Empty, 0, 0, 0, 0)
        {
            name = person;
            health = 50;
            intelligence = 25;
        }

        public void heal()
        {
            health += 10 * intelligence;
        }

        public void fireball(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Fireball Failed to find a Target");
            }
            else
            {
                Random damage = new Random();
                enemy.health -= damage.Next(20, 50);
            }
        }
    }
}