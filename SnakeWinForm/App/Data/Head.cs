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
    class Head : IElement, IHead
    {
        public Point Position { get; private set; }
        public Point PreviousPosition { get; private set; }
        public Setting Settings => Setting.Instance;
        public SolidBrush Color => Settings.DefaultHeadColor;
        public Size ElemSize => Settings.ElemSize;
        public ElementManager Manager => ElementManager.Instance;
        public IElement Previous => throw new NotImplementedException();

        public Head()
        {
            Position = Settings.DefaultHeadPosition;
            PreviousPosition = Position;
            Manager.Add(this);
            Manager.SetHead(this);
        }

        public void CheckPosition()
        {

        }

        public void Move()
        {

        }

        public void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(Position, ElemSize);
            g.FillEllipse(Color, rect);
        }

        public void ResetPosition()
        {
            throw new NotImplementedException();
        }
    }
}
