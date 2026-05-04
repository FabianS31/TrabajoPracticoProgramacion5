using System;
using Microsoft.Data.SqlClient;

namespace Trabajo_practico_01.CapaDatos
{
    public class Usuario
    {
        public bool ValidarUsuario(string usuario, string password)
        {
            Conectar cn = new Conectar();
            var connection = cn.ObtenerConexion();
            try
            {
                using (connection)
                {
                    string query = "select count(*) from Usuarios where Usuario = @Usuario and contrasena = @Password";
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int cantidad = (int)comando.ExecuteScalar();

                        if (cantidad > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // 2. Método para evitar registrar usuarios duplicados
        public bool ExisteUsuario(string usuario)
        {
            Conectar cn = new Conectar();
            var connection = cn.ObtenerConexion();
            try
            {
                using (connection)
                {
                    string query = "select count(*) from Usuarios where Usuario = @Usuario";
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        connection.Open();
                        int cantidad = (int)comando.ExecuteScalar();

                        if (cantidad > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception)
            {
                return true; // Por seguridad, si hay error asumimos que existe para no insertar
            }
        }

        // 3. Método para dar de alta un nuevo usuario
        public bool InsertarUsuario(string usuario, string password)
        {
            Conectar cn = new Conectar();
            var connection = cn.ObtenerConexion();
            try
            {
                using (connection)
                {
                    string query = "INSERT INTO Usuarios (Usuario, Contrasena) VALUES (@Usuario, @Password)";
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}