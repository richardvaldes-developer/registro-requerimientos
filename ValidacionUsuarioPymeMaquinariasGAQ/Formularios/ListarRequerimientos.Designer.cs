namespace Principal
{
    partial class ListarRequerimientos
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
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoRequerimiento = new System.Windows.Forms.ComboBox();
            this.labelTipoRequerimiento = new System.Windows.Forms.Label();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.LabelResuelto = new System.Windows.Forms.Label();
            this.LabelPendiente = new System.Windows.Forms.Label();
            this.checkResuelto = new System.Windows.Forms.CheckBox();
            this.checkPendiente = new System.Windows.Forms.CheckBox();
            this.buttonMarcarResuelto = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBuscar.Location = new System.Drawing.Point(389, 97);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(100, 33);
            this.ButtonBuscar.TabIndex = 23;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(163, 59);
            this.comboBoxPrioridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(210, 21);
            this.comboBoxPrioridad.TabIndex = 22;
            // 
            // comboBoxTipoRequerimiento
            // 
            this.comboBoxTipoRequerimiento.FormattingEnabled = true;
            this.comboBoxTipoRequerimiento.Location = new System.Drawing.Point(163, 24);
            this.comboBoxTipoRequerimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoRequerimiento.Name = "comboBoxTipoRequerimiento";
            this.comboBoxTipoRequerimiento.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTipoRequerimiento.TabIndex = 21;
            // 
            // labelTipoRequerimiento
            // 
            this.labelTipoRequerimiento.AutoSize = true;
            this.labelTipoRequerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoRequerimiento.Location = new System.Drawing.Point(38, 31);
            this.labelTipoRequerimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoRequerimiento.Name = "labelTipoRequerimiento";
            this.labelTipoRequerimiento.Size = new System.Drawing.Size(121, 13);
            this.labelTipoRequerimiento.TabIndex = 20;
            this.labelTipoRequerimiento.Text = "Tipo Requerimiento:";
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridad.Location = new System.Drawing.Point(38, 66);
            this.labelPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(61, 13);
            this.labelPrioridad.TabIndex = 19;
            this.labelPrioridad.Text = "Prioridad:";
            // 
            // LabelResuelto
            // 
            this.LabelResuelto.AutoSize = true;
            this.LabelResuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResuelto.Location = new System.Drawing.Point(209, 98);
            this.LabelResuelto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResuelto.Name = "LabelResuelto";
            this.LabelResuelto.Size = new System.Drawing.Size(57, 13);
            this.LabelResuelto.TabIndex = 18;
            this.LabelResuelto.Text = "Resuelto";
            // 
            // LabelPendiente
            // 
            this.LabelPendiente.AutoSize = true;
            this.LabelPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPendiente.Location = new System.Drawing.Point(38, 97);
            this.LabelPendiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPendiente.Name = "LabelPendiente";
            this.LabelPendiente.Size = new System.Drawing.Size(70, 13);
            this.LabelPendiente.TabIndex = 17;
            this.LabelPendiente.Text = "Pendientes";
            // 
            // checkResuelto
            // 
            this.checkResuelto.AutoSize = true;
            this.checkResuelto.Location = new System.Drawing.Point(294, 99);
            this.checkResuelto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkResuelto.Name = "checkResuelto";
            this.checkResuelto.Size = new System.Drawing.Size(15, 14);
            this.checkResuelto.TabIndex = 16;
            this.checkResuelto.UseVisualStyleBackColor = true;
            // 
            // checkPendiente
            // 
            this.checkPendiente.AutoSize = true;
            this.checkPendiente.Location = new System.Drawing.Point(163, 98);
            this.checkPendiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkPendiente.Name = "checkPendiente";
            this.checkPendiente.Size = new System.Drawing.Size(15, 14);
            this.checkPendiente.TabIndex = 15;
            this.checkPendiente.UseVisualStyleBackColor = true;
            // 
            // buttonMarcarResuelto
            // 
            this.buttonMarcarResuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcarResuelto.Location = new System.Drawing.Point(69, 308);
            this.buttonMarcarResuelto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMarcarResuelto.Name = "buttonMarcarResuelto";
            this.buttonMarcarResuelto.Size = new System.Drawing.Size(181, 33);
            this.buttonMarcarResuelto.TabIndex = 14;
            this.buttonMarcarResuelto.Text = "Marcar como Resuelto";
            this.buttonMarcarResuelto.UseVisualStyleBackColor = true;
            this.buttonMarcarResuelto.Click += new System.EventHandler(this.buttonMarcarResuelto_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(311, 308);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(204, 33);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // ListarRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.comboBoxTipoRequerimiento);
            this.Controls.Add(this.labelTipoRequerimiento);
            this.Controls.Add(this.labelPrioridad);
            this.Controls.Add(this.LabelResuelto);
            this.Controls.Add(this.LabelPendiente);
            this.Controls.Add(this.checkResuelto);
            this.Controls.Add(this.checkPendiente);
            this.Controls.Add(this.buttonMarcarResuelto);
            this.Controls.Add(this.buttonEliminar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListarRequerimientos";
            this.Text = "ListarRequerimientos";
            this.Load += new System.EventHandler(this.ListarRequerimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.ComboBox comboBoxTipoRequerimiento;
        private System.Windows.Forms.Label labelTipoRequerimiento;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.Label LabelResuelto;
        private System.Windows.Forms.Label LabelPendiente;
        private System.Windows.Forms.CheckBox checkResuelto;
        private System.Windows.Forms.CheckBox checkPendiente;
        private System.Windows.Forms.Button buttonMarcarResuelto;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}