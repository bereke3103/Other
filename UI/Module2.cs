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
    public partial class Module2 : UserControl
    {
        private static Module2 _instance;

        public static Module2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Module2();
                return _instance;
            }
        }
        public Module2()
        {
            InitializeComponent();
        }

        private void Module2_Load(object sender, EventArgs e)
        {

        }
    }
}
