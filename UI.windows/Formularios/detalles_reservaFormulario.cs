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
    public partial class detalles_reservaFormulario : Form
    {
        private detalles_reservaControladorAplicacion ControladorAplicacion;
        private detalles_reservaVistaModelo VistaModelo;

        public detalles_reservaFormulario()
        {
            InitializeComponent();
            ControladorAplicacion = new detalles_reservaControladorAplicacion();
        }

        private void insertarDetalles_Reserva()
        {
            VistaModelo = new detalles_reservaVistaModelo();
            VistaModelo.barrio = txt_barrio.Text;
            VistaModelo.calles = txt_calles.Text;
            VistaModelo.casa = txt_casa.Text;
            VistaModelo.referencia = txt_referencia.Text;
            VistaModelo.telefono = txt_telefono.Text;
            if (ControladorAplicacion.InsertarDetalle_Reserva(VistaModelo))
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
            else
            {
                MessageBox.Show("Error: No se puede ingresar los datos");
            }
        }

        private void listarDetalles_Reserva()
        {
            dg_detalles_reserva.DataSource = ControladorAplicacion.ListarDetalles_Reserva();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            insertarDetalles_Reserva();
            listarDetalles_Reserva();
        }

        private void detalles_reservaFormulario_Load(object sender, EventArgs e)
        {
            listarDetalles_Reserva();
        }
    }
}
