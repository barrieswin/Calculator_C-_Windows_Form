using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //按下button2~00觸發btn1_Click
            btn2.Click += new System.EventHandler(btn1_Click);
            btn3.Click += new System.EventHandler(btn1_Click);
            btn4.Click += new System.EventHandler(btn1_Click);
            btn5.Click += new System.EventHandler(btn1_Click);
            btn6.Click += new System.EventHandler(btn1_Click);
            btn7.Click += new System.EventHandler(btn1_Click);
            btn8.Click += new System.EventHandler(btn1_Click);
            btn9.Click += new System.EventHandler(btn1_Click);
            btn0.Click += new System.EventHandler(btn1_Click);
            btn00.Click += new System.EventHandler(btn1_Click);
        }

        float num1, ans;
        int count;

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txt1.Text = txt1.Text + btn.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                num1 = float.Parse(txt1.Text);
                txt1.Clear();
                txt1.Focus();
                count = 2;
            }
        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                num1 = float.Parse(txt1.Text);
                txt1.Clear();
                txt1.Focus();
                count = 1;
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                num1 = float.Parse(txt1.Text);
                txt1.Clear();
                txt1.Focus();
                count = 3;
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                num1 = float.Parse(txt1.Text);
                txt1.Clear();
                txt1.Focus();
                count = 4;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            count = 0;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            int c = txt1.TextLength;
            int flag = 0;
            string text = txt1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txt1.Text = txt1.Text + ".";
            }
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txt1.Text);
                    txt1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txt1.Text);
                    txt1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txt1.Text);
                    txt1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txt1.Text);
                    txt1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
