namespace CentroDeAcopio
{
    partial class RegistroP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.btn_ruta = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txt_resp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_pass1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_direc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_am = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 621);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(837, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 621);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.lbl_ruta);
            this.panel3.Controls.Add(this.btn_ruta);
            this.panel3.Controls.Add(this.btn_registro);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.txt_resp);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.txt_pass1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_tel);
            this.panel3.Controls.Add(this.txt_direc);
            this.panel3.Controls.Add(this.txt_am);
            this.panel3.Controls.Add(this.txt_ap);
            this.panel3.Controls.Add(this.txt_nombre);
            this.panel3.Controls.Add(this.txt_correo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 621);
            this.panel3.TabIndex = 2;
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta.ForeColor = System.Drawing.Color.White;
            this.lbl_ruta.Location = new System.Drawing.Point(215, 486);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(11, 16);
            this.lbl_ruta.TabIndex = 40;
            this.lbl_ruta.Text = ":";
            // 
            // btn_ruta
            // 
            this.btn_ruta.BackColor = System.Drawing.Color.Orange;
            this.btn_ruta.FlatAppearance.BorderSize = 0;
            this.btn_ruta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ruta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_ruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ruta.ForeColor = System.Drawing.Color.White;
            this.btn_ruta.Location = new System.Drawing.Point(160, 480);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(49, 23);
            this.btn_ruta.TabIndex = 39;
            this.btn_ruta.Text = "Cargar";
            this.btn_ruta.UseVisualStyleBackColor = false;
            this.btn_ruta.Click += new System.EventHandler(this.btn_ruta_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.Orange;
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.White;
            this.btn_registro.Location = new System.Drawing.Point(205, 563);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(183, 30);
            this.btn_registro.TabIndex = 38;
            this.btn_registro.Text = "Registrar Perfil";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Administrador",
            "Encargado"});
            this.comboBox2.Location = new System.Drawing.Point(160, 437);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 25);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.Text = "Elige tu perfil";
            // 
            // txt_resp
            // 
            this.txt_resp.Depth = 0;
            this.txt_resp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp.ForeColor = System.Drawing.Color.Black;
            this.txt_resp.Hint = "";
            this.txt_resp.Location = new System.Drawing.Point(160, 408);
            this.txt_resp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.PasswordChar = '\0';
            this.txt_resp.SelectedText = "";
            this.txt_resp.SelectionLength = 0;
            this.txt_resp.SelectionStart = 0;
            this.txt_resp.Size = new System.Drawing.Size(278, 23);
            this.txt_resp.TabIndex = 35;
            this.txt_resp.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "¿Nombre de tu mascota?",
            "¿Lugar de nacimiento?",
            "¿Cancion favorita?",
            "¿Pelicula o serie favorita?"});
            this.comboBox1.Location = new System.Drawing.Point(163, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 25);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Elige una pregunta";
            // 
            // txt_pass1
            // 
            this.txt_pass1.Depth = 0;
            this.txt_pass1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass1.ForeColor = System.Drawing.Color.Black;
            this.txt_pass1.Hint = "";
            this.txt_pass1.Location = new System.Drawing.Point(160, 346);
            this.txt_pass1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.PasswordChar = '\0';
            this.txt_pass1.SelectedText = "";
            this.txt_pass1.SelectionLength = 0;
            this.txt_pass1.SelectionStart = 0;
            this.txt_pass1.Size = new System.Drawing.Size(278, 23);
            this.txt_pass1.TabIndex = 33;
            this.txt_pass1.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(251, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Contraseña";
            // 
            // txt_tel
            // 
            this.txt_tel.Depth = 0;
            this.txt_tel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.ForeColor = System.Drawing.Color.Black;
            this.txt_tel.Hint = "";
            this.txt_tel.Location = new System.Drawing.Point(163, 295);
            this.txt_tel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PasswordChar = '\0';
            this.txt_tel.SelectedText = "";
            this.txt_tel.SelectionLength = 0;
            this.txt_tel.SelectionStart = 0;
            this.txt_tel.Size = new System.Drawing.Size(278, 23);
            this.txt_tel.TabIndex = 31;
            this.txt_tel.UseSystemPasswordChar = false;
            // 
            // txt_direc
            // 
            this.txt_direc.Depth = 0;
            this.txt_direc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direc.ForeColor = System.Drawing.Color.Black;
            this.txt_direc.Hint = "";
            this.txt_direc.Location = new System.Drawing.Point(163, 247);
            this.txt_direc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.PasswordChar = '\0';
            this.txt_direc.SelectedText = "";
            this.txt_direc.SelectionLength = 0;
            this.txt_direc.SelectionStart = 0;
            this.txt_direc.Size = new System.Drawing.Size(278, 23);
            this.txt_direc.TabIndex = 30;
            this.txt_direc.UseSystemPasswordChar = false;
            // 
            // txt_am
            // 
            this.txt_am.Depth = 0;
            this.txt_am.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_am.ForeColor = System.Drawing.Color.Black;
            this.txt_am.Hint = "";
            this.txt_am.Location = new System.Drawing.Point(163, 199);
            this.txt_am.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_am.Name = "txt_am";
            this.txt_am.PasswordChar = '\0';
            this.txt_am.SelectedText = "";
            this.txt_am.SelectionLength = 0;
            this.txt_am.SelectionStart = 0;
            this.txt_am.Size = new System.Drawing.Size(278, 23);
            this.txt_am.TabIndex = 29;
            this.txt_am.UseSystemPasswordChar = false;
            // 
            // txt_ap
            // 
            this.txt_ap.Depth = 0;
            this.txt_ap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ap.ForeColor = System.Drawing.Color.Black;
            this.txt_ap.Hint = "";
            this.txt_ap.Location = new System.Drawing.Point(163, 148);
            this.txt_ap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.PasswordChar = '\0';
            this.txt_ap.SelectedText = "";
            this.txt_ap.SelectionLength = 0;
            this.txt_ap.SelectionStart = 0;
            this.txt_ap.Size = new System.Drawing.Size(278, 23);
            this.txt_ap.TabIndex = 28;
            this.txt_ap.UseSystemPasswordChar = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Hint = "";
            this.txt_nombre.Location = new System.Drawing.Point(163, 100);
            this.txt_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.Size = new System.Drawing.Size(278, 23);
            this.txt_nombre.TabIndex = 27;
            this.txt_nombre.UseSystemPasswordChar = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Hint = "";
            this.txt_correo.Location = new System.Drawing.Point(163, 52);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(278, 23);
            this.txt_correo.TabIndex = 26;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(262, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(256, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apelido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Correo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistroP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroP";
            this.Text = "RegistroP";
            this.Load += new System.EventHandler(this.RegistroP_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_pass1;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_direc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_am;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_resp;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Button btn_ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}