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
            this.idTxtbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
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
            this.ADDRESS_COLUMN,
            this.PROVINCE_COLUMN,
            this.ZIPCODE_COLUMN,
            this.COUNTRY_COLUMN});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 294);
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
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtbox.Location = new System.Drawing.Point(92, 74);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(289, 22);
            this.nameTxtbox.TabIndex = 2;
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtbox.Location = new System.Drawing.Point(92, 124);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(289, 22);
            this.addressTxtbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // provinceTxtbox
            // 
            this.provinceTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.provinceTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceTxtbox.Location = new System.Drawing.Point(92, 175);
            this.provinceTxtbox.Name = "provinceTxtbox";
            this.provinceTxtbox.Size = new System.Drawing.Size(289, 22);
            this.provinceTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Province:";
            // 
            // zipcodeTxtbox
            // 
            this.zipcodeTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipcodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeTxtbox.Location = new System.Drawing.Point(92, 225);
            this.zipcodeTxtbox.Name = "zipcodeTxtbox";
            this.zipcodeTxtbox.Size = new System.Drawing.Size(289, 22);
            this.zipcodeTxtbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zip Code:";
            // 
            // countryTxtbox
            // 
            this.countryTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTxtbox.Location = new System.Drawing.Point(91, 273);
            this.countryTxtbox.Name = "countryTxtbox";
            this.countryTxtbox.Size = new System.Drawing.Size(289, 22);
            this.countryTxtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.idTxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countryTxtbox);
            this.groupBox1.Controls.Add(this.nameTxtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.zipcodeTxtbox);
            this.groupBox1.Controls.Add(this.addressTxtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.provinceTxtbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 314);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // idTxtbox
            // 
            this.idTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtbox.Location = new System.Drawing.Point(91, 29);
            this.idTxtbox.Name = "idTxtbox";
            this.idTxtbox.ReadOnly = true;
            this.idTxtbox.Size = new System.Drawing.Size(60, 22);
            this.idTxtbox.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(475, 327);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 33);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtnClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(475, 395);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 33);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtnClick);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Location = new System.Drawing.Point(475, 460);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(84, 33);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtnClick);
            // 
            // PhonebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 638);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhonebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn ID_COLUMN;
        private DataGridViewTextBoxColumn NAME_COLUMN;
        private DataGridViewTextBoxColumn ADDRESS_COLUMN;
        private DataGridViewTextBoxColumn PROVINCE_COLUMN;
        private DataGridViewTextBoxColumn ZIPCODE_COLUMN;
        private DataGridViewTextBoxColumn COUNTRY_COLUMN;
        private Label label6;
        private TextBox idTxtbox;
        private Button deleteBtn;
        private Button updateBtn;
    }
}

