namespace CapstoneProj.Views
{
    partial class ManageStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblManageStudent = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblinputFields = new System.Windows.Forms.TableLayoutPanel();
            this.tblfirstLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tblBirthDate = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tblMiddleName = new System.Windows.Forms.TableLayoutPanel();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tblFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tblLastName = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tblStudentNo = new System.Windows.Forms.TableLayoutPanel();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblSecondLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.tblManageStudent.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.tblinputFields.SuspendLayout();
            this.tblfirstLevel.SuspendLayout();
            this.tblBirthDate.SuspendLayout();
            this.tblMiddleName.SuspendLayout();
            this.tblFirstName.SuspendLayout();
            this.tblLastName.SuspendLayout();
            this.tblStudentNo.SuspendLayout();
            this.tblSecondLevel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tblManageStudent
            // 
            this.tblManageStudent.ColumnCount = 1;
            this.tblManageStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblManageStudent.Controls.Add(this.tblHeader, 0, 0);
            this.tblManageStudent.Controls.Add(this.tblinputFields, 0, 2);
            this.tblManageStudent.Controls.Add(this.dgvStudent, 0, 1);
            this.tblManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblManageStudent.Location = new System.Drawing.Point(0, 0);
            this.tblManageStudent.Name = "tblManageStudent";
            this.tblManageStudent.RowCount = 3;
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tblManageStudent.Size = new System.Drawing.Size(1540, 846);
            this.tblManageStudent.TabIndex = 0;
            // 
            // tblHeader
            // 
            this.tblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.tblHeader.ColumnCount = 5;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.36115F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59583F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.74707F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tblHeader.Controls.Add(this.btnExcel, 3, 0);
            this.tblHeader.Controls.Add(this.btnIndex, 4, 0);
            this.tblHeader.Controls.Add(this.lblHeader, 0, 0);
            this.tblHeader.Location = new System.Drawing.Point(3, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(1534, 61);
            this.tblHeader.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(1241, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(171, 55);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Import Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIndex.FlatAppearance.BorderSize = 0;
            this.btnIndex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIndex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnIndex.ForeColor = System.Drawing.Color.White;
            this.btnIndex.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIndex.Location = new System.Drawing.Point(1418, 3);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(113, 55);
            this.btnIndex.TabIndex = 6;
            this.btnIndex.Text = "Back";
            this.btnIndex.UseVisualStyleBackColor = false;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(269, 38);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Manage Student";
            // 
            // tblinputFields
            // 
            this.tblinputFields.ColumnCount = 1;
            this.tblinputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblinputFields.Controls.Add(this.tblfirstLevel, 0, 0);
            this.tblinputFields.Controls.Add(this.tblSecondLevel, 0, 1);
            this.tblinputFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblinputFields.Location = new System.Drawing.Point(3, 619);
            this.tblinputFields.Name = "tblinputFields";
            this.tblinputFields.RowCount = 2;
            this.tblinputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.85076F));
            this.tblinputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.14925F));
            this.tblinputFields.Size = new System.Drawing.Size(1534, 224);
            this.tblinputFields.TabIndex = 1;
            // 
            // tblfirstLevel
            // 
            this.tblfirstLevel.ColumnCount = 5;
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.Controls.Add(this.tblBirthDate, 4, 0);
            this.tblfirstLevel.Controls.Add(this.tblMiddleName, 3, 0);
            this.tblfirstLevel.Controls.Add(this.tblFirstName, 2, 0);
            this.tblfirstLevel.Controls.Add(this.tblLastName, 1, 0);
            this.tblfirstLevel.Controls.Add(this.tblStudentNo, 0, 0);
            this.tblfirstLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblfirstLevel.Location = new System.Drawing.Point(3, 3);
            this.tblfirstLevel.Name = "tblfirstLevel";
            this.tblfirstLevel.RowCount = 1;
            this.tblfirstLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblfirstLevel.Size = new System.Drawing.Size(1528, 105);
            this.tblfirstLevel.TabIndex = 0;
            // 
            // tblBirthDate
            // 
            this.tblBirthDate.ColumnCount = 1;
            this.tblBirthDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBirthDate.Controls.Add(this.label5, 0, 0);
            this.tblBirthDate.Controls.Add(this.dtpBirthDate, 0, 1);
            this.tblBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBirthDate.Location = new System.Drawing.Point(1223, 3);
            this.tblBirthDate.Name = "tblBirthDate";
            this.tblBirthDate.RowCount = 2;
            this.tblBirthDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblBirthDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblBirthDate.Size = new System.Drawing.Size(302, 99);
            this.tblBirthDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(3, 42);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(296, 49);
            this.dtpBirthDate.TabIndex = 2;
            this.dtpBirthDate.Value = new System.DateTime(2023, 7, 30, 7, 34, 1, 0);
            // 
            // tblMiddleName
            // 
            this.tblMiddleName.ColumnCount = 1;
            this.tblMiddleName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMiddleName.Controls.Add(this.txtMiddleName, 0, 1);
            this.tblMiddleName.Controls.Add(this.lblMiddleName, 0, 0);
            this.tblMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMiddleName.Location = new System.Drawing.Point(918, 3);
            this.tblMiddleName.Name = "tblMiddleName";
            this.tblMiddleName.RowCount = 2;
            this.tblMiddleName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMiddleName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMiddleName.Size = new System.Drawing.Size(299, 99);
            this.tblMiddleName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtMiddleName.Location = new System.Drawing.Point(3, 42);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(293, 53);
            this.txtMiddleName.TabIndex = 0;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMiddleName.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(3, 6);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(293, 33);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Middlename";
            // 
            // tblFirstName
            // 
            this.tblFirstName.ColumnCount = 1;
            this.tblFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFirstName.Controls.Add(this.txtFirstName, 0, 1);
            this.tblFirstName.Controls.Add(this.lblFirstName, 0, 0);
            this.tblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFirstName.Location = new System.Drawing.Point(613, 3);
            this.tblFirstName.Name = "tblFirstName";
            this.tblFirstName.RowCount = 2;
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblFirstName.Size = new System.Drawing.Size(299, 99);
            this.tblFirstName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtFirstName.Location = new System.Drawing.Point(3, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(293, 53);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFirstName.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(293, 33);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Firstname";
            // 
            // tblLastName
            // 
            this.tblLastName.ColumnCount = 1;
            this.tblLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLastName.Controls.Add(this.txtLastName, 0, 1);
            this.tblLastName.Controls.Add(this.lblLastName, 0, 0);
            this.tblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLastName.Location = new System.Drawing.Point(308, 3);
            this.tblLastName.Name = "tblLastName";
            this.tblLastName.RowCount = 2;
            this.tblLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLastName.Size = new System.Drawing.Size(299, 99);
            this.tblLastName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtLastName.Location = new System.Drawing.Point(3, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(293, 53);
            this.txtLastName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLastName.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(293, 33);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Lastname";
            // 
            // tblStudentNo
            // 
            this.tblStudentNo.ColumnCount = 1;
            this.tblStudentNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudentNo.Controls.Add(this.txtStudentNo, 0, 1);
            this.tblStudentNo.Controls.Add(this.label1, 0, 0);
            this.tblStudentNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudentNo.Location = new System.Drawing.Point(3, 3);
            this.tblStudentNo.Name = "tblStudentNo";
            this.tblStudentNo.RowCount = 2;
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblStudentNo.Size = new System.Drawing.Size(299, 99);
            this.tblStudentNo.TabIndex = 0;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNo.Location = new System.Drawing.Point(3, 42);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(293, 53);
            this.txtStudentNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student No";
            // 
            // tblSecondLevel
            // 
            this.tblSecondLevel.ColumnCount = 5;
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tblSecondLevel.Controls.Add(this.btnCreateUpdate, 4, 0);
            this.tblSecondLevel.Controls.Add(this.btnDelete, 3, 0);
            this.tblSecondLevel.Controls.Add(this.btnClear, 2, 0);
            this.tblSecondLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSecondLevel.Location = new System.Drawing.Point(3, 114);
            this.tblSecondLevel.Name = "tblSecondLevel";
            this.tblSecondLevel.RowCount = 1;
            this.tblSecondLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSecondLevel.Size = new System.Drawing.Size(1528, 107);
            this.tblSecondLevel.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cmbCourse, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblCourse, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(308, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(299, 101);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbCourse.Location = new System.Drawing.Point(3, 43);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(293, 54);
            this.cmbCourse.TabIndex = 4;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCourse.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(3, 7);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(293, 33);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.cmbGender, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblGender, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(299, 101);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(3, 43);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(293, 54);
            this.cmbGender.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGender.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(3, 7);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(293, 33);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // btnCreateUpdate
            // 
            this.btnCreateUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateUpdate.FlatAppearance.BorderSize = 0;
            this.btnCreateUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCreateUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnCreateUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCreateUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateUpdate.Location = new System.Drawing.Point(1238, 34);
            this.btnCreateUpdate.Margin = new System.Windows.Forms.Padding(18);
            this.btnCreateUpdate.Name = "btnCreateUpdate";
            this.btnCreateUpdate.Size = new System.Drawing.Size(272, 55);
            this.btnCreateUpdate.TabIndex = 7;
            this.btnCreateUpdate.Text = "Create";
            this.btnCreateUpdate.UseVisualStyleBackColor = false;
            this.btnCreateUpdate.Click += new System.EventHandler(this.btnCreateUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(933, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(269, 55);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(628, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(269, 55);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dgvStudent.Location = new System.Drawing.Point(4, 71);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1532, 541);
            this.dgvStudent.TabIndex = 18;
            this.dgvStudent.TabStop = false;
            this.dgvStudent.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudent_CellMouseDoubleClick);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.tblManageStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.tblManageStudent.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblinputFields.ResumeLayout(false);
            this.tblfirstLevel.ResumeLayout(false);
            this.tblBirthDate.ResumeLayout(false);
            this.tblBirthDate.PerformLayout();
            this.tblMiddleName.ResumeLayout(false);
            this.tblMiddleName.PerformLayout();
            this.tblFirstName.ResumeLayout(false);
            this.tblFirstName.PerformLayout();
            this.tblLastName.ResumeLayout(false);
            this.tblLastName.PerformLayout();
            this.tblStudentNo.ResumeLayout(false);
            this.tblStudentNo.PerformLayout();
            this.tblSecondLevel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblManageStudent;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.TableLayoutPanel tblinputFields;
        private System.Windows.Forms.TableLayoutPanel tblfirstLevel;
        private System.Windows.Forms.TableLayoutPanel tblBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TableLayoutPanel tblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TableLayoutPanel tblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TableLayoutPanel tblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TableLayoutPanel tblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblSecondLevel;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
    }
}