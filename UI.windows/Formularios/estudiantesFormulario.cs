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
    public partial class estudiantesFormulario : Form
    {
        private estudiantesControladorAplicacion ControladorAplicacion;
        private estudiantesVistaModelo VistaModelo;

        public estudiantesFormulario()
        {
            InitializeComponent();
            ControladorAplicacion = new estudiantesControladorAplicacion();
        }

        private void insertarEstudiantes()
        {
            VistaModelo = new estudiantesVistaModelo();
<<<<<<< HEAD
            VistaModelo.nombre =   txt_nombre.Text;
            VistaModelo.apellido = txt_apellido.Text;
            VistaModelo.cedula = (int)num_cedula.Value;
            VistaModelo.edad = txt_edad.Text;
            VistaModelo.especialidad = com_especialidad.Text;
            VistaModelo.semestre = com_semestre.Text;
            VistaModelo.fecha_Registro = date_fecha_registro.Value;
=======
            VistaModelo.Nombre =   txt_nombre.Text;
            VistaModelo.Apellido = txt_apellido.Text;
            VistaModelo.Cedula = (int)num_cedula.Value;
            VistaModelo.Edad = txt_edad.Text;
            VistaModelo.Especialidad = lis_especialidad.Text;
            VistaModelo.Semestre = lis_semestre.Text;
            VistaModelo.Fecha_Registro = date_fecha_registro.Value;
>>>>>>> 0b396eb7c67f8274a92cc78f969bcfe5489dc099
            if (ControladorAplicacion.InsertarEstudiante(VistaModelo))
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
            else
            {
                MessageBox.Show("Error: No se puede ingresar los datos");
            }
        }

        private void listarEstudiantes()
        {
            dg_estudiantes.DataSource = ControladorAplicacion.ListarEstudiantes();
        }

        
        private void bt_guardar_Click(object sender, EventArgs e)
        {
            insertarEstudiantes();
            listarEstudiantes();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (dg_estudiantes.SelectedRows.Count > 0)
            {
                // Obtén el ID del estudiante seleccionado (suponiendo que el ID está en la primera columna)
                int idEstudiante = Convert.ToInt32(dg_estudiantes.SelectedRows[0].Cells["id_estudiante"].Value);

                // Pregunta al usuario si realmente desea eliminar el estudiante
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este estudiante?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Llama al método EliminarEstudiante del controlador de aplicación
                    if (ControladorAplicacion.EliminarEstudiante(idEstudiante))
                    {
                        MessageBox.Show("Estudiante eliminado correctamente");
                        listarEstudiantes(); // Actualiza la lista después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el estudiante");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminar");
            }
        }

        private void estudiantesFormulario_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
        }
    }
}
