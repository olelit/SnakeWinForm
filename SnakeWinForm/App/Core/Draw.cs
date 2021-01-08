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
        private PictureBox _PictureBox;
        private Graphics _Graphics;
        private Bitmap _Bitmap;

        public Draw(PictureBox pictureBox1)
        {
            _PictureBox = pictureBox1;
            _Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _Graphics = Graphics.FromImage(_Bitmap);
        }

        public void Refresh()
        {
            _Graphics.Clear(_PictureBox.BackColor);
            _PictureBox.Image = _Bitmap;
        }
    }
}
