using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scisors
{
    public class HitPoint
    {
        private int InternalValue = 100;
        public void DecreaseLife(int x)
        {
            InternalValue -= x;
        }
        public int GetInternalValue()
        {
            return InternalValue;
        }
    }
}
