using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace phonebook1
{
    public partial class PhonebookForm : Connector
    {
        public PhonebookForm()
        {
            InitializeComponent();
            load();
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
                    string getAddress = reader["USER_ADDRESS"].ToString();
                    string getProvince = reader["USER_STATE"].ToString();
                    string getZipcode = reader["USER_ZIPCODE"].ToString();
                    string getCountry = reader["USER_COUNTRY"].ToString();

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, getID, getName, getAddress, getProvince, getZipcode, getCountry);
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
                String getAddress = selectedRow.Cells["ADDRESS_COLUMN"].Value.ToString();
                String getProvince = selectedRow.Cells["PROVINCE_COLUMN"].Value.ToString();
                String getZipcode = selectedRow.Cells["ZIPCODE_COLUMN"].Value.ToString();
                String getCountry = selectedRow.Cells["COUNTRY_COLUMN"].Value.ToString();

                idTxtbox.Text = getID;
                nameTxtbox.Text = getName;
                addressTxtbox.Text = getAddress;
                provinceTxtbox.Text = getProvince;
                zipcodeTxtbox.Text = getZipcode;
                countryTxtbox.Text = getCountry;
            }
        }

        private void addBtnClick(object sender, EventArgs e)
        {

            if (nameTxtbox.TextLength == 0 && addressTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0 && countryTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "INSERT INTO contactlist (USER_NAME, USER_ADDRESS, USER_STATE, USER_ZIPCODE, USER_COUNTRY) VALUES (@Name, @Address, @State, @ZipCode, @Country)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Address", addressTxtbox.Text);
                    command.Parameters.AddWithValue("@State", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.Parameters.AddWithValue("@Country", countryTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    addressTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    countryTxtbox.Text = null;
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
            if (nameTxtbox.TextLength == 0 && addressTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0 && countryTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "DELETE FROM contactlist WHERE USER_NAME = @Name AND USER_ADDRESS = @Address AND USER_STATE = @State AND USER_ZIPCODE = @ZipCode AND USER_COUNTRY = @Country";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Address", addressTxtbox.Text);
                    command.Parameters.AddWithValue("@State", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.Parameters.AddWithValue("@Country", countryTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    addressTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    countryTxtbox.Text = null;
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
            if (nameTxtbox.TextLength == 0 && addressTxtbox.TextLength == 0 && provinceTxtbox.TextLength == 0 && zipcodeTxtbox.TextLength == 0 && countryTxtbox.TextLength == 0)
            {
                MessageBox.Show("Please enter the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DoConnect();
                    String query = "UPDATE contactlist SET USER_NAME = @Name, USER_ADDRESS = @Address, USER_STATE = @State, USER_ZIPCODE = @ZipCode, USER_COUNTRY = @Country WHERE USERID = @Id";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", idTxtbox.Text);
                    command.Parameters.AddWithValue("@Name", nameTxtbox.Text);
                    command.Parameters.AddWithValue("@Address", addressTxtbox.Text);
                    command.Parameters.AddWithValue("@State", provinceTxtbox.Text);
                    command.Parameters.AddWithValue("@ZipCode", zipcodeTxtbox.Text);
                    command.Parameters.AddWithValue("@Country", countryTxtbox.Text);
                    command.ExecuteNonQuery();

                    nameTxtbox.Text = null;
                    addressTxtbox.Text = null;
                    provinceTxtbox.Text = null;
                    zipcodeTxtbox.Text = null;
                    countryTxtbox.Text = null;
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
    }
}