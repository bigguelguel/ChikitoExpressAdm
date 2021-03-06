﻿using ChikitoExpressAdm.ServiceReference;
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
    public partial class GestionarPlatos : Form
    {
        AdmServiceClient client;
        public class Plat
        {
            public String Nombre { get; set; }
            public String Categoria { get; set; }
            public int Precio { get; set; }
            public String Descripcion { get; set; }
            public bool Estado { get; set; }
        }
        public List<Plat> Platos;
        public String Imagen { get; set; }
        public GestionarPlatos()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            Platos = new List <Plat>();
            UpdateDataGridViewPlato();
            UpdateComboBoxTiboBebida();
        }

        public void UpdateComboBoxTiboBebida()
        {
            var tipoPlatos = client.GetTipoPlatos();
            List<String> strTipoBebidas = new List<string>();
            foreach (var t in tipoPlatos)
            {
                strTipoBebidas.Add(t.nombre);
            }
            var vPlatos = client.GetMenu();
            List<String> strPlato = new List<string>();
            foreach (var p in vPlatos)
            {
                strPlato.Add(p.nombre);
            }
            comboBoxMenu.DataSource = strPlato;
            comboBoxTipoPlato.DataSource = strTipoBebidas;
        }
        private void UpdateDataGridViewPlato()
        {
            var platos = client.GetPlato();
            var tipoPlatos = client.GetTipoPlatos();
            Platos = new List<Plat>();
            foreach (var p in platos)
            {
                Plat pla = new Plat
                {
                    Nombre = p.nombre,
                    Precio = p.precio,
                    Categoria = (from t in tipoPlatos where t.idTipoPlato == p.idTipoPlato select t.nombre).ElementAt(0),
                    Estado = p.estado,
                    Descripcion = p.descripcion
                };
                Platos.Add(pla);
            }
            dataGridViewPlato.DataSource =Platos;
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
                        pictureBoxPlato.Image = Image.FromFile(Imagen);
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Bad data or Extention " + ex.Source);
                    }
                }
            }
        }

        private void dataGridViewPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombre.Text = Platos.ElementAt(dataGridViewPlato.CurrentRow.Index).Nombre;
            textBoxPrecio.Text = Platos.ElementAt(dataGridViewPlato.CurrentRow.Index).Precio.ToString();
            textBoxDescripcion.Text = Platos.ElementAt(dataGridViewPlato.CurrentRow.Index).Descripcion;
            checkBox1.Checked = Platos.ElementAt(dataGridViewPlato.CurrentRow.Index).Estado;
            var beb = client.GetPlato();
            Imagen = beb.ElementAt(dataGridViewPlato.CurrentRow.Index).imagen;
            pictureBoxPlato.Image = Image.FromFile(Imagen);
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            var tipoPlatos = client.GetTipoPlatos();
            Plato plato = new Plato
            {
                nombre = textBoxNombre.Text,
                precio = int.Parse(textBoxPrecio.Text),
                imagen = Imagen,
                estado = checkBox1.Checked,
                descripcion = textBoxDescripcion.Text,
                idTipoPlato = tipoPlatos.ElementAt(comboBoxTipoPlato.SelectedIndex).idTipoPlato
            };

            var menus = client.GetMenu();
            var plates = client.GetPlato();
            ElementosDeMenu elementosDeMenu = new ElementosDeMenu
            {
                idPlato = plato.idPlato,
                Plato = plato,
                idMenu = menus.ElementAt(comboBoxMenu.SelectedIndex).idMenu,
                disponible = true
            };
            client.PostElementosDeMenu(elementosDeMenu);
            UpdateDataGridViewPlato();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var tipoPlatos = client.GetTipoPlatos();
            var plat = client.GetPlato();
            Plato plato = new Plato
            {
                nombre = textBoxNombre.Text,
                precio = int.Parse(textBoxPrecio.Text),
                imagen = Imagen,
                estado = checkBox1.Checked,
                descripcion = textBoxDescripcion.Text,
                idTipoPlato = tipoPlatos.ElementAt(comboBoxTipoPlato.SelectedIndex).idTipoPlato
            };
            client.ActualizarPlato(plat.ElementAt(dataGridViewPlato.CurrentRow.Index).idPlato, plato);
            UpdateDataGridViewPlato();
            
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
    }
}
