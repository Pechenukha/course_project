
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data; 

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string connectionString = @" Data Source= LAPTOP-V151BVUF\TRZBDLABA; Initial catalog=CourseProject; Integrated Security=True";

        public Window2()
        {
            InitializeComponent(); 
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ThierdForm.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            string showCommand=string.Empty;

            switch (tablesComboBox.SelectedIndex)
            {
                case 0:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Дети]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Дети]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Дети";
                    break;
                case 1:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Родители]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Родители]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Родители";
                    break;
                case 2:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Сотрудники]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Сотрудники]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Сотрудники";
                    break;
                case 3:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Корпуса]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Корпуса]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Корпуса";
                    break;
                case 4:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Отряды]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Отряды]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Отряды";
                    break;
                case 5:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Договора с родителями]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с родителями]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Договора с родителями";

                    break;
                case 6:
                    using (SqlConnection MyConnection = new SqlConnection(connectionString))
                    {
                        showCommand = "SELECT * FROM [Договора с сотрудниками]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с сотрудниками]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    nameTextBlock.Text = "Договора с сотрудниками";

                    break;

            }

           
        }

        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window7 Eights = new Window7();
            Eights.Show();
            this.Close();
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window6 Seventh = new Window6();
            Seventh.Show();
            this.Close();
        }
    }
}
