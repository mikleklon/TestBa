using ServerBars.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ServerBars
{
    public class Service : IService
    {
        private string conStr = @"Data Source=np:\\.\pipe\LOCALDB#997CC8CA\tsql\query;Initial Catalog=msdb;Integrated Security=True";
        public Docs GetData()
        {
            string queryString =
            "SELECT id, DateCreate, DateUpdate from [dbo].[Table] "
                + "ORDER BY id ASC;";
            List<Doc> docs = new List<Doc>();
            using (var conn = new SqlConnection(conStr)) {
                var com = new SqlCommand(queryString, conn);
                conn.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var doc = new Doc((DateTime)reader[1], (int)reader[0], (DateTime)reader[2]);
                    docs.Add(doc);
                }
                reader.Close();
            }
            Docs d = new Docs();
            d.docs = docs;
            return d;
        }

    }
}
