using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Scissors : Obtiune
    {
        public static readonly Scissors Instance = new Scissors();
        private Scissors()
        {
            CriticalStrength = Paper.Instance;
            StrongAgainst = Lizard.Instance;
            WeakAgainst = Rock.Instance;
            CriticalWeakness = Spock.Instance;
        }
    }
}
