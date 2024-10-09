namespace FayaFoodUPN
{
    partial class menu
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
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            panel1 = new Panel();
            label6 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btnInicio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 47);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(915, 16);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
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
            iconButton1.Location = new Point(852, 9);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 35);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(774, 16);
            label5.Name = "label5";
            label5.Size = new Size(50, 22);
            label5.TabIndex = 5;
            label5.Text = "menú";
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
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 508);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "menu";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Panel panel1;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private Label btnInicio;
    }
}