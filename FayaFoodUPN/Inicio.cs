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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicio form2 = new inicio();
            form2.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu form3 = new menu();
            form3.Show();
            this.Hide();
        }

        private void btnCesta_Click(object sender, EventArgs e)
        {
            Carrito form4 = new Carrito();
            form4.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Hpedido form5 = new Hpedido();
            form5.Show();
            this.Hide();
        }
    }
}
