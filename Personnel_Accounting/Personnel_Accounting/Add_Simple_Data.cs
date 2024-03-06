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
    public partial class Add_Simple_Data : Form
    {
        private bool checkin = true;

        DataBase database = new DataBase();
        public Add_Simple_Data()
        {
            InitializeComponent();
        }
        private void CreateColumns_Citizenship()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код гражданства");
            dataGridView1.Columns.Add("name", "Наименование гражданства");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_City()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код места");
            dataGridView1.Columns.Add("name", "Наименование места");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_MVD()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код Отделения");
            dataGridView1.Columns.Add("name", "Наименование Отделения");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_Fam()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код Семейного положения");
            dataGridView1.Columns.Add("name", "Наименование смейеного положеия");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_TypeTD()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код типа ТД");
            dataGridView1.Columns.Add("name", "Наименование типа ТД");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_Qualification()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код квалификации");
            dataGridView1.Columns.Add("name", "Наименование квалификации");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_OO()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код Организации");
            dataGridView1.Columns.Add("name", "Наименование Организации");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_Speciality()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код специальности");
            dataGridView1.Columns.Add("name", "Наименование специальности");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_TypeEdu()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код образования");
            dataGridView1.Columns.Add("name", "Наименование образования");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void CreateColumns_Job()//заполнить таблицу 2 датагрида
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Код Должности");
            dataGridView1.Columns.Add("name", "Наименование Должности");
            dataGridView1.Columns.Add("salary", "Заработная плата");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns.Add("Is", String.Empty);
            dataGridView1.Columns[2].Visible = true;

        }

        private void UpdateSimple()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var rn = row.Cells[1].Value;
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    var index = row.Index;
                    if (label1.Text != "Трудовой договор" && label1.Text != "Должность")
                    {
                        var rowstate = (RowState)row.Cells[2].Value;

                        if (label1.Text == "Гражданство")
                        {

                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Гражданство where Код_Гражданства = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {

                                var changePass = $"Insert into Гражданство (Код_Гражданства, Наименование_Гражданства) values ('{dataGridView1.Rows[index].Cells[0].Value.ToString().Trim()}','{dataGridView1.Rows[index].Cells[1].Value.ToString().Trim()}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }



                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Гражданство set Код_Гражданства = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Гражданства = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Гражданства = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text == "Место_Рождения")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Место_Рождения where Код_Места = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {

                                var changePass = $"Insert into Место_Рождения (Код_Места, Наименование_Места) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }



                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Место_Рождения set Код_Места = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Места = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Места = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text == "Отделение МВД")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Отделение_МВД where Код_Подразделения = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {

                                var changePass = $"Insert into Отделение_МВД (Код_Подразделения, Наименование_Подразделения) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }



                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Отделение_МВД set Код_Подразделения = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Подразделения = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Подразделения = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text == "Семейное положение")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Семейное_Положение where Код_Семейного_Положения = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {

                                var changePass = $"Insert into Семейное_Положение (Код_Семейного_Положения, Наименование_Положения) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }



                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Семейное_Положение set Код_Семейного_Положения = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Положения = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Семейного_Положения = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text == "Тип трудового договора")
                        {

                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Тип_ТД where Код_Типа_ТД = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {

                                var changePass = $"Insert into Тип_ТД (Код_Типа_ТД, Наименование_Типа) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }



                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Тип_ТД set Код_Типа_ТД = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Типа = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Типа_ТД = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text.Trim() == "Квалификация")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Квалификация where Код_Квалификации = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {
                                dataGridView1.Columns[0].ReadOnly = false;
                                var changePass = $"Insert into Квалификация ( Код_Квалификации, Наименование_Квалификации) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());

                                cmd.ExecuteNonQuery();
                                dataGridView1.Columns[0].ReadOnly = true;

                            }

                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Квалификация set Код_Квалификации = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Квалификации = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Квалификации = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text.Trim() == "Образовательная организация")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Образовательная_Организация where Код_ОО = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {
                                dataGridView1.Columns[0].ReadOnly = false;
                                var changePass = $"Insert into Образовательная_Организация ( Наименование_ОО) values ('{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());

                                cmd.ExecuteNonQuery();
                                dataGridView1.Columns[0].ReadOnly = true;

                            }

                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Образовательная_Организация set Код_ОО = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_ОО = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_ОО = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if(label1.Text.Trim() == "Специальность")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Специальность where Код_Специальности = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {
                                dataGridView1.Columns[0].ReadOnly = false;
                                var changePass = $"Insert into Специальность (Код_Специальности, Наименование_Специальности) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());

                                cmd.ExecuteNonQuery();
                                dataGridView1.Columns[0].ReadOnly = true;

                            }

                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Специальность set Код_Специальности = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Специальности = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Специальности = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }

                        if (label1.Text.Trim() == "Тип образования")
                        {
                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Тип_Образования where Код_Образования = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {
                                dataGridView1.Columns[0].ReadOnly = false;
                                var changePass = $"Insert into Тип_Образования ( Код_Образования, Наименование_Образования) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());

                                cmd.ExecuteNonQuery();
                                dataGridView1.Columns[0].ReadOnly = true;

                            }

                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Тип_Образования set Код_Образования = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Образования = '{dataGridView1.Rows[index].Cells[1].Value}' where Код_Образования = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }
                        }
                    }

                    if(label1.Text == "Должность")
                    {

                        if(dataGridView1.Rows[index].Cells[2] != null)
                        {
                            var rowstate = (RowState)dataGridView1.Rows[index].Cells[3].Value;

                            row.Cells[1].Style.BackColor = Color.White; row.Cells[1].ToolTipText = row.Cells[1].Value.ToString();checkin = true;

                            if (rowstate == RowState.Deleted)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"delete from Должность where Код_Должности = '{id}'";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                            if (rowstate == RowState.New)
                            {
                                dataGridView1.Columns[0].ReadOnly = false;
                                var changePass = $"Insert into Должность ( Код_Должности, Наименование_Должности, Заработная_Плата) values ('{dataGridView1.Rows[index].Cells[0].Value}','{dataGridView1.Rows[index].Cells[1].Value}', '{dataGridView1.Rows[index].Cells[2].Value}')";
                                var cmd = new SqlCommand(changePass, database.getConnection());

                                cmd.ExecuteNonQuery();
                                dataGridView1.Columns[0].ReadOnly = true;

                            }

                            if (rowstate == RowState.Modified)
                            {

                                var id = dataGridView1.Rows[index].Cells[0].Value;

                                var delquery = $"update Должность set Код_Должности = '{dataGridView1.Rows[index].Cells[0].Value}', Наименование_Должности = '{dataGridView1.Rows[index].Cells[1].Value}', Заработная_Плата = '{dataGridView1.Rows[index].Cells[2].Value}' where Код_Должности = {id}";

                                var cmd = new SqlCommand(delquery, database.getConnection());
                                cmd.ExecuteNonQuery();

                            }

                        }
                        else
                        {

                            row.Cells[2].Style.BackColor = Color.Red; row.Cells[0].ToolTipText = "Пустое поле"; checkin = false;
                            break;

                        }
                    }
                }
                else if (row.Visible == false)
                {

                    break;

                }
                else if (row.Index == dataGridView1.Rows.Count - 1)
                {

                    break;

                }
                else if (row.Cells[0].Value == null)
                {

                    row.Cells[0].Style.BackColor = Color.Red; row.Cells[0].ToolTipText = "Пустое поле"; checkin = false;
                    break;

                }
                else if (row.Cells[1].Value == null)
                {

                    row.Cells[1].Style.BackColor = Color.Red; row.Cells[1].ToolTipText = "Пустое поле"; checkin = false;
                    break;

                }
                else if (row.Cells[0].Value.ToString() == "")
                {

                    row.Cells[0].Style.BackColor = Color.Red; row.Cells[0].ToolTipText = "Пустое поле"; checkin = false;

                }
                else if (row.Cells[1].Value.ToString() == "")
                {

                    row.Cells[1].Style.BackColor = Color.Red; row.Cells[1].ToolTipText = "Пустое поле"; checkin = false;

                }
                else
                {

                    row.Cells[0].Style.BackColor = Color.White; row.Cells[0].ToolTipText = row.Cells[0].Value.ToString(); checkin = true;
                    row.Cells[1].Style.BackColor = Color.White; row.Cells[1].ToolTipText = row.Cells[1].Value.ToString();

                }

            }

        }



        private void ReadSingleRow_Simple(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), RowState.Existed);
        }

        private void ReadSingleRow_SimpleDecimal(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.Existed);
        }

        private void ReadSingleRow_Job(DataGridView dgw, IDataRecord record)//прочитать кажду строку
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(2), RowState.Existed);
        }




        private void RefreshAsCitizenship(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Гражданство ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsCity(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Место_Рождения ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsMVD(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Отделение_МВД ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsFam(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Семейное_Положение ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsTypeTD(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Тип_ТД ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsQualification(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Квалификация ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_SimpleDecimal(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsOO(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Образовательная_Организация ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_SimpleDecimal(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsSpeciality(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Специальность ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Simple(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsTypeEdu(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Тип_Образования ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_SimpleDecimal(dgw, dr);
            }
            dr.Close();

        }

        private void RefreshAsJob(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"Select * from Должность ";
            SqlCommand cmd = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ReadSingleRow_Job(dgw, dr);
            }
            dr.Close();

        }



        private void Add_Simple_Data_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            if (label1.Text == "Гражданство")
            {
                CreateColumns_Citizenship();
                RefreshAsCitizenship(dataGridView1);
            }

            if (label1.Text == "Место_Рождения")
            {
                CreateColumns_City();
                RefreshAsCity(dataGridView1);
            }

            if (label1.Text == "Отделение МВД")
            {
                CreateColumns_MVD();
                RefreshAsMVD(dataGridView1);
            }

            if (label1.Text == "Семейное положение")
            {
                CreateColumns_Fam();
                RefreshAsFam(dataGridView1);
            }

            if (label1.Text == "Тип трудового договора")
            {
                CreateColumns_TypeTD();
                RefreshAsTypeTD(dataGridView1);
            }

            if (label1.Text == "Квалификация")
            {
                CreateColumns_Qualification();
                RefreshAsQualification(dataGridView1);
            }

            if (label1.Text == "Образовательная организация")
            {
                CreateColumns_OO();
                RefreshAsOO(dataGridView1);
            }

            if (label1.Text == "Специальность")
            {
                CreateColumns_Speciality();
                RefreshAsSpeciality(dataGridView1);
            }

            if (label1.Text == "Тип образования")
            {
                CreateColumns_TypeEdu();
                RefreshAsTypeEdu(dataGridView1);
            }

            if (label1.Text == "Должность")
            {
                CreateColumns_Job();
                RefreshAsJob(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSimple();

            if (checkin == true)
            {

                this.Close();

            }

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dataGridView1.RowCount > 1 && label1.Text != "Должность")
            {

                if(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value == null)
                {

                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[2].Value = RowState.New;

                }
                
            }
            else if (dataGridView1.RowCount > 1 && label1.Text == "Должность")
            {

                if (dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value == null)
                {

                    dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value = RowState.New;

                }

            }


            int moveHigher = 3;

            if ((label1.Text == "Образовательная организация" || label1.Text == "Квалификация" || label1.Text == "Тип образования" || label1.Text == "Должность") && dataGridView1.RowCount == 2)
            {

                dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = 1;

            }
            else if ((label1.Text == "Образовательная организация" || label1.Text == "Квалификация" || label1.Text == "Тип образования" || label1.Text == "Должность") && dataGridView1.RowCount > 2)
            {

                while (moveHigher <= dataGridView1.RowCount)
                {

                    if(dataGridView1.Rows[dataGridView1.RowCount - moveHigher].Visible == true)
                    {

                        dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = (int)dataGridView1.Rows[dataGridView1.RowCount - moveHigher].Cells[0].Value + 1;
                        break;

                    }

                    if (dataGridView1.Rows[dataGridView1.RowCount - moveHigher].Visible == false)
                    {

                        moveHigher++;

                    }

                }
            }

            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            if ((label1.Text == "Образовательная организация" || label1.Text == "Квалификация" || label1.Text == "Тип образования" || label1.Text == "Должность") && dataGridView1.RowCount > 1)
            {

                if (dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1 && label1.Text != "Должность")
                {

                    dataGridView1.CurrentRow.Cells[2].Value = RowState.Deleted;
                    dataGridView1.CurrentRow.Visible = false;

                }
                else if(dataGridView1.CurrentRow.Index != dataGridView1.RowCount - 1 && label1.Text == "Должность") 
                {

                    dataGridView1.CurrentRow.Cells[3].Value = RowState.Deleted;
                    dataGridView1.CurrentRow.Visible = false;

                }

                var index = 1;

                foreach( DataGridViewRow row in dataGridView1.Rows)
                {

                    if(row.Visible == true && row.Index != dataGridView1.RowCount -1 && label1.Text != "Должность")
                    {

                        if((RowState)row.Cells[2].Value == RowState.Existed)
                        {

                            row.Cells[2].Value = RowState.Modified;

                        }       
                        row.Cells[0].Value = index;

                        index++;

                    }
                    else if (row.Visible == true && row.Index != dataGridView1.RowCount - 1 && label1.Text == "Должность")
                    {

                        if ((RowState)row.Cells[3].Value == RowState.Existed)
                        {

                            row.Cells[3].Value = RowState.Modified;

                        }
                        row.Cells[0].Value = index;

                        index++;

                    }

                }

            }
            

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool check = true;
            if(dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Visible == true)
                    {

                        if (dataGridView1.CurrentRow.Cells[0].Value != null && row.Cells[0].Value != null)
                        {

                            if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() == row.Cells[0].Value.ToString().Trim() && dataGridView1.CurrentRow.Index != row.Index)
                            {

                                check = false;

                            }

                        }

                    }

                }

                RowState rowst = (RowState)dataGridView1.CurrentRow.Cells[2].Value;


                if (check == true)
                {
                    dataGridView1.CurrentRow.Cells[0].Style.ForeColor = Color.Black;
                    button1.Enabled = true;
                    dataGridView1.CurrentRow.Cells[0].ToolTipText = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
                else
                {
                    dataGridView1.CurrentRow.Cells[0].Style.ForeColor = Color.Red;
                    button1.Enabled = false;
                    dataGridView1.CurrentRow.Cells[0].ToolTipText = "Такой код уже есть";
                }

                if (rowst == RowState.Modified)
                {

                    dataGridView1.CurrentRow.Cells[2].Value = RowState.Modified;

                }
            }
            
                       
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
               
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                if(e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
