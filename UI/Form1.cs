using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Module1.Instance))
            {
                panel1.Controls.Add(Module1.Instance);
                Module1.Instance.Dock = DockStyle.Fill;
                Module1.Instance.BringToFront();
            }
            else
            {
                Module1.Instance.BringToFront();
            }
                
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Module2.Instance))
            {
                panel1.Controls.Add(Module2.Instance);
                Module2.Instance.Dock = DockStyle.Fill;
                Module2.Instance.BringToFront();
            }
            else
            {
                Module2.Instance.BringToFront();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Module3.Instance))
            {
                panel1.Controls.Add(Module3.Instance);
                Module3.Instance.Dock = DockStyle.Fill;
                Module3.Instance.BringToFront();
            }
            else
            {
                Module3.Instance.BringToFront();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
