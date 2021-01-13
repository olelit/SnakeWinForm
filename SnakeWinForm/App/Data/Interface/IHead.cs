using SnakeWinForm.App.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWinForm.App.Data
{
    interface IHead
    {
        Core.Control GetControl { get; }
        Point CurrentWay { get; }
        void CheckPosition();
        void ChangeWay(Keys keys);
    }
}
