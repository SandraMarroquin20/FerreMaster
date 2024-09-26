using System.Collections.Generic;
using System.Data.SqlClient;

namespace FerreMaster.Logica
{
	public class Permiso
	{
		public int IdPermiso { get; set; }
		public string Descripcion { get; set; }

		public static int AgregarPermiso(string descripcion)
		{
			string query = $"INSERT INTO Permisos (Descripcion) VALUES ('{descripcion}')";
			return ComunDB.EjecutarComando(query);
		}

		public static List<Permiso> ObtenerPermisos()
		{
			List<Permiso> listaPermisos = new List<Permiso>();
			string query = "SELECT IdPermiso, Descripcion FROM Permisos";
			SqlDataReader reader = ComunDB.EjecutarComandoReader(query);

			while (reader.Read())
			{
				Permiso permiso = new Permiso()
				{
					IdPermiso = (int)reader["IdPermiso"],
					Descripcion = reader["Descripcion"].ToString()
				};
				listaPermisos.Add(permiso);
			}
			reader.Close();
			return listaPermisos;
		}

		public static int EliminarPermiso(int idPermiso)
		{
			string query = $"DELETE FROM Permisos WHERE IdPermiso = {idPermiso}";
			return ComunDB.EjecutarComando(query);
		}
	}
}
