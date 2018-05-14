using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeAcopio
{
    public partial class Form2 : Form
    {
        public Form2(String usr1, String foto)
        {
            InitializeComponent();
            this.usr1 = usr1;
            this.foto = foto;
        }

        //Mueve ventaba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //terminar

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



        String usr1;
        String foto;

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_correo.Text = usr1;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            normal.Visible = false;
            pictureBox2.Visible = true;
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

        private void btn_ConsultaP_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Formularios.ConsultaE());
        }

        private void btn_ConsultaE_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Formularios.ConsultaE());
        }
    }
}
