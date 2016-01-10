using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace To_Do_List
{
    public class DataBaseHandler
    {
        private string masterConnectionString = "";
        static string LoadData(int Id)
        {
            string Title = "";
            //Connect to database
            
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("", con))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    
                    Debug.WriteLine("Baza danych chuj");
                }
            }


            return Title;
        }
    }
}