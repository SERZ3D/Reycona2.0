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
    public partial class Denuncias : Form
    {
        public Denuncias()
        {
            InitializeComponent();
        }

        private void btnReycona_Click(object sender, EventArgs e)
        {
            IndexLogeado indexLogeado = new IndexLogeado();
            indexLogeado.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();  
            empleados.Show();
            this.Hide();

        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            Voluntarios voluntarios = new Voluntarios();
            voluntarios.Show();
            this.Hide();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            AnimalesRegistrados animalesRegistrados = new AnimalesRegistrados();
            animalesRegistrados.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
