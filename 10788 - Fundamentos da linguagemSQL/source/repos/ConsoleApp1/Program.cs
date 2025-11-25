using System;
using System.Data.SqlClient;

namespace PesquisaClientesPRIDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=PRIDEMO;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = @"
                SELECT Cliente, Nome, NumContrib, TotalDeb, LimiteCred
                FROM Clientes
                WHERE TotalDeb > 5000";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Estado  | Cliente   | Nome | NumContrib");
                        Console.WriteLine(new string('-', 90));

                        while (dr.Read())
                        {
                            string cliente = dr["Cliente"].ToString();
                            string nome = dr["Nome"].ToString();
                            string numContrib = dr["NumContrib"].ToString();
                            decimal limiteCred = 0;
                            if (dr["LimiteCred"] != DBNull.Value)
                                limiteCred = Convert.ToDecimal(dr["LimiteCred"]);

                            string estado = (limiteCred > 0) ? "Com Limite" : "Sem Limite";

                            Console.WriteLine(
                                $"{estado,-11} | {cliente,-9} | {nome,-34} | {numContrib}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao aceder à base de dados:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Pressiona ENTER para sair.");
            Console.ReadLine();
        }
    }
}
