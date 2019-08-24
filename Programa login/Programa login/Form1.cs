using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextAceptar_Click(object sender, EventArgs e)
        {
            if (User.Text == "juancho")
            {
                if (Contra.Text == "123tamarindo")
                    MessageBox.Show("felicidades, su cuenta de fornais ha iniciado correctamente");
                else
                    MessageBox.Show("la contraseña es inncorrecta");
            }
            else
                MessageBox.Show("el nombre de usuario es incorrecto");
        }

        private void TextSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
