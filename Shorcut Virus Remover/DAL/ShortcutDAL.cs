using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shorcut_Virus_Remover.DAL
{
    internal class ShortcutDAL : ShortcutBLL
    {
        private string conStr = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();

        protected override bool RetrieveDataDAL(ShortcutInfo shortcutinfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("RetrieveData", con))
                {

                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = shortcutinfo.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = shortcutinfo.Password;


                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {

                            return true;
                        }
                    }
                    if (dr.HasRows == false)
                    {
                    }
                    return false;
                }
            }
        }


        protected override void SaveLogHistoryDAL(ShortcutInfo shortcutinfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("SaveLogHistory", con))
                {
                    cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = shortcutinfo.LogHistory.ToString(" MM - dd - yyyy HH:mm:ss");
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        protected override void SaveScanHistoryDAL(ShortcutInfo shortcutinfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("SaveScanHistory", con))
                {
                    cmd.Parameters.Add("@Date_Time", SqlDbType.DateTime).Value = shortcutinfo.ScanHistory.ToString(" MM - dd - yyyy HH:mm:ss");
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }




        protected override void RetrieveDateDAL(ShortcutInfo shortcutinfo)
        {
            //this will be the connection in sql
            using (var con = new SqlConnection(conStr))
            {
                //create sql command name
                //the name of the one you've create in the sql 
                using (var cmd = new SqlCommand("RetrieveDate", con))
                {
                    cmd.Parameters.Add("@Date_Time", SqlDbType.NVarChar).Value = shortcutinfo.ScanHistory;


                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
   