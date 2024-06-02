using ExamenFinalCRUD.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalCRUD
{
    public partial class Form1 : Form

    {
        private Conexion cancion;
        public Form1()
        {
            InitializeComponent();
            cancion = new Conexion("localhost", "root", "37416689j");
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewCanciones.DataSource = cancion.Leercanciones();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string titulo = textTitulo.Text;
            string artista = textArtista.Text;
            string album = textAlbum.Text;
            DateTime fechalanzamiento = DateTime.Now;
            TimeSpan duracion = TimeSpan.Parse(textDuracion.Text);
            string Genero = textGenero.Text;
            int popularidad = Convert.ToInt32(textPopularidad.Text);

            int respuesta = cancion.Crearcancion(titulo, artista, album, fechalanzamiento, duracion, Genero, popularidad);
            if (respuesta > 0)
            {
                MessageBox.Show("Cancion creada correctamente");
                dataGridViewCanciones.DataSource = cancion.Leercanciones();
            }
            else
            {
                MessageBox.Show("Error al crear la cancion ");
            }

        }
        private void buscarPorId()
        {
            int Idcancion = int.Parse(textID.Text);

            DataTable Cancionencontrada = cancion.Buscarcancionporid(Idcancion);

            if (Cancionencontrada.Rows.Count > 0)
            {

                string titulo = Cancionencontrada.Rows[0]["titulo"].ToString();
                string artista = Cancionencontrada.Rows[0]["artista"].ToString();
                string album = Cancionencontrada.Rows[0]["album"].ToString();
                DateTime fechalanzamiento = DateTime.Now;
                TimeSpan duracion = DateTime.Now - fechalanzamiento;
                string genero = Cancionencontrada.Rows[0]["genero"].ToString();
                int popularidad = int.Parse(Cancionencontrada.Rows[0]["popularidad"].ToString());
                textTitulo.Text = titulo.ToString();
                textArtista.Text = artista.ToString();
                textAlbum.Text = album.ToString();
                textDuracion.Text = duracion.ToString();
                textGenero.Text = genero.ToString();
                textPopularidad.Text = popularidad.ToString();


            }
            else
            {

                Console.WriteLine("No se encontró la cancion con el ID: " + Idcancion);
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            buscarPorId();
        }
        private void textID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textID.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de texto.");
                textID.Focus();
            }
            else
            {
                buscarPorId();
            }
        }


        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string titulo = textTitulo.Text;
            string artista = textArtista.Text;
            string album = textAlbum.Text;
            DateTime fechalanzamiento = dateTimePickerFechalanzamiento.Value;
            TimeSpan duracion = TimeSpan.Parse(textDuracion.Text);
            string Genero = textGenero.Text;
            int popularidad = Convert.ToInt32(textPopularidad.Text);

            int respuesta = cancion.Crearcancion(titulo, artista, album, fechalanzamiento, duracion, Genero, popularidad);
            if (respuesta > 0)
            {
                MessageBox.Show("Cancion actualizada correctamente");
                dataGridViewCanciones.DataSource = cancion.Leercanciones();
            }
            else
            {
                MessageBox.Show("Error al actualizar la cancion ");
            }

        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            

}
    
}  



    














