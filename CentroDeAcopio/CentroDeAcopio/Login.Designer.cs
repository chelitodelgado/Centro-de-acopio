namespace CentroDeAcopio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btb_minimizar = new System.Windows.Forms.PictureBox();
            this.btb_cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.si_no = new System.Windows.Forms.CheckBox();
            this.lbl_recupera = new System.Windows.Forms.LinkLabel();
            this.lbl_pass = new MaterialSkin.Controls.MaterialLabel();
            this.txt_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_correo = new MaterialSkin.Controls.MaterialLabel();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btb_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btb_minimizar);
            this.panel1.Controls.Add(this.btb_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btb_minimizar
            // 
            this.btb_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btb_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btb_minimizar.Image")));
            this.btb_minimizar.Location = new System.Drawing.Point(248, 4);
            this.btb_minimizar.Name = "btb_minimizar";
            this.btb_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btb_minimizar.TabIndex = 7;
            this.btb_minimizar.TabStop = false;
            this.btb_minimizar.Click += new System.EventHandler(this.btb_minimizar_Click);
            // 
            // btb_cerrar
            // 
            this.btb_cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btb_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btb_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btb_cerrar.Image")));
            this.btb_cerrar.Location = new System.Drawing.Point(272, 4);
            this.btb_cerrar.Name = "btb_cerrar";
            this.btb_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btb_cerrar.TabIndex = 6;
            this.btb_cerrar.TabStop = false;
            this.btb_cerrar.Click += new System.EventHandler(this.btb_cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btn_ingreso);
            this.panel2.Controls.Add(this.si_no);
            this.panel2.Controls.Add(this.lbl_recupera);
            this.panel2.Controls.Add(this.lbl_pass);
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.lbl_correo);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.img1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 429);
            this.panel2.TabIndex = 1;
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.Orange;
            this.btn_ingreso.FlatAppearance.BorderSize = 0;
            this.btn_ingreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingreso.ForeColor = System.Drawing.Color.White;
            this.btn_ingreso.Location = new System.Drawing.Point(58, 275);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(183, 30);
            this.btn_ingreso.TabIndex = 39;
            this.btn_ingreso.Text = "Ingresar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // si_no
            // 
            this.si_no.AutoSize = true;
            this.si_no.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si_no.ForeColor = System.Drawing.Color.Black;
            this.si_no.Location = new System.Drawing.Point(52, 244);
            this.si_no.Name = "si_no";
            this.si_no.Size = new System.Drawing.Size(182, 25);
            this.si_no.TabIndex = 7;
            this.si_no.Text = "Mostrar contraseña";
            this.si_no.UseVisualStyleBackColor = true;
            this.si_no.CheckedChanged += new System.EventHandler(this.si_no_CheckedChanged);
            // 
            // lbl_recupera
            // 
            this.lbl_recupera.AutoSize = true;
            this.lbl_recupera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recupera.LinkColor = System.Drawing.Color.Black;
            this.lbl_recupera.Location = new System.Drawing.Point(76, 375);
            this.lbl_recupera.Name = "lbl_recupera";
            this.lbl_recupera.Size = new System.Drawing.Size(158, 21);
            this.lbl_recupera.TabIndex = 6;
            this.lbl_recupera.TabStop = true;
            this.lbl_recupera.Text = "Olvide Contraseña";
            this.lbl_recupera.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_recupera_LinkClicked);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Depth = 0;
            this.lbl_pass.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pass.Location = new System.Drawing.Point(106, 191);
            this.lbl_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(86, 19);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Contraseña";
            // 
            // txt_pass
            // 
            this.txt_pass.Depth = 0;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Hint = "";
            this.txt_pass.Location = new System.Drawing.Point(54, 215);
            this.txt_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.Size = new System.Drawing.Size(195, 23);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Depth = 0;
            this.lbl_correo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_correo.Location = new System.Drawing.Point(119, 132);
            this.lbl_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(55, 19);
            this.lbl_correo.TabIndex = 2;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Hint = "";
            this.txt_correo.Location = new System.Drawing.Point(52, 156);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(195, 23);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(109, 27);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(72, 72);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btb_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lbl_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_pass;
        private MaterialSkin.Controls.MaterialLabel lbl_correo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox btb_minimizar;
        private System.Windows.Forms.PictureBox btb_cerrar;
        private System.Windows.Forms.LinkLabel lbl_recupera;
        private System.Windows.Forms.CheckBox si_no;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}