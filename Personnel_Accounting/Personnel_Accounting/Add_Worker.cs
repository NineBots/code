using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Accounting
{
    public partial class Add_Worker : Form
    {
        DataBase database = new DataBase();
        public Add_Worker()
        {
            InitializeComponent();
        }

        private void Add_Worker_Load(object sender, EventArgs e)
        {
            try
            {
                var fillGender = $"select Код_Пола, Наименование_Пола from Пол";
                var fillCity = $"select Код_Места, Наименование_Места from Место_Рождения";
                var fillPlaceGiven = $"select Код_Подразделения, Наименование_Подразделения from Отделение_МВД";
                var fillCitizenship = $"select Код_Гражданства, Наименование_Гражданства from Гражданство";
                var fillFamily = $"select Код_Семейного_Положения, Наименование_Положения from Семейное_Положение";
                var fillTypetd = $"select Код_Типа_ТД, Наименование_Типа from Тип_ТД";
                var fillJob = $"select Код_Должности, Наименование_Должности from Должность";

                SqlDataAdapter cmdGender = new SqlDataAdapter(fillGender, database.getConnection());
                SqlDataAdapter cmdCity = new SqlDataAdapter(fillCity, database.getConnection());
                SqlDataAdapter cmdPlaceGiven = new SqlDataAdapter(fillPlaceGiven, database.getConnection());
                SqlDataAdapter cmdCitizenship = new SqlDataAdapter(fillCitizenship, database.getConnection());
                SqlDataAdapter cmdFamily = new SqlDataAdapter(fillFamily, database.getConnection());
                SqlDataAdapter cmdTypeTD = new SqlDataAdapter(fillTypetd, database.getConnection());
                SqlDataAdapter cmdJob = new SqlDataAdapter(fillJob, database.getConnection());

                database.openConnection();

                DataTable genders = new DataTable();
                DataTable cities = new DataTable();
                DataTable places = new DataTable();
                DataTable citizenships = new DataTable();
                DataTable fams = new DataTable();
                DataTable types = new DataTable();
                DataTable jobs = new DataTable();

                cmdGender.Fill(genders);
                cmdCity.Fill(cities);
                cmdPlaceGiven.Fill(places);
                cmdCitizenship.Fill(citizenships);
                cmdFamily.Fill(fams);
                cmdTypeTD.Fill(types);
                cmdJob.Fill(jobs);

                comboBox_inp_gender.DataSource = genders;
                comboBox_inp_gender.ValueMember = "Код_Пола";
                comboBox_inp_gender.DisplayMember = "Наименование_Пола";

                comboBox_inp_city.DataSource = cities;
                comboBox_inp_city.ValueMember = "Код_Места";
                comboBox_inp_city.DisplayMember = "Наименование_Места";

                comboBox_inp_placeGiven.DataSource = places;
                comboBox_inp_placeGiven.ValueMember = "Код_Подразделения";
                comboBox_inp_placeGiven.DisplayMember = "Наименование_Подразделения";

                comboBox_inp_citizenship.DataSource = citizenships;
                comboBox_inp_citizenship.ValueMember = "Код_Гражданства";
                comboBox_inp_citizenship.DisplayMember = "Наименование_Гражданства";

                comboBox_inp_fam.DataSource = fams;
                comboBox_inp_fam.ValueMember = "Код_Семейного_Положения";
                comboBox_inp_fam.DisplayMember = "Наименование_Положения";

                comboBox_inp_typeTD.DataSource = types;
                comboBox_inp_typeTD.ValueMember = "Код_Типа_ТД";
                comboBox_inp_typeTD.DisplayMember = "Наименование_Типа";

                comboBox_inp_job.DataSource = jobs;
                comboBox_inp_job.ValueMember = "Код_Должности";
                comboBox_inp_job.DisplayMember = "Наименование_Должности";

                database.closeConnection();
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                database.openConnection();
                string[] array;

                var surname = maskedTextBox_inp_surname.Text;
                var name = maskedTextBox_inp_name.Text;
                var fathname = maskedTextBox_inp_fathname.Text;
                var gender = comboBox_inp_gender.SelectedValue.ToString();

                var birthday = maskedTextBox_inp_birthday.Text; //дата рождения
                try
                {
                    if ((DateTime.Now.Year - DateTime.Parse($"{birthday} 00:00:00").Year) < 18)
                    {
                        maskedTextBox_inp_birthday.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_birthday, "Человек должен быть старше 18");
                        check = false;
                    }
                    else { maskedTextBox_inp_birthday.ForeColor = Color.Black; check = true; }
                }
                catch (System.FormatException) { maskedTextBox_inp_birthday.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_birthday, "Нарушен формат даты"); check = false; }


                var city = comboBox_inp_city.SelectedValue.ToString();//место рождения
                var addr = maskedTextBox_inp_addr.Text;//фактический адрес
                var addr_pass = maskedTextBox_inp_addrPass.Text;
                var inn = maskedTextBox_inp_inn.Text;
                var snils = maskedTextBox_inp_snils.Text.Replace("-", "");
                var phone = maskedTextBox_inp_phone.Text.Replace("(", "").Replace(")", "").Replace("-", "");

                var mail = maskedTextBox_inp_mail.Text;
                byte[] photo;
                using (var memoryStream = new System.IO.MemoryStream())
                {
                    pictureBox1.Image.Save(memoryStream, ImageFormat.Jpeg);
                    photo = memoryStream.ToArray();
                }




                var seria = maskedTextBox_inp_seria.Text.Replace(" ", "");
                var number = maskedTextBox_inp_number.Text;
                var place_given = comboBox_inp_placeGiven.SelectedValue.ToString();

                var date_given = maskedTextBox_inp_dateGiven.Text;//дата выдачи пас
                try
                {
                    if (DateTime.Now < DateTime.Parse($"{ date_given} 00:00:00"))
                    {
                        maskedTextBox_inp_dateGiven.ForeColor = Color.Red;
                        ToolTip t = new ToolTip();
                        t.SetToolTip(maskedTextBox_inp_dateGiven, "Дата выдачи не может быть больше текущей даты");
                        check = false;
                    }
                    else if (DateTime.Parse(date_given).Year - DateTime.Parse(birthday).Year < 14)
                    {
                        maskedTextBox_inp_dateGiven.ForeColor = Color.Red;
                        ToolTip t = new ToolTip();
                        t.SetToolTip(maskedTextBox_inp_dateGiven, "Первый паспорт выдается с 14 лет");
                        check = false;
                    }
                    else { maskedTextBox_inp_dateGiven.ForeColor = Color.Black; check = true; }
                }
                catch (System.FormatException)
                {
                    maskedTextBox_inp_dateGiven.ForeColor = Color.Red;
                    ToolTip t = new ToolTip();
                    t.SetToolTip(maskedTextBox_inp_dateGiven, "Нарушен формат ввода даты");
                    check = false;
                }

                var citizenship = comboBox_inp_citizenship.SelectedValue.ToString();
                var fam_status = comboBox_inp_fam.SelectedValue.ToString();
                var TDnum = maskedTextBox_inp_numberTD.Text;
                var TDtype = comboBox_inp_typeTD.SelectedValue.ToString();
                string dateCreated = "";
                try
                {
                    dateCreated = maskedTextBox_inp_dateCreated.Text; //дата создания ТД
                    if (DateTime.Parse(dateCreated) < DateTime.Parse($"{dateCreated} 00:00:00"))
                    {
                        maskedTextBox_inp_dateCreated.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_dateCreated, "Трудовой договор подписан раньше полученного паспорта");
                        check = false;
                    }
                    else { maskedTextBox_inp_dateCreated.ForeColor = Color.Black; check = true; }
                }
                catch (System.FormatException)
                {
                    maskedTextBox_inp_dateCreated.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_dateCreated, "Нарушен формат ввода даты");
                    check = false;
                }

                var dateEnded = maskedTextBox_inp_dateEnded.Text; //срок окончания ТД
                try
                {
                    if (dateEnded != "00.00.0000")
                    {
                        if (DateTime.Parse($"{dateCreated} 00:00:00") > DateTime.Parse($"{dateEnded} 00:00:00"))
                        {
                            maskedTextBox_inp_dateEnded.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_dateEnded, "Срок окончания ТД не может быть раньше даты Создания");
                            check = false;
                        }
                        else { maskedTextBox_inp_dateEnded.ForeColor = Color.Black; check = true; }
                    }
                    else { dateEnded = "Null"; }
                }
                catch (System.FormatException)
                {
                    maskedTextBox_inp_dateEnded.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_dateEnded, "Нарушен формат ввода даты");
                    check = false;
                }
                var job = comboBox_inp_job.SelectedValue.ToString();
                var brigade = maskedTextBox_inp_brigade.Text;


                array = birthday.Split('.');
                Array.Reverse(array);
                birthday = string.Join("-", array);

                array = date_given.Split('.');
                Array.Reverse(array);
                date_given = string.Join("-", array);

                if (dateEnded != "Null")
                {
                    array = dateEnded.Split('.');
                    Array.Reverse(array);
                    dateEnded = string.Join("-", array);
                }

                array = dateCreated.Split('.');
                Array.Reverse(array);
                dateCreated = string.Join("-", array);

                array = DateTime.Now.ToShortDateString().Split('.');
                Array.Reverse(array);
                string dateNow = String.Join("-", array);
                if (check == true)
                {
                    var addperson = "Insert into Человек (Снилс, Пол_Человека, Дата_Рождения, Место_Рождения, Телефон, Электронная_Почта,ИНН, Фактический_Адрес_Проживания, Фото) values (@snils,@gender,@birthday,@city,@phone,@mail,@inn,@addr_pass,@photo)";
                    var addpass = $"Insert into Паспорт (Серия, Номер, Человек, Отделение_МВД, Адрес_Прописки, Дата_Выдачи, Фамилия, Имя, Отчество, Гражданство, Семейное_Положение) values ('{seria}','{number}','{snils}','{place_given}','{addr_pass}','{date_given}','{surname}','{name}','{fathname}','{citizenship}','{fam_status}')";
                    var addtd = $"Insert into Трудовой_Договор (Номер_ТД, Дата_Создания, Дата_Окончания_ТД, Тип_ТД, Человек) values ('{TDnum}','{dateCreated}','{dateEnded}','{TDtype}','{snils}')";
                    var addjob = $"Insert into Прием_Перевод (Трудовой_Договор, Дата_Записи, Должность, Номер_Бригады, Основание) values ('{TDnum}','{dateNow}','{job}','{brigade}','Трудовой Договор{TDnum}')";

                    var command = new SqlCommand(addperson, database.getConnection());
                    command.Parameters.Add("@snils", SqlDbType.NChar).Value = snils;
                    command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
                    command.Parameters.Add("@birthday", SqlDbType.Date).Value = birthday;
                    command.Parameters.Add("@city", SqlDbType.NChar).Value = city;
                    command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
                    command.Parameters.Add("@mail", SqlDbType.NChar).Value = mail;
                    command.Parameters.Add("@inn", SqlDbType.NChar).Value = inn;
                    command.Parameters.Add("@addr_pass", SqlDbType.NVarChar).Value = addr_pass;
                    command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = photo;
                    command.ExecuteNonQuery();

                    command = new SqlCommand(addpass, database.getConnection());
                    command.ExecuteNonQuery();

                    command = new SqlCommand(addtd, database.getConnection());
                    command.ExecuteNonQuery();

                    command = new SqlCommand(addjob, database.getConnection());
                    command.ExecuteNonQuery();
                }


                database.closeConnection();
                Close();
            }catch (Exception ex) { }
        }   

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Add_Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialoge = new OpenFileDialog())
                {
                    openFileDialoge.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg, *.png";
                    openFileDialoge.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (openFileDialoge.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialoge.FileName);
                    }
                }
            }catch (Exception ex) { }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_inp_snils_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Снилс from Человек";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if ($"{maskedTextBox_inp_snils.Text.Replace("-", "")}" == $"{row[0]}")
                    {
                        button1.Enabled = false;
                        maskedTextBox_inp_snils.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_snils, "Человек с таким СНИЛС уже есть");
                        break;
                    }
                    else { button1.Enabled = true; maskedTextBox_inp_snils.ForeColor = Color.Black; maskedTextBox_inp_snils.ForeColor = Color.Black; }
                }
            }catch(Exception ex) { }
        }

        private void maskedTextBox_inp_seria_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия, Номер from Паспорт";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if ($"{maskedTextBox_inp_seria.Text.Replace(" ", "")}{maskedTextBox_inp_number.Text}" == $"{row[0].ToString().Replace(" ", "")}{row[1].ToString()}")
                    {
                        button1.Enabled = false;
                        maskedTextBox_inp_seria.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_seria, "Паспорт с такой серией и номером уже есть");
                        maskedTextBox_inp_number.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_inp_number, "Паспорт с такой серией и номером уже есть");
                        break;
                    }
                    else { button1.Enabled = true; maskedTextBox_inp_seria.ForeColor = Color.Black; maskedTextBox_inp_number.ForeColor = Color.Black; }
                }
            }catch (Exception ex) { }
        }

        private void maskedTextBox_inp_number_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия, Номер from Паспорт";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if ($"{maskedTextBox_inp_seria.Text.Replace(" ", "")}{maskedTextBox_inp_number.Text}" == $"{row[0].ToString().Replace(" ", "")}{row[1].ToString()}")
                    {
                        button1.Enabled = false;
                        maskedTextBox_inp_seria.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_seria, "Паспорт с такой серией и номером уже есть");
                        maskedTextBox_inp_number.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_inp_number, "Паспорт с такой серией и номером уже есть");
                        break;
                    }
                    else { button1.Enabled = true; maskedTextBox_inp_seria.ForeColor = Color.Black; maskedTextBox_inp_number.ForeColor = Color.Black; }
                }
            }catch (Exception ex) { }
        }

        private void maskedTextBox_inp_inn_Leave(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox_inp_inn.Text != "000000000000")
                {
                    DataTable dt = new DataTable();

                    var virtQuery = "select ИНН from Человек";
                    var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                    SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        if ($"{maskedTextBox_inp_inn.Text}" == $"{row[0]}")
                        {
                            button1.Enabled = false;
                            maskedTextBox_inp_inn.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_inn, "Человек с таким ИНН уже есть");
                            break;
                        }
                        else { button1.Enabled = true; maskedTextBox_inp_inn.ForeColor = Color.Black; }
                    }
                }
            }catch(Exception ex) { }
        }

        private void maskedTextBox_inp_numberTD_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Номер_ТД from Трудовой_Договор";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if ($"{maskedTextBox_inp_numberTD.Text}" == $"{row[0]}")
                    {
                        button1.Enabled = false;
                        maskedTextBox_inp_numberTD.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_numberTD, "Такой трудовой договор уже есть");
                        break;
                    }
                    else { button1.Enabled = true; maskedTextBox_inp_numberTD.ForeColor = Color.Black; }
                }
            }catch (Exception ex) { }
        }
    }
}
