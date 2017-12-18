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

namespace ChikitoExpressAdm.Realizar_Orden
{
    public partial class Realizar_Orden : Form
    {
        AdmServiceClient cliente;
        private int Total { get; set; } 
        private int ITBIS { get; set; }
        public Realizar_Orden()
        {
            InitializeComponent();
           cliente = new AdmServiceClient();
        }

        private void Realizar_Orden_Load(object sender, EventArgs e)
        {
             
            var bebidas = cliente.GetBebida();
            foreach(var b in bebidas)
            {
                imageList1.Images.Add(Image.FromFile(b.imagen));
            }
            for(int i = 0; i< bebidas.Count(); i++)
            {
                listView1.Items.Add(bebidas.ElementAt(i).Nombre+" $"+ bebidas.ElementAt(i).precio, i);
            }

           
            var platos = cliente.GetPlato();
            foreach (var b in platos)
            {
                imageList2.Images.Add(Image.FromFile(b.imagen));
            }
            for (int i = 0; i < platos.Count(); i++)
            {
                listView2.Items.Add(platos.ElementAt(i).nombre+ " $" + platos.ElementAt(i).precio, i);
            }
        }

     

     

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var cl = cliente.GetBebida();
            listBox1.Items.Add(cl.ElementAt(listView1.FocusedItem.Index).Nombre+" --->$"+ cl.ElementAt(listView1.FocusedItem.Index).precio);
            Total += cl.ElementAt(listView1.FocusedItem.Index).precio;
            labelSuma.Text = Total.ToString();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            var cl = cliente.GetPlato();
            listBox1.Items.Add(cl.ElementAt(listView2.FocusedItem.Index).nombre + " --->$" + cl.ElementAt(listView2.FocusedItem.Index).precio);
            Total += cl.ElementAt(listView2.FocusedItem.Index).precio;
            labelSuma.Text = Total.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = 50;
            e.Graphics.DrawImage(Image.FromFile("C:/Users/Miguelson/Source/repos/ChikitoExpressAdmgit/ChikitoExpressAdm-master/ChikitoExpressAdm/ChikitoExpress.png"), 175,altura);
            altura = 500;
            foreach(var i in listBox1.Items)
            {
                e.Graphics.DrawString(i.ToString(), listBox1.Font, new SolidBrush(listBox1.ForeColor), 50, altura, StringFormat.GenericDefault);
                altura += listBox1.ItemHeight;
            }
            e.Graphics.DrawString("Total = "+Total, listBox1.Font, new SolidBrush(listBox1.ForeColor), 550, altura, StringFormat.GenericDefault);
            altura += listBox1.ItemHeight;
            e.Graphics.DrawString("Pago = " + textBoxEntradaCaja.Text, textBoxEntradaCaja.Font, new SolidBrush(textBoxEntradaCaja.ForeColor), 550, altura, StringFormat.GenericDefault);
            altura += listBox1.ItemHeight;
            e.Graphics.DrawString("Devuelta = " + textBoxDevuelta.Text, textBoxDevuelta.Font, new SolidBrush(textBoxDevuelta.ForeColor), 550, altura, StringFormat.GenericDefault);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void textBoxEntradaCaja_TextChanged(object sender, EventArgs e)
        {
            textBoxDevuelta.Text = (Int32.Parse(textBoxEntradaCaja.Text) - Total).ToString();
        }
    }
}
