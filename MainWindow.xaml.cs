using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TaskList taskList;
        public MainWindow()
        {
            InitializeComponent();
            taskList = new TaskList();
            taskList = DataBaseHandler.LoadData();
            
            rightFrameMainWindow.Content = new MainPage(taskList);
            

            //leftFrameMainWindow.Source = new Uri("MainPage.xml", UriKind.RelativeOrAbsolute);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           DataBaseHandler.DeleteAllDataFromDb();
           DataBaseHandler.SaveData(taskList);
        }
    }
}
