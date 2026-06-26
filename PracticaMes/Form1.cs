using PracticaMes.Instancia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Estacionamiento vehiculo = null;

            string Tipovehiculo = cmbVehiculo.Text.Trim();
            int HorasIngresadas = int.Parse(txtHoras.Text.Trim());

            if (Tipovehiculo == "Motocicleta")
            {

            }
            else if (Tipovehiculo == "Automovil")
            {


            }
            else if (Tipovehiculo == "Camioneta")
            {

            }

            if (vehiculo != null)
            {
                float precioFinal = vehiculo.calcularPrecioFinal();

                lblPagar.Text = "Total a pagar: $" + precioFinal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
