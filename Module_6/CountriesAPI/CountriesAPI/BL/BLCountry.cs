using CountriesAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CountriesAPI.BL
{
    public class BLCountry
    {
        #region Public Variables

        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        #endregion Public Variables

        #region Public Methods
        //retrive all data
        public List<Countries> selectAll()
        {
            List<Countries> countriesList = new List<Countries>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    //sql query - select all country data.
                    MySqlCommand cmd = new MySqlCommand("select * from countries", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //insert data into model.
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
                }
                catch (Exception objException)
                {
                    Console.WriteLine("Cannot open connection with error - " + objException.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return countriesList;
        }

        #endregion Public Methods
    }
}