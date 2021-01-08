using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Data
{
    class Element
    {
        public static Element Head { get; private set; }
        public static List<Element> Elements { get; private set; }
        public Point Position { get; private set; }
        public Point PreviousPosition { get; private set; }
        
        public Element()
        {
            if(Elements == null)
            {
                Elements = new List<Element>();
                Head = this;
            }

            Elements.Add(this);
        }
    }
}
