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
            if (rad_norte.Checked)
                VistaModelo.norte = rad_norte.Text;
            else if (rad_centro.Checked)
                VistaModelo.centro = rad_centro.Text;
            else if (rad_sur.Checked)
                VistaModelo.sur = rad_sur.Text;
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
