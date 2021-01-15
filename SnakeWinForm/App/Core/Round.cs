using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Core
{
    public static class Round
    {
        public static int RountVal(int val)
        {
            return val - (val % Setting.Instance.DefaultHeadStep);
        }
    }
}
