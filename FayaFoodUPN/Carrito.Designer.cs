namespace FayaFoodUPN
{
    partial class Carrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnPedidos = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btnInicio = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPedidos);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 7;
            // 
            // btnPedidos
            // 
            btnPedidos.AutoSize = true;
            btnPedidos.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidos.ForeColor = Color.Black;
            btnPedidos.Location = new Point(1046, 21);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(113, 26);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "H. pedidos";
            btnPedidos.Click += btnPedidos_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(974, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(49, 47);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(885, 21);
            label5.Name = "label5";
            label5.Size = new Size(67, 26);
            label5.TabIndex = 5;
            label5.Text = "menú";
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Peru;
            btnInicio.Location = new Point(39, 21);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(98, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "F.A.Y.A.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 114);
            label1.Name = "label1";
            label1.Size = new Size(313, 35);
            label1.TabIndex = 8;
            label1.Text = "CARRITO DE COMPRAS";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { " producto                        precio                      cantidad                    sub total", " _________________________________________________________________________________", "", "BK STACKER                   S/23.90                            2                          S/47.80", "doble junior", "__________________________________________________________________________________", "", "PIZZA DOBLE", "O NADA                         S/72.90                            1                          S/72.90", "FAMILIAR", "___________________________________________________________________________________", "", "MEGA BOX                    S/115.00                          1                          S/115.00" });
            listBox1.Location = new Point(40, 193);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1008, 396);
            listBox1.TabIndex = 11;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 630);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Carrito";
            Text = "Carrito";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private Label btnInicio;
        private Label label1;
        private ListBox listBox1;
        private Label Hpedidos;
        private Label btnPedidos;
    }
}