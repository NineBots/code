using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace Personnel_Accounting
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted
    }
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        ToolStripMenuItem clicked;

        public Form1()
        {
            InitializeComponent();
            dataGridView2.Parent = panel1;
            dataGridView2.Location = panel7.Location;
            dataGridView2.Size = panel7.Size;
        }
        private void FillBoxes()//заполнить комбобоксы
        {
            try
            {
                var fillGender = $"select Код_Пола, Наименование_Пола from Пол";
                var fillCity = $"select Код_Места, Наименование_Места from Место_Рождения";
                var fillJob = $"select Код_Должности, Наименование_Должности from Должность";
                var fillMvdPass = $"select Код_Подразделения, Наименование_Подразделения from Отделение_МВД";
                var fillCitizenship = $"select Код_Гражданства, Наименование_Гражданства from Гражданство";
                var fillFam = $"select Код_Семейного_Положения, Наименование_Положения from Семейное_Положение";
                var fillTD = "";
                if (dataGridView1.CurrentRow != null)
                {
                    fillTD = $"select Номер_ТД, Наименование_Типа from Трудовой_Договор inner join Тип_ТД ON Трудовой_Договор.Тип_ТД = Тип_ТД.Код_Типа_ТД where Человек = {dataGridView1.CurrentRow.Cells[7].Value}";
                }

                var fillOO = $"select Код_ОО, Наименование_ОО from Образовательная_Организация";
                var fillType = $"select Код_Образования, Наименование_Образования from Тип_Образования";
                var fillSpeciality = $"select Код_Специальности, Наименование_Специальности from Специальность";
                var fillQualification = $"select Код_Квалификации, Наименование_Квалификации from Квалификация";
                var fillRelative = $"select Код_Типа_Связи, Наименование_Типа_Связи from Тип_Родственной_Связи";


                SqlDataAdapter cmdGender = new SqlDataAdapter(fillGender, database.getConnection());
                SqlDataAdapter cmdCity = new SqlDataAdapter(fillCity, database.getConnection());
                SqlDataAdapter cmdJob = new SqlDataAdapter(fillJob, database.getConnection());
                SqlDataAdapter cmdMvd = new SqlDataAdapter(fillMvdPass, database.getConnection());
                SqlDataAdapter cmdCitizenship = new SqlDataAdapter(fillCitizenship, database.getConnection());
                SqlDataAdapter cmdFam = new SqlDataAdapter(fillFam, database.getConnection());
                SqlDataAdapter cmdTD = new SqlDataAdapter(fillTD, database.getConnection());
                SqlDataAdapter cmdOO = new SqlDataAdapter(fillOO, database.getConnection());
                SqlDataAdapter cmdType = new SqlDataAdapter(fillType, database.getConnection());
                SqlDataAdapter cmdSpeciality = new SqlDataAdapter(fillSpeciality, database.getConnection());
                SqlDataAdapter cmdQualification = new SqlDataAdapter(fillQualification, database.getConnection());
                SqlDataAdapter cmdRelative = new SqlDataAdapter(fillRelative, database.getConnection());
                database.openConnection();

                DataTable genders = new DataTable();
                DataTable cities = new DataTable();
                DataTable jobs = new DataTable();
                DataTable mvd = new DataTable();
                DataTable citizenships = new DataTable();
                DataTable fams = new DataTable();
                DataTable td = new DataTable();
                DataTable oo = new DataTable();
                DataTable type = new DataTable();
                DataTable speciality = new DataTable();
                DataTable qualification = new DataTable();
                DataTable relative = new DataTable();

                cmdGender.Fill(genders);
                cmdCity.Fill(cities);
                cmdJob.Fill(jobs);
                cmdMvd.Fill(mvd);
                cmdCitizenship.Fill(citizenships);
                cmdFam.Fill(fams);
                cmdTD.Fill(td);
                cmdOO.Fill(oo);
                cmdType.Fill(type);
                cmdSpeciality.Fill(speciality);
                cmdQualification.Fill(qualification);
                cmdRelative.Fill(relative);


                comboBox_inp_gender.DataSource = genders;
                comboBox_inp_gender.ValueMember = "Код_Пола";
                comboBox_inp_gender.DisplayMember = "Наименование_Пола";

                comboBox_inp_city.DataSource = cities;
                comboBox_inp_city.ValueMember = "Код_Места";
                comboBox_inp_city.DisplayMember = "Наименование_Места";

                comboBox_inp_job.DataSource = jobs;
                comboBox_inp_job.ValueMember = "Код_Должности";
                comboBox_inp_job.DisplayMember = "Наименование_Должности";

                comboBox_jobCareer.DataSource = jobs;
                comboBox_jobCareer.ValueMember = "Код_Должности";
                comboBox_jobCareer.DisplayMember = "Наименование_Должности";

                comboBox_wherePass.DataSource = mvd;
                comboBox_wherePass.ValueMember = "Код_Подразделения";
                comboBox_wherePass.DisplayMember = "Наименование_Подразделения";


                comboBox_citizenshipPass.DataSource = citizenships;
                comboBox_citizenshipPass.ValueMember = "Код_Гражданства";
                comboBox_citizenshipPass.DisplayMember = "Наименование_Гражданства";

                comboBox_famPass.DataSource = fams;
                comboBox_famPass.ValueMember = "Код_Семейного_Положения";
                comboBox_famPass.DisplayMember = "Наименование_Положения";

                comboBox_tdCareer.DataSource = td;
                comboBox_tdCareer.ValueMember = "Номер_ТД";
                DataColumn computedColumn = new DataColumn("ТД_Тип", typeof(string));
                computedColumn.Expression = "[Номер_ТД] + ' - ' + [Наименование_Типа]";
                td.Columns.Add(computedColumn);
                comboBox_tdCareer.DisplayMember = "ТД_Тип";

                comboBox_ooEdu.DataSource = oo;
                comboBox_ooEdu.ValueMember = "Код_ОО";
                comboBox_ooEdu.DisplayMember = "Наименование_ОО";

                comboBox_typeEdu.DataSource = type;
                comboBox_typeEdu.ValueMember = "Код_Образования";
                comboBox_typeEdu.DisplayMember = "Наименование_Образования";

                comboBox_specialityEdu.DataSource = speciality;
                comboBox_specialityEdu.ValueMember = "Код_Специальности";
                comboBox_specialityEdu.DisplayMember = "Наименование_Специальности";

                comboBox_qualificationEdu.DataSource = qualification;
                comboBox_qualificationEdu.ValueMember = "Код_Квалификации";
                comboBox_qualificationEdu.DisplayMember = "Наименование_Квалификации";

                comboBox_typeRel.DataSource = relative;
                comboBox_typeRel.ValueMember = "Код_Типа_Связи";
                comboBox_typeRel.DisplayMember = "Наименование_Типа_Связи";



                database.closeConnection();
            }
            catch (Exception ex) { }

        }

        private void DeleteRow()//удалить строку
        {
            if (panel7.Visible == true)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
                {
                    dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
            }

            if (clicked == паспортToolStripMenuItem)
            {
                int index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
                {
                    dataGridView2.Rows[index].Cells[10].Value = RowState.Deleted;
                    return;
                }
                dataGridView2.Rows[index].Cells[10].Value = RowState.Deleted;
            }

            if (clicked == карьераToolStripMenuItem)
            {
                int index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
                {
                    dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }
                dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            if (clicked == образованиеToolStripMenuItem)
            {
                int index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
                {
                    dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }
                dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            if (clicked == семьяToolStripMenuItem)
            {
                int index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() == String.Empty)
                {
                    dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
                    return;
                }
                dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
            }

        }

        private void Updatedg()//обновить датагрид и таблицу
        {
            database.openConnection();
            if (panel7.Visible == true)
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowstate = (RowState)dataGridView1.Rows[index].Cells[10].Value;

                    if (rowstate == RowState.Existed)
                        continue;

                    if (rowstate == RowState.Deleted)//условие для общих данных
                    {
                        var id = dataGridView1.Rows[index].Cells[7].Value;

                        var delquery = $"delete from Человек where СНИЛС = {id}";

                        var cmd = new SqlCommand(delquery, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }

                    if (rowstate == RowState.Modified)//условие для общих данных
                    {

                        byte[] photo;
                        using (var memoryStream = new System.IO.MemoryStream())
                        {
                            var img = new Bitmap(pictureBox_image.Image);
                            img.Save(memoryStream, ImageFormat.Jpeg);
                            photo = memoryStream.ToArray();
                        }

                        var birthday = maskedTextBox_inp_birthday.Text;


                        var array = birthday.Split('.');
                        Array.Reverse(array);
                        birthday = string.Join("-", array);

                        var changeQueryPerson = $"update Человек set Пол_Человека = '{comboBox_inp_gender.SelectedValue.ToString()}', ИНН = '{maskedTextBoxinp_inn.Text}', СНИЛС = '{maskedTextBox_inp_snils.Text.Replace("-", "")}', Дата_Рождения = '{birthday}', Место_Рождения = '{comboBox_inp_city.SelectedValue}', Фактический_Адрес_Проживания = '{maskedTextBox_inp_addr.Text}', Телефон = '{maskedTextBox_inp_phone.Text.Replace("(", "").Replace(")", "").Replace(" ", "")}', Электронная_Почта = '{maskedTextBox_inp_mail.Text}' where СНИЛС = {textBox_snils.Text.Replace("-", "")}";
                        var cmd = new SqlCommand(changeQueryPerson, database.getConnection());
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("update Человек set Фото = @photo where СНИЛС = @snils", database.getConnection());
                        cmd.Parameters.Add("@photo", SqlDbType.VarBinary).Value = photo;
                        cmd.Parameters.Add("@snils", SqlDbType.NVarChar).Value = maskedTextBox_inp_snils.Text.Replace("-", "");
                        cmd.ExecuteNonQuery();

                        var changeQueryPass = $"update Паспорт set Фамилия = '{maskedTextBox_surname.Text}', Имя = '{maskedTextBox_name.Text}', Отчество = '{maskedTextBox_fathName.Text}' where  Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = {maskedTextBox_inp_snils.Text.Replace("-", "")} Group BY Человек)";
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand(changeQueryPass, database.getConnection());
                        cmd.ExecuteNonQuery();

                        var changeJob = $"update Прием_Перевод set Должность = {comboBox_inp_job.SelectedValue} where Прием_Перевод.Код_Записи = (Select Max(Код_Записи) from Человек inner join Трудовой_Договор On Человек.СНИЛС = Трудовой_Договор.Человек inner join Прием_Перевод on Трудовой_Договор.Номер_ТД = Прием_Перевод.Трудовой_Договор where Человек.СНИЛС = '{maskedTextBox_inp_snils.Text.Replace("-", "")}'  ) ";
                        cmd = new SqlCommand(changeJob, database.getConnection());
                        cmd.ExecuteNonQuery();


                    }
                }
            }

            for (int index2 = 0; index2 < dataGridView2.Rows.Count; index2++)
            {
                if (clicked == паспортToolStripMenuItem)
                {


                    var rowstate = (RowState)dataGridView2.Rows[index2].Cells[10].Value;
                    if (panel_changePass.Visible == true) //если активна панель смены паспорта
                    {

                        if (dataGridView2.Visible == true && rowstate == RowState.Deleted)
                        {
                            var seria = dataGridView2.Rows[index2].Cells[0].Value;
                            var number = dataGridView2.Rows[index2].Cells[1].Value;

                            var delquery = $"delete from Паспорт where Серия = {seria} and Номер = {number}";

                            var cmd = new SqlCommand(delquery, database.getConnection());
                            cmd.ExecuteNonQuery();
                        }

                        if (rowstate == RowState.Modified)//условие изменения для паспорта
                        {

                            var date_given = maskedTextBox_dateGivenPass.Text.ToString();

                            var array = date_given.Split('.');
                            Array.Reverse(array);
                            date_given = string.Join("-", array);

                            var changePass = $"update Паспорт set Серия = '{maskedTextBox_seriaPass.Text.Replace(" ", "")}', Номер = '{maskedTextBox_numberPass.Text}', Фамилия = '{maskedTextBox_surnamePass.Text}', Имя = '{maskedTextBox_namePass.Text}', Отчество = '{maskedTextBox_fathnamePass.Text}', Дата_Выдачи = '{date_given}', Отделение_МВД = '{comboBox_wherePass.SelectedValue}', Адрес_Прописки = '{maskedTextBox_addrPass.Text}', Гражданство = '{comboBox_citizenshipPass.SelectedValue}', Семейное_Положение = '{comboBox_famPass.SelectedValue}' where Серия = '{dataGridView2.CurrentRow.Cells[0].Value}' and Номер = '{dataGridView2.CurrentRow.Cells[1].Value}' and Человек = '{textBox_snils.Text}' ";

                            var cmd = new SqlCommand(changePass, database.getConnection());
                            cmd.ExecuteNonQuery();

                        }


                        if (rowstate == RowState.New)
                        {


                            var date_given = maskedTextBox_dateGivenPass.Text.ToString();

                            var array = date_given.Split('.');
                            Array.Reverse(array);
                            date_given = string.Join("-", array);

                            var changePass = $"Insert into Паспорт (Серия,Номер,Человек,Фамилия,Имя,Отчество,Дата_Выдачи,Отделение_МВД,Адрес_Прописки,Гражданство,Семейное_Положение) values ('{maskedTextBox_seriaPass.Text.Replace(" ", "")}', '{maskedTextBox_numberPass.Text}', '{textBox_snils.Text.Trim()}', '{maskedTextBox_surnamePass.Text}', '{maskedTextBox_namePass.Text}', '{maskedTextBox_fathnamePass.Text}', '{date_given}', '{comboBox_wherePass.SelectedValue}',  '{maskedTextBox_addrPass.Text}', '{comboBox_citizenshipPass.SelectedValue}', '{comboBox_famPass.SelectedValue}')  ";

                            var cmd = new SqlCommand(changePass, database.getConnection());
                            cmd.ExecuteNonQuery();
                        }



                    }

                }
                if (clicked == карьераToolStripMenuItem)
                {
                    var rowstate = (RowState)dataGridView2.Rows[index2].Cells[7].Value;

                    if (dataGridView2.Visible == true && rowstate == RowState.Deleted)
                    {
                        var num_mark = dataGridView2.Rows[index2].Cells[0].Value;

                        var delquery = $"delete from Прием_Перевод where Код_Записи = {num_mark}";

                        var cmd = new SqlCommand(delquery, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }

                    if (rowstate == RowState.Modified)//условие изменения для паспорта
                    {

                        var date_of = maskedTextBox_dateCareer.Text.ToString();

                        var array = date_of.Split('.');
                        Array.Reverse(array);
                        date_of = string.Join("-", array);
                        var changePass = "";
                        if(dataGridView2.Rows[index2].Cells[3].Value.ToString()[0] == 'Т')
                        {
                            changePass = $"update Прием_Перевод set Дата_Записи = '{date_of}', Основание = 'Трудовой договор №{comboBox_tdCareer.SelectedValue}', Номер_Бригады = '{maskedTextBox_numCareer.Text}', Должность = '{comboBox_jobCareer.SelectedValue}' where Код_Записи = '{dataGridView2.CurrentRow.Cells[0].Value}'";
                        }
                        else
                        {
                            changePass = $"update Прием_Перевод set Дата_Записи = '{date_of}', Основание = 'Приказ №{dataGridView2.CurrentRow.Cells[0].Value}', Номер_Бригады = '{maskedTextBox_numCareer.Text}', Должность = '{comboBox_jobCareer.SelectedValue}' where Код_Записи = '{dataGridView2.CurrentRow.Cells[0].Value}'";

                        }

                        var cmd = new SqlCommand(changePass, database.getConnection());
                        cmd.ExecuteNonQuery();

                    }

                    if (rowstate == RowState.New)
                    {

                        var date_mark = maskedTextBox_dateCareer.Text.ToString();

                        var array = date_mark.Split('.');
                        Array.Reverse(array);
                        date_mark = string.Join("-", array);

                        var changePass = $"Insert into Прием_Перевод (Трудовой_Договор,Дата_Записи,Основание,Должность,Номер_Бригады) values ('{comboBox_tdCareer.SelectedValue}', '{date_mark}', '', {comboBox_jobCareer.SelectedValue}, '{maskedTextBox_numCareer.Text}')";

                        var cmd = new SqlCommand(changePass, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }



                }


                if (clicked == образованиеToolStripMenuItem)
                {
                    var rowstate = (RowState)dataGridView2.Rows[index2].Cells[7].Value;

                    if (dataGridView2.Visible == true && rowstate == RowState.Deleted)
                    {
                        var seria = dataGridView2.Rows[index2].Cells[0].Value;
                        var num = dataGridView2.Rows[index2].Cells[1].Value;

                        var delquery = $"delete from Документ_Об_Образовании where Серия_Документа = {seria} and Номер_Документа = '{num}'";

                        var cmd = new SqlCommand(delquery, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }

                    if (rowstate == RowState.Modified)//условие изменения для образования
                    {

                        var date_end = maskedTextBox_dateEdu.Text.ToString();

                        var array = date_end.Split('.');
                        Array.Reverse(array);
                        date_end = string.Join("-", array);

                        var changePass = $"update Документ_Об_Образовании set Серия_Документа = '{maskedTextBox_seriaEdu.Text}', Номер_Документа = '{maskedTextBox_numberEdu.Text}', ОО = '{comboBox_ooEdu.SelectedValue}', Тип_Образования = '{comboBox_typeEdu.SelectedValue}', Специальность = '{comboBox_specialityEdu.SelectedValue}', Квалификация = {comboBox_qualificationEdu.SelectedValue}, Дата_Окончания = '{date_end}' where Серия_Документа = '{dataGridView2.CurrentRow.Cells[0].Value}' and Номер_Документа = '{dataGridView2.CurrentRow.Cells[1].Value}'";

                        var cmd = new SqlCommand(changePass, database.getConnection());
                        cmd.ExecuteNonQuery();

                    }

                    if (rowstate == RowState.New)
                    {

                        var date_end = maskedTextBox_dateEdu.Text.ToString();

                        var array = date_end.Split('.');
                        Array.Reverse(array);
                        date_end = string.Join("-", array);

                        var changePass = $"Insert into Документ_Об_Образовании (Серия_Документа,Номер_Документа,ОО,Тип_Образования,Специальность, Квалификация, Дата_Окончания, Человек) values ('{maskedTextBox_seriaEdu.Text}','{maskedTextBox_numberEdu.Text}','{comboBox_ooEdu.SelectedValue}','{comboBox_typeEdu.SelectedValue}','{comboBox_specialityEdu.SelectedValue}','{comboBox_qualificationEdu.SelectedValue}', '{date_end}', '{dataGridView1.CurrentRow.Cells[7].Value}' )";

                        var cmd = new SqlCommand(changePass, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }



                }

                if (clicked == семьяToolStripMenuItem)
                {
                    var rowstate = (RowState)dataGridView2.Rows[index2].Cells[5].Value;

                    if (dataGridView2.Visible == true && rowstate == RowState.Deleted)
                    {
                        var surname = dataGridView2.Rows[index2].Cells[0].Value;
                        var name = dataGridView2.Rows[index2].Cells[1].Value;
                        var fathname = dataGridView2.Rows[index2].Cells[2].Value;

                        var delquery = $"delete from Родственник where Сотрудник = {dataGridView1.CurrentRow.Cells[7].Value} and Фамилия = '{surname}' and Имя = '{name}' and Отчество = '{fathname}'";

                        var cmd = new SqlCommand(delquery, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }

                    if (rowstate == RowState.Modified)//условие изменения для образования
                    {

                        var date_birthday = maskedTextBox_birthdayRel.Text.ToString();

                        var array = date_birthday.Split('.');
                        Array.Reverse(array);
                        date_birthday = string.Join("-", array);

                        var changeRel = $"update Родственник set Фамилия = '{maskedTextBox_surnameRel.Text}', Имя = '{maskedTextBox_nameRel.Text}', Отчество = '{maskedTextBox_fathnameRel.Text}', Дата_Рождения = '{date_birthday}', Родственная_Связь = '{comboBox_typeRel.SelectedValue}' where Сотрудник = '{dataGridView1.CurrentRow.Cells[7].Value}'";

                        var cmd = new SqlCommand(changeRel, database.getConnection());
                        cmd.ExecuteNonQuery();

                    }

                    if (rowstate == RowState.New)
                    {

                        var date_birthday = maskedTextBox_birthdayRel.Text.ToString();

                        var array = date_birthday.Split('.');
                        Array.Reverse(array);
                        date_birthday = string.Join("-", array);

                        var changePass = $"Insert into Родственник (Сотрудник,Фамилия,Имя,Отчество,Родственная_Связь, Дата_Рождения) values ('{dataGridView1.CurrentRow.Cells[7].Value}','{maskedTextBox_surnameRel.Text}','{maskedTextBox_nameRel.Text}','{maskedTextBox_fathnameRel.Text}','{comboBox_typeRel.SelectedValue}','{date_birthday}' )";

                        var cmd = new SqlCommand(changePass, database.getConnection());
                        cmd.ExecuteNonQuery();
                    }



                }
            }



            database.closeConnection();
        }

        private void Search(DataGridView dgw)//поиск
        {
            dgw.Rows.Clear();


            string serStr = $"Select Номер_Бригады, Наименование_Должности, Фамилия, Имя, Отчество, Наименование_Пола, Дата_Рождения, СНИЛС, Телефон, Электронная_Почта From(Человек Inner Join Паспорт ON Человек.СНИЛС = Паспорт.Человек) INNER JOIN Пол ON Пол.Код_Пола = Человек.Пол_Человека  INNER JOIN Трудовой_Договор ON Человек.СНИЛС = Трудовой_Договор.Человек INNER JOIN Прием_Перевод ON Трудовой_Договор.Номер_ТД = Прием_Перевод.Трудовой_Договор INNER JOIN Должность ON Прием_Перевод.Должность = Должность.Код_Должности where Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = Человек.СНИЛС GROUP BY Человек) AND Прием_Перевод.Код_Записи = (SELECT MAX(Код_Записи) FROM Прием_Перевод WHERE(Трудовой_Договор = Трудовой_Договор.Номер_ТД) GROUP BY Трудовой_Договор) AND (Трудовой_Договор.Дата_Расторжения_ТД Is NULL or Трудовой_Договор.Дата_Расторжения_ТД = '1900-01-01') and (Трудовой_Договор.Основание_Расторжения is null or Трудовой_Договор.Основание_Расторжения = '') and concat (Номер_Бригады, Наименование_Должности, Фамилия, Имя, Отчество, Наименование_Пола, Дата_Рождения, СНИЛС, Телефон, Электронная_Почта ) like '%" + textBox_search.Text.Replace(" ", "%") + "%'";
            SqlCommand cmd = new SqlCommand(serStr, database.getConnection());

            database.openConnection();

            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void CreateColumns()//заполнить таблицу 1 датагрида
        {
            dataGridView2.Columns.Clear();
            dataGridView1.Columns.Add("Brigade", "Номер_Бригады");
            dataGridView1.Columns.Add("Job", "Должность");
            dataGridView1.Columns.Add("Surname", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("FathName", "Отчество");
            dataGridView1.Columns.Add("Gender", "Пол");
            dataGridView1.Columns.Add("Birthday", "Дата_рождения");
            dataGridView1.Columns.Add("id", "СНИЛС");
            dataGridView1.Columns.Add("Telephone", "Телефон");
            dataGridView1.Columns.Add("Mail", "Почта");
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[10].Visible = false;

        }

        private void CreateColumns_Pass()//заполнить таблицу 2 датагрида
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Seria", "Серия");
            dataGridView2.Columns.Add("Number", "Номер");
            dataGridView2.Columns.Add("Surname", "Фамилия");
            dataGridView2.Columns.Add("Name", "Имя");
            dataGridView2.Columns.Add("FathName", "Отчество");
            dataGridView2.Columns.Add("Given_place", "Кем выдан");
            dataGridView2.Columns.Add("Given_date", "Дата выдачи");
            dataGridView2.Columns.Add("Addr", "Адрес прописки");
            dataGridView2.Columns.Add("Citizenship", "Гражданство");
            dataGridView2.Columns.Add("Fam", "Семейное положение");
            dataGridView2.Columns.Add("Is", String.Empty);
            dataGridView2.Columns[10].Visible = false;

        }

        private void CreateColumns_Career()//заполнить таблицу 2 датагрида
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("id", "Номер Записи");
            dataGridView2.Columns.Add("Td", "Трудовой Договор");
            dataGridView2.Columns.Add("Date", "Дата Записи");
            dataGridView2.Columns.Add("Surname", "Основание");
            dataGridView2.Columns.Add("Name", "Должность");
            dataGridView2.Columns.Add("Salary", "Зарплата");
            dataGridView2.Columns.Add("FathName", "Номер Бригады");
            dataGridView2.Columns.Add("Is", String.Empty);
            dataGridView2.Columns[7].Visible = false;

        }

        private void CreateColumns_Education()//заполнить таблицу 2 датагрида
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("seria", "Серия");
            dataGridView2.Columns.Add("num", "Номер");
            dataGridView2.Columns.Add("OO", "Образовательная организация");
            dataGridView2.Columns.Add("type", "Тип");
            dataGridView2.Columns.Add("speciality", "Специальность");
            dataGridView2.Columns.Add("qualif", "Квалификация");
            dataGridView2.Columns.Add("date_end", "Дата окончания");
            dataGridView2.Columns.Add("Is", String.Empty);
            dataGridView2.Columns[7].Visible = false;

        }

        private void CreateColumns_Relatives()//заполнить таблицу 2 датагрида
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("surname", "Фамилия");
            dataGridView2.Columns.Add("name", "Имя");
            dataGridView2.Columns.Add("fathname", "Отчество");
            dataGridView2.Columns.Add("type", "Кем приходится");
            dataGridView2.Columns.Add("date", "Дата рождения");
            dataGridView2.Columns.Add("Is", String.Empty);
            dataGridView2.Columns[5].Visible = false;

        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetDateTime(6), record.GetString(7), record.GetString(8), record.GetString(9), RowState.Existed);
        }

        private void ReadSingleRow_Career(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), record.GetString(3), record.GetString(4), record.GetDecimal(5), record.GetString(6), RowState.Existed);
        }

        private void ReadSingleRow_Education(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetDateTime(6), RowState.Existed);
        }

        private void ReadSingleRow_Relatives(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), RowState.Existed);
        }

        public void RefreshDataGridView(DataGridView dgw)//обновить дата грид1
        {
            dgw.Rows.Clear();

            string query = $"Select Номер_Бригады, Наименование_Должности, Фамилия, Имя, Отчество, Наименование_Пола, Дата_Рождения,СНИЛС, Телефон, Электронная_Почта From (Человек Inner Join Паспорт ON Человек.СНИЛС = Паспорт.Человек) INNER JOIN Пол ON Пол.Код_Пола = Человек.Пол_Человека  INNER JOIN Трудовой_Договор ON Человек.СНИЛС = Трудовой_Договор.Человек INNER JOIN Прием_Перевод ON Трудовой_Договор.Номер_ТД = Прием_Перевод.Трудовой_Договор INNER JOIN Должность ON Прием_Перевод.Должность = Должность.Код_Должности where Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = Человек.СНИЛС GROUP BY Человек) AND Прием_Перевод.Код_Записи = (SELECT MAX(Код_Записи) FROM Прием_Перевод WHERE(Трудовой_Договор = Трудовой_Договор.Номер_ТД) GROUP BY Трудовой_Договор) AND (Трудовой_Договор.Дата_Расторжения_ТД Is NULL or Трудовой_Договор.Дата_Расторжения_ТД = '1900-01-01') and (Дата_Окончания_ТД > GetDate() or Дата_Окончания_ТД = '1900-01-01' ) and (Трудовой_Договор.Основание_Расторжения is null or Трудовой_Договор.Основание_Расторжения = '') ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow(dgw, dr);
            }
            dr.Close();

            if (panel7.Visible == true)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    button_deleteWorker.Enabled = false;
                    button_changeWorker.Enabled = false;
                }
                else { button_deleteWorker.Enabled = true; button_changeWorker.Enabled = true; }
            }


        }

        public void RefreshDataGridView_Pass(DataGridView dgw)//обновить дата грид паспорта
        {
            dgw.Rows.Clear();

            string query = $"Select Серия,Номер,Фамилия,Имя,Отчество,Наименование_Подразделения,Дата_Выдачи,Адрес_Прописки,Наименование_Гражданства,Наименование_Положения from .Гражданство INNER JOIN Паспорт ON Гражданство.Код_Гражданства = Паспорт.Гражданство INNER JOIN Отделение_МВД ON Паспорт.Отделение_МВД = Отделение_МВД.Код_Подразделения INNER JOIN Семейное_Положение ON Паспорт.Семейное_Положение = Семейное_Положение.Код_Семейного_Положения where Паспорт.Человек = {dataGridView1.Rows[selectedRow].Cells[7].Value.ToString()}";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow(dgw, dr);
            }
            dr.Close();

            if (dataGridView2.Visible == true)
            {

                if (dataGridView2.Rows.Count == 0)
                {
                    button_changeWorker.Enabled = false;
                }
                else { button_changeWorker.Enabled = true; }
            }

        }

        public void RefreshDataGridView_Career(DataGridView dgw)//обновить дата грид карьеры
        {
            dgw.Rows.Clear();

            string query = $"Select  Код_Записи,Трудовой_Договор,Дата_Записи,Основание,Наименование_Должности, Заработная_Плата,Номер_Бригады from Прием_Перевод INNER JOIN Трудовой_Договор ON Прием_Перевод.Трудовой_Договор = Трудовой_Договор.Номер_ТД INNER JOIN Человек ON Трудовой_Договор.Человек = Человек.СНИЛС INNER JOIN Должность ON Прием_Перевод.Должность = Должность.Код_Должности where Трудовой_Договор.Человек = {dataGridView1.Rows[selectedRow].Cells[7].Value.ToString()}";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ReadSingleRow_Career(dgw, dr);
                }
            }

            dr.Close();

            if (dataGridView2.Visible == true)
            {

                if (dataGridView2.Rows.Count == 0)
                {
                    button_word.Enabled = false;
                    button_deleteWorker.Enabled = false;
                    button_changeWorker.Enabled = false;
                }
                else
                {
                    button_changeWorker.Enabled = true; button_word.Enabled = true;
                    button_deleteWorker.Enabled = true;
                }
            }

        }

        public void RefreshDataGridView_Education(DataGridView dgw)//обновить дата грид образования
        {
            dgw.Rows.Clear();

            string query = $"Select  Серия_Документа,Номер_Документа,Наименование_ОО,Наименование_Образования,Наименование_Специальности, Наименование_Квалификации,Дата_Окончания FROM Человек INNER JOIN Документ_Об_Образовании ON Человек.СНИЛС = Документ_Об_Образовании.Человек INNER JOIN Специальность ON Документ_Об_Образовании.Специальность = Специальность.Код_Специальности INNER JOIN Образовательная_Организация ON Документ_Об_Образовании.ОО = Образовательная_Организация.Код_ОО INNER JOIN Квалификация ON Документ_Об_Образовании.Квалификация = Квалификация.Код_Квалификации INNER JOIN Тип_Образования ON Документ_Об_Образовании.Тип_Образования = Тип_Образования.Код_Образования where Человек.СНИЛС = {dataGridView1.CurrentRow.Cells[7].Value}";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ReadSingleRow_Education(dgw, dr);
                }
            }

            dr.Close();

            if (dataGridView2.Visible == true)
            {

                if (dataGridView2.Rows.Count == 0)
                {
                    button_changeWorker.Enabled = false;
                }
                else { button_changeWorker.Enabled = true; }
            }

        }

        public void RefreshDataGridView_Relatives(DataGridView dgw)//обновить дата грид образования
        {
            dgw.Rows.Clear();

            string query = $"Select  Фамилия,Имя,Отчество,Наименование_Типа_Связи,Дата_Рождения FROM Родственник inner join Тип_Родственной_Связи on Родственная_Связь = Код_Типа_Связи where Сотрудник = {dataGridView1.CurrentRow.Cells[7].Value}";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ReadSingleRow_Relatives(dgw, dr);
                }
            }

            dr.Close();

            if (dataGridView2.Visible == true)
            {

                if (dataGridView2.Rows.Count == 0)
                {
                    button_changeWorker.Enabled = false;
                }
                else { button_changeWorker.Enabled = true; }
            }

        }

        private void сменитьРольToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreateColumns();
            CreateColumns_Pass();
            RefreshDataGridView(dataGridView1);
            dataGridView2.DefaultCellStyle.Font = dataGridView1.DefaultCellStyle.Font;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = dataGridView1.ColumnHeadersDefaultCellStyle.Font;


            FillBoxes();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//обновить дата грид при нажатии на ячейку
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                string query = $"Select * From (Человек Inner Join Паспорт ON Человек.СНИЛС = Паспорт.Человек) INNER JOIN Пол ON Пол.Код_Пола = Человек.Пол_Человека  INNER JOIN Трудовой_Договор ON Человек.СНИЛС = Трудовой_Договор.Человек INNER JOIN Прием_Перевод ON Трудовой_Договор.Номер_ТД = Прием_Перевод.Трудовой_Договор INNER JOIN Должность ON Прием_Перевод.Должность = Должность.Код_Должности Inner Join Место_Рождения ON Место_Рождения.Код_Места = Человек.Место_Рождения where Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = Человек.СНИЛС GROUP BY Человек) AND Прием_Перевод.Код_Записи = (SELECT MAX(Код_Записи) FROM Прием_Перевод WHERE(Трудовой_Договор = Трудовой_Договор.Номер_ТД) GROUP BY Трудовой_Договор) AND (Трудовой_Договор.Дата_Расторжения_ТД Is NULL or Трудовой_Договор.Дата_Расторжения_ТД = '1900-01-01') and (Трудовой_Договор.Основание_Расторжения is null or Трудовой_Договор.Основание_Расторжения = '') and Человек.СНИЛС = {row.Cells[7].Value} ";
                SqlCommand cmd = new SqlCommand(query, database.getConnection());

                database.openConnection();

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.GetValue(21).ToString().Trim() == "Мужской")
                {
                    pictureBox_image.BackgroundImage = Properties.Resources.islands_200;
                }
                else { pictureBox_image.BackgroundImage = Properties.Resources.sb8apxowHAY1; }

                textBox_surname.Text = dr.GetValue(15).ToString();
                textBox_name.Text = dr.GetValue(16).ToString();
                textBox_fathname.Text = dr.GetValue(17).ToString();
                textBox_job.Text = dr.GetValue(37).ToString();
                textBox_gender.Text = dr.GetValue(21).ToString();
                textBox_birthday.Text = dr.GetValue(2).ToString().Split(' ')[0];
                textBox_city.Text = dr.GetValue(40).ToString();
                textBox_addr.Text = dr.GetValue(7).ToString();

                if (dr.GetValue(6) != null)
                {
                    textBox_inn.Text = dr.GetValue(6).ToString();
                }

                textBox_snils.Text = dr.GetValue(0).ToString();
                textBox_phone.Text = dr.GetValue(4).ToString();
                textBox_mail.Text = dr.GetValue(5).ToString();

                try
                {
                    var imageData = (byte[])dr["Фото"];
                    using (var memoryStream = new System.IO.MemoryStream(imageData))
                    {
                        pictureBox_image.Image = Image.FromStream(memoryStream);
                    }
                }
                catch { pictureBox_image.Image = null; }


                comboBox_inp_gender.SelectedValue = dr.GetValue(20).ToString();//установка значений на спрятанные комбобоксы
                comboBox_inp_city.SelectedValue = dr.GetValue(38).ToString();
                comboBox_inp_job.SelectedValue = dr.GetValue(36).ToString();

                dr.Close();

                if (clicked == паспортToolStripMenuItem)
                {
                    RefreshDataGridView_Pass(dataGridView2);
                }
                if (clicked == карьераToolStripMenuItem)
                {
                    RefreshDataGridView_Career(dataGridView2);
                }
                if (clicked == образованиеToolStripMenuItem)
                {
                    RefreshDataGridView_Education(dataGridView2);
                }

                if (clicked == семьяToolStripMenuItem)
                {
                    RefreshDataGridView_Relatives(dataGridView2);
                }


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//добавить сотрудника, паспорт
        {
            if (panel7.Visible == true) //общее
            {
                Add_Worker addfrm = new Add_Worker();
                addfrm.ShowDialog();
                RefreshDataGridView(dataGridView1);
            }

            if (clicked == паспортToolStripMenuItem) //паспорт
            {
                dataGridView1.Enabled = false;
                button_addWorker.Visible = false;
                button_deleteWorker.Visible = false;
                button_saveChanges.Text = "Добавить\nпаспорт";
                menuStrip2.Enabled = false;
                panel_changePass.Parent = panel1;
                panel_changePass.Location = panel7.Location;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[10].Value = RowState.New;
                dataGridView2.Visible = false;
                panel_changePass.Visible = true;
                foreach (var item in panel_changePass.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }
                maskedTextBox_surnamePass.Text = textBox_surname.Text;
                maskedTextBox_namePass.Text = textBox_name.Text;
                maskedTextBox_fathnamePass.Text = textBox_fathname.Text;
                maskedTextBox_addrPass.Text = textBox_addr.Text;
                foreach (var item in panel_changePass.Controls.OfType<Label>())
                {
                    item.Visible = true;
                }
                foreach (var item in panel_changePass.Controls.OfType<ComboBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }
                button_saveChanges.Visible = true;
                button_cancelChanges.Visible = true;
            }

            if (clicked == карьераToolStripMenuItem) //карьера
            {
                FillBoxes();
                button_word.Visible = false;
                button_deleteWorker.Visible = false;
                dataGridView1.Enabled = false;
                button_addWorker.Visible = false;
                button_saveChanges.Text = "Добавить\nзапись";
                menuStrip2.Enabled = false;
                panel_changeCareer.Parent = panel1;
                panel_changeCareer.Location = panel7.Location;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[7].Value = RowState.New;
                dataGridView2.Visible = false;
                panel_changeCareer.Visible = true;
                maskedTextBox_dateCareer.ReadOnly = false;

                foreach (var item in panel_changeCareer.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }

                maskedTextBox_dateCareer.Text = DateTime.Now.ToShortDateString();

                foreach (var item in panel_changeCareer.Controls.OfType<Label>())
                {
                    item.Visible = true;
                }
                foreach (var item in panel_changeCareer.Controls.OfType<ComboBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }
                button_saveChanges.Visible = true;
                button_cancelChanges.Visible = true;
            }

            if (clicked == образованиеToolStripMenuItem) //образование
            {
                button_deleteWorker.Visible = false;
                dataGridView1.Enabled = false;
                button_addWorker.Visible = false;
                button_saveChanges.Text = "Добавить\nдокумент";
                menuStrip2.Enabled = false;
                panel_changeEducation.Parent = panel1;
                panel_changeEducation.Location = panel7.Location;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[7].Value = RowState.New;
                dataGridView2.Visible = false;
                panel_changeEducation.Visible = true;
                maskedTextBox_dateCareer.ReadOnly = false;

                foreach (var item in panel_changeEducation.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }

                foreach (var item in panel_changeEducation.Controls.OfType<Label>())
                {
                    item.Visible = true;
                }
                foreach (var item in panel_changeEducation.Controls.OfType<ComboBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }
                button_saveChanges.Visible = true;
                button_cancelChanges.Visible = true;
            }

            if (clicked == семьяToolStripMenuItem) //образование
            {
                button_deleteWorker.Visible = false;
                dataGridView1.Enabled = false;
                button_addWorker.Visible = false;
                button_saveChanges.Text = "Добавить\nродного";
                menuStrip2.Enabled = false;
                panel_changeRelative.Parent = panel1;
                panel_changeRelative.Location = panel7.Location;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[5].Value = RowState.New;
                dataGridView2.Visible = false;
                panel_changeRelative.Visible = true;

                foreach (var item in panel_changeRelative.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }

                foreach (var item in panel_changeRelative.Controls.OfType<Label>())
                {
                    item.Visible = true;
                }
                foreach (var item in panel_changeRelative.Controls.OfType<ComboBox>())
                {
                    item.Visible = true;
                    item.Text = "";
                }
                button_saveChanges.Visible = true;
                button_cancelChanges.Visible = true;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)//удаление
        {
            button_addWorker.Visible = false;
            button_changeWorker.Visible = false;

            DeleteRow();
            if (dataGridView2.Visible == true)
            {
                menuStrip2.Enabled = false;
                dataGridView1.Enabled = false;
            }


            button_saveChanges.Visible = true;
            button_cancelChanges.Visible = true;


        }

        private void button_saveChanges_Click(object sender, EventArgs e)//сохранить изменения
        {
            menuStrip2.Enabled = true;
            button_deleteWorker.Visible = true;
            maskedTextBox_dateCareer.ReadOnly = true;
            if(comboBox_inp_gender.Visible == true)
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value = RowState.Modified;
            }
            

            if (clicked == паспортToolStripMenuItem && panel_changePass.Visible == true && button_saveChanges.Text == "Сохранить")
            {
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[10].Value = RowState.Modified;
            }

            if (clicked == карьераToolStripMenuItem && panel_changeCareer.Visible == true && button_saveChanges.Text == "Сохранить")
            {
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[7].Value = RowState.Modified;
            }

            if (clicked == образованиеToolStripMenuItem && panel_changeEducation.Visible == true && button_saveChanges.Text == "Сохранить")
            {
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[7].Value = RowState.Modified;
            }

            if (clicked == семьяToolStripMenuItem && panel_changeRelative.Visible == true && button_saveChanges.Text == "Сохранить")
            {
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[5].Value = RowState.Modified;

            }

            Updatedg();

            button_saveChanges.Visible = false;
            button_cancelChanges.Visible = false;

            button_addWorker.Visible = true;
            button_changeWorker.Visible = true;

            if (panel7.Visible == true)//общее
            {
                foreach (var item in panel7.Controls.OfType<TextBox>())
                {
                    item.Visible = true;
                }

                foreach (var item in panel7.Controls.OfType<ComboBox>())
                {
                    item.Visible = false;
                }

                foreach (var item in panel7.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = false;
                }
            }

            if (clicked == паспортToolStripMenuItem)//обновление дата грида смена панели
            {
                dataGridView2.Visible = true;
                panel_changePass.Visible = false;
                RefreshDataGridView_Pass(dataGridView2);
            }

            if (clicked == карьераToolStripMenuItem)
            {
                dataGridView2.Visible = true;
                panel_changeCareer.Visible = false;
                RefreshDataGridView_Career(dataGridView2);
                button_word.Visible = true;
            }

            if (clicked == образованиеToolStripMenuItem)
            {
                dataGridView2.Visible = true;
                panel_changeEducation.Visible = false;
                RefreshDataGridView_Education(dataGridView2);
            }

            if (clicked == семьяToolStripMenuItem)
            {
                dataGridView2.Visible = true;
                panel_changeEducation.Visible = false;
                RefreshDataGridView_Relatives(dataGridView2);
            }
            RefreshDataGridView(dataGridView1);

            dataGridView1.Enabled = true;
        }

        private void button_cancelChanges_Click(object sender, EventArgs e)
        {
            menuStrip2.Enabled = true;
            button_deleteWorker.Visible = true;
            if (panel7.Visible == true)
            {

                RefreshDataGridView(dataGridView1);

                foreach (var item in panel7.Controls.OfType<TextBox>())
                {
                    item.Visible = true;
                }

                foreach (var item in panel7.Controls.OfType<ComboBox>())
                {
                    item.Visible = false;
                }

                foreach (var item in panel7.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = false;
                }
            }


            if (dataGridView2.Visible == true && clicked == паспортToolStripMenuItem || panel_changePass.Visible == true)//обновление дата грид при отмене
            {
                RefreshDataGridView_Pass(dataGridView2);
                panel_changePass.Visible = false;
                dataGridView2.Visible = true;
                button_addWorker.Visible = false;
            }

            if (dataGridView2.Visible == true && clicked == карьераToolStripMenuItem || panel_changeCareer.Visible == true)
            {
                RefreshDataGridView_Career(dataGridView2);
                panel_changeCareer.Visible = false;
                dataGridView2.Visible = true;
                button_addWorker.Visible = false;
                button_word.Visible = true;
            }

            if (dataGridView2.Visible == true && clicked == образованиеToolStripMenuItem || panel_changeEducation.Visible == true)
            {
                RefreshDataGridView_Education(dataGridView2);
                panel_changeEducation.Visible = false;
                dataGridView2.Visible = true;
                button_addWorker.Visible = false;
            }

            if (dataGridView2.Visible == true && clicked == семьяToolStripMenuItem || panel_changeRelative.Visible == true)
            {
                RefreshDataGridView_Relatives(dataGridView2);
                panel_changeRelative.Visible = false;
                dataGridView2.Visible = true;
                button_addWorker.Visible = false;
            }


            button_saveChanges.Text = "Сохранить";
            button_saveChanges.Visible = false;
            button_cancelChanges.Visible = false;

            button_addWorker.Visible = true;
            button_changeWorker.Visible = true;

            dataGridView1.Enabled = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_changeWorker_Click(object sender, EventArgs e)
        {
            menuStrip2.Enabled = false;
            button_saveChanges.Visible = true;
            button_cancelChanges.Visible = true;

            button_addWorker.Visible = false;
            button_changeWorker.Visible = false;
            button_deleteWorker.Visible = false;

            dataGridView1.Enabled = false;
            if (panel7.Visible == true)
            {

                foreach (var item in panel7.Controls.OfType<TextBox>())
                {
                    item.Visible = false;
                }

                foreach (var item in panel7.Controls.OfType<ComboBox>())
                {
                    item.Visible = true;
                }

                foreach (var item in panel7.Controls.OfType<MaskedTextBox>())
                {
                    item.Visible = true;
                }

                maskedTextBox_surname.Text = textBox_surname.Text;
                maskedTextBoxinp_inn.Text = textBox_inn.Text;
                maskedTextBox_name.Text = textBox_name.Text;
                maskedTextBox_fathName.Text = textBox_fathname.Text;
                maskedTextBox_inp_snils.Text = textBox_snils.Text;
                maskedTextBox_inp_birthday.Text = textBox_birthday.Text;
                maskedTextBox_inp_addr.Text = textBox_addr.Text;
                maskedTextBox_inp_phone.Text = textBox_phone.Text;
                maskedTextBox_inp_mail.Text = textBox_mail.Text;

                comboBox_inp_job.Text = textBox_job.Text;
                comboBox_inp_gender.Text = textBox_gender.Text;
                comboBox_inp_city.Text = textBox_city.Text;


            }

            if (dataGridView2.Visible == true)
            {
                if (clicked == паспортToolStripMenuItem)
                {


                    panel_changePass.Parent = panel1;
                    panel_changePass.Location = panel7.Location;
                    dataGridView2.Visible = false;
                    panel_changePass.Visible = true;

                    maskedTextBox_seriaPass.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    maskedTextBox_numberPass.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    maskedTextBox_surnamePass.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    maskedTextBox_namePass.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    maskedTextBox_fathnamePass.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    comboBox_wherePass.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    maskedTextBox_dateGivenPass.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString().Replace(".", "");
                    maskedTextBox_addrPass.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                    comboBox_citizenshipPass.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                    comboBox_famPass.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();

                    foreach (var item in panel_changePass.Controls.OfType<MaskedTextBox>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changePass.Controls.OfType<Label>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changePass.Controls.OfType<ComboBox>())
                    {
                        item.Visible = true;
                    }
                }

                if (clicked == карьераToolStripMenuItem)
                {
                    FillBoxes();
                    button_word.Visible = false;
                    panel_changeCareer.Parent = panel1;
                    panel_changeCareer.Location = panel7.Location;
                    dataGridView2.Visible = false;
                    panel_changeCareer.Visible = true;

                    maskedTextBox_dateCareer.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString().Replace(".", "");
                    comboBox_jobCareer.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    maskedTextBox_salaryCareer.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    maskedTextBox_numCareer.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

                    foreach (var item in panel_changeCareer.Controls.OfType<MaskedTextBox>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeCareer.Controls.OfType<Label>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeCareer.Controls.OfType<ComboBox>())
                    {
                        item.Visible = true;
                    }
                }

                if (clicked == образованиеToolStripMenuItem)
                {

                    panel_changeEducation.Parent = panel1;
                    panel_changeEducation.Location = panel7.Location;
                    dataGridView2.Visible = false;
                    panel_changeEducation.Visible = true;

                    maskedTextBox_seriaEdu.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    maskedTextBox_numberEdu.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    comboBox_ooEdu.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    comboBox_typeEdu.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    comboBox_specialityEdu.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    comboBox_qualificationEdu.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    maskedTextBox_dateEdu.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString().Replace(".", "");


                    foreach (var item in panel_changeEducation.Controls.OfType<MaskedTextBox>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeEducation.Controls.OfType<Label>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeEducation.Controls.OfType<ComboBox>())
                    {
                        item.Visible = true;
                    }
                }

                if (clicked == семьяToolStripMenuItem)
                {

                    panel_changeRelative.Parent = panel1;
                    panel_changeRelative.Location = panel7.Location;
                    dataGridView2.Visible = false;
                    panel_changeRelative.Visible = true;

                    maskedTextBox_surnameRel.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    maskedTextBox_nameRel.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    maskedTextBox_fathnameRel.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    comboBox_typeRel.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    maskedTextBox_birthdayRel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString().Replace(".", "");


                    foreach (var item in panel_changeRelative.Controls.OfType<MaskedTextBox>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeRelative.Controls.OfType<Label>())
                    {
                        item.Visible = true;
                    }
                    foreach (var item in panel_changeRelative.Controls.OfType<ComboBox>())
                    {
                        item.Visible = true;
                    }
                }
            }
        }

        private void pictureBox_image_Click(object sender, EventArgs e)
        {
            if (button_saveChanges.Visible == true)
            {
                using (var openFileDialoge = new OpenFileDialog())
                {
                    openFileDialoge.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg, *.png";
                    openFileDialoge.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (openFileDialoge.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox_image.Image = Image.FromFile(openFileDialoge.FileName);
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void общееToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clicked = общееToolStripMenuItem;
            button_word.Visible = false;
            dataGridView2.Visible = false;
            panel7.Visible = true;
            try
            {
                RefreshDataGridView(dataGridView1);
            }
            catch (Exception ex) { }
            button_addWorker.Text = "Добавить\nсотрудника";
        }

        private void паспортToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            clicked = паспортToolStripMenuItem;
            button_word.Visible = false;
            CreateColumns_Pass();
            panel7.Visible = false;
            dataGridView2.Visible = true;
            try { RefreshDataGridView_Pass(dataGridView2); } catch (Exception ex) { }

            button_addWorker.Text = "Добавить\nпаспорт";

        }

        private void textBox_city_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(textBox_city, textBox_city.Text);
        }

        private void textBox_addr_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(textBox_addr, textBox_addr.Text);
        }

        private void maskedTextBox_inp_birthday_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((DateTime.Now.Year - DateTime.Parse($"{maskedTextBox_inp_birthday.Text} 00:00:00").Year) < 18)
                {
                    maskedTextBox_inp_birthday.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_birthday, "Человек должен быть старше 18");
                    button_saveChanges.Enabled = false;
                }
                else { maskedTextBox_inp_birthday.ForeColor = Color.Black; button_saveChanges.Enabled = true; }
            }
            catch (System.FormatException)
            {
                maskedTextBox_inp_birthday.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_birthday, "Нарушен формат даты"); button_saveChanges.Enabled = false; ;
            }
        }

        private void maskedTextBox_dateGivenPass_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((DateTime.Parse($"{maskedTextBox_dateGivenPass.Text} 00:00:00").Year) - (DateTime.Parse($"{textBox_birthday.Text} 00:00:00").Year) < 14)
                {
                    maskedTextBox_dateGivenPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_dateGivenPass, "Первый паспорт выдается с 14 лет");
                    button_saveChanges.Enabled = false;
                }
                else { maskedTextBox_dateGivenPass.ForeColor = Color.Black; button_saveChanges.Enabled = true; }
            }
            catch (System.FormatException)
            {
                maskedTextBox_dateGivenPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_dateGivenPass, "Нарушен формат даты"); button_saveChanges.Enabled = false;
            }
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

            if (dataGridView2.Rows.Count == 1 && clicked != образованиеToolStripMenuItem && clicked != семьяToolStripMenuItem || dataGridView2.Rows.Count == 0)
            {
                button_deleteWorker.Enabled = false;
            }
            else { button_deleteWorker.Enabled = true; }

            if (clicked == образованиеToolStripMenuItem && dataGridView2.Rows.Count > 0 || clicked == семьяToolStripMenuItem && dataGridView2.Rows.Count > 0)
            {
                button_deleteWorker.Enabled = true;
            }



        }

        private void карьераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clicked = карьераToolStripMenuItem;
            CreateColumns_Career();
            panel7.Visible = false;
            dataGridView2.Visible = true;
            try { RefreshDataGridView_Career(dataGridView2); } catch (Exception ex) { }
            button_addWorker.Text = "Добавить\nзапись";
            button_word.Visible = true;

        }

        private void comboBox_jobCareer_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox_jobCareer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var query = $"select Заработная_Плата from Должность where Код_Должности = {comboBox_jobCareer.SelectedValue} ";
            database.openConnection();
            DataTable dt = new DataTable();

            var virtCmd = new SqlCommand(query, database.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
            adapter.Fill(dt);

            maskedTextBox_salaryCareer.Text = dt.Rows[0][0].ToString();


            database.closeConnection();

        }

        private void comboBox_jobCareer_SelectedValueChanged(object sender, EventArgs e)
        {



        }

        private void образованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clicked = образованиеToolStripMenuItem;
            button_word.Visible = false;
            button_deleteWorker.Enabled = true;
            CreateColumns_Education();
            panel7.Visible = false;
            dataGridView2.Visible = true;
            try { RefreshDataGridView_Education(dataGridView2); } catch (Exception ex) { button_deleteWorker.Enabled = false; }
            button_addWorker.Text = "Добавить\nдокумент";

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_dateEdu_Leave(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Parse($"{maskedTextBox_dateEdu.Text} 00:00:00") > DateTime.Now)
                {
                    maskedTextBox_dateEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_dateEdu, "Дата не должна превышать текущую");
                    button_saveChanges.Enabled = false;
                }
                else { maskedTextBox_dateEdu.ForeColor = Color.Black; button_saveChanges.Enabled = true; }

                if (DateTime.Parse($"{maskedTextBox_dateEdu.Text} 00:00:00") < DateTime.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString()))
                {
                    maskedTextBox_dateEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_dateEdu, "Дата не должна быть раньше даты рождения");
                    button_saveChanges.Enabled = false;
                }
                else { maskedTextBox_dateEdu.ForeColor = Color.Black; button_saveChanges.Enabled = true; }
            }
            catch (System.FormatException)
            {
                maskedTextBox_dateEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_dateEdu, "Нарушен формат даты"); button_saveChanges.Enabled = false;
            }
        }

        private void maskedTextBox_seriaPass_Leave(object sender, EventArgs e)
        {
            if (button_saveChanges.Text == "Добавить\nпаспорт" || button_saveChanges.Text == "Сохранить")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия, Номер from Паспорт";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                if (maskedTextBox_seriaPass.Text.Replace("_", "").Replace(" ","").Length < 4)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBox_seriaPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaPass, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBox_seriaPass.ForeColor = Color.Black; maskedTextBox_numberPass.ForeColor = Color.Black; }

                    foreach (DataRow row in dt.Rows)
                {
                    if (maskedTextBox_seriaPass.ForeColor != Color.Red && maskedTextBox_numberPass.ForeColor != Color.Red)
                    {
                        if ($"{maskedTextBox_seriaPass.Text.Replace(" ", "")}{maskedTextBox_numberPass.Text}" == $"{row[0].ToString().Replace(" ", "")}{row[1].ToString()}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBox_seriaPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaPass, "Паспорт с такой серией и номером уже есть");
                            maskedTextBox_numberPass.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_numberPass, "Паспорт с такой серией и номером уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBox_seriaPass.ForeColor = Color.Black; }
                    }
                    else { button_saveChanges.Enabled = false; }

                }
                
            }

        }

        private void maskedTextBox_numberPass_Leave(object sender, EventArgs e)
        {
            if (button_saveChanges.Text == "Добавить\nпаспорт" || button_saveChanges.Text == "Сохранить")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия, Номер from Паспорт";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                if (maskedTextBox_numberPass.Text.Replace("_", "").Length < 6)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBox_numberPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_numberPass, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBox_numberPass.ForeColor = Color.Black;}

                foreach (DataRow row in dt.Rows)
                {
                    if (maskedTextBox_numberPass.ForeColor != Color.Red && maskedTextBox_seriaPass.ForeColor != Color.Red)
                    {
                        if ($"{maskedTextBox_seriaPass.Text.Replace(" ", "")}{maskedTextBox_numberPass.Text}" == $"{row[0].ToString().Replace(" ", "")}{row[1].ToString()}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBox_seriaPass.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaPass, "Паспорт с такой серией и номером уже есть");
                            maskedTextBox_numberPass.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_numberPass, "Паспорт с такой серией и номером уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBox_seriaPass.ForeColor = Color.Black; maskedTextBox_numberPass.ForeColor = Color.Black; }
                    }
                    else { button_saveChanges.Enabled = false; }
                }   


            }
        }

        private void maskedTextBox_inp_snils_Leave(object sender, EventArgs e)
        {
            if (button_saveChanges.Text == "Сохранить")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Снилс from Человек";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);
                if (maskedTextBox_inp_snils.Text.Replace("-", "").Replace("_","").Length < 11)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBox_inp_snils.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_snils, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBox_inp_snils.ForeColor = Color.Black; }
                foreach (DataRow row in dt.Rows)
                {
                    if(maskedTextBox_inp_snils.ForeColor != Color.Red)
                    {
                        if ($"{maskedTextBox_inp_snils.Text.Replace("-", "")}" == $"{row[0]}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBox_inp_snils.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_inp_snils, "Человек с таким СНИЛС уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBox_inp_snils.ForeColor = Color.Black; }
                    }
                 
                }
            }
        }

        private void maskedTextBoxinp_inn_Leave(object sender, EventArgs e)
        {
            if (button_saveChanges.Text == "Сохранить" && maskedTextBoxinp_inn.Text != "000000000000")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select ИНН from Человек";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                if (maskedTextBoxinp_inn.Text.Replace("_", "").Length < 12)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBoxinp_inn.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBoxinp_inn, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBoxinp_inn.ForeColor = Color.Black; }

                foreach (DataRow row in dt.Rows)
                {
                    if(maskedTextBoxinp_inn.ForeColor != Color.Red )
                    {
                        if ($"{maskedTextBoxinp_inn.Text}" == $"{row[0]}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBoxinp_inn.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBoxinp_inn, "Человек с таким ИНН уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBoxinp_inn.ForeColor = Color.Black; }
                    }
                    
                }
            }
        }

        private void maskedTextBox_seriaEdu_Leave(object sender, EventArgs e)
        {
            if (button_saveChanges.Text == "Добавить\nдокумент" || button_saveChanges.Text == "Сохранить")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия_Документа, Номер_Документа from Документ_Об_Образовании";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                if(maskedTextBox_seriaEdu.Text.Length < 6)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBox_seriaEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaEdu, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBox_seriaEdu.ForeColor = Color.Black;}

                foreach (DataRow row in dt.Rows)
                {
                    if(maskedTextBox_seriaEdu.ForeColor != Color.Red && maskedTextBox_numberEdu.ForeColor != Color.Red)
                    {

                        if ($"{maskedTextBox_seriaEdu.Text}{maskedTextBox_numberEdu.Text}" == $"{row[0].ToString()}{row[1].ToString()}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBox_seriaEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaEdu, "Такой документ об образовании уже есть");
                            maskedTextBox_numberEdu.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_numberEdu, "Такой документ об образовании уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBox_seriaEdu.ForeColor = Color.Black; maskedTextBox_numberEdu.ForeColor = Color.Black; }
                    }
                    else { button_saveChanges.Enabled = false; }
                    
                }
            }
        }

        private void семьяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clicked = семьяToolStripMenuItem;
            button_word.Visible = false;
            CreateColumns_Relatives();
            panel7.Visible = false;
            dataGridView2.Visible = true;
            try { RefreshDataGridView_Relatives(dataGridView2); } catch { button_deleteWorker.Enabled = false; }
            button_addWorker.Text = "Добавить\nродного";

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_fathnameRel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_birthdayRel_Leave(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Parse($"{maskedTextBox_birthdayRel.Text} 00:00:00") > DateTime.Now)
                {
                    maskedTextBox_birthdayRel.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_birthdayRel, "Дата рождения не может быть больше текущей");
                    button_saveChanges.Enabled = false;
                }
                else { maskedTextBox_birthdayRel.ForeColor = Color.Black; button_saveChanges.Enabled = true; }
            }
            catch (System.FormatException)
            {
                maskedTextBox_birthdayRel.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_birthdayRel, "Нарушен формат даты"); button_saveChanges.Enabled = false;
            }
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (clicked == карьераToolStripMenuItem)
            {
                if (dataGridView2.RowCount == 1)
                {

                    dataGridView2.Rows[0].Cells[3].Value = "Трудовой договор №" + dataGridView2.Rows[0].Cells[1].Value;

                }
                else
                {

                    dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[3].Value = "Приказ №" + dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value;

                }
            }
        }

        private void гражданствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = гражданствоToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void местоРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = местоРожденияToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();
        }

        private void отделениеМВДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = отделениеМВДToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();
        }

        private void семейноеПоложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = семейноеПоложениеToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void типРодтсвеннойСвязиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = типРодтсвеннойСвязиToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void типТрудовогоДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = типТрудовогоДоговораToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();
        }

        private void квалификацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = квалификацияToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void образовательнаяОрганизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = образовательнаяОрганизацияToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();
        }

        private void специальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = специальностьToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void типОбразованияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = типОбразованияToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Simple_Data frame = new Add_Simple_Data();
            frame.label1.Text = должностьToolStripMenuItem.Text;
            frame.ShowDialog();
            FillBoxes();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (clicked == карьераToolStripMenuItem)
            {
                if (((string)dataGridView2.CurrentRow.Cells[3].Value).Split('№')[0] == "Трудовой договор ")
                {

                    button_deleteWorker.Enabled = false;

                }
                else
                {
                    button_deleteWorker.Enabled = true;
                }
            }

        }

        private void трудовойДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_TD frame = new Add_TD();

            frame.ShowDialog(this);

            RefreshDataGridView(dataGridView1);
        }

        private void button_word_Click(object sender, EventArgs e)
        {




            if (dataGridView2.CurrentRow.Index == 0)
            {
                Word_Helper help = new Word_Helper("forma_n_t-1__prikaz_(rasporyagenie)_o_prieme_rabotnika_na_rabotu_.docx");
                DataTable dt = new DataTable();
                var virtQuery = $"select Номер_ТД, Дата_Создания, Дата_Окончания_ТД, Табельный_Номер, Наименование_Типа from Трудовой_Договор inner join Тип_ТД on Тип_ТД = Код_Типа_ТД where Номер_ТД = '{dataGridView2.CurrentRow.Cells[1].Value}'";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                var date_ended = ((DateTime)dt.Rows[0][2]).ToShortDateString();
                if (date_ended == "01.01.1900") { date_ended = ""; }


                var items = new Dictionary<string, string>
                  {
                      { "Number", dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim()},
                      {"Created", ((DateTime)dataGridView2.CurrentRow.Cells[2].Value).ToShortDateString() },
                      {"Ended", date_ended},
                      { "Surname", dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() },
                      {"FathName", dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() },
                      {"Name", dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim() },
                      {"TabNum", dt.Rows[0][3].ToString().Trim() },
                      {"Brigade", dataGridView2.CurrentRow.Cells[6].Value.ToString().Trim() },
                      {"Job", dataGridView2.CurrentRow.Cells[4].Value.ToString().Trim() },
                      {"Type", dt.Rows[0][4].ToString().Trim() },
                      {"NumTd", dt.Rows[0][0].ToString().Trim() },
                      { "Salary", dataGridView2.CurrentRow.Cells[5].Value.ToString().Trim() }
                  };


                help.FindReplace(items, dataGridView2.CurrentRow);

                Process.Start($"C://Users//Yakovka//Desktop//Personnel_Accounting//Personnel_Accounting//bin//Debug//Shablons//Приказ №{dataGridView2.CurrentRow.Cells[0].Value}.docx");


            }
            else
            {
                Word_Helper help = new Word_Helper("blank-prikaz-o-perevode-na-druguyu-dolzhnost-forma-t-5.doc");
                DataTable dt = new DataTable();
                var virtQuery = $"select Номер_ТД, Дата_Создания, Дата_Окончания_ТД, Табельный_Номер, Наименование_Типа from Трудовой_Договор inner join Тип_ТД on Тип_ТД = Код_Типа_ТД where Номер_ТД = '{dataGridView2.CurrentRow.Cells[1].Value}'";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                var date_CreatedTd = ((DateTime)dt.Rows[0][1]).ToShortDateString();


                var items = new Dictionary<string, string>
                {
                    {"NumTd", dt.Rows[0][0].ToString().Trim() },
                    {"TabNum", dt.Rows[0][3].ToString().Trim() },
                    {"Num", dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim()},
                    { "TdCreated", date_CreatedTd },
                    {"Created", ((DateTime)dataGridView2.CurrentRow.Cells[2].Value).ToShortDateString() },
                    {"Surname", dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() },
                    {"FathName", dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() },
                    {"Name", dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim() },
                    {"BrigadeNew", dataGridView2.CurrentRow.Cells[6].Value.ToString().Trim() },
                    {"JobNew", dataGridView2.CurrentRow.Cells[4].Value.ToString().Trim() },
                    {"Type", dt.Rows[0][4].ToString().Trim() },
                    { "Salary", dataGridView2.CurrentRow.Cells[5].Value.ToString().Trim() },
                    { "JobLast", dataGridView2.Rows[dataGridView2.CurrentRow.Index - 1].Cells[4].Value.ToString().Trim()},
                    { "BrigadeLast", dataGridView2.Rows[dataGridView2.CurrentRow.Index - 1].Cells[6].Value.ToString().Trim()},
                };


                help.FindReplace(items, dataGridView2.CurrentRow);

                Process.Start($"C://Users//Yakovka//Desktop//Personnel_Accounting//Personnel_Accounting//bin//Debug//Shablons//Приказ №{dataGridView2.CurrentRow.Cells[0].Value}.doc");


            }





        }

        private void форма1кадрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string [] queries = { "select Count(*) from Человек", "select count(*) from Человек where СНИЛС in (Select СНИЛС from Документ_Об_Образовании inner join Человек on Человек = СНИЛС where Year(Дата_Окончания) = Year(GETDATE()))  ", "select count(*), Тип_Образования from Документ_Об_Образовании right join Тип_Образования On Код_Образования = Тип_Образования where Year(Дата_Окончания) = Year(GETDATE()) or Year(Дата_Окончания) is null or Year(Дата_Окончания) = '' Group By Тип_Образования Order By Тип_Образования ", "select Count(*) from Человек where (Year(GetDate()) - Year(Дата_Рождения)) < 25", "select count(*) from Человек where СНИЛС in (Select СНИЛС from Документ_Об_Образовании inner join Человек On Человек = СНИЛС where Year(Дата_Окончания) = Year(GETDATE()) and (Year(GetDate()) - Year(Дата_Рождения)) <= 25 and Year(Дата_Окончания) = Year(GETDATE()))", "select count(*), Тип_Образования from Документ_Об_Образовании left join человек on Человек = СНИЛС right join Тип_Образования On Код_Образования = Тип_Образования where (Year(Дата_Окончания) = Year(GETDATE()) or Year(Дата_Окончания) is null or Year(Дата_Окончания) = '') and (Year(GetDate()) - Year(Дата_Рождения) >= 25 or Year(Дата_Рождения) is null) Group By Тип_Образования Order By Тип_Образования " };

            DataTable dt = new DataTable();
            SqlDataAdapter adapter;

            using (var helper = new Excel_Helper())
            { 
                if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, $"Table.xlsx")))
                {
                    int stroke = 10;
                    var col = "F";
                    for (int index = 0; index<queries.Length; index++)
                    {
                        database.openConnection();
                        dt = new DataTable();

                        var virtCmd = new SqlCommand(queries[index], database.getConnection());
                        adapter = new SqlDataAdapter(virtCmd);
                        adapter.Fill(dt);
                        
                        if (index == 3)
                        {
                            col = "I";
                            stroke = 10;
                        }

                        foreach (DataRow r in dt.Rows)
                        {
                            if (r[0] != null)
                            {
                                if ((index == 2 || index == 5)&& (r[1].ToString() == null || r[1].ToString() == "")) { r[0] = 0; }
                                helper.Set(column: col, row: stroke, data: r[0].ToString());

                            }
                            stroke += 2;

                        }



                        database.closeConnection();

                    }
                    
                    helper.Save();


                }
            }
            Process.Start($"C://Users//Yakovka//Desktop//Personnel_Accounting//Personnel_Accounting//bin//Debug//Отчет за {DateTime.Now.Year}.xlsx");

        }

        private void maskedTextBox_numberEdu_Leave(object sender, EventArgs e)
        {

            if (button_saveChanges.Text == "Добавить\nдокумент" || button_saveChanges.Text == "Сохранить")
            {
                DataTable dt = new DataTable();

                var virtQuery = "select Серия_Документа, Номер_Документа from Документ_Об_Образовании";
                var virtCmd = new SqlCommand(virtQuery, database.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(virtCmd);
                adapter.Fill(dt);

                if (maskedTextBox_numberEdu.Text.Length < 7)
                {
                    button_saveChanges.Enabled = false;
                    maskedTextBox_numberEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_numberEdu, "Не полное поле");

                }
                else { button_saveChanges.Enabled = true; maskedTextBox_numberEdu.ForeColor = Color.Black; }

                foreach (DataRow row in dt.Rows)
                {
                    if (maskedTextBox_numberEdu.ForeColor != Color.Red && maskedTextBox_seriaEdu.ForeColor != Color.Red)
                    {

                        if ($"{maskedTextBox_seriaEdu.Text}{maskedTextBox_numberEdu.Text}" == $"{row[0].ToString()}{row[1].ToString()}")
                        {
                            button_saveChanges.Enabled = false;
                            maskedTextBox_seriaEdu.ForeColor = Color.Red; ToolTip t = new ToolTip(); t.SetToolTip(maskedTextBox_seriaEdu, "Такой документ об образовании уже есть");
                            maskedTextBox_numberEdu.ForeColor = Color.Red; ToolTip t2 = new ToolTip(); t.SetToolTip(maskedTextBox_numberEdu, "Такой документ об образовании уже есть");
                            break;
                        }
                        else { button_saveChanges.Enabled = true; maskedTextBox_seriaEdu.ForeColor = Color.Black; maskedTextBox_numberEdu.ForeColor = Color.Black; }
                    }
                    else { button_saveChanges.Enabled = false; }

                }
            }

        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start($"C://Users//Yakovka//Desktop//Personnel_Accounting//Personnel_Accounting//Руководство пользователя.docx");
        }
    }
}
