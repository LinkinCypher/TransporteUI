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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_estudiantes = new System.Windows.Forms.DataGridView();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.lb_especialidad = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lb_edad = new System.Windows.Forms.Label();
            this.lb_cedula = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_semestre = new System.Windows.Forms.Label();
            this.lb_fecha_Registro = new System.Windows.Forms.Label();
            this.num_cedula = new System.Windows.Forms.NumericUpDown();
            this.date_fecha_registro = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lis_semestre = new System.Windows.Forms.ListBox();
            this.lis_especialidad = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_estudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cedula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_estudiantes
            // 
            this.dg_estudiantes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_estudiantes.EnableHeadersVisualStyles = false;
            this.dg_estudiantes.Location = new System.Drawing.Point(369, 50);
            this.dg_estudiantes.Name = "dg_estudiantes";
            this.dg_estudiantes.Size = new System.Drawing.Size(844, 388);
            this.dg_estudiantes.TabIndex = 25;
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_guardar.Location = new System.Drawing.Point(84, 317);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(182, 33);
            this.bt_guardar.TabIndex = 24;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // lb_especialidad
            // 
            this.lb_especialidad.AutoSize = true;
            this.lb_especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_especialidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_especialidad.Location = new System.Drawing.Point(31, 159);
            this.lb_especialidad.Name = "lb_especialidad";
            this.lb_especialidad.Size = new System.Drawing.Size(83, 13);
            this.lb_especialidad.TabIndex = 22;
            this.lb_especialidad.Text = "Especialidad:";
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_edad.Location = new System.Drawing.Point(120, 117);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(169, 20);
            this.txt_edad.TabIndex = 21;
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_edad.Location = new System.Drawing.Point(74, 124);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(40, 13);
            this.lb_edad.TabIndex = 20;
            this.lb_edad.Text = "Edad:";
            // 
            // lb_cedula
            // 
            this.lb_cedula.AutoSize = true;
            this.lb_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cedula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_cedula.Location = new System.Drawing.Point(64, 91);
            this.lb_cedula.Name = "lb_cedula";
            this.lb_cedula.Size = new System.Drawing.Size(50, 13);
            this.lb_cedula.TabIndex = 18;
            this.lb_cedula.Text = "Cédula:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_apellido.Location = new System.Drawing.Point(120, 52);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(169, 20);
            this.txt_apellido.TabIndex = 17;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_apellido.Location = new System.Drawing.Point(58, 55);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(56, 13);
            this.lb_apellido.TabIndex = 16;
            this.lb_apellido.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nombre.Location = new System.Drawing.Point(120, 21);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_nombre.TabIndex = 15;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_nombre.Location = new System.Drawing.Point(60, 28);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(54, 13);
            this.lb_nombre.TabIndex = 14;
            this.lb_nombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ESTUDIANTES";
            // 
            // lb_semestre
            // 
            this.lb_semestre.AutoSize = true;
            this.lb_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semestre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_semestre.Location = new System.Drawing.Point(51, 193);
            this.lb_semestre.Name = "lb_semestre";
            this.lb_semestre.Size = new System.Drawing.Size(63, 13);
            this.lb_semestre.TabIndex = 26;
            this.lb_semestre.Text = "Semestre:";
            // 
            // lb_fecha_Registro
            // 
            this.lb_fecha_Registro.AutoSize = true;
            this.lb_fecha_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha_Registro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_fecha_Registro.Location = new System.Drawing.Point(6, 226);
            this.lb_fecha_Registro.Name = "lb_fecha_Registro";
            this.lb_fecha_Registro.Size = new System.Drawing.Size(110, 13);
            this.lb_fecha_Registro.TabIndex = 28;
            this.lb_fecha_Registro.Text = "Fecha de registro:";
            // 
            // num_cedula
            // 
            this.num_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cedula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.num_cedula.Location = new System.Drawing.Point(120, 84);
            this.num_cedula.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.num_cedula.Name = "num_cedula";
            this.num_cedula.Size = new System.Drawing.Size(165, 20);
            this.num_cedula.TabIndex = 30;
            // 
            // date_fecha_registro
            // 
            this.date_fecha_registro.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.date_fecha_registro.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.date_fecha_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha_registro.Location = new System.Drawing.Point(120, 220);
            this.date_fecha_registro.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.date_fecha_registro.Name = "date_fecha_registro";
            this.date_fecha_registro.Size = new System.Drawing.Size(164, 20);
            this.date_fecha_registro.TabIndex = 31;
            this.date_fecha_registro.Value = new System.DateTime(2024, 1, 21, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lis_especialidad);
            this.groupBox1.Controls.Add(this.lis_semestre);
            this.groupBox1.Controls.Add(this.date_fecha_registro);
            this.groupBox1.Controls.Add(this.num_cedula);
            this.groupBox1.Controls.Add(this.lb_fecha_Registro);
            this.groupBox1.Controls.Add(this.lb_semestre);
            this.groupBox1.Controls.Add(this.lb_especialidad);
            this.groupBox1.Controls.Add(this.txt_edad);
            this.groupBox1.Controls.Add(this.lb_edad);
            this.groupBox1.Controls.Add(this.lb_cedula);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.lb_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lb_nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 261);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // lis_semestre
            // 
            this.lis_semestre.FormattingEnabled = true;
            this.lis_semestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto",
            "Séptimo",
            "Octavo",
            "Noveno",
            "Décimo"});
            this.lis_semestre.Location = new System.Drawing.Point(118, 189);
            this.lis_semestre.Name = "lis_semestre";
            this.lis_semestre.Size = new System.Drawing.Size(171, 17);
            this.lis_semestre.TabIndex = 33;
            // 
            // lis_especialidad
            // 
            this.lis_especialidad.FormattingEnabled = true;
            this.lis_especialidad.Items.AddRange(new object[] {
            "Medicina",
            "Telecomunicaciones",
            "Informática",
            "Sistemas",
            "Electrónica",
            "Educación",
            "Diseño",
            "Administración",
            "Contabilidad",
            "Psicología"});
            this.lis_especialidad.Location = new System.Drawing.Point(118, 155);
            this.lis_especialidad.Name = "lis_especialidad";
            this.lis_especialidad.Size = new System.Drawing.Size(171, 17);
            this.lis_especialidad.TabIndex = 34;
            // 
            // estudiantesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_estudiantes);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.label1);
            this.Name = "estudiantesFormulario";
            this.Text = "estudiantesFormulario";
            this.Load += new System.EventHandler(this.estudiantesFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_estudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cedula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_estudiantes;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label lb_especialidad;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.Label lb_cedula;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_semestre;
        private System.Windows.Forms.Label lb_fecha_Registro;
        private System.Windows.Forms.NumericUpDown num_cedula;
        private System.Windows.Forms.DateTimePicker date_fecha_registro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lis_semestre;
        private System.Windows.Forms.ListBox lis_especialidad;
    }
}