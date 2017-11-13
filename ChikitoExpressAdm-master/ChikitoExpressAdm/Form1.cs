using ChikitoExpressAdm.LugaresForms;
using ChikitoExpressAdm.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikitoExpressAdm
{
    public partial class Form1 : Form
    {
        private GestionPaises formPais { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPais = new GestionPaises();
            formPais.Show();
        }

        private void provenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProvencias provencia = new GestionProvencias();
            provencia.Show();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMunicipios municipio = new GestionMunicipios();
            municipio.Show();
        }

        private void zonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionZonas vistaZona = new GestionZonas();
            vistaZona.Show();
        }

    }
}
