using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace MantenimientodeNotaperiodisticas.Presentacion
{
    public partial class FrmMenuPrincipal : MetroForm
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            group1.Visible = false;
            group2.Visible = false;
            group3.Visible = false;
        }

        private void lblcrearRoles_Click(object sender, EventArgs e)
        {
            group1.Visible = true;
            group2.Visible = false;
            group3.Visible = false;
        }

       

        private void lblCrearusuarios_Click(object sender, EventArgs e)
        {
            group2.Visible = true;
            group1.Visible = false;
            group3.Visible = false;
        }

        private void lblconfsistema_Click(object sender, EventArgs e)
        {
            group3.Visible = true;
            group2.Visible = false;
            group1.Visible = false;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtsistema_Click(object sender, EventArgs e)
        {

        }
    }
}
