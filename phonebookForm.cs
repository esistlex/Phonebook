using MySql.Data.MySqlClient;

namespace phonebook
{
    public partial class PhonebookForm : Connector
    {
        public PhonebookForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private MySqlDataReader GetReader()
        {
            return reader;
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            try
            {
                DoConnect();
                String query = "SELECT * FROM contactlist";
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string getID = reader["USERID"].ToString();
                    string getName = reader["USER_NAME"].ToString();
                    string getNumber = reader["USER_NUMBER"].ToString();
                    string getProvince = reader["USER_PROVINCE"].ToString();
                    string getZipcode = reader["USER_ZIPCODE"].ToString();

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, getID, getName, getNumber, getProvince, getZipcode);
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                DoDisconnect();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                String getID = selectedRow.Cells["ID_COLUMN"].Value.ToString();
                String getName = selectedRow.Cells["NAME_COLUMN"].Value.ToString();
                String getNumber = selectedRow.Cells["CONTACTNO_COLUMN"].Value.ToString();
                String getProvince = selectedRow.Cells["PROVINCE_COLUMN"].Value.ToString();
                String getZipcode = selectedRow.Cells["ZIPCODE_COLUMN"].Value.ToString();

                idTxtbox.Text = getID;
                nameTxtbox.Text = getName;
                contactTxtbox.Text = getNumber;
                provinceTxtbox.Text = getProvince;
                zipcodeTxtbox.Text = getZipcode;
            }
        }

        private void searchBtnClick(object sender, EventArgs e)
        {
            string category = "NULL";
            string searchvalue = searchbox.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    category = "USER_NAME";
                    break;
                case 1:
                    category = "USER_PROVINCE";
                    break;
            }
            dataGridView1.Rows.Clear();
            try
            {
                DoConnect();

                if (string.IsNullOrWhiteSpace(searchvalue))
                {
                    load();
                }
                else if (!string.IsNullOrEmpty(searchvalue))
                {
                    String query = "SELECT * FROM contactlist WHERE " + category + " = '" + searchvalue + "';";
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                            string getID = reader["USERID"].ToString();
                            string getName = reader["USER_NAME"].ToString();
                            string getNumber = reader["USER_NUMBER"].ToString();
                            string getProvince = reader["USER_PROVINCE"].ToString();
                            string getZipcode = reader["USER_ZIPCODE"].ToString();

                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1, getID, getName, getNumber, getProvince, getZipcode);
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                DoDisconnect();
            }
        }

        private void addBtnClick(object sender, EventArgs e)
        {

            if (nameTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "INSERT INTO contactlist (USER_NAME, USER_NUMBER, USER_PROVINCE, USER_ZIPCODE) VALUES (@Name, @Number, @Province, @ZipCode)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Number", contactTxtbox.Text);
                    command.Parameters.AddWithValue("@Province", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    contactTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    load();
                    MessageBox.Show("Successfully inserted the record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    DoDisconnect();
                }
            }
        }

        private void deleteBtnClick(object sender, EventArgs e)
        {
            if (nameTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "DELETE FROM contactlist WHERE USER_NAME = @Name AND USER_NUMBER = @Number AND USER_PROVINCE = @Province AND USER_ZIPCODE = @ZipCode";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Number", contactTxtbox.Text);
                    command.Parameters.AddWithValue("@Province", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    load();
                    MessageBox.Show("Successfully deleted the record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    DoDisconnect();
                }
            }
        }

        private void updateBtnClick(object sender, EventArgs e)
        {
            if (nameTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "UPDATE contactlist SET USER_NAME = @Name, USER_NUMBER = @Number, USER_PROVINCE = @Province, USER_ZIPCODE = @ZipCode WHERE USERID = @Id";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", idTxtbox.Text);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Number", contactTxtbox.Text);
                    command.Parameters.AddWithValue("@Province", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    load();
                    MessageBox.Show("Successfully updated the record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    DoDisconnect();
                }
            }
        }

        private void PhonebookForm_Activated(object sender, EventArgs e)
        {
            load();
            nameTxtbox.Text = null;
            contactTxtbox.Text = null;
            provinceTxtbox.Text = null;
            zipcodeTxtbox.Text = null;
        }

        private void refreshBtnClick(object sender, EventArgs e)
        {
            load();
            idTxtbox.Text = null;
            nameTxtbox.Text = null;
            contactTxtbox.Text = null;
            provinceTxtbox.Text = null;
            zipcodeTxtbox.Text = null;
            searchbox.Text = null;
        }
    }
}