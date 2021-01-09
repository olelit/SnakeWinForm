using SnakeWinForm.App.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data
{
    interface IHead
    {
        Point CurrentWay { get; }
        void CheckPosition();
        void ChangeWay();
    }
}
