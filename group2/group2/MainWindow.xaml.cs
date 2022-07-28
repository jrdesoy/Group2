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

namespace group2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connetionString = "Data Source=LAPTOP-VRFKIHV7;Initial Catalog=db_try;User ID=sa;Password=123";

        public MainWindow()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void Loadgrid()
        {
            SqlConnection cnn;
            SqlCommand cmd;

            cnn = new SqlConnection(connetionString);

            cnn.Open();
            cmd = new SqlCommand("SELECT InfoStudents.StudentID, InfoStudents.Firstname, InfoStudents.Middlename, InfoStudents.Lastname, InfoStudents.Birthdate, COUNT(InfoGuardians.GuardianID) AS 'Number of Guardians' FROM InfoStudents LEFT JOIN InfoGuardians ON InfoStudents.StudentID = InfoGuardians.StudentID GROUP BY InfoStudents.StudentID, InfoStudents.Firstname, InfoStudents.Middlename, InfoStudents.Lastname, InfoStudents.Birthdate", cnn);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            cmd.Dispose();
            cnn.Close();
            datagrid.ItemsSource = dt.DefaultView;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Loadgrid();
            txtFirstname.Clear();
            txtMiddlename.Clear();
            txtLastname.Clear();
            dtpBirthdate.Text = string.Empty;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
>>>>>>> efd954b7ffe7fbb975be741259c4ddcae80fefbf
    }
}
