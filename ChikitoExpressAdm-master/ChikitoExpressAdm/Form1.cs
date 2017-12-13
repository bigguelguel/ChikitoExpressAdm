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
        AdmServiceClient client;
        public int MaxPlato { get; set; }
        public int MaxBebida { get; set; }
        public int PosicionPlato { get; set; }
        public int PosicionBebida { get; set; }
        List<Plato> Platos;
        List<Bebida> Bebidas;
        public Form1()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            panel1.Hide();
            label3.Hide();
            Platos = new List<Plato>();
            var plato = client.GetPlato();
            foreach(var p in plato)
            {
                Platos.Add(p);
            }
            Bebidas = new List<Bebida>();
            var bebida = client.GetBebida();
            foreach(var b in bebida)
            {
                Bebidas.Add(b);
            }
            MaxBebida = Bebidas.Count / 8;
            if (Bebidas.Count % 8 != 0)
            {
                MaxBebida++;
            }
            MaxPlato = Platos.Count / 8;
            if(Platos.Count % 8 != 0)
            {
                MaxPlato++;
            }
            ViewMenuPLato();
            
          

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var users = client.GetUsers();
            foreach(var u in users)
            {
                if(u.idUserName.Equals(textBoxUsuario.Text) && u.password.Equals(textBoxContrasena.Text))
                {
                    panel1.Enabled = true;
                    panel1.Hide();

                    break;
                }
            }
            if(panel1.Enabled)
            {
                label3.Text = "Usuario y Contrasena no corresponden !";
                label3.Show();
            }
        }

        private void buttonPlatoLeft_Click(object sender, EventArgs e)
        {
            
        }
        public void ViewMenuPLato()
        {
            
            while (true)
            {
                
                foreach (Control c in panelPlato.Controls)
                {
                    PictureBox p = new PictureBox();
                    if (c is PictureBox )
                    {
                        p = (PictureBox)c;
                        p.Image = Image.FromFile(Platos.ElementAt(0).imagen);
                       
                    }
                }
                break;
            }
        }
    }

        
}
