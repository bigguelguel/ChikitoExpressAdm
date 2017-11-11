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

        public GestionProvencias()
        {
            InitializeComponent();
            client = new AdmServiceClient();
            updateDataGridView();
        }
        public void updateDataGridView()
        {
            dataGridView1.DataSource = client.GetProvencias();
        }
    }
}
