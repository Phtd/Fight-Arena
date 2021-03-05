using System;
using System.Collections.Generic;
using System.Text;

namespace Fight_Arena
{
    class Fighters
    {
        public static Random randomizer = new Random();
        
        private string name;
        private int hP;
        private int minAttack;
        private int maxAttack;
        private int minDefence;
        private int maxDefence;
        private string state;


        public string Name { get; set; }
        public int HP { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }
        public int MinDefence { get; set; }
        public int MaxDefence { get; set; }
        public string State { get; set; }

        public Fighters()
        {

        }
        public int Attack()
        {
            return randomizer.Next(minAttack, maxAttack+1);
        }
        public int Defence()
        {
            return randomizer.Next(minDefence, maxDefence + 1);
        }
        public void Damaged(int damage)
        {
            int damaged = (Defence() - damage);
            if (damaged < 0)
            {
                this.hP = hP + damaged;
                Alive();
            }
        }
        public bool Alive()
        {
            if (HP > 0)
                return true;
            else
                return false;
        }
    }
}
