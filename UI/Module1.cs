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
    public partial class Module1 : UserControl
    {

        private static Module1 _instance;

        public static Module1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Module1();
                return _instance;
            }
        }

        public Module1()
        {
            InitializeComponent();
        }

        private void Module1_Load(object sender, EventArgs e)
        {

        }
    }
}
