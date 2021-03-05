using System;
using System.Collections.Generic;

namespace Fight_Arena
{
    class Program
    {
        public static Random randomizer = new Random();
        static void Main(string[] args)
        {
            List<Fighters> fighterList = new List<Fighters>();

            fighterList.Add(new Fighters() { Name = "Kung Fu Harry", HP = 120, MinAttack = 2, MaxAttack = 2, MinDefence = 5, MaxDefence = 5, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "SuperHunden Dino", HP = 70, MinAttack = 6, MaxAttack = 8, MinDefence = 2, MaxDefence = 8, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Hurtig Karl", HP = 90, MinAttack = 2, MaxAttack = 5, MinDefence = 3, MaxDefence = 3, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Gift Gunner", HP = 90, MinAttack = 1, MaxAttack = 13, MinDefence = 5, MaxDefence = 5, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Minimusen Mikkel", HP = 40, MinAttack = 9, MaxAttack = 9, MinDefence = 9, MaxDefence = 9, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Katten Tiger", HP = 35, MinAttack = 3, MaxAttack = 6, MinDefence = 4, MaxDefence = 4, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Gummigeden Ivan", HP = 70, MinAttack = 6, MaxAttack = 6, MinDefence = 8, MaxDefence = 8, State = "Alive" });
            fighterList.Add(new Fighters() { Name = "Egon", HP = 90, MinAttack = 5, MaxAttack = 11, MinDefence = 4, MaxDefence = 4, State = "Alive" });

            List<Fighting> quaterFinale = new List<Fighting>(); 
            List<Fighting> semiFinale = new List<Fighting>();
            List<Fighting> finale = new List<Fighting>();
            List<Fighters> temp = new List<Fighters>();
            while (fighterList.Count > 1)
            {
                int value = randomizer.Next(1,fighterList.Count);
                quaterFinale.Add(new Fighting() {Fighter1 = fighterList[value], Fighter2 = fighterList[0]});

                fighterList.RemoveAt(value);
                fighterList.RemoveAt(0);


            }
            foreach(Fighting fighting in quaterFinale)
            {
                temp.Add(fighting.Fight());
            }



        }
    }
}
