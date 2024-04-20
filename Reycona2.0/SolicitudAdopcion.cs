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
    public partial class SolicitudAdopcion : Form
    {
        public SolicitudAdopcion()
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
            AnimalesAdopcion animales = new AnimalesAdopcion(); 
            animales.Show();
            this.Hide();
        }

        private void btnVeterinarias_Click(object sender, EventArgs e)
        {
            Veterinaria veterinaria = new Veterinaria();
            veterinaria.Show();
            this.Hide();
                    }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAgregarSolicitudAdopcion_Click(object sender, EventArgs e)
        {
            string dni = tbxDNIAdopcion.Text;
            string idanimal = tbxIdAnimalAdopcion.Text;
            string depto = cbxDepartamentoAdopcion.Text;
            string nombre1 = tbxNombre1Adopcion.Text;
            string nombre2 = tbxNombre2Adopcion.Text;
            string municipio= cbxMunicipioAdopcion.Text;
            string apellido1 = tbxApellido1Adopcion.Text;
            string apellido2 = tbxApellido2Adopcion.Text;
            string colonia = tbxColoniaAdopcion.Text;
            string telefono = tbxTelefonoAdopcion.Text;
            string correo =TbxCorreoAdopcion.Text;
            string sector = tbxSectorAdopcion.Text;
            DateTime nacimiento = dtpNacimientoAdopcion.MinDate;
            DateTime solicitud = dtpSolicitudAdopcion.MinDate;
            string bloque = tbxBloqueAdopcion.Text;
            string profesion = tbxProfesionAdopcion.Text;
            string genero = cbxGeneroAdopcion.Text;
            string casa = tbxNoCasaAdopcion.Text;

            if (dni=="" || idanimal == "" || depto =="Seleccione Tipo" || nombre1 =="" || nombre2 == "" || municipio== "Seleccione Tipo" ||  apellido1 == "" || apellido2 == "" || colonia == "" 
                || telefono == "" || correo == "" || sector == "" || bloque == "" || profesion == "" || genero == "Seleccione Tipo" || casa == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }else
            {
                MessageBox.Show("Vamo :v");
            }
         }
    }
}
