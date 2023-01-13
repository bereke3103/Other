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
    public partial class Module3 : UserControl
    {
        private static Module3 _instance;

        public static Module3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Module3();
                return _instance;
            }
        }

        public Module3()
        {
            InitializeComponent();
        }

        private void Module3_Load(object sender, EventArgs e)
        {

        }
    }
}
