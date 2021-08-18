using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class GenericUtility <T>
    {
        public bool Compare(T x, T y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }
    }
}
