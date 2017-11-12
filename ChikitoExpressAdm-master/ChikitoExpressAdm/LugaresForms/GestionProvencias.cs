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

namespace ChikitoExpressAdm.LugaresForms
{
    public partial class GestionProvencias : Form
    {
        AdmServiceClient client;
        private int IdPais { get; set; }
        public class Pro
        {
            public String Nombre { get; set; }
            public String Pais { get; set; }
            public String FechaAgregar { get; set; }
            public Boolean Estado { get; set; }
        }
        public GestionProvencias()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            updateDataGridView();
            UpDateCombobox();
        }
        public void updateDataGridView()
        {
            var provencias = client.GetProvencias();
            var paises = client.GetPaises();
            List<Pro> proves = new List<Pro>();
            foreach(var p in provencias)
            {
                var prov = new Pro
                {
                    Nombre = p.nombre,
                    Pais = (from c in paises where c.idpais == p.Pais_idpais select c.nombre).ElementAt(0),
                    FechaAgregar = p.fechaCreacion.ToString(),
                    Estado = p.estado
                };
                proves.Add(prov);
            }
            dataGridView1.DataSource = proves;
        }
        public void UpDateCombobox()
        {
            var paises = new List<String>();
            var pais = client.GetPaises();
            foreach (var p in pais)
            {
                paises.Add(p.nombre);
            }
            comboBoxPais.DataSource = paises;
        }
        private void bttAgregarProvencia_Click(object sender, EventArgs e)
        {
            var pais = client.GetPaises();
            Provencia prov = new Provencia
            {
                nombre = txtbAgregarProvencia.Text,
                fechaCreacion = DateTime.Now,
                Pais_idpais = pais.ElementAt(comboBoxPais.SelectedIndex).idpais,
                estado = true
            };

            client.PosProvencia(prov);
            updateDataGridView();
        }

    }
}
