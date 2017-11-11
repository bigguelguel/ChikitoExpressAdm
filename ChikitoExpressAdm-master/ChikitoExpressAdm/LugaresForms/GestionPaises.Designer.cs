namespace ChikitoExpressAdm.LugaresForms
{
    partial class GestionPaises
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
            this.bttActualizar = new System.Windows.Forms.Button();
            this.bttRetirar = new System.Windows.Forms.Button();
            this.dataGridViewPais = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbActualizarNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPais)).BeginInit();
            this.SuspendLayout();
            // 
            // bttActualizar
            // 
            this.bttActualizar.AccessibleDescription = "bttCrearPais";
            this.bttActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttActualizar.Location = new System.Drawing.Point(493, 117);
            this.bttActualizar.Name = "bttActualizar";
            this.bttActualizar.Size = new System.Drawing.Size(111, 27);
            this.bttActualizar.TabIndex = 15;
            this.bttActualizar.Text = "Actualizar";
            this.bttActualizar.UseVisualStyleBackColor = true;
            this.bttActualizar.Click += new System.EventHandler(this.bttActualizar_Click);
            // 
            // bttRetirar
            // 
            this.bttRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRetirar.Location = new System.Drawing.Point(160, 114);
            this.bttRetirar.Name = "bttRetirar";
            this.bttRetirar.Size = new System.Drawing.Size(85, 30);
            this.bttRetirar.TabIndex = 13;
            this.bttRetirar.Text = "Retirar";
            this.bttRetirar.UseVisualStyleBackColor = true;
            this.bttRetirar.Click += new System.EventHandler(this.bttRetirar_Click);
            // 
            // dataGridViewPais
            // 
            this.dataGridViewPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPais.Location = new System.Drawing.Point(4, 150);
            this.dataGridViewPais.Name = "dataGridViewPais";
            this.dataGridViewPais.Size = new System.Drawing.Size(776, 188);
            this.dataGridViewPais.TabIndex = 12;
            this.dataGridViewPais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPais_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "nombre";
            // 
            // txbPais
            // 
            this.txbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPais.Location = new System.Drawing.Point(114, 37);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(194, 26);
            this.txbPais.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "bttCrearPais";
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevo Pais";
            // 
            // txbActualizarNombre
            // 
            this.txbActualizarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbActualizarNombre.Location = new System.Drawing.Point(451, 33);
            this.txbActualizarNombre.Name = "txbActualizarNombre";
            this.txbActualizarNombre.Size = new System.Drawing.Size(194, 26);
            this.txbActualizarNombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "nombre";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(451, 69);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(87, 28);
            this.chkEstado.TabIndex = 20;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // GestionPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 341);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbActualizarNombre);
            this.Controls.Add(this.bttActualizar);
            this.Controls.Add(this.bttRetirar);
            this.Controls.Add(this.dataGridViewPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "GestionPaises";
            this.Text = "GestionPaises";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttActualizar;
        private System.Windows.Forms.Button bttRetirar;
        private System.Windows.Forms.DataGridView dataGridViewPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbActualizarNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEstado;
    }
}