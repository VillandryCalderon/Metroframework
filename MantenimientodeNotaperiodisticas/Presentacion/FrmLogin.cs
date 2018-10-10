using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MantenimientodeNotaperiodisticas.Presentacion;
using MetroFramework;
using MetroFramework.Forms;

namespace MantenimientodeNotaperiodisticas
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        { if (txtusuario.Text == "" && txtpass.Text == "")
            {
                MetroMessageBox.Show(this, "PorFavor Ingrese un usuario y Contraseña valida", "MetroMessagebox", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            else
            {

                var ventana = new FrmMenuPrincipal();
                ventana.Show();
                this.Hide();
            }
        }
    }
}
