namespace CentroDeAcopio.Formularios
{
    partial class Productos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_presentacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_cantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.com_alimentos = new System.Windows.Forms.ComboBox();
            this.com_vestir = new System.Windows.Forms.ComboBox();
            this.btn_registroP = new System.Windows.Forms.Button();
            this.com_higiene = new System.Windows.Forms.ComboBox();
            this.com_categorias = new System.Windows.Forms.ComboBox();
            this.txt_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.date_caducidad = new System.Windows.Forms.DateTimePicker();
            this.date_registro = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.date_registro);
            this.panel1.Controls.Add(this.date_caducidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_presentacion);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.com_alimentos);
            this.panel1.Controls.Add(this.com_vestir);
            this.panel1.Controls.Add(this.btn_registroP);
            this.panel1.Controls.Add(this.com_higiene);
            this.panel1.Controls.Add(this.com_categorias);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 621);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(436, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha de registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(436, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de caducidad";
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.Depth = 0;
            this.txt_presentacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_presentacion.ForeColor = System.Drawing.Color.Black;
            this.txt_presentacion.Hint = "";
            this.txt_presentacion.Location = new System.Drawing.Point(121, 306);
            this.txt_presentacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.PasswordChar = '\0';
            this.txt_presentacion.SelectedText = "";
            this.txt_presentacion.SelectionLength = 0;
            this.txt_presentacion.SelectionStart = 0;
            this.txt_presentacion.Size = new System.Drawing.Size(278, 23);
            this.txt_presentacion.TabIndex = 51;
            this.txt_presentacion.UseSystemPasswordChar = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Depth = 0;
            this.txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.Black;
            this.txt_cantidad.Hint = "";
            this.txt_cantidad.Location = new System.Drawing.Point(121, 242);
            this.txt_cantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.PasswordChar = '\0';
            this.txt_cantidad.SelectedText = "";
            this.txt_cantidad.SelectionLength = 0;
            this.txt_cantidad.SelectionStart = 0;
            this.txt_cantidad.Size = new System.Drawing.Size(278, 23);
            this.txt_cantidad.TabIndex = 50;
            this.txt_cantidad.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Presentación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id";
            // 
            // com_alimentos
            // 
            this.com_alimentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_alimentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_alimentos.FormattingEnabled = true;
            this.com_alimentos.Items.AddRange(new object[] {
            "Sopas Instantáneas",
            "Atún",
            "Embutidos"});
            this.com_alimentos.Location = new System.Drawing.Point(414, 85);
            this.com_alimentos.Name = "com_alimentos";
            this.com_alimentos.Size = new System.Drawing.Size(278, 25);
            this.com_alimentos.TabIndex = 46;
            this.com_alimentos.Text = "Seleccione el producto";
            this.com_alimentos.Visible = false;
            // 
            // com_vestir
            // 
            this.com_vestir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_vestir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_vestir.FormattingEnabled = true;
            this.com_vestir.Items.AddRange(new object[] {
            "Pantalones",
            "Playeras",
            "Zapatos"});
            this.com_vestir.Location = new System.Drawing.Point(414, 85);
            this.com_vestir.Name = "com_vestir";
            this.com_vestir.Size = new System.Drawing.Size(278, 25);
            this.com_vestir.TabIndex = 45;
            this.com_vestir.Text = "Seleccione el producto";
            this.com_vestir.Visible = false;
            // 
            // btn_registroP
            // 
            this.btn_registroP.BackColor = System.Drawing.Color.Orange;
            this.btn_registroP.FlatAppearance.BorderSize = 0;
            this.btn_registroP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_registroP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btn_registroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registroP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registroP.ForeColor = System.Drawing.Color.White;
            this.btn_registroP.Location = new System.Drawing.Point(440, 279);
            this.btn_registroP.Name = "btn_registroP";
            this.btn_registroP.Size = new System.Drawing.Size(278, 50);
            this.btn_registroP.TabIndex = 44;
            this.btn_registroP.Text = "Registrar Perfil";
            this.btn_registroP.UseVisualStyleBackColor = false;
            this.btn_registroP.Click += new System.EventHandler(this.btn_registroP_Click);
            // 
            // com_higiene
            // 
            this.com_higiene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_higiene.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_higiene.FormattingEnabled = true;
            this.com_higiene.Items.AddRange(new object[] {
            "Shampoo ",
            "Pasta Dental ",
            "Papel Higiénico"});
            this.com_higiene.Location = new System.Drawing.Point(414, 85);
            this.com_higiene.Name = "com_higiene";
            this.com_higiene.Size = new System.Drawing.Size(278, 25);
            this.com_higiene.TabIndex = 43;
            this.com_higiene.Text = "Seleccione el producto";
            this.com_higiene.Visible = false;
            // 
            // com_categorias
            // 
            this.com_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_categorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_categorias.FormattingEnabled = true;
            this.com_categorias.Items.AddRange(new object[] {
            "Higiene personal",
            "Alimentos",
            "Vestir"});
            this.com_categorias.Location = new System.Drawing.Point(121, 85);
            this.com_categorias.Name = "com_categorias";
            this.com_categorias.Size = new System.Drawing.Size(278, 25);
            this.com_categorias.TabIndex = 41;
            this.com_categorias.Text = "Elige una categoria";
            this.com_categorias.SelectedIndexChanged += new System.EventHandler(this.com_categorias_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Hint = "";
            this.txt_id.Location = new System.Drawing.Point(121, 177);
            this.txt_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.Size = new System.Drawing.Size(278, 23);
            this.txt_id.TabIndex = 40;
            this.txt_id.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Categosrias";
            // 
            // date_caducidad
            // 
            this.date_caducidad.Location = new System.Drawing.Point(440, 180);
            this.date_caducidad.Name = "date_caducidad";
            this.date_caducidad.Size = new System.Drawing.Size(278, 20);
            this.date_caducidad.TabIndex = 54;
            // 
            // date_registro
            // 
            this.date_registro.Location = new System.Drawing.Point(440, 239);
            this.date_registro.Name = "date_registro";
            this.date_registro.Size = new System.Drawing.Size(278, 20);
            this.date_registro.TabIndex = 55;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 621);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox com_alimentos;
        private System.Windows.Forms.ComboBox com_vestir;
        private System.Windows.Forms.Button btn_registroP;
        private System.Windows.Forms.ComboBox com_higiene;
        private System.Windows.Forms.ComboBox com_categorias;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_presentacion;
        private System.Windows.Forms.DateTimePicker date_registro;
        private System.Windows.Forms.DateTimePicker date_caducidad;
    }
}