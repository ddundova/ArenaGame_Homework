using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Wand
    {
        private int spellPower;

        public int CastSpell ()
        {
            int damagePercentage = 0;
            int luckyNumber = Random.Shared.Next(0, 30);
            spellPower = Random.Shared.Next(0, 21);

            if (luckyNumber % 2 == 0)
                damagePercentage = 2;
            else if (luckyNumber % 3 == 0)
                damagePercentage = 3;
            else if (luckyNumber % 5 == 0)
                damagePercentage = 5;
            else damagePercentage = 7;

            damagePercentage = damagePercentage * spellPower;

            return damagePercentage;
        }


    }
}
