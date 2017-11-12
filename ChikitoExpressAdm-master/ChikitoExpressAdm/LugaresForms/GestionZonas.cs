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
        public class Pro
        {
            public String Nombre { get; set; }
            public String Municipio { get; set; }
            public String Provencia { get; set; }
            public String Pais { get; set; }
            public String FechaAgregar { get; set; }
            public Boolean Estado { get; set; }
        }
        public GestionZonas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
