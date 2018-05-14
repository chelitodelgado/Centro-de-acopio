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

namespace CentroDeAcopio.Formularios
{
    public partial class ConsultaE : Form
    {
        public ConsultaE()
        {
            InitializeComponent();
        }

        ConsultarE obj = new ConsultarE();

        private void ConsultaE_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.VistaTablaEmpleados();
        }
    }
}
