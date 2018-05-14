using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeAcopio.DAO
{
    class Conexion
    {
        MySqlConnection conexion_;
        String Cadena;
        public MySqlConnection conectar()
        {
            Cadena = String.Format("server=localhost; database=centroacopio; Uid=root; pwd=ParedesMint;");
            conexion_ = new MySqlConnection(Cadena);
            return conexion_;
        }

        public void AbrirConexion()
        {
            conexion_.Open();
        }

        public void CerrarConexion()
        {
            conexion_.Close();
        }
    }
}
