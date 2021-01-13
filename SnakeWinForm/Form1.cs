using SnakeWinForm.App.Core;
using SnakeWinForm.App.Data;
using SnakeWinForm.App.Manager;
using System;
using System.Windows.Forms;

namespace SnakeWinForm
{
    public partial class Form1 : Form
    {
        readonly MainApp App;
        readonly Draw Draw;
        readonly IHead Head;

        public Form1()
        {
            InitializeComponent();
            WindowArea.WinSize = pictureBox1.Size;
            App = new MainApp();
            Draw = new Draw(pictureBox1);
            Head = ElementManager.Instance.Head;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Head.ChangeWay(e.KeyCode);
        }
    }
}
