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
        public void DefaultValue2()
        {
            box11.Text = "0"; box12.Text = "180"; 
            box21.Text = "90"; box22.Text = "270"; 
            box31.Text = "180"; box32.Text = "0";
            box41.Text = "-90"; box42.Text = "90";
            box51.Text = "0"; box52.Text = "180"; 
            box61.Text = "90"; box62.Text = "270"; 
            box71.Text = "180"; box72.Text = "0";
            box81.Text = "-90"; box82.Text = "90";
            textBox1.Text = "";
        }
        public void DefaultValue()
        {
            box11.Text = ""; box12.Text = ""; 
            box21.Text = ""; box22.Text = ""; 
            box31.Text = ""; box32.Text = "";
            box41.Text = ""; box42.Text = "";
            box51.Text = ""; box52.Text = ""; 
            box61.Text = ""; box62.Text = ""; 
            box71.Text = ""; box72.Text = "";
            box81.Text = ""; box82.Text = "";
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
            textBox1.Text ="" ;
            string err="";
            RegularExpression RE = new RegularExpression();
            try
            {
                int int_a = Convert.ToInt32(box11.Text);
                int int_b = Convert.ToInt32(box12.Text);
                    err += RE.SolvePI1(new IndexDomain(int_a, int_b),false);             
                int int_c = Convert.ToInt32(box21.Text);
                int int_d = Convert.ToInt32(box22.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_c, int_d), false);           
                int int_e = Convert.ToInt32(box31.Text);
                int int_f = Convert.ToInt32(box32.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_e, int_f), false);            
                int int_g = Convert.ToInt32(box41.Text);
                int int_h = Convert.ToInt32(box42.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_g, int_h), false);
                int int_i = Convert.ToInt32(box51.Text);
                int int_j = Convert.ToInt32(box52.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_i, int_j), false);
                int int_k = Convert.ToInt32(box61.Text);
                int int_l = Convert.ToInt32(box62.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_k, int_l), false);
                int int_m = Convert.ToInt32(box71.Text);
                int int_n = Convert.ToInt32(box72.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_m, int_n), false);
                int int_o = Convert.ToInt32(box81.Text);
                int int_p = Convert.ToInt32(box82.Text);
                    err += "|";
                    err += RE.SolvePI1(new IndexDomain(int_o, int_p), false);
            }catch {
                if (err == "" | err == null) textBox1.Text += "Input Error";
            }
            textBox1.Text += "^("+err + ")$";
        }
    }
}
