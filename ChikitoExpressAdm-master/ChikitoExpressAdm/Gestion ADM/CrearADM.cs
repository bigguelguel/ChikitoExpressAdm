using ChikitoExpressAdm.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChikitoExpressAdm.Gestion_ADM
{
    public partial class CrearADM : Form
    {
        AdmServiceClient client;
        public CrearADM()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            UpdateComboxRoles();
            UpdateComboxZonas();
            comboBoxRoles.Enabled = false;
            buttonAsignarRoles.Enabled = false;
        }

        private void buttonAsignarRoles_Click(object sender, EventArgs e)
        {
            var roles = client.GetRoles();
            listBoxRoles.Items.Add(roles.ElementAt(comboBoxRoles.SelectedIndex).Nombre);
        }
        // this funcion get a list of Rol from the server and them to comboboxRoeles
        private void UpdateComboxRoles()
        {
            var roles = client.GetRoles();
            List<String> Nroles = new List<string>();
            foreach (var r in roles)
            {
                Nroles.Add(r.Nombre);
            }
            comboBoxRoles.DataSource = Nroles;
        }
        // this funcion get a list of Zon from the server and them to comboboxZona
        private void UpdateComboxZonas()
        {
            var zonas = client.GetZonas();
            List<String> nZonas = new List<string>();
            foreach (var r in zonas)
            {
                nZonas.Add(r.nombre);
            }
            comboBoxZona.DataSource = nZonas;
        }

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            var zonas = client.GetZonas();
            Direccione direccione = new Direccione
            {
                calle = textBoxCalle.Text,
                casa = textBoxCasa.Text,
                Apt = textBoxApartamento.Text,
                idZona = zonas.ElementAt(comboBoxZona.SelectedIndex).idZona,
                Edificio = textBoxEdificio.Text,
                estado = true
            };
            Persona persona = new Persona
            {
                idDireccion = direccione.idDireccion,
                Direccione = direccione,
                Documento = textBoxDocumento.Text,
                telefono = textBoxTelefono.Text,
                estado = true,
                nacionalidad = textBoxNacimiento.Text,
                primerNombre = textBoxPrimerNombre.Text,
                segundoNombre = textBoxSegundoNombre.Text,
                primerApellido = textBoxPrimerApellido.Text,
                segundoApellido = textBoxSegundoApellido.Text,
                email = textBoxEmail.Text,
                fechaCreacion = DateTime.Now,
                fechaNacimiento= DateTime.ParseExact(textBoxNacimiento.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture),

             };
             
        
            List<UsersRole> usersroles = new List<UsersRole>();
            User user = new User
            {
                loginEstado = false,
                estado = true,
                idUserName = textBoxUsuario.Text,
                password = textBoxUsuario.Text,
                fechaCreacion = DateTime.Now
            };
           
            Administradore newAdm = new Administradore()
            {
                IdUser = user.IdUser,
                User = user,
                idPersona = persona.idPersona,
                Persona = persona,
                FechaCreacion = DateTime.Now,
                salario = Int32.Parse(textBoxSalario.Text),
                estado = true
            };
            client.PostAdministrador(newAdm);
            comboBoxRoles.Enabled = true;
            buttonAsignarRoles.Enabled = true; ;
        }

        private void buttonNuevoAdm_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }
        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }
    }
}
