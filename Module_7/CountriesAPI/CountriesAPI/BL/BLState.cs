using CountriesAPI.Database;
using CountriesAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CountriesAPI.BL
{
    public class BLState
    {
        #region Public Methods
        //retrive all data
        public ResponseModel SelectAll()
        {
            List<State> objStateList = new List<State>();
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "SELECT " +
                            "stateid, " +
                            "state_name, " +
                            "country_id " +
                        "FROM " +
                            "state;"
                        );

                    //sql query - select all country data.
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    using (var objReader = objMySqlCommand.ExecuteReader())
                    {
                        while (objReader.Read())
                        {
                            //insert data into model.
                            objStateList.Add(new State()
                            {
                                stateid = Convert.ToInt32(objReader["stateid"]),
                                stateName = objReader["state_name"].ToString(),
                                countryId = Convert.ToInt32(objReader["country_id"])
                            });
                        }
                        objResponseModel.result = objStateList;
                        objResponseModel.statusMessage = "All State List.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objResponseModel;
        }


        //retrive data by Country Id
        public ResponseModel GetStateByCountryId(int countryId)
        {
            List<State> objStateList = new List<State>();
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "SELECT " +
                            "stateid, " +
                            "state_name, " +
                            "country_id " +
                        "FROM " +
                            "state " +
                        "WHERE " +
                            "country_id = " + countryId + ";"
                        );

                    //sql query - select country base on CountryID
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    using (var objReader = objMySqlCommand.ExecuteReader())
                    {
                        while (objReader.Read())
                        {
                            objStateList.Add(new State()
                            {
                                stateid = Convert.ToInt32(objReader["stateid"]),
                                stateName = objReader["state_name"].ToString(),
                                countryId = Convert.ToInt32(objReader["country_id"])
                            });
                        }
                        objResponseModel.result = objStateList;
                        objResponseModel.statusMessage = "All State List By Country Id.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objResponseModel;
        }

        //retrive data by state Id
        public ResponseModel GetStateById(int stateId)
        {
            State objStateList = new State();
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "SELECT " +
                            "stateid, " +
                            "state_name, " +
                            "country_id " +
                        "FROM " +
                            "state " +
                        "WHERE " +
                            "stateid = " + stateId + ";"
                        );

                    //sql query - select country base on CountryID
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    using (var objReader = objMySqlCommand.ExecuteReader())
                    {
                        while (objReader.Read())
                        {
                            objStateList.stateid = Convert.ToInt32(objReader["stateid"]);
                            objStateList.stateName = objReader["state_name"].ToString();
                            objStateList.countryId = Convert.ToInt32(objReader["country_id"]);
                        }
                        objResponseModel.result = objStateList;
                        objResponseModel.statusMessage = "State List.";
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
        public ResponseModel AddState(State objState)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "INSERT INTO " +
                            "state (" +
                            "state_name, " +
                            "country_id ) " +
                        "VALUES ( " +
                            "@state_name, " +
                            "@country_id )"
                        );

                    //sql query - delete country base on CountryID
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    objMySqlCommand.Parameters.Add(new MySqlParameter("@state_name", objState.stateName));
                    objMySqlCommand.Parameters.Add(new MySqlParameter("@country_id", objState.countryId));

                    int effect = objMySqlCommand.ExecuteNonQuery();

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
        public ResponseModel DelectStateById(int id)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "DELETE FROM " +
                            "state " +
                        "WHERE " +
                            "id = " + id + ";"
                        );

                    //sql query - delete country base on CountryID
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    int effect = objMySqlCommand.ExecuteNonQuery();

                    //check query is execute succssfully or not.
                    if (effect > 0)
                    {
                        objResponseModel.statusMessage = "Data Deleted successfully";
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
        public ResponseModel UpdateState(State objState)
        {
            ResponseModel objResponseModel = new ResponseModel();

            using (MySqlConnection objMySqlConnection = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    objMySqlConnection.Open();

                    string query = string.Format(
                        "UPDATE " +
                            "state " +
                        "SET " +
                            "state_name = @state_name, " +
                            "country_id = @country_id " +
                        "WHERE " +
                            "id = @stateid;"
                        );

                    //sql query - update country base on CountryID
                    MySqlCommand objMySqlCommand = new MySqlCommand(query, objMySqlConnection);

                    objMySqlCommand.Parameters.AddWithValue("@stateid", objState.stateid);
                    objMySqlCommand.Parameters.AddWithValue("@state_name", objState.stateName);
                    objMySqlCommand.Parameters.AddWithValue("@country_id", objState.countryId);

                    int effect = objMySqlCommand.ExecuteNonQuery();

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