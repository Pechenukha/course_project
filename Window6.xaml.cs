using System.Windows;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void InfButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 Thierd = new Window2();
            Thierd.Show();
            this.Close();
        }

        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window7 Eights = new Window7();
            Eights.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            SeventhForm.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionString = @" Data Source= LAPTOP-V151BVUF\TRZBDLABA; Initial catalog=CourseProject; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            string ComShowNumBlood = " select d.[Группа крови] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowRes = " select d.[Резус-фактор] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowFIO = " select d.ФИО from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowAddress = " select d.[Адрес проживания] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowTel = " select d.[Номер телефона] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowFIO1 = " select r.ФИО from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowAdress1 = " select r.[Адрес проживания] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowTel1 = " select r.[Номер телефона] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            string ComShowJob = " select r.[Место работы] from Дети d, Родители r, [Договора с родителями] dr where d.[Код]= dr.Код and r.Код = dr.[Код родителя]and dr.[Код ребёнка]= @id";
            SqlCommand cmd1 = new SqlCommand(ComShowNumBlood, MyConnection);
            SqlCommand cmd2 = new SqlCommand(ComShowRes, MyConnection);
            SqlCommand cmd3 = new SqlCommand(ComShowFIO, MyConnection);
            SqlCommand cmd4 = new SqlCommand(ComShowAddress, MyConnection);
            SqlCommand cmd5 = new SqlCommand(ComShowTel, MyConnection);
            SqlCommand cmd6 = new SqlCommand(ComShowFIO1, MyConnection);
            SqlCommand cmd7 = new SqlCommand(ComShowAdress1, MyConnection);
            SqlCommand cmd8 = new SqlCommand(ComShowTel1, MyConnection);
            SqlCommand cmd9 = new SqlCommand(ComShowJob, MyConnection);
            SqlParameter pr1 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr2 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr3 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr4 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr5 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr6 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr7 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr8 = new SqlParameter("@id", CodeTB.Text);
            SqlParameter pr9 = new SqlParameter("@id", CodeTB.Text);
            cmd1.Parameters.Add(pr1);
            cmd2.Parameters.Add(pr2);
            cmd3.Parameters.Add(pr3);
            cmd4.Parameters.Add(pr4);
            cmd5.Parameters.Add(pr5);
            cmd6.Parameters.Add(pr6);
            cmd7.Parameters.Add(pr7);
            cmd8.Parameters.Add(pr8);
            cmd9.Parameters.Add(pr9);
            MyConnection.Open();
            NumBloodTB.Text = cmd1.ExecuteScalar().ToString();
            ResTB.Text = cmd2.ExecuteScalar().ToString();
            ChilNameTBK.Text = cmd3.ExecuteScalar().ToString();
            ChilAdressTBK.Text = cmd4.ExecuteScalar().ToString();
            ChilTelTBK.Text = cmd5.ExecuteScalar().ToString();
            ParNameTBK.Text = cmd6.ExecuteScalar().ToString();
            ParAdressTBK.Text = cmd7.ExecuteScalar().ToString();
            ParTelTBK.Text = cmd8.ExecuteScalar().ToString();
            JobTBK.Text = cmd9.ExecuteScalar().ToString();
            MyConnection.Close();
        }
    }
}
