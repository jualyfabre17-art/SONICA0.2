using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        var conexion = "Server=DESKTOP-FL68TIF\\SQLEXPRESS;Database=SONICA;Trusted_Connection=True;TrustServerCertificate=True;";

        Console.Write("Ingrese título: ");
        string titulo = Console.ReadLine();

        Console.Write("Ingrese artista: ");
        string artista = Console.ReadLine();

        string insertar = "INSERT INTO Canciones (Titulo, Artista) VALUES (@titulo, @artista)";

        using (SqlConnection cn = new SqlConnection(conexion))
        {
            SqlCommand cmd = new SqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@artista", artista);

            cn.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Guardado correctamente");
        }

        string consultar = "SELECT * FROM Canciones";

        using (SqlConnection cn = new SqlConnection(conexion))
        {
            SqlCommand cmd = new SqlCommand(consultar, cn);

            cn.Open();

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Console.WriteLine($"{lector["Titulo"]} - {lector["Artista"]}");
            }
        }
    }
}


//h