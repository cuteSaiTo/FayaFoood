namespace FayaFoodUPN
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnPedidos = new Label();
            btnCesta = new FontAwesome.Sharp.IconButton();
            btnMenu = new Label();
            btnInicio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 119);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(353, 162);
            label2.TabIndex = 2;
            label2.Text = "En                     \r\ntransformamos la manera en\r\nque recibes tus productos favoritos\r\nNuestra misión es ofrecerte una \r\nexperiencia de entrega rápida\r\nconfiable y sin complicaciones";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(192, 112);
            label3.Name = "label3";
            label3.Size = new Size(115, 33);
            label3.TabIndex = 4;
            label3.Text = "F.A.Y.A.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPedidos);
            panel1.Controls.Add(btnCesta);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 47);
            panel1.TabIndex = 5;
            // 
            // btnPedidos
            // 
            btnPedidos.AutoSize = true;
            btnPedidos.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(915, 16);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(90, 22);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "H. pedidos";
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnCesta
            // 
            btnCesta.BackColor = Color.Sienna;
            btnCesta.ForeColor = Color.Transparent;
            btnCesta.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            btnCesta.IconColor = Color.White;
            btnCesta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCesta.Location = new Point(852, 9);
            btnCesta.Margin = new Padding(3, 2, 3, 2);
            btnCesta.Name = "btnCesta";
            btnCesta.Size = new Size(43, 35);
            btnCesta.TabIndex = 4;
            btnCesta.UseVisualStyleBackColor = false;
            btnCesta.Click += btnCesta_Click;
            // 
            // btnMenu
            // 
            btnMenu.AutoSize = true;
            btnMenu.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(774, 16);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(50, 22);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "menú";
            btnMenu.Click += btnMenu_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Peru;
            btnInicio.Location = new Point(34, 16);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(81, 23);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "F.A.Y.A.";
            btnInicio.Click += btnInicio_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 473);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "inicio";
            Text = "Inicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label btnPedidos;
        private FontAwesome.Sharp.IconButton btnCesta;
        private Label btnMenu;
        private Label btnInicio;
    }
}