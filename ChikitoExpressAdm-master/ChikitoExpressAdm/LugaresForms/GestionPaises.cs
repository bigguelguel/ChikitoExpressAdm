﻿using ChikitoExpressAdm.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikitoExpressAdm.LugaresForms
{
    public partial class GestionPaises : Form
    {
        AdmServiceClient client;
        public int Row { get; set; }
        private int IdPais { get; set; }
        public GestionPaises()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            dataGridUpdate();
            chkEstado.Enabled = false;
            txbActualizarNombre.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbPais.Text != string.Empty)
            {
                Pais p = new Pais { nombre = txbPais.Text, estado = true };
                try
                {
                    client.PostPais(p);

                }
                catch (EntryPointNotFoundException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Porfavor Ensena el nombre del pais antes de pulsar a enter");
            }
            dataGridUpdate();
        }

        private void dataGridViewPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = dataGridViewPais.CurrentRow.Index;
            var paises = client.GetPaises();
            txbActualizarNombre.Text = paises.ElementAt(Row).nombre;
            chkEstado.Checked = paises.ElementAt(Row).estado;
            IdPais = paises.ElementAt(Row).idpais;
            chkEstado.Enabled = true;
            txbActualizarNombre.Enabled = true;
        }
        public void dataGridUpdate()
        {
            var p = client.GetPaises();
            dataGridViewPais.DataSource = p;
        }

        private void bttRetirar_Click(object sender, EventArgs e)
        {
            client.RetirarPais(IdPais);
            dataGridUpdate();

        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            var paises = client.GetPaises();
            client.ActualizarPais(IdPais, txbActualizarNombre.Text, chkEstado.Checked);
            dataGridUpdate();
        }
    }
}
