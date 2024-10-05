using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FerreMaster
{
	public partial class Login : Form
	{

        public Login()
		{
			InitializeComponent();
            
        }

        private void txtUsuario_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

 
        }

        private void lblUsuario_Click(object sender, System.EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
