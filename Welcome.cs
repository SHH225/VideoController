using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDWindowsFormsTest
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >0)
            {
                this.Opacity -= 0.5;
                //this.Opacity = 0.99;
            }
            else
            {
                this.timer1.Stop();
                this.Hide();
               // Application.Exit();
                Form1 fm = new Form1();
                fm.Show();
               
            }

           // this.Close();
        }


        private void Welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
