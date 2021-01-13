using SnakeWinForm.App.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data.Init
{
    class ElementsInit: IInit
    {
        public ElementsInit()
        {
            IHead head = new Head();
            IElement element = new Element();
            IElement element1 = new Element();
            IElement element2 = new Element();
            IElement element3 = new Element();
            IElement element4 = new Element();

            Eat eat = new Eat();
            ElementManager.Instance.GetEat = eat;
        }
    }
}
