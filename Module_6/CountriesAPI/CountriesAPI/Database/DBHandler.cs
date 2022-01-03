using CountriesAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CountriesAPI.Database
{
    public class DBHandler
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        public List<Countries> selectAll()
        {
            List<Countries> countriesList = new List<Countries>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from countries", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            countriesList.Add(new Countries()
                            {
                                countryId = Convert.ToInt32(reader["id"]),
                                countryCode = reader["code"].ToString(),
                                countryName = reader["name"].ToString(),
                                capital = reader["capital"].ToString(),
                                currency = reader["currency"].ToString(),
                                continent = reader["continent"].ToString(),
                                continentCode = reader["continent_code"].ToString(),
                                phone = Convert.ToInt32(reader["phone"])
                            });
                        }
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Can not open connection !");

                }

            }
            return countriesList;
           }

    }
}
