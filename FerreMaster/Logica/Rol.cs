using System.Collections.Generic;
using System.Data.SqlClient;

namespace FerreMaster.Logica
{
	public class Rol
	{
		public int IdRol { get; set; }
		public string NombreRol { get; set; }

		// Método para agregar un rol a la base de datos
		public static int AgregarRol(string nombreRol)
		{
			string query = $"INSERT INTO Roles (NombreRol) VALUES ('{nombreRol}')";
			return ComunDB.EjecutarComando(query);
		}

		// Método para obtener todos los roles
		public static List<Rol> ObtenerRoles()
		{
			List<Rol> listaRoles = new List<Rol>();
			string query = "SELECT IdRol, NombreRol FROM Roles";
			SqlDataReader reader = ComunDB.EjecutarComandoReader(query);

			while (reader.Read())
			{
				Rol rol = new Rol()
				{
					IdRol = (int)reader["IdRol"],
					NombreRol = reader["NombreRol"].ToString()
				};
				listaRoles.Add(rol);
			}
			reader.Close();
			return listaRoles;
		}

		// Método para eliminar un rol por su ID
		public static int EliminarRol(int idRol)
		{
			string query = $"DELETE FROM Roles WHERE IdRol = {idRol}";
			return ComunDB.EjecutarComando(query);
		}
	}
}
