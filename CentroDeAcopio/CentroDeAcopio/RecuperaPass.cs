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

namespace CentroDeAcopio
{
    public partial class RecuperaPass : Form
    {
        public RecuperaPass()
        {
            InitializeComponent();
        }


        private void lbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_recupera_Click_1(object sender, EventArgs e)
        {
            String correo = txt_correo.Text;
            String respuesta = txt_respuesta.Text;
            if (correo.Equals("") || comboBox1.Text.Equals("[Elige Una Pregunta]") || respuesta.Equals(""))
            {
                MessageBox.Show(" Rellena los campo", "Verifica tus datos denuevo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
            else
            {
                MySqlConnection conexion = new MySqlConnection();
                String Cadena;
                Cadena = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
                MySqlCommand busqueda = new MySqlCommand(String.Format("SELECT aes_decrypt(password,'" + respuesta + "') FROM usuarios WHERE correo='" + correo + "' ", txt_respuesta.Text, txt_correo.Text));
                conexion.ConnectionString = Cadena;
                busqueda.Connection = conexion;
                conexion.Open();
                MySqlDataReader myreader = busqueda.ExecuteReader();


                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        txt_recupera.Text = myreader.IsDBNull(0) ? "" : myreader.GetString(0);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no Existe!!", " ERROR!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    correo = String.Empty;
                    comboBox1.Text = "[Elige Una Pregunta]";
                    respuesta = String.Empty;
                }
                conexion.Close();
                comboBox1.SelectedIndex = -1;
            }
        }

        private void si_no_CheckedChanged(object sender, EventArgs e)
        {
            if (si_no.Checked == true)
            {
                txt_respuesta.UseSystemPasswordChar = false;
            }
            else
                if (si_no.Checked == false)
            {
                txt_respuesta.UseSystemPasswordChar = true;
            }
        }
    }
}
