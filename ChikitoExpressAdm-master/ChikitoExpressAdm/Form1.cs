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
            updatePlatoBebida();
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
            
            PosicionPlato = 0;
            PosicionBebida = 0;
            ActAndDesacButon();
            ViewMenuBebida();
            ViewMenuPLato();
            UpdateCombox();

        }
        public void updatePlatoBebida()
        {
            var plato = client.GetPlato();
            foreach (var p in plato)
            {
                Platos.Add(p);
            }
            Bebidas = new List<Bebida>();
            var bebida = client.GetBebida();
            foreach (var b in bebida)
            {
                Bebidas.Add(b);
            }
        }
        public void UpdateCombox()
        {
            var menus = client.GetMenu();
            var plato = client.GetTipoPlatos();
            var bebida = client.GetTipoBebidas();
            List<String> vPlatos = new List<String>();
            List<String> vBebida = new List<String>();
            List<String> vMenu = new List<String>();
            foreach(var p in plato)
            {
                vPlatos.Add(p.nombre);
            }
            foreach (var p in bebida)
            {
                vBebida.Add(p.nombre);
            }
            foreach (var p in menus)
            {
                vMenu.Add(p.nombre);
            }
            comboBoxMenu.DataSource = vMenu;
            comboBoxTipoPlato.DataSource = vPlatos;
            comboBoxTipoBebida.DataSource = vBebida;
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
            PosicionPlato-=1;
            ViewMenuPLato();
            ActAndDesacButon();

        }

        private void buttonPlatoRight_Click(object sender, EventArgs e)
        {
            PosicionPlato+=1;
            ViewMenuPLato();
            ActAndDesacButon();
        }
        public void ViewMenuPLato()
        {
            
            while (true)
            {
                int i = 0;
                if(PosicionPlato >= 1)
                {
                    i = 8 * PosicionPlato;
                }

                foreach (Control c in panelPlato.Controls)
                {
                    PictureBox p = new PictureBox();
                    if (c is PictureBox )
                    {
                        p = (PictureBox)c;
                        if (i < Platos.Count)
                        {
                            p.Image = Image.FromFile(Platos.ElementAt(i).imagen);
                        }
                        i++;
                       
                    }
                }
                break;
            }
        }
        public void ViewMenuBebida()
        {

            while (true)
            {
                int i = 0;
                if (PosicionBebida >= 1)
                {
                    i = 8 * PosicionBebida;
                }

                foreach (Control c in panelBebida.Controls)
                {
                    PictureBox p = new PictureBox();
                    if (c is PictureBox)
                    {
                        p = (PictureBox)c;
                        if (i < Bebidas.Count)
                        {
                            
                            p.Image = Image.FromFile(Bebidas.ElementAt(i).imagen);
                        }
                        i++;

                    }
                }
                break;
            }
        }
        private void ActAndDesacButon()
        {
            if(MaxPlato == 1)
            {
                buttonPlatoRight.Enabled = false;
                buttonPlatoLeft.Enabled = false;
            }
            else if(PosicionPlato == 0)
            {
                buttonPlatoRight.Enabled = true;
                buttonPlatoLeft.Enabled = false;
            }
            else if( PosicionPlato > 0 && PosicionPlato < MaxPlato -1)
            {
                buttonPlatoRight.Enabled = true;
                buttonPlatoLeft.Enabled = true;
            }
            else
            {
                buttonPlatoRight.Enabled = false;
                buttonPlatoLeft.Enabled = true;
            }

            if (MaxBebida == 1)
            {
                buttonBebidaRight.Enabled = false;
                buttonBebidaLeft.Enabled = false;
            }
            else if (PosicionBebida == 0)
            {
                buttonBebidaRight.Enabled = true;
                buttonBebidaLeft.Enabled = false;
            }
            else if (PosicionBebida > 0 && PosicionBebida < MaxBebida -1)
            {
                buttonBebidaRight.Enabled = true;
                buttonBebidaLeft.Enabled = true;
            }
            else
            {
                buttonBebidaRight.Enabled = false;
                buttonBebidaLeft.Enabled = true;
            }
        }

        private void buttonBebidaRight_Click(object sender, EventArgs e)
        {
            PosicionBebida += 1;
            ViewMenuBebida();
            ActAndDesacButon();

        }

        private void buttonBebidaLeft_Click(object sender, EventArgs e)
        {
            PosicionBebida -= 1;
            ViewMenuBebida();
            ActAndDesacButon();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            var menus = client.GetMenu();
            var elementM = client.GetElementosDeMenu();
            var element = from el in elementM where el.idMenu == menus.ElementAt(comboBoxMenu.SelectedIndex).idMenu select el;
            List<Plato> plat =  new List<Plato>();
            List<Bebida> beb = new List<Bebida>();
            updatePlatoBebida();
            foreach (var m in element)
            {
                if(m.idBebida != null)
                {
                    beb.Add((from b in Bebidas where b.idBebida == m.idBebida select b).ElementAt(0));
                }
            }
            foreach (var m in element)
            {
                if (m.idPlato != null)
                {
                    plat.Add((from p in Platos where p.idPlato == m.idPlato select p).ElementAt(0));
                }
            }
            Platos = new List<Plato>();
            Bebidas = new List<Bebida>();
            foreach(var p in plat)
            {
                Platos.Add(p);
            }
            foreach (var b in beb)
            {
                Bebidas.Add(b);
            }
            RemovePictureBox();
            ViewMenuBebida();
            ViewMenuPLato();
            
        }

        private void RemovePictureBox()
        {
            foreach(Control c in panelBebida.Controls)
            {
                PictureBox p = new PictureBox();
                
                if( c is PictureBox)
                {
                    p = (PictureBox)c;
                    p.Image = null;
                    p.Refresh();
                }
            }

            foreach (Control c in panelPlato.Controls)
            {
                PictureBox p = new PictureBox();
                if (c is PictureBox)
                {
                    p = (PictureBox)c;
                   
                    p.Image = null;
                    p.Refresh();
                }
            }
        }

        private void realizarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Realizar_Orden.Realizar_Orden FormRealizarOrden = new Realizar_Orden.Realizar_Orden();
            FormRealizarOrden.Show();
        }
    }

        
}
