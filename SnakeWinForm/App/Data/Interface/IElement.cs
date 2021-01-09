using SnakeWinForm.App.Core;
using SnakeWinForm.App.Manager;
using System.Drawing;

namespace SnakeWinForm.App.Data
{
    interface IElement
    {
        SolidBrush Color { get;  }
        Setting Settings { get; }
        Point Position { get; }
        Size ElemSize { get; }
        Point PreviousPosition { get; }
        ElementManager Manager { get; }
        void Move();
        void Draw(Graphics g);
    }
}
