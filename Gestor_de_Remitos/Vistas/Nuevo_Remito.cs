using Gestor_de_Remitos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Remitos.Vistas
{
    public partial class Nuevo_Remito : Form
    {
        public Nuevo_Remito()
        {
            InitializeComponent();
            DB_Helper helper = new DB_Helper();
            txt_descripcion.Text = helper.algo();
        }

        private void btn_editar_mis_datos_Click(object sender, EventArgs e)
        {
            Form_mis_datos misDatos = new Form_mis_datos();
            misDatos.ShowDialog();
        }
    }
}
