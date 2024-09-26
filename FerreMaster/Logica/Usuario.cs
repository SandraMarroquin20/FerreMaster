using System.Collections.Generic;
using System.Data.SqlClient;

namespace FerreMaster.Logica
{
	public class Usuario
	{
		#region Propiedades
		// Propiedades de la clase Usuario
		public int IdUsuario { get; set; }
		public string NombreUsuario { get; set; }
		public string Contraseña { get; set; }
		public string Email { get; set; }
		public bool Activo { get; set; }
		#endregion

		#region Métodos
		// Método para agregar un nuevo usuario a la base de datos
		public static int AgregarUsuario(string nombreUsuario, string contraseña, string email, bool activo)
		{
			string query = $"INSERT INTO Usuarios (NombreUsuario, Contraseña, Email, Activo) " +
						   $"VALUES ('{nombreUsuario}', '{contraseña}', '{email}', {(activo ? 1 : 0)})";
			return ComunDB.EjecutarComando(query);
		}

		// Método para obtener todos los usuarios de la base de datos
		public static List<Usuario> ObtenerUsuarios()
		{
			List<Usuario> listaUsuarios = new List<Usuario>();
			string query = "SELECT IdUsuario, NombreUsuario, Contraseña, Email, Activo FROM Usuarios";
			SqlDataReader reader = ComunDB.EjecutarComandoReader(query);

			while (reader.Read())
			{
				Usuario usuario = new Usuario()
				{
					IdUsuario = (int)reader["IdUsuario"],
					NombreUsuario = reader["NombreUsuario"].ToString(),
					Contraseña = reader["Contraseña"].ToString(),
					Email = reader["Email"].ToString(),
					Activo = (bool)reader["Activo"]
				};
				listaUsuarios.Add(usuario);
			}
			reader.Close();
			return listaUsuarios;
		}

		// Método para eliminar un usuario por su ID
		public static int EliminarUsuario(int idUsuario)
		{
			string query = $"DELETE FROM Usuarios WHERE IdUsuario = {idUsuario}";
			return ComunDB.EjecutarComando(query);
		}

		// Método para actualizar un usuario existente
		public static int ActualizarUsuario(int idUsuario, string nombreUsuario, string contraseña, string email, bool activo)
		{
			string query = $"UPDATE Usuarios SET " +
						   $"NombreUsuario = '{nombreUsuario}', " +
						   $"Contraseña = '{contraseña}', " +
						   $"Email = '{email}', " +
						   $"Activo = {(activo ? 1 : 0)} " +
						   $"WHERE IdUsuario = {idUsuario}";
			return ComunDB.EjecutarComando(query);
		}

		// Método para asignar un rol a un usuario
		public static int AsignarRol(int idUsuario, int idRol)
		{
			string query = $"INSERT INTO UsuarioRoles (IdUsuario, IdRol) VALUES ({idUsuario}, {idRol})";
			return ComunDB.EjecutarComando(query);
		}

		// Método para obtener los roles asignados a un usuario
		public static List<Rol> ObtenerRolesUsuario(int idUsuario)
		{
			List<Rol> roles = new List<Rol>();
			string query = $"SELECT R.IdRol, R.NombreRol FROM Roles R " +
						   $"JOIN UsuarioRoles UR ON R.IdRol = UR.IdRol " +
						   $"WHERE UR.IdUsuario = {idUsuario}";

			SqlDataReader reader = ComunDB.EjecutarComandoReader(query);

			while (reader.Read())
			{
				Rol rol = new Rol()
				{
					IdRol = (int)reader["IdRol"],
					NombreRol = reader["NombreRol"].ToString()
				};
				roles.Add(rol);
			}
			reader.Close();
			return roles;
		}
		#endregion
	}
}
