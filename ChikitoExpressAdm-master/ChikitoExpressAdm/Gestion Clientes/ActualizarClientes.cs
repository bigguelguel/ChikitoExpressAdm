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

namespace ChikitoExpressAdm.Gestion_Clientes
{
    public partial class ActualizarClientes : Form
    {
        public class Clian
        {
            public string PrimerNombre { get; set; }
            public string SegundoNombre { get; set; }
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public int IdCliente { get; set; }
            public string Document { get; set; }
            public string Usuario { get; set; }
            public Int32 PuntoFidelizacion { get; set; }
            public string Nacionalidad { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public String Email { get; set; }
            public String Zona { get; set; }
            public String Apt { get; set; }
            public String Casa { get; set; }
            public String Calle { get; set; }
        }
        public Cliente Actualizada { get; set; }
        AdmServiceClient client;
        public ActualizarClientes()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            UpdateDataGridCliente();
            UpdateComboBoxZona();
            Actualizada = new Cliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var zonas = client.GetZonas();
            Direccione direccione = new Direccione
            {
                Apt = textBoxApartamento.Text,
                casa = textBoxCasa.Text,
                calle = textBoxCalle.Text,
                idZona = zonas.ElementAt(comboBox3.SelectedIndex).idZona,
                estado = true,
                Edificio = textBoxEdificio.Text
            };
            Persona person = new Persona
            {
                primerNombre = textBoxPrimerNombre.Text,
                segundoNombre = textBoxSegundoNombre.Text,
                primerApellido = textBoxPrimerApellido.Text,
                segundoApellido = textBoxSegundoApellido.Text,
                telefono = textBoxTelefono.Text,
                Documento = textBoxDocument.Text,
                email = textBoxEmail.Text,
                nacionalidad = textBoxNacionalidad.Text,
                fechaModicacion = DateTime.Now,
                estado = checkBox1.Enabled,
                idDireccion = direccione.idDireccion,
                Direccione = direccione
            };
            User username = new User
            {
                idUserName = textBoxUsuario.Text,
                password = textBoxUsuario.Text,
                loginEstado = false,
                estado = true,
                fechaCreacion = DateTime.Now
            };
            Cliente newClient = new Cliente
            {
                puntoFidelizacion = 0,
                estado = true,
                Persona = person,
                User = username
            };
            client.ActualizarCliente(newClient, Int32.Parse(textBoxIdCliente.Text));
            UpdateDataGridCliente();
        }

        private void UpdateDataGridCliente()
        {
            int idperson;
            int idDireccion;
            int idUser;
            var cliente = client.GetCliente();
            var user = client.GetUsers();
            var direccion = client.GetDirecciones();
            var persone = client.GetPersonas();
            var zona = client.GetZonas();
            List<Clian> clis = new List<Clian>();
            foreach (var c in cliente)
            {
                idperson = (from p in persone
                            where p.idPersona == c.idPersona
                            select p.idPersona).ElementAt(0);
                int personiddicreccion = (from p in persone
                                          where p.idPersona == c.idPersona
                                          select p.idDireccion).ElementAt(0);
                idDireccion = (from d in direccion where d.idDireccion == personiddicreccion select d.idDireccion).ElementAt(0);
                int idzona = (from d in direccion where d.idDireccion == idDireccion select d.idZona).ElementAt(0);
                idUser = (from u in user where u.IdUser == c.IdUser select u.IdUser).ElementAt(0);
                Clian cli = new Clian
                {
                    IdCliente = c.idCliente,
                    PuntoFidelizacion = (int)c.puntoFidelizacion,
                    PrimerNombre = (from p in persone where p.idPersona == idperson select p.primerNombre).ElementAt(0),
                    SegundoNombre = (from p in persone where p.idPersona == idperson select p.segundoNombre).ElementAt(0),
                    PrimerApellido = (from p in persone where p.idPersona == idperson select p.primerApellido).ElementAt(0),
                    SegundoApellido = (from p in persone where p.idPersona == idperson select p.segundoApellido).ElementAt(0),
                    Email = (from p in persone where p.idPersona == idperson select p.email).ElementAt(0),
                    Nacionalidad = (from p in persone where p.idPersona == idperson select p.nacionalidad).ElementAt(0),
                    FechaNacimiento = (from p in persone where p.idPersona == idperson select p.fechaNacimiento).ElementAt(0),
                    Document = (from p in persone where p.idPersona == idperson select p.Documento).ElementAt(0),
                    Telefono = (from p in persone where p.idPersona == idperson select p.telefono).ElementAt(0),
                    Usuario = (from u in user where u.IdUser == c.IdUser select u.idUserName).ElementAt(0),
                    Zona = (from z in zona where z.idZona == idzona select z.nombre).ElementAt(0),
                    Apt = (from d in direccion where d.idDireccion == idDireccion select d.Apt).ElementAt(0),
                    Casa = (from d in direccion where d.idDireccion == idDireccion select d.casa).ElementAt(0),
                    Calle = (from d in direccion where d.idDireccion == idDireccion select d.calle).ElementAt(0)
                };
                clis.Add(cli);
            }

            dataGridView1.DataSource = clis;
        }
        private void UpdateComboBoxZona()
        {
            var zonas = client.GetZonas();
            List<string> zons = new List<string>();
            foreach (var c in zonas)
            {
                zons.Add(c.nombre);
            }
            comboBox3.DataSource = zons;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var zona = client.GetZonas();
            var users = client.GetUsers();
            var personas = client.GetPersonas();
            var direcciones = client.GetDirecciones();
            var cliente = client.GetCliente();
            

            int row = dataGridView1.CurrentRow.Index;
            int idcliente = cliente.ElementAt(row).idCliente;
            int idpersona = cliente.ElementAt(row).idPersona;
            int iduser = (int)cliente.ElementAt(row).IdUser;
            var person = from p in personas where p.idPersona == idpersona select p;
            var user = from u in users where u.IdUser == iduser select u;
            var direccion = from d in direcciones where d.idDireccion == person.ElementAt(row).idDireccion select d;
            textBoxApartamento.Text = direccion.ElementAt(row).Apt;
            textBoxCalle.Text = direccion.ElementAt(row).calle;
            textBoxCasa.Text = direccion.ElementAt(row).casa;
            textBoxEdificio.Text = direccion.ElementAt(row).Edificio;
            textBoxUsuario.Text = user.ElementAt(row).idUserName;
            textBoxIdCliente.Text = cliente.ElementAt(row).idCliente.ToString();
            textBoxDocument.Text = person.ElementAt(row).Documento;
            textBoxPrimerNombre.Text = person.ElementAt(row).primerNombre;
            textBoxSegundoNombre.Text = person.ElementAt(row).segundoNombre;
            textBoxPrimerApellido.Text = person.ElementAt(row).primerApellido;
            textBoxSegundoApellido.Text = person.ElementAt(row).segundoApellido;
            textBoxTelefono.Text = person.ElementAt(row).telefono;
            textBoxNacionalidad.Text = person.ElementAt(row).nacionalidad;
            textBoxFechaNacimiento.Text = person.ElementAt(row).fechaNacimiento.ToString();
            textBoxEmail.Text = person.ElementAt(row).email;
            checkBox1.Checked = user.ElementAt(row).estado;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
