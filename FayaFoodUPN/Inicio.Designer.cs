﻿namespace FayaFoodUPN
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
            label6 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 159);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(434, 210);
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
            label3.Location = new Point(219, 150);
            label3.Name = "label3";
            label3.Size = new Size(145, 43);
            label3.TabIndex = 4;
            label3.Text = "F.A.Y.A.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 62);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1046, 21);
            label6.Name = "label6";
            label6.Size = new Size(113, 26);
            label6.TabIndex = 6;
            label6.Text = "H. pedidos";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Sienna;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            iconButton1.IconColor = Color.White;
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
            label5.ForeColor = Color.White;
            label5.Location = new Point(884, 21);
            label5.Name = "label5";
            label5.Size = new Size(67, 26);
            label5.TabIndex = 5;
            label5.Text = "menú";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
            label1.TabIndex = 1;
            label1.Text = "F.A.Y.A.";
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 631);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private Label label1;
    }
}