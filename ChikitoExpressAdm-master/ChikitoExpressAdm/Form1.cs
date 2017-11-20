using ChikitoExpressAdm.Gestion_ADM;
using ChikitoExpressAdm.Gestion_Clientes;
using ChikitoExpressAdm.Gestion_Restaurante;
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
        private GestionPaises FormPais { get; set; }
        private CrearClientes FormCliente { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void PaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPais = new GestionPaises();
            FormPais.Show();
        }

        private void ProvenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProvencias provencia = new GestionProvencias();
            provencia.Show();
        }

        private void MunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMunicipios municipio = new GestionMunicipios();
            municipio.Show();
        }

        private void ZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionZonas vistaZona = new GestionZonas();
            vistaZona.Show();
        }

        private void CrearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente = new CrearClientes();
            FormCliente.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarClientes FormActulizarCliente = new ActualizarClientes();
            FormActulizarCliente.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearADM adm = new CrearADM();
            adm.Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarADM actualizarAdm = new ActualizarADM();
            actualizarAdm.Show();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GestionarBebidas vistaBebida = new GestionarBebidas();
            vistaBebida.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionarPlatos vistaPlato = new GestionarPlatos();
            vistaPlato.Show();
        }
    }

        
}
