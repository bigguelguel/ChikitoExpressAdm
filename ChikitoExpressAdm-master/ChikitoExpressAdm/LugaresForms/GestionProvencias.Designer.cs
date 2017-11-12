namespace ChikitoExpressAdm.LugaresForms
{
    partial class GestionProvencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbAgregarProvencia = new System.Windows.Forms.TextBox();
            this.bttAgregarProvencia = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Provencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtbAgregarProvencia
            // 
            this.txtbAgregarProvencia.Location = new System.Drawing.Point(104, 79);
            this.txtbAgregarProvencia.Name = "txtbAgregarProvencia";
            this.txtbAgregarProvencia.Size = new System.Drawing.Size(236, 20);
            this.txtbAgregarProvencia.TabIndex = 3;
            // 
            // bttAgregarProvencia
            // 
            this.bttAgregarProvencia.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregarProvencia.Location = new System.Drawing.Point(179, 142);
            this.bttAgregarProvencia.Name = "bttAgregarProvencia";
            this.bttAgregarProvencia.Size = new System.Drawing.Size(88, 35);
            this.bttAgregarProvencia.TabIndex = 4;
            this.bttAgregarProvencia.Text = "Agregar";
            this.bttAgregarProvencia.UseVisualStyleBackColor = true;
            this.bttAgregarProvencia.Click += new System.EventHandler(this.bttAgregarProvencia_Click);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(104, 115);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(236, 21);
            this.comboBoxPais.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 24);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Pais";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 168);
            this.dataGridView1.TabIndex = 7;
            // 
            // GestionProvencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.bttAgregarProvencia);
            this.Controls.Add(this.txtbAgregarProvencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionProvencias";
            this.Text = "GestionProvencias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAgregarProvencia;
        private System.Windows.Forms.Button bttAgregarProvencia;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}