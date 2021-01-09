using SnakeWinForm.App.Data.Init;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWinForm.App.Manager
{
    class InitManager
    {
        private List<IInit> Inits;
        
        public InitManager()
        {
            Inits = new List<IInit>();
            var ElementManager = new ElementManager();
            Connect();
        }

        void Connect()
        {
            Inits.Add(new ElementsInit());
        }
    }
}
