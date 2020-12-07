namespace TP1_ElControlDeCalidad.Vistas
{
    partial class VistaListaModelos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn,
            this.denominacionDataGridViewTextBoxColumn,
            this.objetivoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modeloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(254, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 707);
            this.dataGridView1.TabIndex = 0;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denominacionDataGridViewTextBoxColumn
            // 
            this.denominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.HeaderText = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.Name = "denominacionDataGridViewTextBoxColumn";
            this.denominacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetivoDataGridViewTextBoxColumn
            // 
            this.objetivoDataGridViewTextBoxColumn.DataPropertyName = "Objetivo";
            this.objetivoDataGridViewTextBoxColumn.HeaderText = "Objetivo";
            this.objetivoDataGridViewTextBoxColumn.Name = "objetivoDataGridViewTextBoxColumn";
            this.objetivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(TP1_ElControlDeCalidad.Modelo.Modelo);
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(663, 146);
            this.bttAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(198, 118);
            this.bttAgregar.TabIndex = 1;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(663, 308);
            this.bttEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(198, 118);
            this.bttEditar.TabIndex = 2;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // VistaListaModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaListaModelos";
            this.Text = "Gestion de Modelos";
            this.Load += new System.EventHandler(this.VistaListaModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEditar;
    }
}