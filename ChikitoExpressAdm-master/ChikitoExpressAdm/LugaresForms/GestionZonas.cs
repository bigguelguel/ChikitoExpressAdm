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
    public partial class GestionZonas : Form
    {
        public class Zon
        {
            public String Nombre { get; set; }
            public String Municipio { get; set; }
            public String Provencia { get; set; }
            public String Pais { get; set; }
            public String FechaAgregar { get; set; }
            public Boolean Estado { get; set; }
        }
        AdmServiceClient client;
        private int IdPais { get; set; }
        private int IdProvencia { get; set; }
        public GestionZonas()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            UpDateCombobox();
            updateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
          public void UpDateCombobox()
        {
            var stringMunicipios = new List<String>();
            var municipios = client.GetMunicipios();
            foreach (var m in municipios)
            {
                stringMunicipios.Add(m.nombre);
            }
            comboBoxMunicipio.DataSource = stringMunicipios;
        }
        public void updateDataGridView()
        {
            var zonas = client.GetZonas();
            var paises = client.GetPaises();
            var provencias = client.GetProvencias();
            var municipios = client.GetMunicipios();
            List<Zon> zons = new List<Zon>();
            foreach (var z in zonas)
            {
                IdProvencia = (from m in municipios where m.idMunicipio == z.idMunicipio select m.Provencias_idprovencia).ElementAt(0);
                IdPais = (from prov in provencias where prov.idprovencia == IdProvencia select prov.Pais_idpais).ElementAt(0);
                var zona = new Zon
                {
                    Nombre = z.nombre,
                    Municipio = (from m in municipios where m.idMunicipio == z.idMunicipio select m.nombre).ElementAt(0),
                    Provencia = (from prov in provencias where prov.idprovencia == IdProvencia select prov.nombre).ElementAt(0),
                    Pais = (from p in paises where p.idpais == IdPais select p.nombre).ElementAt(0),
                    FechaAgregar = z.fechaCreacion.ToString(),
                    Estado = z.estado
                };
                zons.Add(zona);
            }
            dataGridView1.DataSource = zons;
        }
    }
}
