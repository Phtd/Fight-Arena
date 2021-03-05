using System;
using System.Collections.Generic;
using System.Text;

namespace Fight_Arena
{
    
    class Fighting
    {
        private Fighters fighter1;

        public Fighters Fighter1
        {
            get { return fighter1; }
            set { fighter1 = value; }
        }
        private Fighters fighter2;

        public Fighters Fighter2
        {
            get { return fighter2; }
            set { fighter2 = value; }
        }

        public Fighting() 
        {
            
        }


        public Fighters Fight()
        {
            Fighters winner = fighter1;
            while (fighter1.State == "Alive" && fighter2.State == "Alive")
            {
                fighter2.Damaged(fighter1.Attack());
                if (fighter2.HP <= 0)
                {
                    fighter2.State = "Dead";
                }

                fighter1.Damaged(fighter2.Attack());
                if (fighter1.HP <= 0)
                {
                    fighter1.State = "Dead";
                    winner = fighter2;
                }
            }
            return winner;
        }

    }
}
