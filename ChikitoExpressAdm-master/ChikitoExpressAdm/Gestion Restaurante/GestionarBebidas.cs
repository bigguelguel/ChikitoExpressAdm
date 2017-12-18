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
        List<Boison> boisones;
        List<ServiceReference.Menu> Menus;
        public GestionarBebidas()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            boisones = new List<Boison>();
            Menus = new List<ServiceReference.Menu>();
            UpdateComboBoxTiboBebida();
            UpdateDataGridViewBebida();
            
        }
        public class Boison
        {
            public String Nombre { get; set; }
            public int Precio { get; set; }
            public string Categoria { get; set; }
            public String Menu { get; set; }
            public string Descripcion { get; set; }
            public bool Estado { get; set; }
            
        }
     
        public void UpdateComboBoxTiboBebida()
        {
            var tipoBebidas = client.GetTipoBebidas();
            List<String> strTipoBebidas = new List<string>();
            foreach(var t in tipoBebidas)
            {
                strTipoBebidas.Add(t.nombre);
            }
            var menus = client.GetMenu();
            List<String> strMenu = new List<string>();
            foreach(var m in menus)
            {
                strMenu.Add(m.nombre);
            }
            comboBoxTipoBebida.DataSource = strTipoBebidas;
            comboBoxMenu.DataSource = strMenu;
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
            var menus = client.GetMenu();
            var elemento = client.GetElementosDeMenu();
            boisones = new List<Boison>();
            foreach(var b in bebidas)
            {
                int id = (int)(from e in elemento where e.idBebida == b.idBebida select e.idMenu).ElementAt(0);
                Boison bo = new Boison
                {
                    Nombre = b.Nombre,
                    Precio = b.precio,
                    Categoria = (from t in tipoBebidas where t.idTipoBebida == b.idTipoBebida select t.nombre).ElementAt(0),
                    Estado = b.estado,
                    Menu = (from m in menus where m.idMenu == id select m.nombre).ElementAt(0),
                    Descripcion = b.descripcion
                };
                boisones.Add(bo);
            }
            dataGridViewBebida.DataSource = boisones;
        }

        private void dataGridViewBebida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombre.Text = boisones.ElementAt(dataGridViewBebida.CurrentRow.Index).Nombre;
            textBoxPrecio.Text = boisones.ElementAt(dataGridViewBebida.CurrentRow.Index).Precio.ToString();
            textBoxDescripcion.Text = boisones.ElementAt(dataGridViewBebida.CurrentRow.Index).Descripcion;
            radioButton1.Checked = boisones.ElementAt(dataGridViewBebida.CurrentRow.Index).Estado;
            var beb = client.GetBebida();
            Imagen = beb.ElementAt(dataGridViewBebida.CurrentRow.Index).imagen;
            pictureBoxBebida.Image = Image.FromFile(Imagen);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var tipoBebidas = client.GetTipoBebidas();
            var beb = client.GetBebida();
            var menu = client.GetMenu();
            Bebida bebida = new Bebida
            {
                Nombre = textBoxNombre.Text,
                precio = int.Parse(textBoxPrecio.Text),
                imagen = Imagen,
                estado = radioButton1.Checked,
                descripcion = textBoxDescripcion.Text,
                idTipoBebida = tipoBebidas.ElementAt(comboBoxTipoBebida.SelectedIndex).idTipoBebida
            };
            client.ActualizarBebida(beb.ElementAt(dataGridViewBebida.CurrentRow.Index).idBebida, bebida, menu.ElementAt(comboBoxMenu.SelectedIndex).idMenu);
           
            UpdateDataGridViewBebida();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var tipoBebidas = client.GetTipoBebidas();
            var menus = client.GetMenu(); 
            Bebida bebida = new Bebida
            {
                Nombre = textBoxNombre.Text,
                precio = int.Parse(textBoxPrecio.Text),
                imagen = Imagen,
                estado = radioButton1.Checked,
                descripcion = textBoxDescripcion.Text,
                idTipoBebida = tipoBebidas.ElementAt(comboBoxTipoBebida.SelectedIndex).idTipoBebida
            };
            ElementosDeMenu elementosDeMenu = new ElementosDeMenu
            {
                idBebida = bebida.idBebida,
                Bebida = bebida,
                idMenu = menus.ElementAt(comboBoxMenu.SelectedIndex).idMenu,
                disponible = true
            };
            client.PostElementosDeMenu(elementosDeMenu);
            UpdateDataGridViewBebida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
        }
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

        private void GestionarBebidas_Load(object sender, EventArgs e)
        {

        }
    }
}
