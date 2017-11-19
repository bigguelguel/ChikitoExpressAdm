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
    }
}
