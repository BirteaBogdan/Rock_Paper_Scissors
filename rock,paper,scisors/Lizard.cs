using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Lizard : Obtiune
    {
        public static readonly Lizard Instance = new Lizard();
        private Lizard()
        {
            CriticalStrength = Spock.Instance;
            StrongAgainst = Paper.Instance;
            WeakAgainst = Scissors.Instance;
            CriticalWeakness = Rock.Instance;
        }
    }
}
