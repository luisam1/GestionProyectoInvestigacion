using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectoInvestigacion
{
    public partial class Ingreso : Form
    {
        private const string USUARIO = "";
        private const string CLAVE = "";

        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            erpMensaje.SetError(txtUsuario, null);
            erpMensaje.SetError(txtClave, null);
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpMensaje.SetError(txtUsuario, "Ingresa nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpMensaje.SetError(txtClave, "Ingresa la contraseña");
                return;
            }
            if (txtUsuario.Text == USUARIO && txtClave.Text == CLAVE)
            {
                var principal = new MDIPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales de ingreso no son válidas. Verifique", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
