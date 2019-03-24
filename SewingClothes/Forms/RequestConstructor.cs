using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class RequestConstructor : Form
    {

        List<string> TablesNames = new List<string>();
        List<List<string>> TablesFields = new List<List<string>>();
        List<List<DataCondition>> FieldsValues = new List<List<DataCondition>>();

        public RequestConstructor()
        {
            InitializeComponent();
            LoadCheckBoxTables();
        }

        public void LoadCheckBoxTables()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT TABLE_NAME FROM SewingBD.INFORMATION_SCHEMA.TABLES " +
                                      "WHERE TABLE_NAME != 'sysdiagrams' ORDER BY TABLE_NAME";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    TablesNames = new List<string>();
                    while (reader.Read())
                    {
                        string Name = reader.GetString(0);
                        checkedListBoxTables.Items.Add(Name);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddTables()
        {
            if (checkedListBoxTables.CheckedItems.Count > 0)
            {
                comboBoxTables.Items.Clear();
                TablesNames.Clear();
                TablesFields.Clear();
                dataGridViewConditions.Rows.Clear();
                foreach (string Element in checkedListBoxTables.CheckedItems)
                {
                    TablesNames.Add(Element);
                    comboBoxTables.Items.Add(Element);
                    TablesFields.Add(new List<string>());
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну таблицу из списка.","",MessageBoxButtons.OK);
            }
        }

        public void LoadFields()
        {
            checkedListBoxFields.Items.Clear();
            SqlConnection connection = new SqlConnection(Connection.connectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT COLUMN_NAME FROM SewingBD.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName";
                command.Connection = connection;
                SqlParameter TableName = new SqlParameter("tableName",comboBoxTables.SelectedItem);
                command.Parameters.Add(TableName);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {                   
                    while (reader.Read())
                    {
                        string Name = reader.GetString(0);
                        checkedListBoxFields.Items.Add(Name);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool AddFields()
        {
            if (checkedListBoxFields.CheckedItems.Count > 0)
            {
                int index = comboBoxTables.Items.IndexOf(comboBoxTables.SelectedItem);
                TablesFields[index].Clear();
                if (TablesFields[index].Count > 0)
                {
                    MessageBox.Show("Повторное добавление полей, очистите список полей и попробуйте еще раз.", "",
                        MessageBoxButtons.OK);
                    return false;
                }
                foreach (string Element in checkedListBoxFields.CheckedItems)
                {                   
                    TablesFields[index].Add(Element);    
                    FieldsValues.Add(new List<DataCondition>());
                }
                return true;
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну таблицу из списка.", "", MessageBoxButtons.OK);
                return false;
            }
        }

        public void FillDgv()
        {
            int index = comboBoxTables.Items.IndexOf(comboBoxTables.SelectedItem);

            if(index >= 0)
            for (int i = 0; i < TablesFields[index].Count; i++)
            {
                    dataGridViewConditions.Rows.Add(TablesFields[index][i]);
            }
        }

        public void SaveValues()
        {
            int index = -1;
            try
            {
                index = comboBoxTables.Items.IndexOf(comboBoxTables.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Выберите таблицу.", "", MessageBoxButtons.OK);
            }
            if (index >= 0)
            {
                try
                {
                    for (int i = 0; i < dataGridViewConditions.Rows.Count; i++)
                    {
                        
                        string field = dataGridViewConditions.Rows[i].Cells[0].Value.ToString();
                        string condition = dataGridViewConditions.Rows[i].Cells[1].Value.ToString();
                        object value = dataGridViewConditions.Rows[i].Cells[2].Value;
                        string predicate = dataGridViewConditions.Rows[i].Cells[3].Value.ToString();
                        FieldsValues[index].Add(new DataCondition(field, condition, value, predicate));
                    }

                    dataGridViewConditions.Rows.Clear();
                }
                catch
                {
                    MessageBox.Show("Заполните значения.", "", MessageBoxButtons.OK);
                }
            }

        }

        public void FinalQuery()
        {
            string query = "SELECT * FROM ";
            bool ok = false;
            for (int i = 0; i < TablesNames.Count; i++)
            {               
                query += TablesNames[i];
                if (i != TablesNames.Count - 1)
                {
                    query += ", ";
                }
            }

            for (int i = 0; i < FieldsValues.Count; i++)
            {
                if (FieldsValues[i].Count > 0)
                {
                    query += " WHERE ";
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                for (int i = 0; i < FieldsValues.Count; i++)
                {
                    for (int j = 0; j < FieldsValues[i].Count; j++)
                    {
                        query += TablesNames[i] + ".";
                        query += FieldsValues[i][j].Field + FieldsValues[i][j].Condition + "'" + FieldsValues[i][j].Value + "'";
                        if (i != FieldsValues.Count - 1)
                        {
                            query += " " + FieldsValues[i][j].Predicate + " ";
                        }
                    }
                }
            }
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
                DataTable ds = new DataTable();
                sqlAdapter.Fill(ds);
                dataGridViewRequest.DataSource = ds.DefaultView;
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAddTables_Click(object sender, EventArgs e)
        {
            AddTables();
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFields();
            dataGridViewConditions.Rows.Clear();
        }

        private void buttonAddFields_Click(object sender, EventArgs e)
        {
            bool ok;
            ok = AddFields();
            if(ok)
            FillDgv();
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBoxTables.Items.IndexOf(comboBoxTables.SelectedItem);
                TablesFields[index].Clear();
                LoadFields();
                dataGridViewConditions.Rows.Clear();
            }
            catch
            {
                MessageBox.Show("Выберите таблицу.", "", MessageBoxButtons.OK);
            }
        }

        private void buttonSaveValues_Click(object sender, EventArgs e)
        {
            SaveValues();
        }

        private void buttonLaunchQuery_Click(object sender, EventArgs e)
        {
            FinalQuery();
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();
            Hide();
        }

        private void RequestConstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
