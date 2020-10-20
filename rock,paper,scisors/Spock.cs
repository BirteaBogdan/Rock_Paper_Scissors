using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Spock : Obtiune
    {
        public static readonly Spock Instance = new Spock();
        private Spock()
        {
            CriticalStrength = Scissors.Instance;
            StrongAgainst = Rock.Instance;
            WeakAgainst = Paper.Instance;
            CriticalWeakness = Lizard.Instance;
        }
    }
}
