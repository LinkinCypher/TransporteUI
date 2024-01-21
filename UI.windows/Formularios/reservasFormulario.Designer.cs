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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_norte = new System.Windows.Forms.Label();
            this.txt_norte = new System.Windows.Forms.TextBox();
            this.txt_centro = new System.Windows.Forms.TextBox();
            this.lb_centro = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.dg_reservas = new System.Windows.Forms.DataGridView();
            this.lb_sur = new System.Windows.Forms.Label();
            this.txt_sur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVAS";
            // 
            // lb_norte
            // 
            this.lb_norte.AutoSize = true;
            this.lb_norte.Location = new System.Drawing.Point(12, 96);
            this.lb_norte.Name = "lb_norte";
            this.lb_norte.Size = new System.Drawing.Size(36, 13);
            this.lb_norte.TabIndex = 1;
            this.lb_norte.Text = "Norte:";
            // 
            // txt_norte
            // 
            this.txt_norte.Location = new System.Drawing.Point(109, 89);
            this.txt_norte.Name = "txt_norte";
            this.txt_norte.Size = new System.Drawing.Size(169, 20);
            this.txt_norte.TabIndex = 2;
            // 
            // txt_centro
            // 
            this.txt_centro.Location = new System.Drawing.Point(109, 125);
            this.txt_centro.Name = "txt_centro";
            this.txt_centro.Size = new System.Drawing.Size(169, 20);
            this.txt_centro.TabIndex = 4;
            // 
            // lb_centro
            // 
            this.lb_centro.AutoSize = true;
            this.lb_centro.Location = new System.Drawing.Point(12, 132);
            this.lb_centro.Name = "lb_centro";
            this.lb_centro.Size = new System.Drawing.Size(41, 13);
            this.lb_centro.TabIndex = 3;
            this.lb_centro.Text = "Centro:";
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(45, 292);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(182, 33);
            this.bt_guardar.TabIndex = 11;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // dg_reservas
            // 
            this.dg_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reservas.Location = new System.Drawing.Point(284, 59);
            this.dg_reservas.Name = "dg_reservas";
            this.dg_reservas.Size = new System.Drawing.Size(936, 388);
            this.dg_reservas.TabIndex = 12;
            // 
            // lb_sur
            // 
            this.lb_sur.AutoSize = true;
            this.lb_sur.Location = new System.Drawing.Point(12, 170);
            this.lb_sur.Name = "lb_sur";
            this.lb_sur.Size = new System.Drawing.Size(26, 13);
            this.lb_sur.TabIndex = 5;
            this.lb_sur.Text = "Sur:";
            // 
            // txt_sur
            // 
            this.txt_sur.Location = new System.Drawing.Point(109, 163);
            this.txt_sur.Name = "txt_sur";
            this.txt_sur.Size = new System.Drawing.Size(169, 20);
            this.txt_sur.TabIndex = 6;
            // 
            // reservasFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.dg_reservas);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.txt_sur);
            this.Controls.Add(this.lb_sur);
            this.Controls.Add(this.txt_centro);
            this.Controls.Add(this.lb_centro);
            this.Controls.Add(this.txt_norte);
            this.Controls.Add(this.lb_norte);
            this.Controls.Add(this.label1);
            this.Name = "reservasFormulario";
            this.Text = "reservasFormulario";
            this.Load += new System.EventHandler(this.reservasFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_norte;
        private System.Windows.Forms.TextBox txt_norte;
        private System.Windows.Forms.TextBox txt_centro;
        private System.Windows.Forms.Label lb_centro;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DataGridView dg_reservas;
        private System.Windows.Forms.Label lb_sur;
        private System.Windows.Forms.TextBox txt_sur;
    }
}