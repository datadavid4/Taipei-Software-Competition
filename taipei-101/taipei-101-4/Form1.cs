using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taipei_101_4
{
    public partial class Form1 : Form
    {
        Button[] btns;
        public Form1()
        {
            InitializeComponent();
            btns = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15, button16, button17 };

            foreach (var item in btns) item.Click += (s, e) => { textBox1.Text += (s as Button).Text; };
        }
        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
