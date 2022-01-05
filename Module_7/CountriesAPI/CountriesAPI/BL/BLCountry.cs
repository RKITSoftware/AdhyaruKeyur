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

        //retrive data by id
        public Countries getCountryById(int id)
        {
            Countries countriesList = new Countries();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    //sql query - select country base on CountryID
                    MySqlCommand cmd = new MySqlCommand("select * from countries where id = " + id + ";", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // retrive data to country model.
                            countriesList.countryId = Convert.ToInt32(reader["id"]);
                            countriesList.countryCode = reader["code"].ToString();
                            countriesList.countryName = reader["name"].ToString();
                            countriesList.capital = reader["capital"].ToString();
                            countriesList.currency = reader["currency"].ToString();
                            countriesList.continent = reader["continent"].ToString();
                            countriesList.continentCode = reader["continent_code"].ToString();
                            countriesList.phone = Convert.ToInt32(reader["phone"]);
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

        //add data
        public string addCountry(Countries objCountries)
        {
            List<Countries> countriesList = new List<Countries>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    //sql query - delete country base on CountryID
                    MySqlCommand cmd = new MySqlCommand("insert into countries (name,code,capital,currency,continent,continent_code,phone) values('" + objCountries.countryName + "','" + objCountries.countryCode + "','" + objCountries.capital + "','" + objCountries.currency + "','" + objCountries.continent + "','" + objCountries.continentCode + "','" + objCountries.phone + "')", conn);

                    /*cmd.Parameters.AddWithValue("@name", objCountries.countryName);
                    cmd.Parameters.AddWithValue("@code", objCountries.countryCode);
                    cmd.Parameters.AddWithValue("@capital", objCountries.capital);
                    cmd.Parameters.AddWithValue("@currency", objCountries.currency);
                    cmd.Parameters.AddWithValue("@continent", objCountries.continent);
                    cmd.Parameters.AddWithValue("@continent_code", objCountries.continentCode);
                    cmd.Parameters.AddWithValue("@phone", objCountries.phone);*/

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";
                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //delete data of given id.
        public string delectCountryById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    //sql query - delete country base on CountryID
                    MySqlCommand cmd = new MySqlCommand("delete from countries where id = " + id, conn);

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";
                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //update data
        public string updateCountry(Countries objCountries)
        {
            List<Countries> countriesList = new List<Countries>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    //sql query - update country base on CountryID
                    MySqlCommand cmd = new MySqlCommand("update countries set name = '" + objCountries.countryName + "',code = '" + objCountries.countryCode + "',capital = '" + objCountries.capital + "',currency = '" + objCountries.currency + "',continent = '" + objCountries.continent + "',continent_code = '" + objCountries.continentCode + "',phone = '" + objCountries.phone + "' where id = '" + objCountries.countryId + "';", conn);

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";
                }
                catch (Exception ex)
                {
                    return "Cannot open connection with error - " + ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        #endregion Public Methods
    }
}