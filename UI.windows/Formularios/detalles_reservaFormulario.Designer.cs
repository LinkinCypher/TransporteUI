namespace UI.windows.Formularios
{
    partial class detalles_reservaFormulario
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
            this.dg_detalles_reserva = new System.Windows.Forms.DataGridView();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.lb_referencia = new System.Windows.Forms.Label();
            this.txt_casa = new System.Windows.Forms.TextBox();
            this.lb_casa = new System.Windows.Forms.Label();
            this.txt_calles = new System.Windows.Forms.TextBox();
            this.lb_calles = new System.Windows.Forms.Label();
            this.txt_barrio = new System.Windows.Forms.TextBox();
            this.lb_barrio = new System.Windows.Forms.Label();
            this.lb_detalles_reserva = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalles_reserva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_detalles_reserva
            // 
            this.dg_detalles_reserva.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_detalles_reserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_detalles_reserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_detalles_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalles_reserva.EnableHeadersVisualStyles = false;
            this.dg_detalles_reserva.Location = new System.Drawing.Point(373, 50);
            this.dg_detalles_reserva.Name = "dg_detalles_reserva";
            this.dg_detalles_reserva.Size = new System.Drawing.Size(650, 388);
            this.dg_detalles_reserva.TabIndex = 25;
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_guardar.Location = new System.Drawing.Point(80, 289);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(182, 33);
            this.bt_guardar.TabIndex = 24;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(97, 175);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(169, 20);
            this.txt_telefono.TabIndex = 23;
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_telefono.Location = new System.Drawing.Point(30, 182);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(61, 13);
            this.lb_telefono.TabIndex = 22;
            this.lb_telefono.Text = "Teléfono:";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_referencia.Location = new System.Drawing.Point(97, 136);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(169, 20);
            this.txt_referencia.TabIndex = 21;
            // 
            // lb_referencia
            // 
            this.lb_referencia.AutoSize = true;
            this.lb_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_referencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_referencia.Location = new System.Drawing.Point(18, 139);
            this.lb_referencia.Name = "lb_referencia";
            this.lb_referencia.Size = new System.Drawing.Size(73, 13);
            this.lb_referencia.TabIndex = 20;
            this.lb_referencia.Text = "Referencia:";
            // 
            // txt_casa
            // 
            this.txt_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_casa.Location = new System.Drawing.Point(97, 97);
            this.txt_casa.Name = "txt_casa";
            this.txt_casa.Size = new System.Drawing.Size(169, 20);
            this.txt_casa.TabIndex = 19;
            // 
            // lb_casa
            // 
            this.lb_casa.AutoSize = true;
            this.lb_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_casa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_casa.Location = new System.Drawing.Point(52, 104);
            this.lb_casa.Name = "lb_casa";
            this.lb_casa.Size = new System.Drawing.Size(39, 13);
            this.lb_casa.TabIndex = 18;
            this.lb_casa.Text = "Casa:";
            // 
            // txt_calles
            // 
            this.txt_calles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calles.Location = new System.Drawing.Point(97, 59);
            this.txt_calles.Name = "txt_calles";
            this.txt_calles.Size = new System.Drawing.Size(169, 20);
            this.txt_calles.TabIndex = 17;
            // 
            // lb_calles
            // 
            this.lb_calles.AutoSize = true;
            this.lb_calles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_calles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_calles.Location = new System.Drawing.Point(46, 66);
            this.lb_calles.Name = "lb_calles";
            this.lb_calles.Size = new System.Drawing.Size(45, 13);
            this.lb_calles.TabIndex = 16;
            this.lb_calles.Text = "Calles:";
            // 
            // txt_barrio
            // 
            this.txt_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barrio.Location = new System.Drawing.Point(97, 23);
            this.txt_barrio.Name = "txt_barrio";
            this.txt_barrio.Size = new System.Drawing.Size(169, 20);
            this.txt_barrio.TabIndex = 15;
            // 
            // lb_barrio
            // 
            this.lb_barrio.AutoSize = true;
            this.lb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_barrio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_barrio.Location = new System.Drawing.Point(47, 30);
            this.lb_barrio.Name = "lb_barrio";
            this.lb_barrio.Size = new System.Drawing.Size(44, 13);
            this.lb_barrio.TabIndex = 14;
            this.lb_barrio.Text = "Barrio:";
            // 
            // lb_detalles_reserva
            // 
            this.lb_detalles_reserva.AutoSize = true;
            this.lb_detalles_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalles_reserva.Location = new System.Drawing.Point(616, 31);
            this.lb_detalles_reserva.Name = "lb_detalles_reserva";
            this.lb_detalles_reserva.Size = new System.Drawing.Size(207, 16);
            this.lb_detalles_reserva.TabIndex = 13;
            this.lb_detalles_reserva.Text = "DETALLES DE LA RESERVA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.lb_telefono);
            this.groupBox1.Controls.Add(this.txt_referencia);
            this.groupBox1.Controls.Add(this.lb_referencia);
            this.groupBox1.Controls.Add(this.txt_casa);
            this.groupBox1.Controls.Add(this.lb_casa);
            this.groupBox1.Controls.Add(this.txt_calles);
            this.groupBox1.Controls.Add(this.lb_calles);
            this.groupBox1.Controls.Add(this.txt_barrio);
            this.groupBox1.Controls.Add(this.lb_barrio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(31, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 222);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL DOMICILIO";
            // 
            // detalles_reservaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_detalles_reserva);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.lb_detalles_reserva);
            this.Name = "detalles_reservaFormulario";
            this.Text = "detalles_reservaFormulario";
            this.Load += new System.EventHandler(this.detalles_reservaFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalles_reserva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_detalles_reserva;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.Label lb_referencia;
        private System.Windows.Forms.TextBox txt_casa;
        private System.Windows.Forms.Label lb_casa;
        private System.Windows.Forms.TextBox txt_calles;
        private System.Windows.Forms.Label lb_calles;
        private System.Windows.Forms.TextBox txt_barrio;
        private System.Windows.Forms.Label lb_barrio;
        private System.Windows.Forms.Label lb_detalles_reserva;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}