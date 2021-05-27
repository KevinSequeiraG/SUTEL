using SUTEL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUTEL
{
    public partial class Form1 : Form
    {
        List<Telefono> listaTelefonos;
        public Form1()
        {
            InitializeComponent();
            listaTelefonos = new List<Telefono>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Telefono telefono = new Telefono();
                var prov = FactoryProveedor.CrearProveedor(rdbKolbi.Checked, rdbMovistar.Checked, rdbClaro.Checked, int.Parse(nudMins.Value.ToString()));
                FacadeProveedor fProveedor = new FacadeProveedor();

                telefono.agregarProveedor(prov);
                telefono.minutos = int.Parse(nudMins.Value.ToString());
                telefono.numero = txtNumero.Text;

                int i = dgrTelefonos.Rows.Add();
                dgrTelefonos.Rows[i].Cells[0].Value = fProveedor.nombreProveedor(telefono.proveedor);
                dgrTelefonos.Rows[i].Cells[1].Value = telefono.numero;
                dgrTelefonos.Rows[i].Cells[2].Value = telefono.minutos;
                dgrTelefonos.Rows[i].Cells[3].Value = fProveedor.ObtenerCosto(telefono.proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            nudMins.Value = 0;
        }
    }
}
