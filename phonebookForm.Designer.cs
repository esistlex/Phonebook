using System.Windows.Forms;

namespace phonebook1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACTNO_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCE_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIPCODE_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRY_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.provinceTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zipcodeTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countryTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTxtbox = new System.Windows.Forms.TextBox();
            this.contactTxtbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COLUMN,
            this.NAME_COLUMN,
            this.CONTACTNO_COLUMN,
            this.ADDRESS_COLUMN,
            this.PROVINCE_COLUMN,
            this.ZIPCODE_COLUMN,
            this.COUNTRY_COLUMN});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 503);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_COLUMN
            // 
            this.ID_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_COLUMN.HeaderText = "ID";
            this.ID_COLUMN.Name = "ID_COLUMN";
            this.ID_COLUMN.ReadOnly = true;
            this.ID_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_COLUMN.Width = 43;
            // 
            // NAME_COLUMN
            // 
            this.NAME_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME_COLUMN.HeaderText = "NAME";
            this.NAME_COLUMN.Name = "NAME_COLUMN";
            this.NAME_COLUMN.ReadOnly = true;
            this.NAME_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CONTACTNO_COLUMN
            // 
            this.CONTACTNO_COLUMN.HeaderText = "CONTACT NO.";
            this.CONTACTNO_COLUMN.Name = "CONTACTNO_COLUMN";
            this.CONTACTNO_COLUMN.ReadOnly = true;
            this.CONTACTNO_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CONTACTNO_COLUMN.Width = 105;
            // 
            // ADDRESS_COLUMN
            // 
            this.ADDRESS_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADDRESS_COLUMN.HeaderText = "ADDRESS";
            this.ADDRESS_COLUMN.Name = "ADDRESS_COLUMN";
            this.ADDRESS_COLUMN.ReadOnly = true;
            this.ADDRESS_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PROVINCE_COLUMN
            // 
            this.PROVINCE_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PROVINCE_COLUMN.HeaderText = "PROVINCE";
            this.PROVINCE_COLUMN.Name = "PROVINCE_COLUMN";
            this.PROVINCE_COLUMN.ReadOnly = true;
            this.PROVINCE_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ZIPCODE_COLUMN
            // 
            this.ZIPCODE_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZIPCODE_COLUMN.HeaderText = "ZIP CODE";
            this.ZIPCODE_COLUMN.Name = "ZIPCODE_COLUMN";
            this.ZIPCODE_COLUMN.ReadOnly = true;
            this.ZIPCODE_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // COUNTRY_COLUMN
            // 
            this.COUNTRY_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COUNTRY_COLUMN.HeaderText = "COUNTRY";
            this.COUNTRY_COLUMN.Name = "COUNTRY_COLUMN";
            this.COUNTRY_COLUMN.ReadOnly = true;
            this.COUNTRY_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtbox.Location = new System.Drawing.Point(120, 88);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(289, 22);
            this.nameTxtbox.TabIndex = 2;
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtbox.Location = new System.Drawing.Point(120, 193);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(289, 22);
            this.addressTxtbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // provinceTxtbox
            // 
            this.provinceTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provinceTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTxtbox.Location = new System.Drawing.Point(120, 246);
            this.provinceTxtbox.Name = "provinceTxtbox";
            this.provinceTxtbox.Size = new System.Drawing.Size(289, 22);
            this.provinceTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Province:";
            // 
            // zipcodeTxtbox
            // 
            this.zipcodeTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipcodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeTxtbox.Location = new System.Drawing.Point(120, 296);
            this.zipcodeTxtbox.Name = "zipcodeTxtbox";
            this.zipcodeTxtbox.Size = new System.Drawing.Size(289, 22);
            this.zipcodeTxtbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zip Code:";
            // 
            // countryTxtbox
            // 
            this.countryTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTxtbox.Location = new System.Drawing.Point(120, 347);
            this.countryTxtbox.Name = "countryTxtbox";
            this.countryTxtbox.Size = new System.Drawing.Size(289, 22);
            this.countryTxtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.idTxtbox);
            this.groupBox1.Controls.Add(this.nameTxtbox);
            this.groupBox1.Controls.Add(this.contactTxtbox);
            this.groupBox1.Controls.Add(this.addressTxtbox);
            this.groupBox1.Controls.Add(this.provinceTxtbox);
            this.groupBox1.Controls.Add(this.zipcodeTxtbox);
            this.groupBox1.Controls.Add(this.countryTxtbox);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(630, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 452);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact No.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Contact No.:";
            // 
            // idTxtbox
            // 
            this.idTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtbox.Location = new System.Drawing.Point(120, 37);
            this.idTxtbox.Name = "idTxtbox";
            this.idTxtbox.ReadOnly = true;
            this.idTxtbox.Size = new System.Drawing.Size(60, 22);
            this.idTxtbox.TabIndex = 12;
            // 
            // contactTxtbox
            // 
            this.contactTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTxtbox.Location = new System.Drawing.Point(120, 137);
            this.contactTxtbox.Name = "contactTxtbox";
            this.contactTxtbox.Size = new System.Drawing.Size(289, 22);
            this.contactTxtbox.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(40, 397);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 33);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtnClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(173, 397);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(84, 33);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtnClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(304, 397);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 33);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(634, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Find by Name:";
            // 
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(750, 24);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(234, 24);
            this.searchbox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(990, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PhonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhonebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.PhonebookForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private TextBox nameTxtbox;
        private TextBox addressTxtbox;
        private Label label2;
        private TextBox provinceTxtbox;
        private Label label3;
        private TextBox zipcodeTxtbox;
        private Label label4;
        private TextBox countryTxtbox;
        private Label label5;
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
        private Button button1;
        private DataGridViewTextBoxColumn ID_COLUMN;
        private DataGridViewTextBoxColumn NAME_COLUMN;
        private DataGridViewTextBoxColumn CONTACTNO_COLUMN;
        private DataGridViewTextBoxColumn ADDRESS_COLUMN;
        private DataGridViewTextBoxColumn PROVINCE_COLUMN;
        private DataGridViewTextBoxColumn ZIPCODE_COLUMN;
        private DataGridViewTextBoxColumn COUNTRY_COLUMN;
        private Label label9;
    }
}

