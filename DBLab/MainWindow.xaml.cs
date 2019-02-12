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
using System.Data.OleDb;

namespace DBLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbConnection cn;

        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\leeroyjenkins.accdb");
            

        }

        private void Assets_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Table1";//database did not rename table properly;
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            
            while (read.Read())
            {
                textblock.Text = String.Empty;
                data += read[0].ToString() + " " + read[1].ToString() + " " +read[2].ToString() + "\n";
                textblock.Text += data;
            }
            cn.Close();
            
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Employees";//database did not rename table properly;
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";

            while (read.Read())
            {
                textblock.Text = String.Empty;
                data +=  read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + "\n";
                textblock.Text += data;
            }
            cn.Close();
        }
    }
}
