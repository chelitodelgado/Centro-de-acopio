using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace CentroDeAcopio
{
    public partial class Form1 : Form
    {
        public Form1(String usr1, String foto)
        {
            InitializeComponent();
            this.usr1 = usr1;
            this.foto = foto;
        }
        String foto="";
        String usr1="";
        //funcion de mdicontainer en paneles
        private void AbrirFormHija(object fomrhija)
        {
            if (this.Container.Controls.Count > 0)
                this.Container.Controls.RemoveAt(0);
            Form fh = fomrhija as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Container.Controls.Add(fh);
            this.Container.Tag = fh;
            fh.Show();
        }
            //termina


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            normal.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            normal.Visible = false;
            pictureBox2.Visible = true;

        }

        private void Batta_Titulo_Paint(object sender, PaintEventArgs e)
        {
            lbl_correo.Text = Convert.ToString(usr1);
            
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Mueve ventaba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //terminar

        private void Form1_Load(object sender, EventArgs e)
        {
            //CODIGO DE LA FOTO

            
            //pictureBox1.Image = Image.FromFile(foto);


        }

        private void Batta_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_registrpU_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RegistroP());
        }

        private void btn_ConsultaG_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Formularios.ConsultaG());
        }

        private void btn_ConsultaI_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Formularios.ConsultaP());
        }

        private void btn_ModificarU_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Formularios.Modificaciones());
        }

        private void btn_submenu_Click(object sender, EventArgs e)
        {
            p_submenu.Visible = true; 
        }

        private void btn_EliminaU_Click(object sender, EventArgs e)
        {

        }

        private void btn_altasProductos_Click(object sender, EventArgs e)
        {
            p_submenu.Visible = false;
            AbrirFormHija(new Formularios.Productos());
        }

        private void btn_ConsultaP_Click(object sender, EventArgs e)
        {
            p_submenu.Visible = false;
            AbrirFormHija(new Formularios.ConsultaGP());
        }

        private void btn_registrpU_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormHija(new RegistroP());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
