using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace To_Do_List
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
      
        private TaskList taskList;        
        public MainPage(TaskList taskList)
        {
            InitializeComponent();
            this.taskList = taskList;
            FillListBox();
        }

        public void FillListBox()
        {
            listBoxDataSource.Items.Clear();
            for (int i = 0; i < taskList.CountOfTaskList(); i++)
            {
                Task task = taskList.ReadTask(i);
                listBoxDataSource.Items.Add(task);
                listBoxDataSource.DataContext = task;

            }

        }


        private void mainPageMinusButton_Click(object sender, RoutedEventArgs e)
        {
            taskList.RemoveTask(listBoxDataSource.SelectedIndex);
            FillListBox();
        }

        private void mainPagePlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainPageTextBox.Text != "")
            { 
                Task taskToAdd = new Task(taskList.CountOfTaskList(), mainPageTextBox.Text, TypeOfTask.Daily, 0, DateTime.Now, 0);
                taskList.AddTask(taskToAdd);
                FillListBox();
                //
            }
            else
            {
                //To do
                Debug.WriteLine("Wpisz coś!");
            }
        }

    }
}
