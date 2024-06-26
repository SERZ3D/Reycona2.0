﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnAdopcion_Click(object sender, EventArgs e)
        {
            AnimalesAdopcion animalesAdopcion = new AnimalesAdopcion();
            animalesAdopcion.Show();
            this.Hide();
        }

        private void btnVeterinarias_Click(object sender, EventArgs e)
        {
            Veterinaria veterinaria = new Veterinaria();    
            veterinaria.Show();
            this.Hide();
        }

      
    }
}
