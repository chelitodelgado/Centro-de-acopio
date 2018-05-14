using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeAcopio.DAO
{
    class ConsultaProductos: Conexion
    {
        String consultaP;
        public DataTable VistaTablaProductos()
        {
            consultaP = "SELECT * FROM productos";
            MySqlDataAdapter adp = new MySqlDataAdapter(consultaP, conectar());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }
    }
}
