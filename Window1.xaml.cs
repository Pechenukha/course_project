
using System.Windows;

using System.Windows.Input;

using System.Data.SqlClient;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondForm.Close();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = @" Data Source= LAPTOP-V151BVUF\TRZBDLABA; Initial catalog=CourseProject; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            //string checkcommand = "select count(*) from [Доступ к БД] where [Логин]=@login";
            string checkcommandUser = "select count(*) from [Доступ к БД] where [Логин]=@login and [Роль]='user'";
            //string insertcommand = "insert into Users values (@id,@login,@password,'user',HASHBYTES('sha1',convert(varchar(50),@password)))  ";
            //SqlCommand cmdCheck = new SqlCommand(checkcommand, MyConnection);
            SqlCommand cmdCheckUser = new SqlCommand(checkcommandUser, MyConnection);
            //SqlParameter login = new SqlParameter("@login", textBox1.Text);
            //SqlParameter password = new SqlParameter("@password", textBox2.Text);
           
          
                SqlParameter login1 = new SqlParameter("@login", textBox1.Text); 
                //SqlParameter password = new SqlParameter("@login", textBox2.Text); 
           

            //cmdCheck.Parameters.Add(login);
            //cmdCheck.Parameters.Add(password);
            cmdCheckUser.Parameters.Add(login1);

            //cmdCheck.Parameters.Add(login1);

            MyConnection.Open();
            string result;
            result = cmdCheckUser.ExecuteScalar().ToString();

            if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для входа");
            }
            else 
            if (result == "1")
            {
                this.Hide();
                Window2 Thierd = new Window2();
                Thierd.Show();
                this.Close();
                // MessageBox.Show("Такой логин уже занят, выберите другое имя пользователя");
            }

            else
            {
                this.Hide();
                Window3 Forth = new Window3();
                Forth.Show();
                this.Close();
            }

      

            //else
            //{
            //    cmdInsert.ExecuteNonQuery();
            //    MessageBox.Show("Регистрация прошла успешно");

            //}

            MyConnection.Close();
            
            

        }
    }
}
