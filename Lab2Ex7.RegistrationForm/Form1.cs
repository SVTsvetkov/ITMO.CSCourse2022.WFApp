using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Ex7.RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Location = new System.Drawing.Point(16, 96);
            lbl.Size = new System.Drawing.Size(32, 23);
            lbl.Name = "labelll";
            lbl.TabIndex = 2;
            lbl.Text = "PIN2";
            groupBox1.Controls.Add(lbl);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(5, 65);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 3;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(60, 65);
                txt.Size = new System.Drawing.Size(160, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }


        }

    }
}
