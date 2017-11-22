namespace ChikitoExpressAdm.Gestion_Restaurante
{
    partial class GestionarPlatos
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.dataGridViewPlato = new System.Windows.Forms.DataGridView();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoPlato = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxPlato = new System.Windows.Forms.PictureBox();
            this.buttonImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AccessibleDescription = "bttCrearPais";
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(389, 363);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(111, 27);
            this.buttonEliminar.TabIndex = 35;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.AccessibleDescription = "bttCrearPais";
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(250, 363);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(111, 27);
            this.buttonActualizar.TabIndex = 34;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // bttAgregar
            // 
            this.bttAgregar.AccessibleDescription = "bttCrearPais";
            this.bttAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.Location = new System.Drawing.Point(79, 363);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(111, 27);
            this.bttAgregar.TabIndex = 33;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // dataGridViewPlato
            // 
            this.dataGridViewPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlato.Location = new System.Drawing.Point(2, 396);
            this.dataGridViewPlato.Name = "dataGridViewPlato";
            this.dataGridViewPlato.Size = new System.Drawing.Size(544, 158);
            this.dataGridViewPlato.TabIndex = 32;
            this.dataGridViewPlato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlato_CellClick);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(280, 171);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(191, 80);
            this.textBoxDescripcion.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Descripción: ";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(280, 133);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(106, 20);
            this.textBoxPrecio.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Precio:";
            // 
            // comboBoxTipoPlato
            // 
            this.comboBoxTipoPlato.FormattingEnabled = true;
            this.comboBoxTipoPlato.Location = new System.Drawing.Point(280, 90);
            this.comboBoxTipoPlato.Name = "comboBoxTipoPlato";
            this.comboBoxTipoPlato.Size = new System.Drawing.Size(183, 21);
            this.comboBoxTipoPlato.TabIndex = 26;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(280, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo de Plato: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Agregar Plato";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(430, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Estado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPlato
            // 
            this.pictureBoxPlato.Location = new System.Drawing.Point(280, 258);
            this.pictureBoxPlato.Name = "pictureBoxPlato";
            this.pictureBoxPlato.Size = new System.Drawing.Size(191, 99);
            this.pictureBoxPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlato.TabIndex = 37;
            this.pictureBoxPlato.TabStop = false;
            // 
            // buttonImagen
            // 
            this.buttonImagen.AccessibleDescription = "bttCrearPais";
            this.buttonImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImagen.Location = new System.Drawing.Point(79, 258);
            this.buttonImagen.Name = "buttonImagen";
            this.buttonImagen.Size = new System.Drawing.Size(111, 27);
            this.buttonImagen.TabIndex = 38;
            this.buttonImagen.Text = "Imagen";
            this.buttonImagen.UseVisualStyleBackColor = true;
            this.buttonImagen.Click += new System.EventHandler(this.buttonImagen_Click);
            // 
            // GestionarPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 556);
            this.Controls.Add(this.buttonImagen);
            this.Controls.Add(this.pictureBoxPlato);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.dataGridViewPlato);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipoPlato);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionarPlatos";
            this.Text = "Gestionar Platos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.DataGridView dataGridViewPlato;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoPlato;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBoxPlato;
        private System.Windows.Forms.Button buttonImagen;
    }
}