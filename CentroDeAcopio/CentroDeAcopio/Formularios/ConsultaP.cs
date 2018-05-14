using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeAcopio.Formularios
{
    public partial class ConsultaP : Form
    {
        public ConsultaP()
        {
            InitializeComponent();
        }

        private void ConsultaP_Load(object sender, EventArgs e)
        {

        }

        private void btn_correo_Click(object sender, EventArgs e)
        {
            String correo = txt_correo.Text;
            if(txt_correo.Text.Equals(""))
            {
                MessageBox.Show("Rellene el campo");
            }else
            {
                MySqlConnection conexion = new MySqlConnection();
                String cadenaconexion;
                cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
                conexion.ConnectionString = cadenaconexion;

                //codigo de pruba
                MySqlCommand comandop = new MySqlCommand("SELECT correo,nombre,appt,apmt,direccion,telefono FROM usuarios WHERE correo='" + correo + "' ");
                comandop.Connection = conexion;
                conexion.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(comandop);
                DataTable Consulta = new DataTable();
                adp.Fill(Consulta);
                dataGridView1.DataSource = Consulta;
            }
            
        }
    }
}
