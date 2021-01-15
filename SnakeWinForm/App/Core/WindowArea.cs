using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Core
{
    public static class WindowArea
    {
        public static Size WinSize { get; set; }

        public static Point TeleportIfNotInArea(Point position)
        {
            if (position.X < 0)
                position = new Point(Round.RountVal(WinSize.Width), position.Y);

            if (position.X > WinSize.Width)
                position = new Point(0, position.Y);

            if (position.Y < 0)
                position = new Point(position.X, Round.RountVal(WinSize.Height));

            if (position.Y > WinSize.Height)
                position = new Point(position.X, 0);

            return position;
        }
    }
}
