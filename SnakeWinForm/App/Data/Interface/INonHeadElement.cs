using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data.Interface
{
    interface INonHeadElement
    {
        IElement Previous { get;  }
    }
}
