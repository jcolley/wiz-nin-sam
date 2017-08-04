using System;

namespace wiz_nin_sam
{
    public class Samurai : Human
    {

        public Samurai(string person, int str, int intel, int dex, int hp) : base(string.Empty, 0, 0, 0, 0)
        {
            name = person;
            health = 200;
        }

        public void death_blow(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("No enemy to attack");
            }
            else
            {
                if (enemy.health < 50)
                {
                    enemy.health = 0;
                }
            }
        }

        public void meditate()
        {
            health = 200;
        }
    }
}