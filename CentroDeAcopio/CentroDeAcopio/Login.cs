using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace CentroDeAcopio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //variable correo
        String usr1 = "";
        String foto = "";

        private void btb_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_recupera_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RecuperaPass guia = new RecuperaPass();
            guia.Show();
        }

        private void si_no_CheckedChanged(object sender, EventArgs e)
        {
            if (si_no.Checked==true)
            {
                txt_pass.UseSystemPasswordChar = false;
            }else
                if (si_no.Checked==false)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            
            //boton de login
            if (txt_correo.Text.Equals("") || txt_pass.Text.Equals(""))
            {
                MessageBox.Show(" Debes Rellenar Todos Los Campos", "   ERROR!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }//fin if
            else
            {
                
                String correo = txt_correo.Text;
                String pass = txt_pass.Text;
                MySqlConnection conexion = new MySqlConnection();
                String cadenaconexion;
                cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
                conexion.ConnectionString = cadenaconexion;

                //codigo de pruba
                MySqlCommand comandop = new MySqlCommand("SELECT perfil FROM usuarios WHERE correo='" + correo + "' ");
                comandop.Connection = conexion;
                conexion.Open();

                MySqlDataReader profile = comandop.ExecuteReader();
                String perfil_ = "";
                try
                {
                    if (profile.HasRows)
                    {
                        while (profile.Read())
                        {
                            perfil_ = profile[0] + "";
                        }

                    }
                }
                catch (Exception) { }
                conexion.Close();
                //fin de co

                //mas codgo de pruba de foto
                //codigo de pruba
                MySqlCommand comandoF = new MySqlCommand("SELECT foto FROM usuarios WHERE correo='" + correo + "' ");
                comandoF.Connection = conexion;
                conexion.Open();

                MySqlDataReader fotito = comandoF.ExecuteReader();
                
                try
                {
                    if (fotito.HasRows)
                    {
                        while (fotito.Read())
                        {

                            foto = fotito[0] + "";
                        }
                        
                    }
                }
                catch (Exception) { }
                conexion.Close();
                //termina qui

                MySqlCommand comando1 = new MySqlCommand("SELECT pregunta FROM usuarios WHERE correo='" + correo + "' AND perfil='" + perfil_ + "' ");
                comando1.Connection = conexion;
                conexion.Open();

                MySqlDataReader myreader = comando1.ExecuteReader();
                String resp = "";
                try
                {
                    if (myreader.HasRows)
                    {
                        while (myreader.Read())
                        {
                            resp = myreader[0] + "";
                        }
                      
                    }
                }
                catch (Exception) { }
                conexion.Close();

                MySqlCommand comand2 = new MySqlCommand("SELECT correo FROM usuarios WHERE  password=aes_encrypt('" + pass + "','" + resp + "'); ");
                comand2.Connection = conexion;
                conexion.Open();
                //String usr1 = "";
                MySqlDataReader myreader2 = comand2.ExecuteReader();
                Boolean band = false;
                try
                {
                    if (myreader2.HasRows)
                    {
                        while (myreader2.Read())
                        {
                            usr1 = myreader2[0] + " ";
                            band = true;
                            //MessageBox.Show( foto );
                        }

                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos ");
                    }
                }
                catch (Exception) { }
                conexion.Close();
                if (band == true)
                {
                    if (perfil_ == "Administrador")
                    {
                        Form1 menu = new Form1(usr1,foto);
                        menu.Show();
                        this.Hide();
                    }
                    else
                        if (perfil_ == "Encargado")
                    {
                        Form2 menu = new Form2(usr1,foto);
                        menu.Show();
                        this.Hide();
                    }
                }
            }
        }
        //terminar
    }
}
