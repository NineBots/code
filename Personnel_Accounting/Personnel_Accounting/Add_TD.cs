using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Accounting
{
    public partial class Add_TD : Form
    {
        DataBase database = new DataBase();
        public Add_TD()
        {
            InitializeComponent();
        }

        private void FillBoxes()
        {
            var typeTD = $"select Код_Типа_ТД, Наименование_Типа from Тип_ТД";
            var persone = $"select Фамилия, Имя, Отчество, СНИЛС from Человек Left Join Трудовой_Договор On Человек.СНИЛС = Трудовой_Договор.Человек INNER JOIN Паспорт ON Человек.СНИЛС = Паспорт.Человек  where Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = Человек.СНИЛС GROUP BY Человек) and Номер_ТД is null or Тип_ТД like '2%' group by Фамилия, Имя, Отчество,СНИЛС";
            var fillJob = $"select Код_Должности, Наименование_Должности from Должность";

            SqlDataAdapter cmdTypeTD = new SqlDataAdapter(typeTD, database.getConnection());
            SqlDataAdapter cmdPersone = new SqlDataAdapter(persone, database.getConnection());
            SqlDataAdapter cmdJob = new SqlDataAdapter(fillJob, database.getConnection());

            database.openConnection();

            DataTable types = new DataTable();
            DataTable people = new DataTable();
            DataTable jobs = new DataTable();

            cmdTypeTD.Fill(types);
            cmdPersone.Fill(people);
            cmdJob.Fill(jobs);

            comboBox_Pers.DataSource = people;
            comboBox_Pers.DisplayMember = "Фамилия";
            comboBox_Pers.ValueMember = "СНИЛС";

            comboBox_Type.DataSource = types;
            comboBox_Type.DisplayMember = "Наименование_Типа";
            comboBox_Type.ValueMember = "Код_Типа_ТД";

            comboBox_Job.DataSource = jobs;
            comboBox_Job.ValueMember = "Код_Должности";
            comboBox_Job.DisplayMember = "Наименование_Должности";
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Номер Договора");
            dataGridView1.Columns.Add("surn", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("fathname", "Отчетсво");
            dataGridView1.Columns.Add("tab", "Табельный номер");
            dataGridView1.Columns.Add("Job", "Должность");
            dataGridView1.Columns.Add("Brigade", "Номер бригады");
            dataGridView1.Columns.Add("date", "Дата создания");
            dataGridView1.Columns.Add("dateen", "Дата окончания");
            dataGridView1.Columns.Add("name", "Тип договора");
            dataGridView1.Columns.Add("datedel", "Дата расторжения");
            dataGridView1.Columns.Add("whyDel", "Основание Расторжения");
;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[12].Visible = true;
        }

        private void ReadSingleRow_Simple(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), record.GetDateTime(7), record.GetDateTime(8), record.GetString(9), record.GetDateTime(10), record.GetString(11), RowState.Existed);
        }


        private void RefreshDG(DataGridView dgw)
        {

                dgw.Rows.Clear();

                string query = $"Select Номер_ТД,Фамилия,Имя,Отчество,Табельный_Номер, Наименование_Должности, Номер_Бригады, Дата_Создания,Дата_Окончания_ТД,Наименование_Типа,Дата_Расторжения_ТД,Основание_Расторжения FROM Человек INNER JOIN Трудовой_Договор ON Человек.СНИЛС = Трудовой_Договор.Человек INNER JOIN Тип_ТД ON Трудовой_Договор.Тип_ТД = Тип_ТД.Код_Типа_ТД INNER JOIN Паспорт ON Человек.СНИЛС = Паспорт.Человек Inner join Прием_Перевод on Трудовой_Договор.Номер_ТД = Прием_Перевод.Трудовой_Договор Inner Join Должность On Прием_Перевод.Должность = Должность.Код_Должности where Паспорт.Дата_Выдачи = (Select Max(Дата_Выдачи) From Паспорт where Паспорт.Человек = Человек.СНИЛС GROUP BY Человек) and Основание like 'Трудовой договор%'  ";
                SqlCommand cmd = new SqlCommand(query, database.getConnection());

                database.openConnection();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ReadSingleRow_Simple(dgw, dr);
                }
                dr.Close();

        }

        private void UpdateDg()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {

                RowState rowstate = (RowState)dataGridView1.Rows[index].Cells[12].Value;

                if(rowstate == RowState.Existed)
                        continue;

                if (rowstate == RowState.Deleted)
                {

                    var changePass = $"delete from Трудовой_Договор where Номер_ТД = '{dataGridView1.Rows[index].Cells[0].Value}'";

                    var cmd = new SqlCommand(changePass, database.getConnection());
                    cmd.ExecuteNonQuery();

                }

                if (rowstate == RowState.New)
                {

                    var date_Created = maskedTextBox_Created.Text.ToString();
                    var date_ended = "";
                    var date_deleted = "";

                    var array = date_Created.Split('.');
                    Array.Reverse(array);
                    date_Created = string.Join("-", array);

                    if (maskedTextBox_Ended.Text != null && maskedTextBox_Ended.Text != "")
                    {

                        date_ended = maskedTextBox_Ended.Text.ToString();

                        array = date_ended.Split('.');
                        Array.Reverse(array);
                        date_ended = string.Join("-", array);

                        if (date_ended == "-  -  ")
                        {
                            date_ended = "1900-01-01";
                        }

                    }

                    if (maskedTextBox_Deleted.Text != null && maskedTextBox_Deleted.Text != "")
                    {

                        date_deleted = maskedTextBox_Deleted.Text.ToString();

                        array = date_deleted.Split('.');
                        Array.Reverse(array);
                        date_deleted = string.Join("-", array);

                        if (date_deleted == "-  -  ")
                        {
                            date_deleted = "1900-01-01";
                        }

                    }

                    var changePass = $"Insert into Трудовой_Договор (Номер_ТД,Дата_Создания,Дата_Окончания_ТД,Тип_ТД,Дата_Расторжения_ТД,Основание_Расторжения,Человек,Табельный_Номер) values ('{maskedTextBox_Num.Text}','{date_Created}','{date_ended}','{comboBox_Type.SelectedValue}','{date_deleted}','{maskedTextBox_WhyDeleted.Text}','{comboBox_Pers.SelectedValue}', '{maskedTextBox_TabNum.Text}' )";

                    var cmd = new SqlCommand(changePass, database.getConnection());
                    cmd.ExecuteNonQuery();
                }

                if (rowstate == RowState.Modified)
                {

                    var date_Created = maskedTextBox_Created.Text.ToString();
                    var date_ended = "";
                    var date_deleted = "";

                    var array = date_Created.Split('.');
                    Array.Reverse(array);
                    date_Created = string.Join("-", array);

                    if (maskedTextBox_Ended.Text != null && maskedTextBox_Ended.Text != "")
                    {

                        date_ended = maskedTextBox_Ended.Text.ToString();

                        array = date_ended.Split('.');
                        Array.Reverse(array);
                        date_ended = string.Join("-", array);

                        if (date_ended == "-  -  ")
                        {
                            date_ended = "1900-01-01";
                        }

                    }

                    if (maskedTextBox_Deleted.Text != null && maskedTextBox_Deleted.Text != "")
                    {

                        date_deleted = maskedTextBox_Deleted.Text.ToString();

                        array = date_deleted.Split('.');
                        Array.Reverse(array);
                        date_deleted = string.Join("-", array);

                        if (date_deleted == "-  -  ")
                        {
                            date_deleted = "1900-01-01";
                        }

                    }

                    var changePass = $"Update Трудовой_Договор set Номер_ТД = '{maskedTextBox_Num.Text}' ,Дата_Создания = '{date_Created}',Дата_Окончания_ТД = '{date_ended}' ,Тип_ТД = '{comboBox_Type.SelectedValue}',Дата_Расторжения_ТД = '{date_deleted}',Основание_Расторжения = '{maskedTextBox_WhyDeleted.Text}',Человек ='{comboBox_Pers.SelectedValue}',Табельный_Номер = '{maskedTextBox_TabNum.Text}' where Номер_ТД = '{dataGridView1.CurrentRow.Cells[0].Value}'";

                    var cmd = new SqlCommand(changePass, database.getConnection());
                    cmd.ExecuteNonQuery();
                }

            }
            database.closeConnection();

        }

        private void DeleteRow()
        {

            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[12].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[12].Value = RowState.Deleted;

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_TD_Load(object sender, EventArgs e)
        {
            FillBoxes();
            CreateColumns();
            RefreshDG(dataGridView1);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.Visible == true && button_add.Text != "Сохранить")//нажата кнопка добавить сотруднкиа
            {
                dataGridView1.Visible = false;
                panel1.Visible = true;
                maskedTextBox_Created.Text = DateTime.Now.ToShortDateString();
                button_delete.Visible = false;
                button_change.Text = "Отмена";

                if (dataGridView1.RowCount > 0)//настройка автоинкремента для номеров
                {
                    var arr = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString().Split('-');

                    var add_stroke = $"{int.Parse(arr[0])+ 1}" + arr[1].Trim();

                    while(add_stroke.Length < 7)
                    {
                        add_stroke = '0' + add_stroke;
                    }
                    maskedTextBox_Num.Text = add_stroke;


                    add_stroke = $"{(int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value + 1}";

                    while (add_stroke.Length < 3)
                    {
                        add_stroke = '0' + add_stroke;
                    }
                    maskedTextBox_TabNum.Text = add_stroke;
                }
                else
                {
                    maskedTextBox_Num.Text = $"001" + DateTime.Now.Year;
                    maskedTextBox_TabNum.Text = "001";
                }



            }
            else if (dataGridView1.Visible == true && button_add.Text == "Сохранить")//условие подтверждения удаления
            {
                button_change.Text = "Изменить";
                button_add.Text = "Добавить";
                UpdateDg();
                RefreshDG(dataGridView1);

            }
            else if (panel1.Visible == true && button_add.Text=="Добавить")//условия подтверждения добавления
            {

                dataGridView1.Visible = true;
                panel1.Visible = false;
                maskedTextBox_Created.Text = DateTime.Now.ToShortDateString();
                button_delete.Visible = true;
                button_change.Text = "Изменить";

                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[12].Value = RowState.New;
                UpdateDg();

                var date_Created = maskedTextBox_Created.Text.ToString();

                var array = date_Created.Split('.');
                Array.Reverse(array);
                date_Created = string.Join("-", array);
                database.openConnection();
                var changePass = $"Insert into Прием_Перевод (Трудовой_Договор,Дата_Записи,Основание,Должность,Номер_Бригады) values ('{maskedTextBox_Num.Text}','{date_Created}','Трудовой договор № {maskedTextBox_Num.Text}','{comboBox_Job.SelectedValue}','{maskedTextBox_Brigade.Text}')";

                var cmd = new SqlCommand(changePass, database.getConnection());
                cmd.ExecuteNonQuery();
                database.closeConnection();
                RefreshDG(dataGridView1);

            }
            else if (panel1.Visible == true && button_add.Text == "Сохранить")//условие подтверждения изменения
            {



                    dataGridView1.Visible = true;
                    panel1.Visible = false;
                    button_delete.Visible = true;
                    button_change.Text = "Изменить";
                    button_add.Text = "Добавить";

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[12].Value = RowState.Modified;
                    UpdateDg();

                    var date_Created = maskedTextBox_Created.Text.ToString();

                    var array = date_Created.Split('.');
                    Array.Reverse(array);
                    date_Created = string.Join("-", array);
                    database.openConnection();
                    var changePass = $"update Прием_Перевод set Трудовой_Договор = '{maskedTextBox_Num.Text}', Дата_Записи = '{date_Created}',Номер_Бригады = '{maskedTextBox_Brigade.Text.Trim()}', Должность = '{comboBox_Job.SelectedValue}' where Трудовой_Договор = '{maskedTextBox_Num.Text}' and Основание Like 'Трудовой договор%'";

                    var cmd = new SqlCommand(changePass, database.getConnection());
                    cmd.ExecuteNonQuery();
                    database.closeConnection();
                    RefreshDG(dataGridView1);

                
                

            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_change_Click(object sender, EventArgs e)
        {

            if(button_change.Text == "Отмена")//отмена
            {

                RefreshDG(dataGridView1);
                panel1.Visible = false;
                dataGridView1.Visible = true;
                button_change.Text = "Изменить";
                button_delete.Visible = true;
                button_add.Text = "Добавить";

            }
            else//нажата кнопка изменить
            {

                maskedTextBox_Num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                maskedTextBox_Created.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                maskedTextBox_Ended.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                maskedTextBox_TabNum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                maskedTextBox_Deleted.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                maskedTextBox_WhyDeleted.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                maskedTextBox_Brigade.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                comboBox_Type.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboBox_Pers.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                dataGridView1.Visible = false;
                panel1.Visible = true;
                button_delete.Visible=false;
                button_change.Text = "Отмена";
                button_add.Text = "Сохранить";


            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            button_change.Text = "Отмена";
            button_add.Text = "Сохранить";
            DeleteRow();
        }
    }
}
