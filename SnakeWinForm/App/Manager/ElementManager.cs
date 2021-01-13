using SnakeWinForm.App.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Manager
{
    class ElementManager
    {
        public List<IElement> Elements { get; private set; }
        public IHead Head { get; private set; }
        public Eat GetEat { get; set; }
        public static ElementManager Instance { get; private set; }
        public ElementManager() {
            Instance = this;
        }

        public void Add(IElement element)
        {
            if(Elements == null)
            {
                Elements = new List<IElement>();
            }

            Elements.Add(element);
        }

        public void SetHead(IHead head)
        {
            Head = head;
        }

        public void Clear()
        {
            Elements.Clear();
        }

        public IElement Last()
        {
            return Elements.Last();
        }
    }
}
