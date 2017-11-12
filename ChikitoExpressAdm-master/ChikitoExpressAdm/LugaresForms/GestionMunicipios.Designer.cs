namespace ChikitoExpressAdm.LugaresForms
{
    partial class GestionMunicipios
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
            this.dataGridViewMunicipio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarMunicipio = new System.Windows.Forms.Button();
            this.txtbMunicipio = new System.Windows.Forms.TextBox();
            this.comboBoxProvencia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMunicipio
            // 
            this.dataGridViewMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMunicipio.Location = new System.Drawing.Point(1, 187);
            this.dataGridViewMunicipio.Name = "dataGridViewMunicipio";
            this.dataGridViewMunicipio.Size = new System.Drawing.Size(443, 160);
            this.dataGridViewMunicipio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Municipio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Provencia";
            // 
            // AgregarMunicipio
            // 
            this.AgregarMunicipio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMunicipio.Location = new System.Drawing.Point(156, 132);
            this.AgregarMunicipio.Name = "AgregarMunicipio";
            this.AgregarMunicipio.Size = new System.Drawing.Size(106, 37);
            this.AgregarMunicipio.TabIndex = 4;
            this.AgregarMunicipio.Text = "Agregar";
            this.AgregarMunicipio.UseVisualStyleBackColor = true;
            this.AgregarMunicipio.Click += new System.EventHandler(this.AgregarMunicipio_Click);
            // 
            // txtbMunicipio
            // 
            this.txtbMunicipio.Location = new System.Drawing.Point(105, 50);
            this.txtbMunicipio.Name = "txtbMunicipio";
            this.txtbMunicipio.Size = new System.Drawing.Size(183, 20);
            this.txtbMunicipio.TabIndex = 5;
            // 
            // comboBoxProvencia
            // 
            this.comboBoxProvencia.FormattingEnabled = true;
            this.comboBoxProvencia.Location = new System.Drawing.Point(105, 93);
            this.comboBoxProvencia.Name = "comboBoxProvencia";
            this.comboBoxProvencia.Size = new System.Drawing.Size(183, 21);
            this.comboBoxProvencia.TabIndex = 6;
            // 
            // GestionMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 349);
            this.Controls.Add(this.comboBoxProvencia);
            this.Controls.Add(this.txtbMunicipio);
            this.Controls.Add(this.AgregarMunicipio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMunicipio);
            this.Name = "GestionMunicipios";
            this.Text = "GestionMunicipios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMunicipio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarMunicipio;
        private System.Windows.Forms.TextBox txtbMunicipio;
        private System.Windows.Forms.ComboBox comboBoxProvencia;
    }
}