using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeAcopio.DAO;
using MySql.Data.MySqlClient;

namespace CentroDeAcopio.Formularios
{
    public partial class ConsultaGP : Form
    {
        public ConsultaGP()
        {
            InitializeComponent();
        }
        ConsultaProductos obj = new ConsultaProductos();
        private void ConsultaGP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.VistaTablaProductos();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            // WHERE categoria="Higiene personal";
            String categoria = com_categorias.SelectedItem.ToString();

            if (com_categorias.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una opcion");
            }else
            {
                MySqlConnection conexion = new MySqlConnection();
                String cadenaconexion;
                cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
                conexion.ConnectionString = cadenaconexion;

                //codigo de pruba
                MySqlCommand comandop = new MySqlCommand("SELECT categoria,id, nom_prod, cantidad,presentacion,fecha_cad,fecha_reg FROM productos WHERE categoria='" + categoria + "' ");
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
