using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Regresar1_Click(object sender, EventArgs e)
        {
            
            Inicio formularioInicio = new Inicio();

           
            formularioInicio.Show();

            
            this.Close();
        }

       

        private void Ginecologia_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();

            
            formularioIngresarDatos.Show();

            
            this.Close();
        }

        private void TrabajoSocial_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();

            
            formularioIngresarDatos.Show();

            
            this.Close();
        }

        private void Ultrasonido_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();


            formularioIngresarDatos.Show();


            this.Close();
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();


            formularioIngresarDatos.Show();


            this.Close();
        }

        private void Dental_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();


            formularioIngresarDatos.Show();


            this.Close();
        }

        private void Laboratorio_Click(object sender, EventArgs e)
        {
            IngresarDatos formularioIngresarDatos = new IngresarDatos();


            formularioIngresarDatos.Show();


            this.Close();
        }
    }
}
