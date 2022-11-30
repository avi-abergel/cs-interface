using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_10_4
{
    interface IItem
    {
        public int GetPrice();
    }

    public class cola : IItem
    {
        public int GetPrice()
        {
            return 10;
        }
    }

    public class kinley : IItem
    {
        public int GetPrice()
        {
            return 11;
        }
    }
}
