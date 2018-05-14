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
using System.Text.RegularExpressions;

namespace CentroDeAcopio
{
    public partial class RegistroP : Form
    {
        
        public RegistroP()
        {
            InitializeComponent();
        }
        private void RegistroP_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {

            String correo = txt_correo.Text;
            String nombre = txt_nombre.Text;
            String appt = txt_ap.Text;
            String apmt = txt_am.Text;
            String direc = txt_direc.Text;
            String tel = txt_tel.Text;
            String pass = txt_pass1.Text;
            String resp = txt_resp.Text;
            String perfil = comboBox2.SelectedItem.ToString();
            String foto = @"C:\NET\solecito.jpg";

            if (pass.Equals("") || resp.Equals("") || comboBox1.Text.Equals("Elige una pregunta") || correo.Equals("") ||  nombre.Equals("")
                || appt.Equals("") || apmt.Equals("") || direc.Equals("") || tel.Equals("") || comboBox2.Text.Equals("Elige tu perfil"))
            {
                MessageBox.Show(" Debes Rellenar Todos Los Campos" , "   ERROR!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }
            else
            {
                MySqlConnection conexion = new MySqlConnection();
                String cadenaconexion;
                cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=chelo; pwd=ParedesMint;");
                conexion.ConnectionString = cadenaconexion;

                //no encripta la respuesta
                MySqlCommand registra = new MySqlCommand(String.Format("INSERT INTO usuarios values('" + correo + "','" + nombre + "','" + appt + "','" + apmt + "','" + direc + "','" + tel + "',aes_encrypt('" + pass + "','" + resp + "'),'" + resp + "','" + perfil + "','" + foto + "')"));
                registra.Connection = conexion;

                conexion.Open();
                try
                {
                    registra.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado!!", "conectado");
                    txt_correo.Clear();
                }
                catch (Exception er)
                {
                    MessageBox.Show("se ha producido un error" + er + "");
                }
                conexion.Close();
            }
        }

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;
                    lbl_ruta.Text = imagen;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error intente denuevo"+ex.StackTrace);
            }
        }
    }
}
