namespace CentroDeAcopio
{
    partial class RecuperaPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperaPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_login = new System.Windows.Forms.LinkLabel();
            this.txt_recupera = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_respuesta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_recupera = new System.Windows.Forms.Button();
            this.si_no = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 25);
            this.panel1.TabIndex = 0;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(247, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(271, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(20, 20);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.si_no);
            this.panel2.Controls.Add(this.btn_recupera);
            this.panel2.Controls.Add(this.lbl_login);
            this.panel2.Controls.Add(this.txt_recupera);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txt_respuesta);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 425);
            this.panel2.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.LinkColor = System.Drawing.Color.Black;
            this.lbl_login.Location = new System.Drawing.Point(122, 398);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(43, 17);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.TabStop = true;
            this.lbl_login.Text = "Login";
            this.lbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_login_LinkClicked);
            // 
            // txt_recupera
            // 
            this.txt_recupera.Depth = 0;
            this.txt_recupera.Hint = "";
            this.txt_recupera.Location = new System.Drawing.Point(69, 348);
            this.txt_recupera.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_recupera.Name = "txt_recupera";
            this.txt_recupera.PasswordChar = '\0';
            this.txt_recupera.SelectedText = "";
            this.txt_recupera.SelectionLength = 0;
            this.txt_recupera.SelectionStart = 0;
            this.txt_recupera.Size = new System.Drawing.Size(147, 23);
            this.txt_recupera.TabIndex = 7;
            this.txt_recupera.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(96, 162);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 21);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Seleccione";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "¿Numero de control?",
            "¿Color favorito?",
            "¿Nombre de tu mascota?",
            "¿Pelicula favorita?"});
            this.comboBox1.Location = new System.Drawing.Point(45, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Elige una pregunta";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Depth = 0;
            this.txt_respuesta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.Hint = "";
            this.txt_respuesta.Location = new System.Drawing.Point(45, 245);
            this.txt_respuesta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.PasswordChar = '\0';
            this.txt_respuesta.SelectedText = "";
            this.txt_respuesta.SelectionLength = 0;
            this.txt_respuesta.SelectionStart = 0;
            this.txt_respuesta.Size = new System.Drawing.Size(194, 23);
            this.txt_respuesta.TabIndex = 4;
            this.txt_respuesta.UseSystemPasswordChar = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(93, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 21);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Respuesta";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Hint = "";
            this.txt_correo.Location = new System.Drawing.Point(45, 130);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(194, 23);
            this.txt_correo.TabIndex = 2;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(115, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 21);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Correo";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_recupera
            // 
            this.btn_recupera.BackColor = System.Drawing.Color.Orange;
            this.btn_recupera.FlatAppearance.BorderSize = 0;
            this.btn_recupera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_recupera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_recupera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recupera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recupera.ForeColor = System.Drawing.Color.White;
            this.btn_recupera.Location = new System.Drawing.Point(52, 307);
            this.btn_recupera.Name = "btn_recupera";
            this.btn_recupera.Size = new System.Drawing.Size(183, 30);
            this.btn_recupera.TabIndex = 40;
            this.btn_recupera.Text = "Recuperar";
            this.btn_recupera.UseVisualStyleBackColor = false;
            this.btn_recupera.Click += new System.EventHandler(this.btn_recupera_Click_1);
            // 
            // si_no
            // 
            this.si_no.AutoSize = true;
            this.si_no.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si_no.ForeColor = System.Drawing.Color.Black;
            this.si_no.Location = new System.Drawing.Point(45, 274);
            this.si_no.Name = "si_no";
            this.si_no.Size = new System.Drawing.Size(182, 25);
            this.si_no.TabIndex = 41;
            this.si_no.Text = "Mostrar contraseña";
            this.si_no.UseVisualStyleBackColor = true;
            this.si_no.CheckedChanged += new System.EventHandler(this.si_no_CheckedChanged);
            // 
            // RecuperaPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperaPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperaPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_respuesta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_login;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_recupera;
        protected internal MaterialSkin.Controls.MaterialSingleLineTextField txt_recupera;
        private System.Windows.Forms.CheckBox si_no;
    }
}