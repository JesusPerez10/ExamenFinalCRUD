using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExamenFinalCRUD.Data
{
    internal class Conexion
    {

        private string connectionString = "Server=localhost;Database=reggaetondb;Uid=root;Pwd=37416689j;";

        //constructor

        public Conexion(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=reggaetondb;Uid=" + usur + ";Pwd=" + pwd + ";";

        }
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public DataTable Leercanciones()
        {
            DataTable canciones = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM reggaetonsongs";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(canciones);
                    }
                }
            }

            return canciones;
        }
        public int Crearcancion(string titulo, string artista, string album, DateTime fechalanzamiento, TimeSpan duracion, string Genero, int popularidad)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO reggaetonsongs (titulo, artista,album,fechalanzamiento,duracion,genero,popularidad) VALUES (@titulo, @artista, @album, @fechalanzamiento,@duracion,@genero,@popularidad)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@artista", artista);
                    command.Parameters.AddWithValue("@album", album);
                    command.Parameters.AddWithValue("@fechalanzamiento", fechalanzamiento);
                    command.Parameters.AddWithValue("@duracion", duracion);
                    command.Parameters.AddWithValue("@genero", Genero);
                    command.Parameters.AddWithValue("@popularidad", popularidad);
                    return command.ExecuteNonQuery();
                }
            }
        }
        public void Actualizarcancion(int id, string titulo, string artista, string album, DateTime fechalanzamiento, TimeSpan duracion, string Genero, int popularidad)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE reggaetonsongs SET titulo = @titulo, artista = @artista,fechalanzamiento = @fechalanzamiento,duracion=@duracion,@genero=genero,@popularidad=popularidad WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@artista", artista);
                    command.Parameters.AddWithValue("@album", album);
                    command.Parameters.AddWithValue("@fechalanzamiento", fechalanzamiento);
                    command.Parameters.AddWithValue("@duracion", duracion);
                    command.Parameters.AddWithValue("@genero", Genero);
                    command.Parameters.AddWithValue("@popularidad", popularidad);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable Buscarcancionporid(int id)
        {
            DataTable cancion = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM reggaetonsongs  WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(cancion);
                    }
                }
            }
            return cancion;
        }
        public void Eliminarcancion(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM reggaetonsongs WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
 }



