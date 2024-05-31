using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword
    {
        private const int blockAttackPossibility = 7;
        private const int moreAccurateStrikeDamage = 20;
        private int counter = 0;
        public int Strike ()
        {
            int damageBySword = 15;
            counter = counter + 1;

            if (counter % 3 == 0)
                damageBySword = damageBySword + moreAccurateStrikeDamage;
            return damageBySword;
        }

        public bool BlockIncomingAttack() 
        {
            int luckyNumber = Random.Shared.Next(101);

            if (luckyNumber % blockAttackPossibility == 0) return true;
            return false;
        }
    }
}
