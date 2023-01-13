using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelMangementSystem.AllUserControl
{
    public partial class WomenMenRate : UserControl
    {
        function fn = new function();
        String query;

        public WomenMenRate()
        {
            InitializeComponent();
        }

        private void WomenMenRate_Load(object sender, EventArgs e)
        {
            query = "select gender from customer";
            DataSet ds = fn.getData(query);
            
            int erkSayi = 0;
            int kadSayi = 0;
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == "Erkek")
                {
                    erkSayi++;
                }
                else
                {
                    kadSayi++;
                }
            }
            txtErkek.Text = erkSayi.ToString();
            txtKadin.Text = kadSayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            float r1, r2, total;
            r1 = int.Parse(txtErkek.Text);
            r2 = int.Parse(txtKadin.Text);

            total = r1 + r2;
            float pr1, pr2;
            pr1 = (r1 / total) * 360;
            pr2 = (r2 / total) * 360;

            Pen p = new Pen(WomenMenRate.DefaultBackColor);
            if (checkBox1.Checked == true)
            {
                p.Color = Color.Black;
                p.Width = 4;

            }
            else
            {
                p.Color = WomenMenRate.DefaultBackColor;
                p.Width = 4;
            }
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(checkBox1.Location.X + checkBox1.Size.Width +
            260, 20, 250, 250);
            Brush b1 = new SolidBrush(Color.OrangeRed);
            Brush b2 = new SolidBrush(Color.White);
            g.DrawPie(p, rec, 0, pr1);
            g.FillPie(b1, rec, 0, pr1);
            g.DrawPie(p, rec, pr1, pr2);
            g.FillPie(b2, rec, pr1, pr2);
        }
    }
}
