using SnakeWinForm.App.Data;
using SnakeWinForm.App.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWinForm.App.Core
{
    class Draw
    {
        private Setting Settings = Setting.Instance;

        private PictureBox _PictureBoxForm;
        private Graphics _G;
        private Bitmap _Btm;

        private ElementManager _ElementManager = ElementManager.Instance;

        public Draw(PictureBox pictureBox1)
        {
            _PictureBoxForm = pictureBox1;
            _Btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _G = Graphics.FromImage(_Btm);
        }

        public void Refresh()
        {
            _G.Clear(_PictureBoxForm.BackColor);
            Redraw();
            _PictureBoxForm.Image = _Btm;
        }

        private void Redraw()
        {
            foreach (IElement item in _ElementManager.Elements.ToArray())
            {
                item.Move();
                item.Draw(_G);
            }
            ElementManager.Instance.GetEat.Draw(_G);
        }
    }
}
