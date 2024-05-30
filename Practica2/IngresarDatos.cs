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
        private Conexion conexion;
        private string nombre;
        private string apellido;
        private string edad;
        private string curp;
        private string telefono;
        private object nombreTextBox;

        public IngresarDatos()
        {
            InitializeComponent();
            // Ocultar la barra de progreso al inicio
            progressBar1.Visible = false;
            // Inicializar la conexión
            conexion = new Conexion();


        }




        private void Regresar2_Click(object sender, EventArgs e)
        {
            Area formularioArea = new Area();
            formularioArea.Show();
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirma tu salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = i;
                });
                Thread.Sleep(50);
            }
            // Incrementar el número de ficha al completarse la barra de progreso
            fichaNumero++;
            GuardarDatosEnBaseDeDatos();  // Llama al método para guardar los datos en la base de datos
            this.Invoke((MethodInvoker)delegate
            {
                // Mostrar mensaje de éxito al completarse la barra de progreso
                MessageBox.Show($"Tu número de ficha es: {fichaNumero}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void GuardarDatosEnBaseDeDatos()
        {
            // Crear la conexión
            using (MySqlConnection connection = conexion.getConexion())
            {
                try
                {
                    // Preparar la consulta SQL para obtener la lista de bases de datos
                    string queryListDB = "SHOW DATABASES";

                    List<string> listaBasesDatos = new List<string>();

                    // Crear el comando SQL para obtener la lista de bases de datos
                    using (MySqlCommand cmdListDB = new MySqlCommand(queryListDB, connection))
                    {
                        // Ejecutar la consulta para obtener la lista de bases de datos
                        using (MySqlDataReader reader = cmdListDB.ExecuteReader())
                        {
                            // Leer y almacenar las bases de datos en la lista
                            while (reader.Read())
                            {
                                listaBasesDatos.Add(reader.GetString(0));
                            }
                        }
                    }

                    // Preparar la consulta SQL para guardar los datos en la tabla fichas
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
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar si se guardaron los datos correctamente
                        if (rowsAffected > 0)
                        {
                            // Mostrar mensaje de éxito
                            MessageBox.Show("Los datos se han guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Mostrar la lista de bases de datos en un mensaje
                            string listaDBMessage = "Bases de datos existentes:\n";
                            foreach (string dbName in listaBasesDatos)
                            {
                                listaDBMessage += "- " + dbName + "\n";
                            }

                            MessageBox.Show(listaDBMessage, "Bases de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron guardar los datos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante el proceso de guardar
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            }
        }



        private void Nombre_TextChanged_1(object sender, EventArgs e)
        {
            nombre = Nombre.Text;
        }

        private void Apellido_TextChanged(object sender, EventArgs e)
        {
            apellido = Apellido.Text;
        }

        private void Edad_TextChanged(object sender, EventArgs e)
        {
            edad = Edad.Text;
        }

        private void Curp_TextChanged(object sender, EventArgs e)
        {
            curp = Curp.Text;
        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {
            telefono=Telefono.Text;
           
        }
    }
}

     