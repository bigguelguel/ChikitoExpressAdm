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

namespace ChikitoExpressAdm.Gestion_Restaurante
{

    public partial class GestionarBebidas : Form
    {
        AdmServiceClient client;
        public string Imagen { get; set; }
        public GestionarBebidas()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            UpdateComboBoxTiboBebida();
            UpdateDataGridViewBebida();
        }
        public class Boison
        {
            public String Nombre { get; set; }
            public int Precio { get; set; }
            public string Categoria { get; set; }
            public bool Estado { get; set; }
        }
        private void bttActualizar_Click(object sender, EventArgs e)
        {
            var tipoBebidas = client.GetTipoBebidas();
            Bebida bebida = new Bebida
            {
                Nombre = textBoxNombre.Text,
                precio = int.Parse(textBoxPrecio.Text),
                imagen = Imagen,
                estado = radioButton1.Checked,
                descripcion = textBoxDescripcion.Text,
                idTipoBebida = tipoBebidas.ElementAt(comboBoxTipoBebida.SelectedIndex).idTipoBebida
            };
            client.PostBebida(bebida);
            UpdateDataGridViewBebida();
        }
        public void UpdateComboBoxTiboBebida()
        {
            var tipoBebidas = client.GetTipoBebidas();
            List<String> strTipoBebidas = new List<string>();
            foreach(var t in tipoBebidas)
            {
                strTipoBebidas.Add(t.nombre);
            }
            comboBoxTipoBebida.DataSource = strTipoBebidas;
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Imagen|*jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Imagen = ofd.FileName;
                        pictureBoxBebida.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Bad data or Extention " + ex.Source);
                    }
                }
            }
        }

        private void UpdateDataGridViewBebida()
        {
            var bebidas = client.GetBebida();
            var tipoBebidas = client.GetTipoBebidas();
            List<Boison> boisones = new List<Boison>();
            foreach(var b in bebidas)
            {
                Boison bo = new Boison
                {
                    Nombre = b.Nombre,
                    Precio = b.precio,
                    Categoria = (from t in tipoBebidas where t.idTipoBebida == b.idTipoBebida select t.nombre).ElementAt(0),
                    Estado = b.estado
                };
                boisones.Add(bo);
            }
            dataGridViewBebida.DataSource = boisones;
        }
    }
}
