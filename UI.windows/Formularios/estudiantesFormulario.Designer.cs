namespace UI.windows.Formularios
{
    partial class estudiantesFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_estudiantes = new System.Windows.Forms.DataGridView();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.lb_especialidad = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lb_edad = new System.Windows.Forms.Label();
            this.lb_cedula = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semestre = new System.Windows.Forms.TextBox();
            this.lb_semestre = new System.Windows.Forms.Label();
            this.lb_fecha_Registro = new System.Windows.Forms.Label();
            this.num_cedula = new System.Windows.Forms.NumericUpDown();
            this.date_fecha_registro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dg_estudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cedula)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_estudiantes
            // 
            this.dg_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_estudiantes.Location = new System.Drawing.Point(284, 59);
            this.dg_estudiantes.Name = "dg_estudiantes";
            this.dg_estudiantes.Size = new System.Drawing.Size(936, 388);
            this.dg_estudiantes.TabIndex = 25;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(45, 292);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(182, 33);
            this.bt_guardar.TabIndex = 24;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(109, 189);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(169, 20);
            this.txt_especialidad.TabIndex = 23;
            // 
            // lb_especialidad
            // 
            this.lb_especialidad.AutoSize = true;
            this.lb_especialidad.Location = new System.Drawing.Point(12, 196);
            this.lb_especialidad.Name = "lb_especialidad";
            this.lb_especialidad.Size = new System.Drawing.Size(70, 13);
            this.lb_especialidad.TabIndex = 22;
            this.lb_especialidad.Text = "Especialidad:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(109, 154);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(169, 20);
            this.txt_edad.TabIndex = 21;
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Location = new System.Drawing.Point(12, 161);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(35, 13);
            this.lb_edad.TabIndex = 20;
            this.lb_edad.Text = "Edad:";
            // 
            // lb_cedula
            // 
            this.lb_cedula.AutoSize = true;
            this.lb_cedula.Location = new System.Drawing.Point(12, 128);
            this.lb_cedula.Name = "lb_cedula";
            this.lb_cedula.Size = new System.Drawing.Size(43, 13);
            this.lb_cedula.TabIndex = 18;
            this.lb_cedula.Text = "Cédula:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(109, 89);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(169, 20);
            this.txt_apellido.TabIndex = 17;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(12, 96);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(47, 13);
            this.lb_apellido.TabIndex = 16;
            this.lb_apellido.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(109, 58);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_nombre.TabIndex = 15;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(12, 65);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_nombre.TabIndex = 14;
            this.lb_nombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ESTUDIANTES";
            // 
            // txt_semestre
            // 
            this.txt_semestre.Location = new System.Drawing.Point(109, 223);
            this.txt_semestre.Name = "txt_semestre";
            this.txt_semestre.Size = new System.Drawing.Size(169, 20);
            this.txt_semestre.TabIndex = 27;
            // 
            // lb_semestre
            // 
            this.lb_semestre.AutoSize = true;
            this.lb_semestre.Location = new System.Drawing.Point(12, 230);
            this.lb_semestre.Name = "lb_semestre";
            this.lb_semestre.Size = new System.Drawing.Size(54, 13);
            this.lb_semestre.TabIndex = 26;
            this.lb_semestre.Text = "Semestre:";
            // 
            // lb_fecha_Registro
            // 
            this.lb_fecha_Registro.AutoSize = true;
            this.lb_fecha_Registro.Location = new System.Drawing.Point(12, 264);
            this.lb_fecha_Registro.Name = "lb_fecha_Registro";
            this.lb_fecha_Registro.Size = new System.Drawing.Size(92, 13);
            this.lb_fecha_Registro.TabIndex = 28;
            this.lb_fecha_Registro.Text = "Fecha de registro:";
            // 
            // num_cedula
            // 
            this.num_cedula.Location = new System.Drawing.Point(109, 121);
            this.num_cedula.Name = "num_cedula";
            this.num_cedula.Size = new System.Drawing.Size(165, 20);
            this.num_cedula.TabIndex = 30;
            // 
            // date_fecha_registro
            // 
            this.date_fecha_registro.Location = new System.Drawing.Point(109, 257);
            this.date_fecha_registro.Name = "date_fecha_registro";
            this.date_fecha_registro.Size = new System.Drawing.Size(164, 20);
            this.date_fecha_registro.TabIndex = 31;
            // 
            // estudiantesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.date_fecha_registro);
            this.Controls.Add(this.num_cedula);
            this.Controls.Add(this.lb_fecha_Registro);
            this.Controls.Add(this.txt_semestre);
            this.Controls.Add(this.lb_semestre);
            this.Controls.Add(this.dg_estudiantes);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.txt_especialidad);
            this.Controls.Add(this.lb_especialidad);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.lb_edad);
            this.Controls.Add(this.lb_cedula);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label1);
            this.Name = "estudiantesFormulario";
            this.Text = "estudiantesFormulario";
            this.Load += new System.EventHandler(this.estudiantesFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_estudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cedula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_estudiantes;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox txt_especialidad;
        private System.Windows.Forms.Label lb_especialidad;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.Label lb_cedula;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semestre;
        private System.Windows.Forms.Label lb_semestre;
        private System.Windows.Forms.Label lb_fecha_Registro;
        private System.Windows.Forms.NumericUpDown num_cedula;
        private System.Windows.Forms.DateTimePicker date_fecha_registro;
    }
}