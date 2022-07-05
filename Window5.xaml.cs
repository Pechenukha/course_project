using System.Windows;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void InfButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window3 Fourth = new Window3();
            Fourth.Show();
            this.Close();
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window4 Fifth = new Window4();
            Fifth.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            SixthForm.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @" Data Source= LAPTOP-V151BVUF\TRZBDLABA; Initial catalog=CourseProject; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            string ComShowFIO = " select r.ФИО from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код]=@id";
            string ComShowDateBegin = " select dr.[Начало действия] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код]=@id";
            string ComShowFIO1 = " select d.ФИО from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код]=@id";
            string ComShowSum = " select dr.[Сумма оплаты] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код]=@id";
            string ComShowDateEnd = " select dr.[Истечение срока] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код]=@id";
            
            SqlCommand cmd1 = new SqlCommand(ComShowFIO, MyConnection);
            SqlCommand cmd2 = new SqlCommand(ComShowDateBegin, MyConnection);
            SqlCommand cmd3 = new SqlCommand(ComShowFIO1, MyConnection);
            SqlCommand cmd4 = new SqlCommand(ComShowSum, MyConnection);
            SqlCommand cmd5 = new SqlCommand(ComShowDateEnd, MyConnection);

            SqlParameter pr1 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr2 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr3 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr4 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr5 = new SqlParameter("@id", CodeTB.Text);

            cmd1.Parameters.Add(pr1);
            cmd2.Parameters.Add(pr2);
            cmd3.Parameters.Add(pr3);
            cmd4.Parameters.Add(pr4);
            cmd5.Parameters.Add(pr5);
       
            MyConnection.Open();
            ParTBK.Text = cmd1.ExecuteScalar().ToString();
            DateBeginTBK.Text = cmd2.ExecuteScalar().ToString();
            ChilTBK.Text = cmd3.ExecuteScalar().ToString();
            SumTBK.Text = cmd4.ExecuteScalar().ToString();
            DateEndTBK.Text = cmd5.ExecuteScalar().ToString();
            MyConnection.Close();
        }
    }
}
