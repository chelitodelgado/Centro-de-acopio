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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            /*
            //VARIABLES DECLARADAS
            txt_id.Enabled = false; 
            txt_cantidad.Enabled = false; 
            txt_presentacion.Enabled = false;
            date_caducidad.Enabled = false;
            date_registro.Enabled = false;
            btn_registroP.Enabled = false;
            */

        }

        private void com_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (com_categorias.SelectedItem.ToString() == "Higiene personal")
            {
                com_higiene.Visible = true;
                com_alimentos.Visible = false;
                com_vestir.Visible = false;

                //activo los componente
                txt_id.Enabled = true;
                txt_cantidad.Enabled = true;
                txt_presentacion.Enabled = true;
                date_caducidad.Enabled = true;
                date_registro.Enabled = true;
                btn_registroP.Enabled = true;
            }
            else if (com_categorias.SelectedItem.ToString() == "Alimentos")
            {
                com_alimentos.Visible = true;
                com_vestir.Visible = false;
                com_higiene.Visible = false;

                //activo los componente
                txt_id.Enabled = true;
                txt_cantidad.Enabled = true;
                txt_presentacion.Enabled = true;
                date_caducidad.Enabled = true;
                date_registro.Enabled = true;
                btn_registroP.Enabled = true;
            }
            else if (com_categorias.SelectedItem.ToString() == "Vestir")
            {
                com_vestir.Visible = true;
                com_higiene.Visible = false;
                com_alimentos.Visible = false;

                //activo los componente
                txt_id.Enabled = true;
                txt_cantidad.Enabled = true;
                txt_presentacion.Enabled = true;
                date_caducidad.Enabled = true;
                date_registro.Enabled = true;
                btn_registroP.Enabled = true;
            }
            
        }

        private void btn_registroP_Click(object sender, EventArgs e)
        {
            //VARIABLES DECLARADAS
            String cate = com_categorias.SelectedItem.ToString();
            String id = txt_id.Text;
            
            int cantidad = int.Parse(txt_cantidad.Text);
            String present = txt_presentacion.Text;
            String caducidad = date_caducidad.Value.Date.ToShortDateString(); 
            String registro = date_registro.Value.Date.ToShortDateString();

            if (txt_id.Text.Equals("") || txt_cantidad.Text.Equals("") || txt_presentacion.Text.Equals("") || com_categorias.Text.Equals("") || com_higiene.Text.Equals("") || com_alimentos.Text.Equals("") ||
                com_vestir.Text.Equals("") || date_caducidad.Text.Equals("") || date_registro.Text.Equals(""))
            {
                MessageBox.Show("Porfavor rellene los compos");
            }
            else
            {
                if (com_categorias.SelectedItem.ToString() == "Higiene personal")
                {
                    String produ = com_higiene.SelectedItem.ToString();

                    com_higiene.Visible = true;
                    com_alimentos.Visible = false;
                    com_vestir.Visible = false;

                    //activo los componente
                    txt_id.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_presentacion.Enabled = true;
                    date_caducidad.Enabled = true;
                    date_registro.Enabled = true;
                    btn_registroP.Enabled = true;

                    //conexion
                    MySqlConnection conexion = new MySqlConnection();
                    String cadenaconexion;
                    cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=chelo; pwd=ParedesMint;");
                    conexion.ConnectionString = cadenaconexion;

                    //no encripta la respuesta
                    MySqlCommand registraP = new MySqlCommand(String.Format(" insert into productos values('" + cate + "','" + id + "','" + produ + "','" + cantidad + "','" + present + "','" + caducidad + "','" + registro + "') "));
                    registraP.Connection = conexion;

                    conexion.Open();
                    try
                    {
                        registraP.ExecuteNonQuery();
                        MessageBox.Show("Producots registrados!!", "conectado");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("se ha producido un error" + er + "");
                    }
                    conexion.Close();



                }
                else if (com_categorias.SelectedItem.ToString() == "Alimentos")
                {
                    String produc = com_alimentos.SelectedItem.ToString();

                    com_alimentos.Visible = true;
                    com_vestir.Visible = false;
                    com_higiene.Visible = false;

                    //activo los componente
                    txt_id.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_presentacion.Enabled = true;
                    date_caducidad.Enabled = true;
                    date_registro.Enabled = true;
                    btn_registroP.Enabled = true;

                    //conexion
                    MySqlConnection conexion = new MySqlConnection();
                    String cadenaconexion;
                    cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=chelo; pwd=ParedesMint;");
                    conexion.ConnectionString = cadenaconexion;

                    //no encripta la respuesta
                    MySqlCommand registraP = new MySqlCommand(String.Format(" insert into productos values('" + cate + "','" + id + "','" + produc + "','" + cantidad + "','" + present + "','" + caducidad + "','" + registro + "') "));
                    registraP.Connection = conexion;

                    conexion.Open();
                    try
                    {
                        registraP.ExecuteNonQuery();
                        MessageBox.Show("Producots registrados!!", "conectado");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("se ha producido un error" + er + "");
                    }
                    conexion.Close();


                }
                else if (com_categorias.SelectedItem.ToString() == "Vestir")
                {

                    String producto = com_vestir.SelectedItem.ToString();

                    com_vestir.Visible = true;
                    com_higiene.Visible = false;
                    com_alimentos.Visible = false;

                    //activo los componente
                    txt_id.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_presentacion.Enabled = true;
                    date_caducidad.Enabled = true;
                    date_registro.Enabled = true;
                    btn_registroP.Enabled = true;

                    //conexion
                    MySqlConnection conexion = new MySqlConnection();
                    String cadenaconexion;
                    cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=chelo; pwd=ParedesMint;");
                    conexion.ConnectionString = cadenaconexion;

                    //no encripta la respuesta
                    MySqlCommand registraP = new MySqlCommand(String.Format(" insert into productos values('" + cate + "','" + id + "','" + producto + "','" + cantidad + "','" + present + "','" + caducidad + "','" + registro + "') "));
                    registraP.Connection = conexion;

                    conexion.Open();
                    try
                    {
                        registraP.ExecuteNonQuery();
                        MessageBox.Show("Producots registrados!!", "conectado");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("se ha producido un error" + er + "");
                    }
                    conexion.Close();


                }
            }
















            /*else
            {
                MySqlConnection conexion = new MySqlConnection();
                String cadenaconexion;
                cadenaconexion = String.Format("server=localhost; database=centroacopio; Uid=chelo; pwd=ParedesMint;");
                conexion.ConnectionString = cadenaconexion;

                //no encripta la respuesta
                MySqlCommand registraP = new MySqlCommand(String.Format(" insert into productos values('"+cate+"','"+id+"','"+produ+"','"+cantidad+"','"+present+"','"+caducidad+"','"+registro+"') "));
                registraP.Connection = conexion;

                conexion.Open();
                try
                {
                    registraP.ExecuteNonQuery();
                    MessageBox.Show("Producots registrados!!", "conectado");
                }
                catch (Exception er)
                {
                    MessageBox.Show("se ha producido un error" + er + "");
                }
                conexion.Close();
            }*/





        }
        
    }
}
