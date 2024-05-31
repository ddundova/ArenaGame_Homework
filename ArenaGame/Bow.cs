using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bow
    {
        private const int percantageToShoot = 75;
        private int accuracy;

        public bool Shoot()
        {
            if (CurrentAccuracy() > percantageToShoot) return true;
            return false;
        }

        private int CurrentAccuracy()
        {
            accuracy = Random.Shared.Next(0, 101);
            return accuracy;
        }

    }
}
