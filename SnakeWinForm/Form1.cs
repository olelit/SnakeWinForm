using SnakeWinForm.App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWinForm
{
    public partial class Form1 : Form
    {

        MainApp _App;

        public Form1()
        {
            InitializeComponent();
            _App = new MainApp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
