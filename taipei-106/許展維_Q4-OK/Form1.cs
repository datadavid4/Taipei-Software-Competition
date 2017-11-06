using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 許展維_Q4
{
    public partial class Form1 : Form
    {
        int G = 34943;
        public Form1()
        {
            InitializeComponent();
            int a = Convert.ToInt32('A');
            string b = Convert.ToString(a, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            int[] arr = Array.ConvertAll(input.ToCharArray(), s => Convert.ToInt32(s));
            // 要記得為ASCII字母填滿8個零
            string devidend = string.Join("", Array.ConvertAll(arr, s => Convert.ToString(s, 2).PadLeft(8, '0')));
            devidend += "".PadLeft(16, '0');// 左移16位元

            // devidend = "10011001110";// 1230
            // G = 9;
            int mod = 0;
            for (int count = 0; count < devidend.Length; count++)
            {
                // 先左移一位元，再加上下個位數
                // 如果大於G就減掉，等到count走完所有位數時，mod就是答案
                mod <<= 1;
                mod += int.Parse(devidend.Substring(count, 1));
                if (mod >= G) mod -= G;
            }

            label1.Text = Convert.ToString(G - mod, 16).ToUpper();
        }
    }
}
