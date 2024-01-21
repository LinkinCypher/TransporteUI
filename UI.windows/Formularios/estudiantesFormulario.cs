﻿using System;
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
            VistaModelo.nombre =   txt_nombre.Text;
            VistaModelo.apellido = txt_apellido.Text;
            //VistaModelo.cedula = num_cedula.Value;
            VistaModelo.edad = txt_edad.Text;
            VistaModelo.especialidad = txt_especialidad.Text;
            VistaModelo.semestre = txt_semestre.Text;
            VistaModelo.fecha_Registro = date_fecha_registro.Value;
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

        private void estudiantesFormulario_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
        }
    }
}