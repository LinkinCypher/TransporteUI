using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.windows.ControladoresAplicacion;
using UI.windows.VistaModelo;

namespace UI.windows.Formularios
{
    public partial class reservasFormulario : Form
    {
        private reservasControladorAplicacion ControladorAplicacion;
        private reservasVistaModelo VistaModelo;

        public reservasFormulario()
        {
            InitializeComponent();
            ControladorAplicacion = new reservasControladorAplicacion();
        }

        private void insertarReservas()
        {
            VistaModelo = new reservasVistaModelo();
            VistaModelo.norte = txt_norte.Text;
            VistaModelo.centro = txt_centro.Text;
            VistaModelo.sur = txt_sur.Text;
            if (ControladorAplicacion.InsertarReserva(VistaModelo))
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
            else
            {
                MessageBox.Show("Error: No se puede ingresar los datos");
            }
        }

        private void listarReservas()
        {
            dg_reservas.DataSource = ControladorAplicacion.ListarReservas();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            insertarReservas();
            listarReservas();
        }

        private void reservasFormulario_Load(object sender, EventArgs e)
        {
            listarReservas();
        }
    }
}
