namespace FayaFoodUPN
{
    partial class Hpedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hpedido));
            panel1 = new Panel();
            label6 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btnInicio = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 62);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1046, 21);
            label6.Name = "label6";
            label6.Size = new Size(113, 26);
            label6.TabIndex = 6;
            label6.Text = "H. pedidos";
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
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "________________________________________________________________________________________________________________________________________________", "PEDIDO                                                                                        FECHA                                                      PRECIO                    ESTADO", "_________________________________________________________________________________________________________________________________________________", "", "Bk Stacker Doble Junior                                                Lunes 2 Septiembre, 2024                                     S/23.90                     Pagado", "", "", "Pizza Doble o Nada Familiar                                        Lunes 2 Septiembre, 2024                                     S/72.90                     Pagado", "", "", "Mega Box                                                                      Lunes 2 Septiembre, 2024                                     S/115.00                   Pagado", " " });
            listBox1.Location = new Point(52, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(984, 280);
            listBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 82);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 82);
            label2.Name = "label2";
            label2.Size = new Size(356, 37);
            label2.TabIndex = 10;
            label2.Text = "Historial de Pedidos";
            // 
            // Hpedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1187, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Hpedido";
            Text = "Hpedido";
            Load += Hpedido_Load;
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
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}