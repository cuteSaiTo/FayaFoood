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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }


        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Hpedido form5 = new Hpedido();
            form5.Show();
            this.Hide();
        }
    }
}
//hola