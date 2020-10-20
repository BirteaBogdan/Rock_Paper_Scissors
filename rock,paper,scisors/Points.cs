using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class Points
    {
        private int Puncte = 0;
        public void AddPoints(int x)
        {
            Puncte += x;
        }
        public int GetPuncte()
        {
            return Puncte;
        }
    }
}
