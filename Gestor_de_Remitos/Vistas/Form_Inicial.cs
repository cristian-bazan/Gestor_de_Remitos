using Gestor_de_Remitos.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Remitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Remito remito = new Nuevo_Remito();
            remito.ShowDialog();
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_mis_datos misDatos = new Form_mis_datos();
            misDatos.ShowDialog();
        }
    }
}
