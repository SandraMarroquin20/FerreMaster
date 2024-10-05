using System.Data;
using System.Data.SqlClient;

namespace FerreMaster
{
	public class ComunDB
	{
		//Esta clase es para la cadena de conexion de la Base de Datos
		const string StringDeConexion = @"Data Source=DESKTOP-JSF8LSD;Initial Catalog=FerreteriaDB;Integrated Security=True";

		private static SqlConnection ObtenerConexion()
		{
			SqlConnection _conexion = new SqlConnection(StringDeConexion);
			_conexion.Open();
			return _conexion;
		}

		public static int EjecutarComando(string pConsulta)
		{
			SqlConnection _conexion = ObtenerConexion();
			SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
			int resultado = _comando.ExecuteNonQuery();
			_conexion.Close();
			return resultado;
		}
		public static SqlDataReader EjecutarComandoReader(string pConsulta)
		{
			SqlConnection _conexion = ObtenerConexion();
			SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
			SqlDataReader _reader = _comando.ExecuteReader(CommandBehavior.CloseConnection);
			return _reader;
		}
	}
}
