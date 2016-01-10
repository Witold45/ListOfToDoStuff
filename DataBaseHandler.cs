using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Media.Animation;

namespace To_Do_List
{
    public class DataBaseHandler
    {
        static private string masterConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\Documents\Visual Studio 2015\Projects\Rozdział10\New\To_Do_List\To_Do_List\Database.mdf';Integrated Security=True".Replace("'", "\"");
        



        public static TaskList LoadData()
        {
            TaskList task = new TaskList();
            Task tempTask;
            //Connect to database
            
            using (SqlConnection con = new SqlConnection(masterConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Table]", con))
                    {
                        //command.ExecuteNonQuery();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            try
                            {

                                int first = reader.GetInt32(0);
                                string second = reader.GetString(1);
                                int third = reader.GetInt32(2);
                                
                                DateTime dT = reader.GetDateTime(3);
                                
                                decimal fifeth = reader.GetDecimal(4);
                                

                                tempTask = new Task(first, second, TypeOfTask.Daily, third, dT , fifeth);
                                
                                                    
                                
                                task.AddTask(tempTask);
                            }
                            catch (Exception)
                            {
                                Debug.WriteLine("Null");
                                //throw;
                            }
                            
                        }
                    }
                }
                catch
                {
                    
                    Debug.WriteLine("Baza danych chuj");
                }
            }

            Debug.WriteLine(masterConnectionString);
            return task;
        }
    }
}