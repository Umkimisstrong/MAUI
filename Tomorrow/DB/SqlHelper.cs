//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MySqlConnector;


namespace Tomorrow.DB
{
    public class SqlHelper
    {
        public string mySqlconnection;

        public SqlHelper()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\.NET_MAUI\\Settings\\applicationSettings.xml");

            #nullable disable
            XmlNode xmlKeyNode = xmlDoc.SelectSingleNode("AppSettings/DBConnection/ConnectionStrings");
            mySqlconnection = xmlKeyNode.Attributes["id"].Value;
        }

        public SqlHelper(string connectionStrings)
        {
            mySqlconnection = connectionStrings;
        }


        public DataSet GetDataSet(string SpName, Dictionary<string, object> arrParams)
        {
            DataSet result = new DataSet();
            using (MySqlConnection conn = new(mySqlconnection))
            {
                conn.Open();
                using (MySqlCommand mySqlCommand = new MySqlCommand(SpName, conn))
                {
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.CommandTimeout = 30;
                    mySqlCommand.Parameters.AddRange(ToSqlParams(arrParams));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);

                    adapter.Fill(result);
                }
                conn.Close();
            }
            return result;
        }



        public int ExecuteNonQuery(string SpName, Dictionary<string, object> arrParams)
        {
            int result = 0;

            using (MySqlConnection conn = new(mySqlconnection))
            {
                conn.Open();

                using (MySqlCommand mySqlCommand = new MySqlCommand(SpName, conn))
                {
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.CommandTimeout = 30;
                    mySqlCommand.Parameters.AddRange(ToSqlParams(arrParams));

                    result = mySqlCommand.ExecuteNonQuery();
                }

                conn.Close();
            }

            return result;
        }

        public MySqlParameter[] ToSqlParams(Dictionary<string, object> paramSource)
        {
            MySqlParameter[] mySqlParams = new MySqlParameter[paramSource.Count];
            int i = 0;

            foreach (KeyValuePair<string, object> param in paramSource)
            {
                mySqlParams[i] = new MySqlParameter();
                mySqlParams[i].ParameterName = param.Key;
                mySqlParams[i].Value = param.Value;
                i += 1;
            }
            return mySqlParams;
        }
    }
}


