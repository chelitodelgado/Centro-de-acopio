using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeAcopio.DAO
{
    class ConsultarE:Conexion
    {
        String consultaE;
        public DataTable VistaTablaEmpleados()
        {
            consultaE = "SELECT correo,nombre,appt,apmt,direccion,telefono FROM usuarios WHERE perfil='Empleados' ";
            MySqlDataAdapter adp = new MySqlDataAdapter(consultaE, conectar());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }
    }
}
