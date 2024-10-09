using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FayaFoodUPN
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicio form2 = new inicio();
            form2.Show();
            this.Hide();
        }
    }
}
