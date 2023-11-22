using System.Windows.Forms;

namespace phonebook
{
    partial class PhonebookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID_COLUMN = new DataGridViewTextBoxColumn();
            NAME_COLUMN = new DataGridViewTextBoxColumn();
            CONTACTNO_COLUMN = new DataGridViewTextBoxColumn();
            PROVINCE_COLUMN = new DataGridViewTextBoxColumn();
            ZIPCODE_COLUMN = new DataGridViewTextBoxColumn();
            label1 = new Label();
            nameTxtbox = new TextBox();
            provinceTxtbox = new TextBox();
            label3 = new Label();
            zipcodeTxtbox = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            refreshBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            idTxtbox = new TextBox();
            contactTxtbox = new TextBox();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            label8 = new Label();
            searchbox = new TextBox();
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_COLUMN, NAME_COLUMN, CONTACTNO_COLUMN, PROVINCE_COLUMN, ZIPCODE_COLUMN });
            dataGridView1.Location = new Point(13, 14);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID_COLUMN
            // 
            ID_COLUMN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID_COLUMN.HeaderText = "ID";
            ID_COLUMN.Name = "ID_COLUMN";
            ID_COLUMN.ReadOnly = true;
            ID_COLUMN.Resizable = DataGridViewTriState.False;
            ID_COLUMN.Width = 43;
            // 
            // NAME_COLUMN
            // 
            NAME_COLUMN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAME_COLUMN.HeaderText = "NAME";
            NAME_COLUMN.Name = "NAME_COLUMN";
            NAME_COLUMN.ReadOnly = true;
            NAME_COLUMN.Resizable = DataGridViewTriState.False;
            // 
            // CONTACTNO_COLUMN
            // 
            CONTACTNO_COLUMN.HeaderText = "CONTACT NO.";
            CONTACTNO_COLUMN.Name = "CONTACTNO_COLUMN";
            CONTACTNO_COLUMN.ReadOnly = true;
            CONTACTNO_COLUMN.Resizable = DataGridViewTriState.False;
            CONTACTNO_COLUMN.Width = 109;
            // 
            // PROVINCE_COLUMN
            // 
            PROVINCE_COLUMN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PROVINCE_COLUMN.HeaderText = "PROVINCE";
            PROVINCE_COLUMN.Name = "PROVINCE_COLUMN";
            PROVINCE_COLUMN.ReadOnly = true;
            PROVINCE_COLUMN.Resizable = DataGridViewTriState.False;
            // 
            // ZIPCODE_COLUMN
            // 
            ZIPCODE_COLUMN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ZIPCODE_COLUMN.HeaderText = "ZIP CODE";
            ZIPCODE_COLUMN.Name = "ZIPCODE_COLUMN";
            ZIPCODE_COLUMN.ReadOnly = true;
            ZIPCODE_COLUMN.Resizable = DataGridViewTriState.False;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // nameTxtbox
            // 
            nameTxtbox.BorderStyle = BorderStyle.FixedSingle;
            nameTxtbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxtbox.Location = new Point(140, 94);
            nameTxtbox.Margin = new Padding(4, 3, 4, 3);
            nameTxtbox.Name = "nameTxtbox";
            nameTxtbox.Size = new Size(337, 22);
            nameTxtbox.TabIndex = 2;
            // 
            // provinceTxtbox
            // 
            provinceTxtbox.BorderStyle = BorderStyle.FixedSingle;
            provinceTxtbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            provinceTxtbox.Location = new Point(140, 215);
            provinceTxtbox.Margin = new Padding(4, 3, 4, 3);
            provinceTxtbox.Name = "provinceTxtbox";
            provinceTxtbox.Size = new Size(337, 22);
            provinceTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Province:";
            // 
            // zipcodeTxtbox
            // 
            zipcodeTxtbox.BorderStyle = BorderStyle.FixedSingle;
            zipcodeTxtbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeTxtbox.Location = new Point(140, 280);
            zipcodeTxtbox.Margin = new Padding(4, 3, 4, 3);
            zipcodeTxtbox.Name = "zipcodeTxtbox";
            zipcodeTxtbox.Size = new Size(337, 22);
            zipcodeTxtbox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 278);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Zip Code:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(refreshBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(idTxtbox);
            groupBox1.Controls.Add(nameTxtbox);
            groupBox1.Controls.Add(contactTxtbox);
            groupBox1.Controls.Add(provinceTxtbox);
            groupBox1.Controls.Add(zipcodeTxtbox);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(735, 62);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(508, 401);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // refreshBtn
            // 
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Location = new Point(140, 342);
            refreshBtn.Margin = new Padding(4, 3, 4, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(98, 38);
            refreshBtn.TabIndex = 15;
            refreshBtn.Text = "REFRESH";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtnClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 11;
            label6.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 157);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 13;
            label7.Text = "Contact No.:";
            // 
            // idTxtbox
            // 
            idTxtbox.BorderStyle = BorderStyle.FixedSingle;
            idTxtbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            idTxtbox.Location = new Point(140, 36);
            idTxtbox.Margin = new Padding(4, 3, 4, 3);
            idTxtbox.Name = "idTxtbox";
            idTxtbox.ReadOnly = true;
            idTxtbox.Size = new Size(70, 22);
            idTxtbox.TabIndex = 12;
            // 
            // contactTxtbox
            // 
            contactTxtbox.BorderStyle = BorderStyle.FixedSingle;
            contactTxtbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            contactTxtbox.Location = new Point(138, 157);
            contactTxtbox.Margin = new Padding(4, 3, 4, 3);
            contactTxtbox.Name = "contactTxtbox";
            contactTxtbox.Size = new Size(337, 22);
            contactTxtbox.TabIndex = 14;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Location = new Point(24, 342);
            addBtn.Margin = new Padding(4, 3, 4, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(98, 38);
            addBtn.TabIndex = 11;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtnClick;
            // 
            // updateBtn
            // 
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Location = new Point(260, 342);
            updateBtn.Margin = new Padding(4, 3, 4, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(98, 38);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtnClick;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(379, 342);
            deleteBtn.Margin = new Padding(4, 3, 4, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(98, 38);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtnClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(743, 22);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 14;
            label8.Text = "Find";
            // 
            // searchbox
            // 
            searchbox.BorderStyle = BorderStyle.FixedSingle;
            searchbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchbox.Location = new Point(932, 20);
            searchbox.Margin = new Padding(4, 3, 4, 3);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(211, 26);
            searchbox.TabIndex = 15;
            // 
            // searchBtn
            // 
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.Location = new Point(1150, 19);
            searchBtn.Margin = new Padding(4, 3, 4, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(88, 29);
            searchBtn.TabIndex = 16;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtnClick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "Province" });
            comboBox1.Location = new Point(790, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 25);
            comboBox1.TabIndex = 16;
            // 
            // PhonebookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1256, 474);
            Controls.Add(comboBox1);
            Controls.Add(searchBtn);
            Controls.Add(searchbox);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "PhonebookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phonebook";
            Activated += PhonebookForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private TextBox nameTxtbox;
        private TextBox provinceTxtbox;
        private Label label3;
        private TextBox zipcodeTxtbox;
        private Label label4;
        private GroupBox groupBox1;
        private Button addBtn;
        private Label label6;
        private TextBox idTxtbox;
        private Button deleteBtn;
        private Button updateBtn;
        private TextBox contactTxtbox;
        private Label label7;
        private Label label8;
        private TextBox searchbox;
        private Button searchBtn;
        private Button refreshBtn;
        private DataGridViewTextBoxColumn ID_COLUMN;
        private DataGridViewTextBoxColumn NAME_COLUMN;
        private DataGridViewTextBoxColumn CONTACTNO_COLUMN;
        private DataGridViewTextBoxColumn PROVINCE_COLUMN;
        private DataGridViewTextBoxColumn ZIPCODE_COLUMN;
        private ComboBox comboBox1;
    }
}

