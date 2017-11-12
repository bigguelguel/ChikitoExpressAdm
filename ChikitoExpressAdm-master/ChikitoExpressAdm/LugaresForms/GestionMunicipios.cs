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
    public partial class GestionMunicipios : Form
    {
        AdmServiceClient client;
        public class Muni
        {
            public String Nombre { get; set; }
            public String Provencia { get; set; }
            public String Pais { get; set; }
            public String FechaAgregar { get; set; }
            public Boolean Estado { get; set; }
        }
        public GestionMunicipios()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            UpDateDataGridMunicipio();
            UpDateCombobox();
        }
        private void UpDateDataGridMunicipio()
        {
            var paises = client.GetPaises();
            var provencias = client.GetProvencias();
            var municipios = client.GetMunicipios();
            var muniPios = new List<Muni>();
            foreach(var m in municipios)
            {
                int idp = (from c in provencias
                           where c.idprovencia == m.Provencias_idprovencia select c.Pais_idpais).ElementAt(0);
                var muni = new Muni
                {
                    Nombre = m.nombre,
                    Provencia = (from c in provencias where c.idprovencia == m.Provencias_idprovencia
                                 select c.nombre).ElementAt(0),
                    Pais = (from c in paises where c.idpais == idp select c.nombre).ElementAt(0),
                    FechaAgregar = m.fechaCreacion.ToString(),
                    Estado = m.estado
                };
                muniPios.Add(muni);
            }
            dataGridViewMunicipio.DataSource = muniPios;
        }
        public void UpDateCombobox()
        {
            var provencias = new List<String>();
            var provens = client.GetProvencias();
            foreach (var p in provens)
            {
                provencias.Add(p.nombre);
            }
            comboBoxProvencia.DataSource = provencias;
        }

        private void AgregarMunicipio_Click(object sender, EventArgs e)
        {
            var provencias = client.GetProvencias();
            Municipio prov = new Municipio
            {
                nombre = txtbMunicipio.Text,
                fechaCreacion = DateTime.Now,
                Provencias_idprovencia = provencias.ElementAt(comboBoxProvencia.SelectedIndex).idprovencia,
                estado = true
            };

            client.PostMunicipio(prov);
            UpDateDataGridMunicipio();
        }
    }
}
