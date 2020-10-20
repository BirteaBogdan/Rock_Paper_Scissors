using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Rock : Obtiune
    {
        public static readonly Rock Instance = new Rock();
        private Rock()
        {
            CriticalStrength = Lizard.Instance;
            StrongAgainst = Scissors.Instance;
            WeakAgainst = Spock.Instance;
            CriticalWeakness = Paper.Instance;
        }
    }
}
