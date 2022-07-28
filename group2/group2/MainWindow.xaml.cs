﻿using System;
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
        string connetionString = "Data Source=LAPTOP-VRFKIHV7;Initial Catalog=db_try;User ID=sa;Password=123";

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

<<<<<<< HEAD
=======
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO StudentsInfo (StudentID, Firstname, Middlename, Lastname, Birthdate) VALUES ('" + txtFirstname.Text.ToString + "', '" + txtMiddlename.Text.ToString + "', '" + txtLastname.Text.ToString + "', '" + dtpBirthdate.SelectedDate.Value + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Successful!");
            }
=======
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

>>>>>>> 61da501196b5770cd07869be82804441c863a309
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
        //update button hehe
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
        
        }
>>>>>>> efd954b7ffe7fbb975be741259c4ddcae80fefbf
    }
}
