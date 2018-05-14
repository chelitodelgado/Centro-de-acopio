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
    public partial class Modificaciones : Form
    {
        public Modificaciones()
        {
            InitializeComponent();
            /*
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Correo";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Apellido Paterno";
            dataGridView1.Columns[3].Name = "Apellido Materno";
            dataGridView1.Columns[4].Name = "Dirección";
            dataGridView1.Columns[5].Name = "Telefono";
            */

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        MaraTabla obj = new MaraTabla();
        private void Modificaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.VistaTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton de eliminar
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            MySqlConnection conexion = new MySqlConnection();
            String cadenaconexion;
            cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
            conexion.ConnectionString = cadenaconexion;

            //codigo de pruba
            MySqlCommand comandop = new MySqlCommand(" DELETE FROM usuarios WHERE correo='"+selected+"' ");
            comandop.Connection = conexion;
            conexion.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(comandop);
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            dataGridView1.DataSource = Consulta;
            dataGridView1.DataSource = obj.VistaTabla();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            panel_update.Visible = true;


            txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_appt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_apmt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_direccion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_telefono.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            //UPDATE peopleTB SET Name = '" + name + "', Position = '" + pos + "', Team = '" + team + "' WHERE ID = " + id + "";
            String correo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            String nombre = txt_nombre.Text;
            String appt = txt_appt.Text;
            String apmt = txt_apmt.Text;
            String dire = txt_direccion.Text;
            String tel = txt_telefono.Text;

            MySqlConnection conexion = new MySqlConnection();
            String cadenaconexion;
            cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
            conexion.ConnectionString = cadenaconexion;

            //codigo de pruba
            MySqlCommand update = new MySqlCommand(" UPDATE usuarios SET nombre='"+nombre+ "', appt='" +appt+ "',apmt='" +apmt+ "',direccion='" +dire+ "',telefono='" + tel+"' WHERE correo='"+correo+"' ");
            update.Connection = conexion;
            conexion.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(update);
            DataTable actualiza = new DataTable();
            adp.Fill(actualiza);
            dataGridView1.DataSource = actualiza;
            dataGridView1.DataSource = obj.VistaTabla();

            panel_update.Visible = false;

        }
    }
}
