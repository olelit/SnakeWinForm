using SnakeWinForm.App.Core;
using SnakeWinForm.App.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data
{
    class Eat
    {
        public ElementManager Manager { get; set; }
        public Point Position { get; set; }
        public SolidBrush Brush => Setting.Instance.DefaultEatColor;
        public Size ElemSize => Setting.Instance.ElemSize;
        public Setting Settings => Setting.Instance;

        public Eat()
        {
            ChangePostition();
        }

        public void ChangePostition()
        {
            Random rand = new Random();
            int x = rand.Next(WindowArea.WinSize.Width);
            int y = rand.Next(WindowArea.WinSize.Height);

            x = x - (x % Setting.Instance.DefaultHeadStep);
            y = y - (y % Setting.Instance.DefaultHeadStep);

            Position = new Point(x, y);
        }

        public void CheckHead(Point position)
        {
            if(position.X == Position.X && Position.Y == position.Y)
            {
                ChangePostition();
                Element element = new Element();
            }
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brush, Position.X, Position.Y, ElemSize.Width, ElemSize.Height);
        }
    }
}
