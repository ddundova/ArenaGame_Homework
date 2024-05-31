using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        Wand Wand = new Wand();

        public Mage(string name) : base(name)
        {
            
        }

        public override int Attack()
        {
            int attack = base.Attack();

            if (ThrowDice(40))
            {
                attack = attack + Wand.CastSpell();
            }

            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(7)) incomingDamage = incomingDamage % 10;
            base.TakeDamage(incomingDamage);
        }
    }
}
