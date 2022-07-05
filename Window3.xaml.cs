using System.Windows;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        string connectionString = @" Data Source= LAPTOP-V151BVUF\TRZBDLABA; Initial catalog=CourseProject; Integrated Security=True";

        public Window3()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ForthForm.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            string showCommand = string.Empty;

            DeleteButton.Visibility = 0;
            EditButton.Visibility = 0;
            AddButton.Visibility = 0;

            tb1.Visibility = Visibility.Hidden; tb2.Visibility = Visibility.Hidden; tb3.Visibility = Visibility.Hidden;
            tb4.Visibility = Visibility.Hidden; tb5.Visibility = Visibility.Hidden; tb6.Visibility = Visibility.Hidden; 
            tb7.Visibility = Visibility.Hidden; tb8.Visibility = Visibility.Hidden;

            tbk1.Visibility = Visibility.Hidden; tbk2.Visibility = Visibility.Hidden; tbk3.Visibility = Visibility.Hidden;
            tbk4.Visibility = Visibility.Hidden; tbk5.Visibility = Visibility.Hidden; tbk6.Visibility = Visibility.Hidden; 
            tbk7.Visibility = Visibility.Hidden; tbk8.Visibility = Visibility.Hidden;

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

                    tbk1.Visibility = 0; tbk2.Visibility = 0; tbk3.Visibility = 0;
                    tbk4.Visibility = 0; tbk5.Visibility = 0; tbk6.Visibility = 0;
                    tbk7.Visibility = 0; tbk8.Visibility = 0; tbk9.Visibility = 0; 
                    tbk10.Visibility = 0; tbk11.Visibility = 0;

                    tbk1.Text = "Код";
                    tbk2.Text = "ФИО";
                    tbk3.Text = "Номер телефона";
                    tbk4.Text = "Дата рождения";
                    tbk5.Text = "Адрес проживания";
                    tbk6.Text = "Группа крови";
                    tbk7.Text = "Резус фактор";
                    tbk8.Text = "Полис ОМС";
                    tbk9.Text = "Свидетельство о рождении";
                    tbk10.Text = "Название учебного учреждения";
                    tbk11.Text = "Код отряда";

                    tb1.Visibility = 0; tb2.Visibility = 0; tb3.Visibility = 0;
                    tb4.Visibility = 0; tb5.Visibility = 0; tb6.Visibility = 0;
                    tb7.Visibility = 0; tb8.Visibility = 0; tb9.Visibility = 0;
                    tb10.Visibility = 0; tb11.Visibility = 0;
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

                   
                    tbk6.Visibility = 0;
                    tbk7.Visibility = 0;
                    tbk8.Visibility = 0;
                    tbk9.Visibility = 0;
                    tbk10.Visibility = 0;
                    tbk11.Visibility = 0;

                    tbk6.Text = "Код";
                    tbk7.Text = "ФИО";
                    tbk8.Text = "Адрес проживания";
                    tbk9.Text = "Место работы";
                    tbk10.Text = "Номер телефона";
                    tbk11.Text = "Паспортные данные";

                    tb6.Visibility = 0;
                    tb7.Visibility = 0; tb8.Visibility = 0; tb9.Visibility = 0;
                    tb10.Visibility = 0; tb11.Visibility = 0;
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

                    tbk6.Visibility = 0;
                    tbk7.Visibility = 0;
                    tbk8.Visibility = 0;
                    tbk9.Visibility = 0;
                    tbk10.Visibility = 0;
                    tbk11.Visibility = 0;

                    tbk6.Text = "Код";
                    tbk7.Text = "ФИО";
                    tbk8.Text = "Должность";
                    tbk9.Text = "Номер телефона";
                    tbk10.Text = "Паспортные данные";
                    tbk11.Text = "Адрес проживания";

                    tb6.Visibility = 0;
                    tb7.Visibility = 0; tb8.Visibility = 0; tb9.Visibility = 0;
                    tb10.Visibility = 0; tb11.Visibility = 0;
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

                    tbk9.Visibility = 0; tbk10.Visibility = 0; tbk11.Visibility = 0;

                    tbk9.Text = "Код";
                    tbk10.Text = "Количество жилых комнат";
                    tbk11.Text = "Количество нежилых комнат";

                    tb9.Visibility = 0; tb10.Visibility = 0; tb11.Visibility = 0;

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

                    tbk8.Visibility = 0; tbk9.Visibility = 0; tbk10.Visibility = 0; tbk11.Visibility = 0;

                    tbk8.Text = "Код";
                    tbk9.Text = "Наименование";
                    tbk10.Text = "Количество жилых комнат";
                    tbk11.Text = "Количество нежилых комнат";

                    tb8.Visibility = 0; tb9.Visibility = 0; tb10.Visibility = 0; tb11.Visibility = 0;

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

                    tbk6.Visibility = 0;
                    tbk7.Visibility = 0;
                    tbk8.Visibility = 0;
                    tbk9.Visibility = 0;
                    tbk10.Visibility = 0;
                    tbk11.Visibility = 0;

                    tbk6.Text = "Код";
                    tbk7.Text = "Начало действия";
                    tbk8.Text = "Истечение срока";
                    tbk9.Text = "Код родителя";
                    tbk10.Text = "Код ребёнка";
                    tbk11.Text = "Сумма оплаты";

                    tb6.Visibility = 0;
                    tb7.Visibility = 0; tb8.Visibility = 0; tb9.Visibility = 0;
                    tb10.Visibility = 0; tb11.Visibility = 0;
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

              
                    tbk7.Visibility = 0;
                    tbk8.Visibility = 0;
                    tbk9.Visibility = 0;
                    tbk10.Visibility = 0;
                    tbk11.Visibility = 0;

                    tbk7.Text = "Код";
                    tbk8.Text = "Начало действия";
                    tbk9.Text = "Истечение срока";
                    tbk10.Text = "Код сотрудника";
                    tbk11.Text = "Оклад";
                

                   
                    tb7.Visibility = 0; tb8.Visibility = 0; tb9.Visibility = 0;
                    tb10.Visibility = 0; tb11.Visibility = 0;
                    break;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            string showCommand = string.Empty;
            switch (tablesComboBox.SelectedIndex)
            {
                case 0:
                    
                    SqlConnection MyConnection = new SqlConnection(connectionString);//объект класса скл коннекшн
                    string ComUpdChildren = " Insert into [Дети] values (@id,@name,@tel,@date,@location,@num_blood,@r,@oms,@born_cer,@school,@id_union)";
                    SqlCommand cmd1 = new SqlCommand(ComUpdChildren, MyConnection);
                    SqlParameter pr1 = new SqlParameter("@id", tb1.Text);
                    SqlParameter pr2 = new SqlParameter("@name", tb2.Text);
                    SqlParameter pr3 = new SqlParameter("@tel", tb3.Text);
                    SqlParameter pr4 = new SqlParameter("@date", tb4.Text);
                    SqlParameter pr5 = new SqlParameter("@location", tb5.Text);
                    SqlParameter pr6 = new SqlParameter("@num_blood", tb6.Text);
                    SqlParameter pr7 = new SqlParameter("@r", tb7.Text);
                    SqlParameter pr8 = new SqlParameter("@oms", tb8.Text);
                    SqlParameter pr9 = new SqlParameter("@born_cer", tb9.Text);
                    SqlParameter pr10 = new SqlParameter("@school", tb10.Text);
                    SqlParameter pr11 = new SqlParameter("@id_union", tb11.Text);
                    cmd1.Parameters.Add(pr1);
                    cmd1.Parameters.Add(pr2);
                    cmd1.Parameters.Add(pr3);
                    cmd1.Parameters.Add(pr4);
                    cmd1.Parameters.Add(pr5);
                    cmd1.Parameters.Add(pr6);
                    cmd1.Parameters.Add(pr7);
                    cmd1.Parameters.Add(pr8);
                    cmd1.Parameters.Add(pr9);
                    cmd1.Parameters.Add(pr10);
                    cmd1.Parameters.Add(pr11);
                    MyConnection.Open();
                    cmd1.ExecuteNonQuery();
                    MyConnection.Close();

                    using (MyConnection)
                    {
                 
                        showCommand = "SELECT * FROM [Дети]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Дети]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }

                    break;
                case 1:
                    SqlConnection MyConnection1 = new SqlConnection(connectionString);
                    string ComUpdParents = " Insert into [Родители] values (@id,@name,@location,@job_place,@tel,@passport)";
                    SqlCommand cmdPar = new SqlCommand(ComUpdParents, MyConnection1);
                    SqlParameter pr6_1 = new SqlParameter("@id", tb6.Text);
                    SqlParameter pr7_1 = new SqlParameter("@name", tb7.Text);
                    SqlParameter pr8_1 = new SqlParameter("@location", tb8.Text);
                    SqlParameter pr9_1 = new SqlParameter("@job_place", tb9.Text);
                    SqlParameter pr10_1 = new SqlParameter("@tel", tb10.Text);
                    SqlParameter pr11_1 = new SqlParameter("@passport", tb11.Text);
                    cmdPar.Parameters.Add(pr6_1);
                    cmdPar.Parameters.Add(pr7_1);
                    cmdPar.Parameters.Add(pr8_1);
                    cmdPar.Parameters.Add(pr9_1);
                    cmdPar.Parameters.Add(pr10_1);
                    cmdPar.Parameters.Add(pr11_1);
                    MyConnection1.Open();
                    cmdPar.ExecuteNonQuery();
                    MyConnection1.Close();

                    using (MyConnection1)
                    {
                        showCommand = "SELECT * FROM [Родители]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Родители]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }

                    break;
                case 2:
                    SqlConnection MyConnection2 = new SqlConnection(connectionString);
                    string ComUpdStaff = " Insert into [Сотрудники] values (@id,@name,@job,@tel,@passport,@location)";
                    SqlCommand cmdStaff = new SqlCommand(ComUpdStaff, MyConnection2);
                    SqlParameter pr6_2 = new SqlParameter("@id", tb6.Text);
                    SqlParameter pr7_2 = new SqlParameter("@name", tb7.Text);
                    SqlParameter pr8_2 = new SqlParameter("@job", tb8.Text);
                    SqlParameter pr9_2 = new SqlParameter("@tel", tb9.Text);
                    SqlParameter pr10_2 = new SqlParameter("@passport", tb10.Text);
                    SqlParameter pr11_2 = new SqlParameter("@location", tb11.Text);
                    cmdStaff.Parameters.Add(pr6_2);
                    cmdStaff.Parameters.Add(pr7_2);
                    cmdStaff.Parameters.Add(pr8_2);
                    cmdStaff.Parameters.Add(pr9_2);
                    cmdStaff.Parameters.Add(pr10_2);
                    cmdStaff.Parameters.Add(pr11_2);
                    MyConnection2.Open();
                    cmdStaff.ExecuteNonQuery();
                    MyConnection2.Close();

                    using (MyConnection2)
                    {
                        showCommand = "SELECT * FROM [Сотрудники]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Сотрудники]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }

                    break;

                case 3:
                    SqlConnection MyConnection3 = new SqlConnection(connectionString);
                    string ComUpdUnion = " Insert into [Корпуса] values (@id,@live,@no_live)";
                    SqlCommand cmdUnion = new SqlCommand(ComUpdUnion, MyConnection3);

                    SqlParameter pr9_3 = new SqlParameter("@id", tb9.Text);
                    SqlParameter pr10_3 = new SqlParameter("@live", tb10.Text);
                    SqlParameter pr11_3 = new SqlParameter("@no_live", tb11.Text);

                    cmdUnion.Parameters.Add(pr9_3);
                    cmdUnion.Parameters.Add(pr10_3);
                    cmdUnion.Parameters.Add(pr11_3);
                    MyConnection3.Open();
                    cmdUnion.ExecuteNonQuery();
                    MyConnection3.Close();

                    using (MyConnection3)
                    {
                        showCommand = "SELECT * FROM [Корпуса]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection3);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Корпуса]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }

                    break;

                case 4:
                    SqlConnection MyConnection4 = new SqlConnection(connectionString);
                    string ComUpdBuild = " Insert into [Отряды] values (@id,@name,@voz,@num)";
                    SqlCommand cmdBuild = new SqlCommand(ComUpdBuild, MyConnection4);
                    
                    SqlParameter pr8_4 = new SqlParameter("@id", tb8.Text);
                    SqlParameter pr9_4 = new SqlParameter("@name", tb9.Text);
                    SqlParameter pr10_4 = new SqlParameter("@voz", tb10.Text);
                    SqlParameter pr11_4 = new SqlParameter("@num", tb11.Text);

                    cmdBuild.Parameters.Add(pr8_4);
                    cmdBuild.Parameters.Add(pr9_4);
                    cmdBuild.Parameters.Add(pr10_4);
                    cmdBuild.Parameters.Add(pr11_4);
                    MyConnection4.Open();
                    cmdBuild.ExecuteNonQuery();
                    MyConnection4.Close();

                    using (MyConnection4)
                    {
                        showCommand = "SELECT * FROM [Отряды]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection4);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Отряды]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }

                    break;
                case 5:
                    SqlConnection MyConnection5 = new SqlConnection(connectionString);
                    string ComUpdDealPar = " Insert into [Договора с родителями] values (@id,@date_beg,@date_end,@id_par,@id_chil,@sum)";
                    SqlCommand cmdDealPar = new SqlCommand(ComUpdDealPar, MyConnection5);
                    SqlParameter pr6_3 = new SqlParameter("@id", tb6.Text);
                    SqlParameter pr7_3 = new SqlParameter("@name", tb7.Text);
                    SqlParameter pr8_3 = new SqlParameter("@job", tb8.Text);
                    SqlParameter pr9_5 = new SqlParameter("@tel", tb9.Text);
                    SqlParameter pr10_5 = new SqlParameter("@passport", tb10.Text);
                    SqlParameter pr11_5 = new SqlParameter("@location", tb11.Text);
                    cmdDealPar.Parameters.Add(pr6_3);
                    cmdDealPar.Parameters.Add(pr7_3);
                    cmdDealPar.Parameters.Add(pr8_3);
                    cmdDealPar.Parameters.Add(pr9_5);
                    cmdDealPar.Parameters.Add(pr10_5);
                    cmdDealPar.Parameters.Add(pr11_5);
                    MyConnection5.Open();
                    cmdDealPar.ExecuteNonQuery();
                    MyConnection5.Close();

                    using (MyConnection5)
                    {
                        showCommand = "SELECT * FROM [Договора с родителями]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection5);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с родителями]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 6:
                    SqlConnection MyConnection6 = new SqlConnection(connectionString);
                    string ComUpdDealStaff = " Insert into [Договора с сотрудниками] values (@id,@date_beg,@date_end,@id_staff,@money)";
                    SqlCommand cmdDealStaff = new SqlCommand(ComUpdDealStaff, MyConnection6);
                    SqlParameter pr7_4 = new SqlParameter("@id", tb7.Text);
                    SqlParameter pr8_5 = new SqlParameter("@date_beg", tb8.Text);
                    SqlParameter pr9_6 = new SqlParameter("@date_end", tb9.Text);
                    SqlParameter pr10_6 = new SqlParameter("@id_staff", tb10.Text);
                    SqlParameter pr11_6 = new SqlParameter("@money", tb11.Text);
                    cmdDealStaff.Parameters.Add(pr7_4);
                    cmdDealStaff.Parameters.Add(pr8_5);
                    cmdDealStaff.Parameters.Add(pr9_6);
                    cmdDealStaff.Parameters.Add(pr10_6);
                    cmdDealStaff.Parameters.Add(pr11_6);
                    MyConnection6.Open();
                    cmdDealStaff.ExecuteNonQuery();
                    MyConnection6.Close();

                    using (MyConnection6)
                    {
                        showCommand = "SELECT * FROM [Договора с сотрудниками]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection6);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с сотрудниками]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;

            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            string showCommand = string.Empty;
            switch (tablesComboBox.SelectedIndex)
            {
                case 0:
                    SqlConnection MyConnection = new SqlConnection(connectionString);
                    string ComEdName = " Update [Дети] set ФИО = @name where Код= @id";
                    string ComEdTel = " Update [Дети] set [Номер телефона] = @tel where Код= @id";
                    string ComEdDate = " Update [Дети] set [Дата рождения] = @date where Код= @id";
                    string ComEdLocation = " Update [Дети] set [Адрес проживания] = @location where Код= @id";
                    string ComEdBloodNum = " Update [Дети] set [Группа крови] = @num_blood where Код= @id";
                    string ComEdR = " Update [Дети] set [Резус-фактор] = @r where Код= @id";
                    string ComEdOMS = " Update [Дети] set [Полис ОМС] =  @oms where Код= @id";
                    string ComEdBornCer = " Update [Дети] set [Свидетельство о рождении] =  @born_cer where Код= @id";
                    string ComEdSchool = " Update [Дети] set [Название учебного учреждения] =  @school where Код= @id";
                    string ComEdSIdUnion = " Update [Дети] set [Код отряда] =   @id_union where Код= @id";
                   
                    SqlCommand cmdName = new SqlCommand(ComEdName, MyConnection);
                    SqlCommand cmdTel = new SqlCommand(ComEdTel, MyConnection);
                    SqlCommand cmdDate = new SqlCommand(ComEdDate, MyConnection);
                    SqlCommand cmdLocation = new SqlCommand(ComEdLocation, MyConnection);
                    SqlCommand cmdBloodNum = new SqlCommand(ComEdBloodNum, MyConnection);
                    SqlCommand cmdR = new SqlCommand(ComEdR, MyConnection);
                    SqlCommand cmdOMS = new SqlCommand(ComEdOMS, MyConnection);
                    SqlCommand cmdBornCer = new SqlCommand(ComEdBornCer, MyConnection);
                    SqlCommand cmdSchool = new SqlCommand(ComEdSchool, MyConnection);
                    SqlCommand cmdIdUnion = new SqlCommand(ComEdSIdUnion, MyConnection);

                    if (tb1.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_3 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_4 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_5 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_6 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_7 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_8 = new SqlParameter("@id", tb1.Text);
                        SqlParameter pr1_9 = new SqlParameter("@id", tb1.Text);
                        
                        cmdName.Parameters.Add(pr1);
                        cmdTel.Parameters.Add(pr1_1);
                        cmdDate.Parameters.Add(pr1_2);
                        cmdLocation.Parameters.Add(pr1_3);
                        cmdBloodNum.Parameters.Add(pr1_4);
                        cmdR.Parameters.Add(pr1_5);
                        cmdOMS.Parameters.Add(pr1_6);
                        cmdBornCer.Parameters.Add(pr1_7);
                        cmdSchool.Parameters.Add(pr1_8);
                        cmdIdUnion.Parameters.Add(pr1_9);
                    }
                    else { MessageBox.Show("Для обновления данных о ребёнке необходимо указать его код!"); }
                    

                    MyConnection.Open();

                    if (tb2.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@name", tb2.Text);
                        cmdName.Parameters.Add(pr2);
                        cmdName.ExecuteNonQuery();
                    }
                    if (tb3.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@tel", tb3.Text);
                        cmdTel.Parameters.Add(pr3);
                        cmdTel.ExecuteNonQuery();
                    }
                    if (tb4.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@date", tb4.Text);
                        cmdDate.Parameters.Add(pr4);
                        cmdDate.ExecuteNonQuery();
                    }
                    if (tb5.Text.Length != 0)
                    {
                        SqlParameter pr5 = new SqlParameter("@location", tb5.Text);
                        cmdLocation.Parameters.Add(pr5);
                        cmdLocation.ExecuteNonQuery();
                    }
                    if (tb6.Text.Length != 0)
                    {
                        SqlParameter pr6 = new SqlParameter("@num_blood", tb6.Text);
                        cmdBloodNum.Parameters.Add(pr6);
                        cmdBloodNum.ExecuteNonQuery();
                    }
                    if (tb7.Text.Length != 0)
                    {
                        SqlParameter pr7 = new SqlParameter("@r", tb7.Text);
                        cmdR.Parameters.Add(pr7);
                        cmdR.ExecuteNonQuery();
                    }
                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr8 = new SqlParameter("@oms", tb8.Text);
                        cmdOMS.Parameters.Add(pr8);
                        cmdOMS.ExecuteNonQuery();
                    }
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr9 = new SqlParameter("@born_cer", tb9.Text);
                        cmdBornCer.Parameters.Add(pr9);
                        cmdBornCer.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr10 = new SqlParameter("@school", tb10.Text);
                        cmdSchool.Parameters.Add(pr10);
                        cmdSchool.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr11 = new SqlParameter("@id_union", tb11.Text);
                        cmdIdUnion.Parameters.Add(pr11);
                        cmdIdUnion.ExecuteNonQuery();
                    }  
 
                    MyConnection.Close();
                    using (MyConnection)
                    {
                        showCommand = "SELECT * FROM [Дети]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Дети]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 1:
                    SqlConnection MyConnection1 = new SqlConnection(connectionString);
                    string ComEdName_1 = " Update [Родители] set ФИО = @name where Код= @id";
                    string ComEdLocation_1 = " Update [Родители] set [Адрес проживания] = @location where Код= @id";
                    string ComEdJob = " Update [Родители] set [Место работы] = @job where Код= @id";
                    string ComEdTel_1 = " Update [Родители] set [Номер телефона] = @tel where Код= @id";
                    string ComEdPassport_1 = " Update [Родители] set [Паспортные данные] = @passport where Код= @id";

                    SqlCommand cmdName_1 = new SqlCommand(ComEdName_1, MyConnection1);
                    SqlCommand cmdLocation_1 = new SqlCommand(ComEdPassport_1, MyConnection1);
                    SqlCommand cmdJob = new SqlCommand(ComEdJob, MyConnection1);
                    SqlCommand cmdTel_1 = new SqlCommand(ComEdLocation_1, MyConnection1);
                    SqlCommand cmdPasspport_1 = new SqlCommand(ComEdTel_1, MyConnection1);

                    if (tb6.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_3 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_4 = new SqlParameter("@id", tb6.Text);

                        cmdName_1.Parameters.Add(pr1);
                        cmdLocation_1.Parameters.Add(pr1_1);
                        cmdJob.Parameters.Add(pr1_2);
                        cmdTel_1.Parameters.Add(pr1_3);
                        cmdPasspport_1.Parameters.Add(pr1_4);
                    }
                    else { MessageBox.Show("Для обновления данных о родителе необходимо указать его код!"); }

                    MyConnection1.Open();

                    if (tb7.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@name", tb7.Text);
                        cmdName_1.Parameters.Add(pr2);
                        cmdName_1.ExecuteNonQuery();
                    }
                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@location", tb8.Text);
                        cmdLocation_1.Parameters.Add(pr3);
                        cmdLocation_1.ExecuteNonQuery();
                    }
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@job", tb9.Text);
                        cmdJob.Parameters.Add(pr4);
                        cmdJob.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr5 = new SqlParameter("@tel", tb10.Text);
                        cmdTel_1.Parameters.Add(pr5);
                        cmdTel_1.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr6 = new SqlParameter("@passport", tb11.Text);
                        cmdPasspport_1.Parameters.Add(pr6);
                        cmdPasspport_1.ExecuteNonQuery();
                    }
                    MyConnection1.Close();

                    using (MyConnection1)
                    {
                        showCommand = "SELECT * FROM [Родители]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Родители]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;

                case 2:
                    SqlConnection MyConnection2 = new SqlConnection(connectionString);
                    string ComEdName_2 = " Update [Сотрудники] set ФИО = @name where Код= @id";
                    string ComEdJob_1 = " Update [Сотрудники] set [Должность] = @job where Код= @id";
                    string ComEdTel_2 = " Update [Сотрудники] set [Номер телефона] = @tel where Код= @id";
                    string ComEdPassport_2 = " Update [Сотрудники] set [Паспортные данные] = @passport where Код= @id";
                    string ComEdLocation_2 = " Update [Сотрудники] set [Адрес проживания] = @location where Код= @id";

                    SqlCommand cmdName_2 = new SqlCommand(ComEdName_2, MyConnection2);
                    SqlCommand cmdJob_1 = new SqlCommand(ComEdJob_1, MyConnection2);
                    SqlCommand cmdTel_2 = new SqlCommand(ComEdTel_2, MyConnection2);
                    SqlCommand cmdPasspport_2 = new SqlCommand(ComEdPassport_2, MyConnection2);
                    SqlCommand cmdLocation_2 = new SqlCommand(ComEdLocation_2, MyConnection2);
                  
                    if (tb6.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_3 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_4 = new SqlParameter("@id", tb6.Text);

                        cmdName_2.Parameters.Add(pr1);
                        cmdJob_1.Parameters.Add(pr1_1);
                        cmdTel_2.Parameters.Add(pr1_2);
                        cmdPasspport_2.Parameters.Add(pr1_3);
                        cmdLocation_2.Parameters.Add(pr1_4);
                    }
                    else { MessageBox.Show("Для обновления данных о сотруднике необходимо указать его код!"); }

                    MyConnection2.Open();

                    if (tb7.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@name", tb7.Text);
                        cmdName_2.Parameters.Add(pr2);
                        cmdName_2.ExecuteNonQuery();
                    }
                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@location", tb8.Text);
                        cmdJob_1.Parameters.Add(pr3);
                        cmdJob_1.ExecuteNonQuery();
                    }
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@job", tb9.Text);
                        cmdTel_2.Parameters.Add(pr4);
                        cmdTel_2.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr5 = new SqlParameter("@tel", tb10.Text);
                        cmdPasspport_2.Parameters.Add(pr5);
                        cmdPasspport_2.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr6 = new SqlParameter("@passport", tb11.Text);
                        cmdLocation_2.Parameters.Add(pr6);
                        cmdLocation_2.ExecuteNonQuery();
                    }
                    MyConnection2.Close();

                    using (MyConnection2)
                    {
                        showCommand = "SELECT * FROM [Сотрудники]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Сотрудники]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 3:
                    SqlConnection MyConnection3 = new SqlConnection(connectionString);
                    string ComEdLiveRoom = " Update [Корпуса] set [Количество жилых комнат] = @live where Код= @id";
                    string ComEdNoLiveRoom = " Update [Корпуса] set [Количество нежилых комнат] = @no_live where Код= @id";
                    
                    SqlCommand cmdLiveRoom = new SqlCommand(ComEdLiveRoom, MyConnection3);
                    SqlCommand cmdNoLiveRoom = new SqlCommand(ComEdNoLiveRoom, MyConnection3);
                    
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb9.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb9.Text);

                        cmdLiveRoom.Parameters.Add(pr1);
                        cmdNoLiveRoom.Parameters.Add(pr1_1);

                    }
                    else { MessageBox.Show("Для обновления данных о корпусе необходимо указать его код!"); }

                    MyConnection3.Open();

                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@name", tb10.Text);
                        cmdLiveRoom.Parameters.Add(pr2);
                        cmdLiveRoom.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@location", tb11.Text);
                        cmdNoLiveRoom.Parameters.Add(pr3);
                        cmdNoLiveRoom.ExecuteNonQuery();
                    }
                    
                    MyConnection3.Close();

                    using (MyConnection3)
                    {
                        showCommand = "SELECT * FROM [Корпуса]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection3);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Корпуса]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;

                case 4:
                    SqlConnection MyConnection4 = new SqlConnection(connectionString);
                    string ComEdName_3 = " Update [Отряды] set [Наименование] = @name where Код= @id";
                    string ComEdNumVoz = " Update [Отряды] set [Код вожатого] = @voz where Код= @id";
                    string ComEdNum = " Update [Отряды] set [Номер корпуса] = @num where Код= @id";

                    SqlCommand cmdName_3 = new SqlCommand(ComEdName_3, MyConnection4);
                    SqlCommand cmdNumVoz = new SqlCommand(ComEdNumVoz, MyConnection4);
                    SqlCommand cmdNum = new SqlCommand(ComEdNum, MyConnection4);

                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb8.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb8.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb8.Text);

                        cmdName_3.Parameters.Add(pr1);
                        cmdNumVoz.Parameters.Add(pr1_1);
                        cmdNum.Parameters.Add(pr1_2);

                    }
                    else { MessageBox.Show("Для обновления данных о корпусе необходимо указать его код!"); }

                    MyConnection4.Open();

                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@name", tb9.Text);
                        cmdName_3.Parameters.Add(pr2);
                        cmdName_3.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@voz", tb10.Text);
                        cmdNumVoz.Parameters.Add(pr3);
                        cmdNumVoz.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@voz", tb11.Text);
                        cmdNum.Parameters.Add(pr4);
                        cmdNum.ExecuteNonQuery();
                    }
                    
                    MyConnection4.Close();

                    using (MyConnection4)
                    {
                        showCommand = "SELECT * FROM [Отряды]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection4);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Отряды]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 5:
                    SqlConnection MyConnection5 = new SqlConnection(connectionString);
                    string ComEdDateBeg = " Update [Договора с родителями] set [Начало действия] = @date_beg where Код= @id";
                    string ComEdDateEnd = " Update [Договора с родителями] set [Истечение срока] = @date_end where Код= @id";
                    string ComEdParID = " Update [Договора с родителями] set [Код родителя] = @code_par where Код= @id";
                    string ComEdChilID = " Update [Договора с родителями] set [Код ребёнка] = @code_chil where Код= @id";
                    string ComEdSum = " Update [Договора с родителями] set [Сумма оплаты] = @sum where Код= @id";

                    SqlCommand cmdDateBeg = new SqlCommand(ComEdDateBeg, MyConnection5);
                    SqlCommand cmdDateEnd = new SqlCommand(ComEdDateEnd, MyConnection5);
                    SqlCommand cmdParID = new SqlCommand(ComEdParID, MyConnection5);
                    SqlCommand cmdChilID = new SqlCommand(ComEdChilID, MyConnection5);
                    SqlCommand cmdSum = new SqlCommand(ComEdSum, MyConnection5);

                    if (tb6.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_3 = new SqlParameter("@id", tb6.Text);
                        SqlParameter pr1_4 = new SqlParameter("@id", tb6.Text);

                        cmdDateBeg.Parameters.Add(pr1);
                        cmdDateEnd.Parameters.Add(pr1_1);
                        cmdParID.Parameters.Add(pr1_2);
                        cmdChilID.Parameters.Add(pr1_3);
                        cmdSum.Parameters.Add(pr1_4);
                    }
                    else { MessageBox.Show("Для обновления данных о договоре с родителем необходимо указать его код!"); }

                    MyConnection5.Open();

                    if (tb7.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@date_beg", tb7.Text);
                        cmdDateBeg.Parameters.Add(pr2);
                        cmdDateBeg.ExecuteNonQuery();
                    }
                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@date_end", tb8.Text);
                        cmdDateEnd.Parameters.Add(pr3);
                        cmdDateEnd.ExecuteNonQuery();
                    }
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@code_par", tb9.Text);
                        cmdParID.Parameters.Add(pr4);
                        cmdParID.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr5 = new SqlParameter("@code_chil", tb10.Text);
                        cmdChilID.Parameters.Add(pr5);
                        cmdChilID.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr6 = new SqlParameter("@sum", tb11.Text);
                        cmdSum.Parameters.Add(pr6);
                        cmdSum.ExecuteNonQuery();
                    }
                    MyConnection5.Close();

                    using (MyConnection5)
                    {
                        showCommand = "SELECT * FROM [Договора с родителями]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection5);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с родителями]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 6:
                    SqlConnection MyConnection6 = new SqlConnection(connectionString);
                    string ComEdDateBeg1 = " Update [Договора с сотрудниками] set [Начало действия] = @date_beg where Код= @id";
                    string ComEdDateEnd1 = " Update [Договора с сотрудниками] set [Истечение срока] = @date_end where Код= @id";
                    string ComEdStaffID = " Update [Договора с сотрудниками] set [Код сотрудника] = @code_staff where Код= @id";
                    string ComEdMoney = " Update [Договора с сотрудниками] set [Оклад] = @money where Код= @id";
                    

                    SqlCommand cmdDateBeg1 = new SqlCommand(ComEdDateBeg1, MyConnection6);
                    SqlCommand cmdDateEnd1 = new SqlCommand(ComEdDateEnd1, MyConnection6);
                    SqlCommand cmdStaffID = new SqlCommand(ComEdStaffID, MyConnection6);
                    SqlCommand cmdMoney = new SqlCommand(ComEdMoney, MyConnection6);
                    

                    if (tb7.Text.Length != 0)
                    {
                        SqlParameter pr1 = new SqlParameter("@id", tb7.Text);
                        SqlParameter pr1_1 = new SqlParameter("@id", tb7.Text);
                        SqlParameter pr1_2 = new SqlParameter("@id", tb7.Text);
                        SqlParameter pr1_3 = new SqlParameter("@id", tb7.Text);
                       

                        cmdDateBeg1.Parameters.Add(pr1);
                        cmdDateEnd1.Parameters.Add(pr1_1);
                        cmdStaffID.Parameters.Add(pr1_2);
                        cmdMoney.Parameters.Add(pr1_3);
                     
                    }
                    else { MessageBox.Show("Для обновления данных о договоре с сотрудником необходимо указать его код!"); }

                    MyConnection6.Open();

                    if (tb8.Text.Length != 0)
                    {
                        SqlParameter pr2 = new SqlParameter("@date_beg", tb8.Text);
                        cmdDateBeg1.Parameters.Add(pr2);
                        cmdDateBeg1.ExecuteNonQuery();
                    }
                    if (tb9.Text.Length != 0)
                    {
                        SqlParameter pr3 = new SqlParameter("@date_end", tb9.Text);
                        cmdDateEnd1.Parameters.Add(pr3);
                        cmdDateEnd1.ExecuteNonQuery();
                    }
                    if (tb10.Text.Length != 0)
                    {
                        SqlParameter pr4 = new SqlParameter("@code_staff", tb10.Text);
                        cmdStaffID.Parameters.Add(pr4);
                        cmdStaffID.ExecuteNonQuery();
                    }
                    if (tb11.Text.Length != 0)
                    {
                        SqlParameter pr5 = new SqlParameter("@money", tb11.Text);
                        cmdMoney.Parameters.Add(pr5);
                        cmdMoney.ExecuteNonQuery();
                    }
                 
                    MyConnection6.Close();

                    using (MyConnection6)
                    {
                        showCommand = "SELECT * FROM [Договора с сотрудниками]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection6);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с сотрудниками]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string showCommand = string.Empty;
            switch (tablesComboBox.SelectedIndex)
            {
                case 0:
                    SqlConnection MyConnection = new SqlConnection(connectionString);
                    string ComDelChild = " Delete from [Дети] where Код=@id";
                    SqlCommand cmd1 = new SqlCommand(ComDelChild, MyConnection);
                    SqlParameter pr1 = new SqlParameter("@id", tb1.Text);
                    cmd1.Parameters.Add(pr1);
                    MyConnection.Open();
                    cmd1.ExecuteNonQuery();
                    MyConnection.Close();

                    using (MyConnection)
                    {
                        showCommand = "SELECT * FROM [Дети]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Дети]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 1:
                    SqlConnection MyConnection1 = new SqlConnection(connectionString);
                    string ComDelParent = " Delete from [Родители] where Код=@id";
                    SqlCommand cmd2 = new SqlCommand(ComDelParent, MyConnection1);
                    SqlParameter pr2 = new SqlParameter("@id", tb6.Text);
                    cmd2.Parameters.Add(pr2);
                    MyConnection1.Open();
                    cmd2.ExecuteNonQuery();
                    MyConnection1.Close();

                    using (MyConnection1)
                    {
                        showCommand = "SELECT * FROM [Родители]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Родители]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 2:
                    SqlConnection MyConnection2 = new SqlConnection(connectionString);
                    string ComDelStaff = " Delete from [Сотрудники] where Код=@id";
                    SqlCommand cmd3 = new SqlCommand(ComDelStaff, MyConnection2);
                    SqlParameter pr3 = new SqlParameter("@id", tb6.Text);
                    cmd3.Parameters.Add(pr3);
                    MyConnection2.Open();
                    cmd3.ExecuteNonQuery();

                    MyConnection2.Close();

                    using (MyConnection2)
                    {
                        showCommand = "SELECT * FROM [Сотрудники]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection2);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Сотрудники]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 3:
                    SqlConnection MyConnection3 = new SqlConnection(connectionString);
                    string ComDelBuild = " Delete from [Корпуса] where Код=@id";
                    SqlCommand cmd4 = new SqlCommand(ComDelBuild, MyConnection3);
                    SqlParameter pr4 = new SqlParameter("@id", tb9.Text);
                    cmd4.Parameters.Add(pr4);
                    MyConnection3.Open();
                    cmd4.ExecuteNonQuery();

                    MyConnection3.Close();

                    using (MyConnection3)
                    {
                        showCommand = "SELECT * FROM [Корпуса]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection3);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Корпуса]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 4:
                    SqlConnection MyConnection4 = new SqlConnection(connectionString);
                    string ComDelUnion = " Delete from [Отряды] where Код=@id";
                    SqlCommand cmd5 = new SqlCommand(ComDelUnion, MyConnection4);
                    SqlParameter pr5 = new SqlParameter("@id", tb8.Text);
                    cmd5.Parameters.Add(pr5);
                    MyConnection4.Open();
                    cmd5.ExecuteNonQuery();

                    MyConnection4.Close();

                    using (MyConnection4)
                    {
                        showCommand = "SELECT * FROM [Отряды]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection4);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Отряды]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 5:
                    SqlConnection MyConnection5 = new SqlConnection(connectionString);
                    string ComDelDealPar = " Delete from [Договора с родителями] where Код=@id";
                    SqlCommand cmd6 = new SqlCommand(ComDelDealPar, MyConnection5);
                    SqlParameter pr6 = new SqlParameter("@id", tb6.Text);
                    cmd6.Parameters.Add(pr6);
                    MyConnection5.Open();
                    cmd6.ExecuteNonQuery();

                    MyConnection5.Close();

                    using (MyConnection5)
                    {
                        showCommand = "SELECT * FROM [Договора с родителями]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection5);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с родителями]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;
                case 6:
                    SqlConnection MyConnection6 = new SqlConnection(connectionString);
                    string ComDelDealStaff = " Delete from [Договора с сотрудниками] where Код=@id";
                    SqlCommand cmd7 = new SqlCommand(ComDelDealStaff, MyConnection6);
                    SqlParameter pr7 = new SqlParameter("@id", tb7.Text);
                    cmd7.Parameters.Add(pr7);
                    MyConnection6.Open();
                    cmd7.ExecuteNonQuery();

                    MyConnection6.Close();

                    using (MyConnection6)
                    {
                        showCommand = "SELECT * FROM [Договора с сотрудниками]";
                        SqlCommand cmd = new SqlCommand(showCommand, MyConnection6);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable("[Договора с сотрудниками]");
                        sda.Fill(dt);
                        grid1.ItemsSource = dt.DefaultView;
                    }
                    break;

            }
            
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window4 Fifth = new Window4();
            Fifth.Show();
            this.Close();
        }

        private void DealButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window5 Sixth = new Window5();
            Sixth.Show();
            this.Close();
        }
    }
}
