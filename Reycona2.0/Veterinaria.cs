using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reycona2._0
{
    public partial class Veterinaria : Form
    {
        public Veterinaria()
        {
            InitializeComponent();
        }


        private void btnReycona_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void btnAdopcion_Click(object sender, EventArgs e)
        {
            AnimalesAdopcion animalesAdopcion = new AnimalesAdopcion();
            animalesAdopcion.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        
    }
}
