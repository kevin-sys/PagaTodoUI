using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;


namespace PagaTodoGUI
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            TablaConsignacion.DataSource = null;
            TablaConsignacion.DataSource = ConsignacionService.Consultar();
           
            int suma = 0;
            foreach (DataGridViewRow row in TablaConsignacion.Rows)
            {
                suma += Convert.ToInt32 (row.Cells["ValorPagado"].Value);
            }
            txtTotal.Text = Convert.ToString(suma);
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
