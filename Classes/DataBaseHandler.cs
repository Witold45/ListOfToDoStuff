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

        public static void DeleteAllDataFromDb()
        {
            using (SqlConnection con = new SqlConnection(masterConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Table]", con))
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine("DeleteAllDataFromDb: " + e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("DeleteAllDataFromDb: " + e.Message);

                }
            }
            
        }

        public static void SaveData(TaskList taskList)
        {

            Task tempTask;
            using (SqlConnection con = new SqlConnection(masterConnectionString))
            {
                con.Open();
                try
                {
                    for (int i = 0; i < taskList.CountOfTaskList(); i++)
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Table] VALUES(@Id, @Title, @Prior, @Time, @Multiplier)", con))
                    {
                        try
                        {
                             
                                tempTask = taskList.ReadTask(i);
                                command.Parameters.Add(new SqlParameter("Id", tempTask.Id));
                                command.Parameters.Add(new SqlParameter("Title", tempTask.Title));
                                command.Parameters.Add(new SqlParameter("Prior", tempTask.Prior));
                                command.Parameters.Add(new SqlParameter("Time", tempTask.Date));
                                command.Parameters.Add(new SqlParameter("Multiplier", tempTask.Multiplier));
                                command.ExecuteNonQuery();
                            
                        }
                        
                        catch (Exception e)
                        {
                            Debug.WriteLine("Message: "+ e.Message);
                        }
                     }
                    }
                }
                catch
                {
                    
                    Debug.WriteLine("Zapis się posypał");
                }
            }


        }

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
                                Debug.WriteLine(tempTask.ToString());
                            }
                            catch (Exception)
                            {
                                Debug.WriteLine("Null przy odczycie");
                            }
                            
                        }
                    }
                }
                catch
                {
                    
                    Debug.WriteLine("Odczyt się posypał");
                }
            }
            return task;
        }
    }
}