using SnakeWinForm.App.Core;
using SnakeWinForm.App.Data.Interface;
using SnakeWinForm.App.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data
{
    class Element: IElement, INonHeadElement
    {
        public Point Position { get; private set; }
        public Point PreviousPosition { get; private set; }
        public Setting Settings => Setting.Instance;
        public SolidBrush Color => Settings.DefaultElementColor;
        public Size ElemSize => Settings.ElemSize;
        public ElementManager Manager => ElementManager.Instance;
        public IElement Previous { get; private set; }

        public Element()
        {
            Previous = Manager.Last();
            Manager.Add(this);
        }

        public void Move()
        {
            Position = Previous.PreviousPosition;
            Previous.ResetPosition();
        }

        public void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(Position, ElemSize);
            g.FillEllipse(Color, rect);
        }

        public void ResetPosition()
        {
            PreviousPosition = Position;
        }
    }
}
