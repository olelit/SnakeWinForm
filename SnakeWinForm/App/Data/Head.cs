using SnakeWinForm.App.Core;
using SnakeWinForm.App.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Core.Control GetControl => new Core.Control();
        public Point CurrentWay { get; private set; }

        public Head()
        {
            Position = Settings.DefaultHeadPosition;
            PreviousPosition = Position;
            Manager.Add(this);
            Manager.SetHead(this);
            CurrentWay = GetControl.GetCurrent();
        }

        public void CheckPosition()
        {
            Position = WindowArea.TeleportIfNotInArea(Position);
            ElementManager.Instance.GetEat.CheckHead(Position);
        }

        public void Move()
        {
            Position = new Point(Position.X + CurrentWay.X, Position.Y + CurrentWay.Y);
            CheckPosition();
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

        public void ChangeWay(Keys key)
        {
            CurrentWay = GetControl.GetCurrent(key);
        }
    }
}
