namespace Equipment_Manager
{
    partial class EquipmentManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            label1 = new Label();
            cmbStatus = new ComboBox();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txtLocation = new TextBox();
            label4 = new Label();
            txtCategory = new TextBox();
            label5 = new Label();
            txtEquipment = new TextBox();
            label3 = new Label();
            txtAssetTag = new TextBox();
            label2 = new Label();
            lblSearch = new Label();
            dgvEquipment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "    🖳 | Equipment Manager";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(409, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(524, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(122, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "⌕   Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = SystemColors.ControlLight;
            btnShowAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.MidnightBlue;
            btnShowAll.ImageAlign = ContentAlignment.MiddleRight;
            btnShowAll.Location = new Point(651, 54);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(122, 30);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(35, 268);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 6;
            label1.Text = "Selected Item Status : ";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(218, 266);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(146, 23);
            cmbStatus.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(380, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEquipment);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAssetTag);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(35, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 150);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Equipment";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(571, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Equipment";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(520, 62);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(132, 29);
            txtLocation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 35);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 6;
            label4.Text = "Location:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(357, 62);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(132, 29);
            txtCategory.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 35);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 4;
            label5.Text = "Category: ";
            // 
            // txtEquipment
            // 
            txtEquipment.Location = new Point(193, 62);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(132, 29);
            txtEquipment.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 35);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 2;
            label3.Text = "Equipment:";
            // 
            // txtAssetTag
            // 
            txtAssetTag.Location = new Point(34, 62);
            txtAssetTag.Name = "txtAssetTag";
            txtAssetTag.Size = new Size(132, 29);
            txtAssetTag.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 35);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 0;
            label2.Text = "Asset Tag: ";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.MidnightBlue;
            lblSearch.Location = new Point(36, 58);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 21);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search: ";
            // 
            // dgvEquipment
            // 
            dgvEquipment.AllowUserToAddRows = false;
            dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipment.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEquipment.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEquipment.EnableHeadersVisualStyles = false;
            dgvEquipment.GridColor = SystemColors.Menu;
            dgvEquipment.Location = new Point(36, 91);
            dgvEquipment.MultiSelect = false;
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.ReadOnly = true;
            dgvEquipment.RowHeadersVisible = false;
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipment.Size = new Size(737, 166);
            dgvEquipment.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Asset Tag";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Equipment";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Category";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Location";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // EquipmentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 470);
            Controls.Add(dgvEquipment);
            Controls.Add(lblSearch);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ButtonFace;
            Name = "EquipmentManager";
            Text = "Equipment Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private Label label1;
        private ComboBox cmbStatus;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private TextBox txtEquipment;
        private Label label3;
        private TextBox txtAssetTag;
        private Label label2;
        private TextBox txtLocation;
        private Label label4;
        private TextBox txtCategory;
        private Label label5;
        private Button btnAdd;
        private Label lblSearch;
        private DataGridView dgvEquipment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
