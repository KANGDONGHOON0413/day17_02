using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day17_02
{
    public partial class Form1 : Form
    {
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            str += e.KeyChar; //문자열에 눌리는 키를 계속 더해준다
            Invalidate(); //반영한다.
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
        }
    }
}
