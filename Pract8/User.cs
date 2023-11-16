using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8
{
    internal class User
    {
        internal string UserName;
        internal int WordsInMinute;
        internal int WordsInSecond;
        internal User (string UN, int WIM, int WIS)
        {
            UserName = UN;
            WordsInMinute = WIM;
            WordsInSecond = WIS;
        }
    }
}
