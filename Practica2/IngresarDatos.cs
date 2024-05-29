using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Practica2
{
    public partial class IngresarDatos : Form
    {
        private int fichaNumero = 0;
        public IngresarDatos()
        {
            InitializeComponent();
            // Ocultar la barra de progreso al inicio
            progressBar1.Visible = false;
        }

        static String conexion = "server=localhost:3307;PORT=3307;DATABASE= fichas;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        private string nombre;
        private string apellido;
        private string edad;
        private string curp;
        private string telefono;

        private void Regresar2_Click(object sender, EventArgs e)
        {
            Area formularioArea = new Area();


            formularioArea.Show();


            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar la barra de progreso al hacer clic en button2
            progressBar1.Visible = true;
            // Aquí puedes agregar la funcionalidad del primer formulario
            Thread hiloProceso = new Thread(ProcesoLargo);
            hiloProceso.Start();
        }

        private void ProcesoLargo()
        {
            for (int i = 0; i <= 100; i++)
            {
                this.Invoke((MethodInvoker)delegate {
                    progressBar1.Value = i;
                });
                Thread.Sleep(50);
            }
            // Incrementar el número de ficha al completarse la barra de progreso
            fichaNumero++;
            GuardarDatosEnBaseDeDatos();  // Llama al método para guardar los datos en la base de datos
            this.Invoke((MethodInvoker)delegate {
                // Mostrar mensaje de éxito al completarse la barra de progreso
                MessageBox.Show($"Tu número de ficha es: {fichaNumero}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void GuardarDatosEnBaseDeDatos()
        {
            // Crear la conexión
            using (MySqlConnection connection = new MySqlConnection(conexion))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Preparar la consulta SQL
                    string query = "INSERT INTO fichas (nombre, apellido, edad, curp, telefono) VALUES (@nombre, @apellido, @edad, @curp, @telefono)";

                    // Crear el comando SQL con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros a la consulta
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@edad", edad);
                        cmd.Parameters.AddWithValue("@curp", curp);
                        cmd.Parameters.AddWithValue("@telefono", telefono);

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante el proceso de guardar
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show("Error al guardar los datos nayeli y alain:  " + ex.Message);
                    });
                }
            }
        }

        // Asignar los eventos TextChanged para actualizar las variables
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = ((TextBox)sender).Text;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            apellido = ((TextBox)sender).Text;
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            edad = ((TextBox)sender).Text;
        }

        private void textBoxCurp_TextChanged(object sender, EventArgs e)
        {
            curp = ((TextBox)sender).Text;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            telefono = ((TextBox)sender).Text;
        }
    }
}
