using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Claims;

namespace ScraperApp
{
    class DBActions
    {
        public static void WriteTables(List<string> scrapeData, string table, Settings.Yahoo.UserCredentials currentUser, string UserId)
        {
            string userId = UserId;
            string ScrapeId;
            DateTime scrapeTime = DateTime.Now;

            SqlConnection conn = DB.Connect();

            string query = $"INSERT INTO Users_Scrapes (ScrapeId, AspUserId) VALUES (@ScrapeId, @AspUserId) SELECT SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@ScrapeId", SqlDbType.DateTime2, 7).Value = scrapeTime;
                cmd.Parameters.Add("@AspUserId", SqlDbType.NVarChar, 450).Value = userId;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ScrapeId = reader[0].ToString();
                conn.Close();
            }

            string CSVFile = FileActions.WriteCSVFile(scrapeData);

            DataTable dt = new DataTable();

            string line = null;
            int i = 0;

            using (StreamReader stream = File.OpenText(CSVFile))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length > 0)
                    {
                        if (i == 0)
                        {
                            foreach (var item in data)
                            {
                                dt.Columns.Add(new DataColumn());
                            }
                            i++;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                data[0] = ScrapeId;
                            }

                            DataRow row = dt.NewRow();
                            row.ItemArray = data;
                            dt.Rows.Add(row);
                        }
                    }
                }
            }

            conn.Open();

            using (SqlBulkCopy copy = new SqlBulkCopy(conn))
            {
                copy.DestinationTableName = table;
                copy.WriteToServer(dt);
            }
            conn.Close();
        }
    }
}


