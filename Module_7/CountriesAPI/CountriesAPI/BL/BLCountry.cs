using CountriesAPI.Database;
using CountriesAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CountriesAPI.BL
{
    public class BLCountry
    {
        #region Public Methods
        //retrive all data
        public ResponseModel SelectAll()
        {
            List<Countries> objCountriesList = new List<Countries>();
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = string.Format(
                        "SELECT " +
                            "id, " +
                            "code, " +
                            "name, " +
                            "capital, " +
                            "currency, " +
                            "continent, " +
                            "continent_code, " +
                            "phone " +
                        "FROM" +
                            " countries " +
                        "ORDER BY " +
                            " id"
                        );

                    //sql query - select all country data.
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //insert data into model.
                            objCountriesList.Add(new Countries()
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
                        objResponseModel.result = objCountriesList;
                        objResponseModel.statusMessage = "All Country List.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objResponseModel;
        }

        //retrive data by id
        public ResponseModel GetCountryById(int id)
        {
            Countries countriesList = new Countries();
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = string.Format(
                        "SELECT " +
                            "id," +
                            "code," +
                            "name," +
                            "capital," +
                            "currency," +
                            "continent," +
                            "continent_code," +
                            "phone" +
                        "FROM " +
                            "countries" +
                        "WHERE " +
                            "id = " + id +
                        "ORDER BY" +
                            "id"
                        );

                    //sql query - select country base on CountryID
                    MySqlCommand cmd = new MySqlCommand(query, conn);

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
                        objResponseModel.result = countriesList;
                        objResponseModel.statusMessage = "Country Data By Given ID.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objResponseModel;
        }

        //add data
        public ResponseModel AddCountry(Countries objCountries)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = string.Format(
                        "INSERT INTO " +
                            "countries ( " +
                            "name, " +
                            "code, " +
                            "capital, " +
                            "currency, " +
                            "continent, " +
                            "continent_code, " +
                            "phone )" +
                        "VALUES (" +
                            "@name, " +
                            "@code, " +
                            "@capital, " +
                            "@currency, " +
                            "@continent, " +
                            "@continent_code, " +
                            "@phone)" 
                        );

                    //sql query - delete country base on CountryID
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.Add(new MySqlParameter("@name", objCountries.countryName));
                    cmd.Parameters.Add(new MySqlParameter("@code", objCountries.countryCode));
                    cmd.Parameters.Add(new MySqlParameter("@capital", objCountries.capital));
                    cmd.Parameters.Add(new MySqlParameter("@currency", objCountries.currency));
                    cmd.Parameters.Add(new MySqlParameter("@continent", objCountries.continent));
                    cmd.Parameters.Add(new MySqlParameter("@continent_code", objCountries.continentCode));
                    cmd.Parameters.Add(new MySqlParameter("@phone", objCountries.phone));

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        objResponseModel.statusMessage = "Data Inserted Successfully.";
                    }
                    else
                    {
                        objResponseModel.statusMessage = "Something Went Wrong - Data Not Inserted.";
                    }
                    return objResponseModel;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //delete data of given id.
        public ResponseModel DelectCountryById(int id)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = string.Format(
                        "DELETE FROM " +
                            "countries," +
                        "WHERE" +
                            "id = " + id
                        );

                    //sql query - delete country base on CountryID
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        objResponseModel.statusMessage =  "Data Deleted successfully";
                    }
                    else
                    {
                        objResponseModel.statusMessage = "Something Went Wrong - Data Not Deleted.";
                    }
                    return objResponseModel;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //update data
        public ResponseModel UpdateCountry(Countries objCountries)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = string.Format(
                        "UPDATE " +
                            "countries " +
                        "SET " +
                            "name = @name, " +
                            "capital = @capital, " +
                            "currency = @currency, " +
                            "continent = @continent, " +
                            "continent_code = @continent_code, " +
                            "phone = @phone, " +
                            "code = @code " +
                        "WHERE " +
                            "id = @id"
                        );

                    //sql query - update country base on CountryID
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", objCountries.countryId);
                    cmd.Parameters.AddWithValue("@name", objCountries.countryName);
                    cmd.Parameters.AddWithValue("@code", objCountries.countryCode);
                    cmd.Parameters.AddWithValue("@capital", objCountries.capital);
                    cmd.Parameters.AddWithValue("@currency", objCountries.currency);
                    cmd.Parameters.AddWithValue("@continent", objCountries.continent);
                    cmd.Parameters.AddWithValue("@continent_code", objCountries.continentCode);
                    cmd.Parameters.AddWithValue("@phone", objCountries.phone);

                    int effect = cmd.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        objResponseModel.statusMessage = "Data Updated successfully";
                    }
                    else
                    {
                        objResponseModel.statusMessage = "Something went Wrong - Data Not Updated";
                    }
                    return objResponseModel;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        #endregion Public Methods
    }
}