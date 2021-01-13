using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWinForm.App.Core
{
    class Control
    {

        Dictionary<Keys, Point> KeyPairs = new Dictionary<Keys, Point>();

        public int Step => Setting.Instance.DefaultHeadStep;

        public Control()
        {
            KeyPairs.Add(Keys.W, new Point(0, Step*-1));
            KeyPairs.Add(Keys.S, new Point(0, Step));
            KeyPairs.Add(Keys.A, new Point(Step * -1, 0));
            KeyPairs.Add(Keys.D, new Point(Step, 0));
        }

        public Point GetCurrent(Keys key)
        {
            if (KeyPairs.ContainsKey(key))
                return KeyPairs[key];

            return KeyPairs.First().Value;
        }

        public Point GetCurrent() => KeyPairs.First().Value;
    }
}
