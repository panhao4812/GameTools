using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaroAngEditor
{
    public partial class Editor2 : Form
    {
        RegularExpression RE = new RegularExpression();
        public Editor2()
        {
            InitializeComponent();
            DefaultValue();
        }
        public void DefaultValue()
        {
            box11.Text = "0"; box12.Text = "180"; ;
            box21.Text = "90"; box22.Text = "270"; ;
            box31.Text = "180"; box32.Text = "0";
            box41.Text = "-90"; box42.Text = "90";
            box51.Text = "0"; box52.Text = "180"; ;
            box61.Text = "90"; box62.Text = "270"; ;
            box71.Text = "180"; box72.Text = "0";
            box81.Text = "-90"; box82.Text = "90";
            textBox1.Text = "";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            DefaultValue();
        }
        private void Tri8_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            int int_g = Convert.ToInt32(box41.Text);
            int int_h = Convert.ToInt32(box42.Text);
            int int_i = Convert.ToInt32(box51.Text);
            int int_j = Convert.ToInt32(box52.Text);
            int int_k = Convert.ToInt32(box61.Text);
            int int_l = Convert.ToInt32(box62.Text);
            int int_m = Convert.ToInt32(box71.Text);
            int int_n = Convert.ToInt32(box72.Text);
            int int_o = Convert.ToInt32(box81.Text);
            int int_p = Convert.ToInt32(box82.Text);
            textBox1.Text = RE.SolveTri8(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f),
                new IndexDomain(int_g, int_h),
                new IndexDomain(int_i, int_j),
                new IndexDomain(int_k, int_l),
                new IndexDomain(int_m, int_n),
                new IndexDomain(int_o, int_p)
                 );
        }
        private void Tri7_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            int int_g = Convert.ToInt32(box41.Text);
            int int_h = Convert.ToInt32(box42.Text);
            int int_i = Convert.ToInt32(box51.Text);
            int int_j = Convert.ToInt32(box52.Text);
            int int_k = Convert.ToInt32(box61.Text);
            int int_l = Convert.ToInt32(box62.Text);
            int int_m = Convert.ToInt32(box71.Text);
            int int_n = Convert.ToInt32(box72.Text);
            textBox1.Text = RE.SolveTri7(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f),
                new IndexDomain(int_g, int_h),
                new IndexDomain(int_i, int_j),
                new IndexDomain(int_k, int_l),
                new IndexDomain(int_m, int_n)
                );
        }
        private void Tri6_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            int int_g = Convert.ToInt32(box41.Text);
            int int_h = Convert.ToInt32(box42.Text);
            int int_i = Convert.ToInt32(box51.Text);
            int int_j = Convert.ToInt32(box52.Text);
            int int_k = Convert.ToInt32(box61.Text);
            int int_l = Convert.ToInt32(box62.Text);
            textBox1.Text = RE.SolveTri6(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f),
                new IndexDomain(int_g, int_h),
                new IndexDomain(int_i, int_j),
                new IndexDomain(int_k, int_l)
                );
        }
        private void Tri5_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            int int_g = Convert.ToInt32(box41.Text);
            int int_h = Convert.ToInt32(box42.Text);
            int int_i = Convert.ToInt32(box51.Text);
            int int_j = Convert.ToInt32(box52.Text);
            textBox1.Text = RE.SolveTri5(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f),
                new IndexDomain(int_g, int_h),
                new IndexDomain(int_i, int_j)
                );
        }
        private void Pi4_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            int int_g = Convert.ToInt32(box41.Text);
            int int_h = Convert.ToInt32(box42.Text);
            textBox1.Text = RE.SolvePI4(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f),
                new IndexDomain(int_g, int_h)
                 );
        }

        private void Pi3_Click(object sender, EventArgs e)
        {
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            int int_e = Convert.ToInt32(box31.Text);
            int int_f = Convert.ToInt32(box32.Text);
            textBox1.Text = RE.SolvePI3(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d),
                new IndexDomain(int_e, int_f)
                 );
        }

        private void Pi2_Click(object sender, EventArgs e)
        {

            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            int int_c = Convert.ToInt32(box21.Text);
            int int_d = Convert.ToInt32(box22.Text);
            textBox1.Text = RE.SolvePI2(
                new IndexDomain(int_a, int_b),
                new IndexDomain(int_c, int_d));

        }

        private void Domain2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "^(";
            RegularExpression RE = new RegularExpression();
            int int_a = Convert.ToInt32(box11.Text);
            int int_b = Convert.ToInt32(box12.Text);
            if (int_a < 0 || int_b < 0)
            {
                textBox1.Text = "";
                return;
            }
            else if (int_a == int_b)
            {
                textBox1.Text += int_a.ToString();

            }
            else if (int_a > int_b)
            {
                textBox1.Text += RE.ExpressionPair(new IndexDomain(int_b, int_a));
            }
            else
            {
                textBox1.Text += RE.ExpressionPair(new IndexDomain(int_a, int_b));
            }
            textBox1.Text += ")$";
        }
    }
}
