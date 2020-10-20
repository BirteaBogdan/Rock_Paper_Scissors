using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Paper : Obtiune
    {
        public static readonly Paper Instance = new Paper();
        private Paper()
        {
            CriticalStrength = Rock.Instance;
            StrongAgainst = Spock.Instance;
            WeakAgainst = Lizard.Instance;
            CriticalWeakness = Scissors.Instance;
        }
    }
}
