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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            panel1.Size = new Size(1217, 62);
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
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 114);
            label1.Name = "label1";
            label1.Size = new Size(337, 37);
            label1.TabIndex = 8;
            label1.Text = "CARRITO DE COMPRAS";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { " PRODUCTO                                        PRECIO                    CANTIDAD               SUB TOTAL", " ______________________________________________________________________________________________________________________________", "", "BK STACKER                                        S/23.90                           2                           S/47.80", "doble junior", "______________________________________________________________________________________________________________________________", "", "PIZZA DOBLE", "O NADA                                              S/72.90                           1                           S/72.90", "FAMILIAR", "_______________________________________________________________________________________________________________________________", "", "", "MEGA BOX                                          S/115.00                         1                           S/115.00", "", "_______________________________________________________________________________________________________________________________" });
            listBox1.Location = new Point(40, 176);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1120, 483);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Red;
            iconButton3.ForeColor = Color.Transparent;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(843, 348);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(55, 53);
            iconButton3.TabIndex = 13;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 572);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 16;
            label2.Text = "< Continue Comprando";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LimeGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(825, 567);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 17;
            label3.Text = "Pagos >";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(604, 567);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 18;
            label4.Text = "Total ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(669, 572);
            label6.Name = "label6";
            label6.Size = new Size(72, 22);
            label6.TabIndex = 19;
            label6.Text = "S/235.7";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Red;
            iconButton2.ForeColor = Color.Transparent;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(843, 462);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(55, 53);
            iconButton2.TabIndex = 20;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Red;
            iconButton4.ForeColor = Color.Transparent;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(843, 235);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(55, 53);
            iconButton4.TabIndex = 21;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(551, 235);
            button1.Name = "button1";
            button1.Size = new Size(37, 29);
            button1.TabIndex = 22;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(551, 350);
            button2.Name = "button2";
            button2.Size = new Size(37, 29);
            button2.TabIndex = 23;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(551, 462);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 24;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(551, 372);
            button4.Name = "button4";
            button4.Size = new Size(37, 29);
            button4.TabIndex = 25;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(551, 259);
            button5.Name = "button5";
            button5.Size = new Size(37, 29);
            button5.TabIndex = 26;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(551, 486);
            button6.Name = "button6";
            button6.Size = new Size(37, 29);
            button6.TabIndex = 27;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 696);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(iconButton4);
            Controls.Add(iconButton2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iconButton3);
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
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}