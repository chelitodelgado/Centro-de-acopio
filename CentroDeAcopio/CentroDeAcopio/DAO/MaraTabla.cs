using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeAcopio.DAO
{
    class MaraTabla:Conexion
    {
        String consultaG;
        public DataTable VistaTabla()
        {
            consultaG = "SELECT correo,nombre,appt,apmt,direccion,telefono,perfil FROM usuarios";
            MySqlDataAdapter adp = new MySqlDataAdapter(consultaG, conectar());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }
    }
}
