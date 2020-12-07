namespace TP1_ElControlDeCalidad.Vistas
{
    partial class VistaModelo
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
            this.bsModelo = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblObj = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.butBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // bsModelo
            // 
            this.bsModelo.DataSource = typeof(TP1_ElControlDeCalidad.Modelo.Modelo);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(454, 181);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(29, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "SKU";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(454, 214);
            this.lblDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 1;
            this.lblDes.Text = "Descripcion";
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Location = new System.Drawing.Point(454, 251);
            this.lblObj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(46, 13);
            this.lblObj.TabIndex = 2;
            this.lblObj.Text = "Objetivo";
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModelo, "SKU", true));
            this.txtCod.Location = new System.Drawing.Point(532, 181);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(113, 20);
            this.txtCod.TabIndex = 3;
            // 
            // txtObj
            // 
            this.txtObj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModelo, "Objetivo", true));
            this.txtObj.Location = new System.Drawing.Point(532, 251);
            this.txtObj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(113, 20);
            this.txtObj.TabIndex = 4;
            // 
            // txtDes
            // 
            this.txtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModelo, "Denominacion", true));
            this.txtDes.Location = new System.Drawing.Point(532, 214);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(113, 20);
            this.txtDes.TabIndex = 5;
            // 
            // butBus
            // 
            this.butBus.Location = new System.Drawing.Point(457, 296);
            this.butBus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butBus.Name = "butBus";
            this.butBus.Size = new System.Drawing.Size(188, 59);
            this.butBus.TabIndex = 6;
            this.butBus.Text = "Guardar";
            this.butBus.UseVisualStyleBackColor = true;
            this.butBus.Click += new System.EventHandler(this.butBus_Click);
            // 
            // VistaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.butBus);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtObj);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.VistaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsModelo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button butBus;
    }
}