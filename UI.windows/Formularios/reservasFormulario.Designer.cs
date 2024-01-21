namespace UI.windows.Formularios
{
    partial class reservasFormulario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.dg_reservas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_sur = new System.Windows.Forms.RadioButton();
            this.rad_centro = new System.Windows.Forms.RadioButton();
            this.rad_norte = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVAS";
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_guardar.Location = new System.Drawing.Point(44, 215);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(182, 33);
            this.bt_guardar.TabIndex = 11;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // dg_reservas
            // 
            this.dg_reservas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_reservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reservas.EnableHeadersVisualStyles = false;
            this.dg_reservas.Location = new System.Drawing.Point(265, 50);
            this.dg_reservas.Name = "dg_reservas";
            this.dg_reservas.Size = new System.Drawing.Size(453, 388);
            this.dg_reservas.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_sur);
            this.groupBox1.Controls.Add(this.rad_centro);
            this.groupBox1.Controls.Add(this.rad_norte);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(37, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 137);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SECTOR DEL DOMICILIO";
            // 
            // rad_sur
            // 
            this.rad_sur.AutoSize = true;
            this.rad_sur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_sur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad_sur.Location = new System.Drawing.Point(58, 102);
            this.rad_sur.Name = "rad_sur";
            this.rad_sur.Size = new System.Drawing.Size(41, 17);
            this.rad_sur.TabIndex = 2;
            this.rad_sur.Text = "Sur";
            this.rad_sur.UseVisualStyleBackColor = true;
            // 
            // rad_centro
            // 
            this.rad_centro.AutoSize = true;
            this.rad_centro.Checked = true;
            this.rad_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_centro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad_centro.Location = new System.Drawing.Point(58, 70);
            this.rad_centro.Name = "rad_centro";
            this.rad_centro.Size = new System.Drawing.Size(56, 17);
            this.rad_centro.TabIndex = 1;
            this.rad_centro.TabStop = true;
            this.rad_centro.Text = "Centro";
            this.rad_centro.UseVisualStyleBackColor = true;
            // 
            // rad_norte
            // 
            this.rad_norte.AutoSize = true;
            this.rad_norte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_norte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad_norte.Location = new System.Drawing.Point(58, 35);
            this.rad_norte.Name = "rad_norte";
            this.rad_norte.Size = new System.Drawing.Size(51, 17);
            this.rad_norte.TabIndex = 0;
            this.rad_norte.Text = "Norte";
            this.rad_norte.UseVisualStyleBackColor = true;
            // 
            // reservasFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_reservas);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.label1);
            this.Name = "reservasFormulario";
            this.Text = "reservasFormulario";
            this.Load += new System.EventHandler(this.reservasFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DataGridView dg_reservas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_sur;
        private System.Windows.Forms.RadioButton rad_centro;
        private System.Windows.Forms.RadioButton rad_norte;
    }
}