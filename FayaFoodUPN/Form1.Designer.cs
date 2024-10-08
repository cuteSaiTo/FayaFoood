namespace FayaFoodUPN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnlogin = new Button();
            label1 = new Label();
            txtpass = new TextBox();
            txtuser = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 500);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(45, 288);
            label4.Name = "label4";
            label4.Size = new Size(244, 47);
            label4.TabIndex = 1;
            label4.Text = "Delivery´s";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(105, 224);
            label3.Name = "label3";
            label3.Size = new Size(158, 47);
            label3.TabIndex = 0;
            label3.Text = "F.A.Y.A.";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(btnlogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(txtuser);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(392, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 499);
            panel2.TabIndex = 7;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Location = new Point(168, 366);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(276, 60);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "INGRESAR";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 49);
            label1.Name = "label1";
            label1.Size = new Size(223, 44);
            label1.TabIndex = 4;
            label1.Text = "bienvenido";
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = SystemColors.InactiveBorder;
            txtpass.Location = new Point(86, 266);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(424, 29);
            txtpass.TabIndex = 7;
            txtpass.Text = "CONTRASEÑA";
            txtpass.TextAlign = HorizontalAlignment.Center;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = SystemColors.InactiveBorder;
            txtuser.Location = new Point(86, 188);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(424, 29);
            txtuser.TabIndex = 5;
            txtuser.Text = "USUARIO";
            txtuser.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 234);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Button btnlogin;
        private Label label1;
        private TextBox txtpass;
        private TextBox txtuser;
        private Label label2;
    }
}
