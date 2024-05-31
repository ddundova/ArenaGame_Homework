﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        Bow Bow = new Bow();
        public Archer (string name) : base(name)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            bool tripleShoot = ThrowDice(10);
            if (Bow.Shoot())
            {
                if (tripleShoot)
                    attack = attack + attack * 30 / 100;
                attack = attack + attack * 10 / 100;

            }
            return attack;
        }
    }
}
