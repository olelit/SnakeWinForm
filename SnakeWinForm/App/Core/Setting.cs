using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Core
{
    class Setting
    {
        public static Setting Instance => new Setting();

        public Point DefaultHeadPosition { get; private set; }
        public SolidBrush DefaultElementColor { get; private set; }
        public SolidBrush DefaultHeadColor { get; private set; }
        public SolidBrush DefaultEatColor { get; private set; }
        public Size ElemSize { get; private set; }
        public int DefaultHeadStep { get; private set; }

        private Setting() {

            Load();
        }

        private void Load()
        {
            DefaultHeadPosition = new Point(100, 100);
            DefaultElementColor = new SolidBrush(Color.Green);
            DefaultHeadColor = new SolidBrush(Color.Red);
            DefaultEatColor = new SolidBrush(Color.Purple);
            ElemSize = new Size(10, 10);
            DefaultHeadStep = 10;
        }
    }
}
