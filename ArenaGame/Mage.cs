using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int reduceDamageChance = 7;
        private const int castSpellPossibility = 40;
        Wand Wand = new Wand();

        public Mage(string name) : base(name)
        {
            
        }

        public override int Attack()
        {
            int attack = base.Attack();

            if (ThrowDice(castSpellPossibility))
            {
                attack = attack + Wand.CastSpell();
            }

            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(reduceDamageChance)) incomingDamage = incomingDamage % 10;
            base.TakeDamage(incomingDamage);
        }
    }
}
