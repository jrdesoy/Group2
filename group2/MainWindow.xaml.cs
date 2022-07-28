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
using System.Data.SqlClient;

namespace group2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static class db_try
        {
            public static string conString = "Data Source=LAPTOP-SUP186MI;Initial Catalog = db_try; Integrated Security = True";

            public static SqlConnection GetGlobalConnection()
            {
                return new SqlConnection(connectString1);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO StudentsInfo (StudentID, Firstname, Middlename, Lastname, Birthdate) VALUES ('" + txtFirstname.Text.ToString + "', '" + txtMiddlename.Text.ToString + "', '" + txtLastname.Text.ToString + "', '" + dtpBirthdate.SelectedDate.Value + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Successful!");
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
