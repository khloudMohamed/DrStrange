using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DoctorStrange
{
    class clsDataBase
    {
        SQLiteConnection con = new SQLiteConnection();

        public Boolean InsertNewItem(clsPatientData newItem)
        {
            try
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\DataBase\DrStrangeDB.db");

                sqlite_conn.Open();

                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                sqlite_cmd.CommandText = "INSERT INTO Items (PID,Name,FName,Phone) VALUES (" + newItem.ID + ",'" + newItem.PName + "'," + newItem.FName + "," + newItem.Phone + ");";

                sqlite_cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<clsPatientData> GetSavedItems()
        {
            List<clsPatientData> lstOfSavedItems = new List<clsPatientData>();
            try
            {
                SQLiteDataReader sqlite_datareader;  // Data Reader Object
                SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source= .\DataBase\DrStrangeDB.db");

                sqlite_conn.Open();

                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                sqlite_cmd.CommandText = "SELECT * FROM tblPatient;";

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                // The SQLiteDataReader allows us to run through each row per loop
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {

                    clsPatientData tempItem = new clsPatientData();
                    if (!sqlite_datareader.IsDBNull(0)) tempItem.ID = sqlite_datareader.GetInt32(0);
                    else tempItem.ID = 0;

                    if (sqlite_datareader.GetValue(1) == DBNull.Value) tempItem.PName = "";
                    else tempItem.PName = sqlite_datareader.GetString(1);

                    if (sqlite_datareader.GetValue(2) == DBNull.Value) tempItem.FName = "";
                    else tempItem.FName = sqlite_datareader.GetString(2);

                    if (sqlite_datareader.GetValue(3) == DBNull.Value) tempItem.Phone = "";
                    else tempItem.Phone = sqlite_datareader.GetString(3);

                    //if (!sqlite_datareader.IsDBNull(4)) tempItem.DateOfBirth = sqlite_datareader.GetDateTime(4);
                    //else tempItem.DateOfBirth = DBNull.Value;

                    lstOfSavedItems.Add(tempItem);
                }
                return lstOfSavedItems;
            }
            catch
            {
                return lstOfSavedItems;
            }

        }

    }
}
