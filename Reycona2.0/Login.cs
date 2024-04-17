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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
      

        private void btnAdopcion_Click(object sender, EventArgs e)
        {
            AnimalesAdopcion animalesAdopcion = new AnimalesAdopcion();
            animalesAdopcion.Show();
            this.Hide();
        }

        private void btnReycona_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();  
            principal.Show();
            this.Hide();
        }

        private void btnVeterinarias_Click(object sender, EventArgs e)
        {
            Veterinaria veterinaria = new Veterinaria();
            veterinaria.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndexLogeado indexLogeado = new IndexLogeado();
            indexLogeado.Show();
            this.Hide();
        }
    }
}
