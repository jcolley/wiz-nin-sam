using System;

namespace wiz_nin_sam
{
    public class Ninja : Human
    {

        public Ninja(string person, int str, int intel, int dex, int hp) : base(string.Empty, 0, 0, 0, 0)
        {
            name = person;
            dexterity = 175;
        }

        public void steal(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("No enemy to steal from");
            }
            else
            {
                enemy.health -= 10;
                health += 10;
            }
        }

        public void get_away()
        {
            health -= 15;
        }
    }
}