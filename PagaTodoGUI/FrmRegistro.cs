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
    public partial class FrmRegistro : Form
    {
        Consignacion consignacion = new Consignacion();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }
        private Consignacion Mapear()
        {
            consignacion = new Consignacion();
            consignacion.EntidadServicios = CmbEntidad.Text;
            consignacion.NumeroRecibo = Int32.Parse(TxtNumeroRecibo.Text);
            consignacion.FechaPago = DtaFechaPago.Value.Date;
            consignacion.ValorPagado = Int32.Parse(TxtValorPagado.Text);
            return consignacion;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Consignacion consignacion = Mapear();
            string mensaje = ConsignacionService.Guardar(consignacion);
        }

        private void BtnAbrirConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar consultar = new FrmConsultar();
            consultar.Show();
            this.Visible = false;
        }
    }
}
