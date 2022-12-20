﻿using System.Data;
using System.Data.SqlClient;

namespace Spotify.Helper
{
    static class Sql
    {
        static string connectionString = "Server=DESKTOP-0D6QJVK\\SQLEXPRESS;Database=Spotifyadonet;Trusted_Connection=True";

        static SqlConnection _connection;

		public static SqlConnection Connection
        {
			get 
			{
				if (_connection == null)
				{
					_connection = new SqlConnection(connectionString);
				}
				return _connection;
			}
		}
		public static int ExecCommand(string command)
		{
			int result = 0;
			Connection.Open();
			using (SqlCommand sqlCommand = new SqlCommand(command, Connection))
			{
				sqlCommand.ExecuteNonQuery();
			}
			Connection.Close();
			return result;
		}
		public static DataTable ExecQuery(string query)
		{
			DataTable dt = new DataTable();
			Connection.Open();
			using (SqlDataAdapter sda = new SqlDataAdapter(query, Connection))
			{
				sda.Fill(dt);
			}
			Connection.Close();
			return dt;
		}
	}
}
