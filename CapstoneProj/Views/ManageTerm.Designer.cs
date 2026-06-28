
namespace CapstoneProj.Views
{
    partial class ManageTerm
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
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.tblfirstLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tblLastName = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.tblStudentNo = new System.Windows.Forms.TableLayoutPanel();
            this.txtTermName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tblinputFields = new System.Windows.Forms.TableLayoutPanel();
            this.tblSecondLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTermId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbIsActive = new System.Windows.Forms.RadioButton();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tblManageStudent = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTerm = new System.Windows.Forms.DataGridView();
            this.tblHeader.SuspendLayout();
            this.tblFirstName.SuspendLayout();
            this.tblfirstLevel.SuspendLayout();
            this.tblLastName.SuspendLayout();
            this.tblStudentNo.SuspendLayout();
            this.tblinputFields.SuspendLayout();
            this.tblSecondLevel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tblManageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHeader
            // 
            this.tblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.tblHeader.ColumnCount = 2;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblHeader.Controls.Add(this.btnIndex, 0, 0);
            this.tblHeader.Controls.Add(this.lblHeader, 0, 0);
            this.tblHeader.Location = new System.Drawing.Point(3, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(1534, 61);
            this.tblHeader.TabIndex = 0;
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
            this.btnIndex.Location = new System.Drawing.Point(1383, 3);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(148, 55);
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
            this.lblHeader.Size = new System.Drawing.Size(230, 38);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Manage Term";
            // 
            // tblFirstName
            // 
            this.tblFirstName.ColumnCount = 1;
            this.tblFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFirstName.Controls.Add(this.dtpDateTo, 0, 1);
            this.tblFirstName.Controls.Add(this.lblDateTo, 0, 0);
            this.tblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFirstName.Location = new System.Drawing.Point(1021, 3);
            this.tblFirstName.Name = "tblFirstName";
            this.tblFirstName.RowCount = 2;
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblFirstName.Size = new System.Drawing.Size(504, 99);
            this.tblFirstName.TabIndex = 2;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDateTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dtpDateTo.CustomFormat = "yyyy-MM-dd";
            this.dtpDateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(3, 42);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(498, 49);
            this.dtpDateTo.TabIndex = 5;
            this.dtpDateTo.Value = new System.DateTime(2023, 7, 30, 7, 34, 1, 0);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDateTo.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(3, 6);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(498, 33);
            this.lblDateTo.TabIndex = 4;
            this.lblDateTo.Text = "Date To";
            // 
            // tblfirstLevel
            // 
            this.tblfirstLevel.ColumnCount = 3;
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblfirstLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
            // tblLastName
            // 
            this.tblLastName.ColumnCount = 1;
            this.tblLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLastName.Controls.Add(this.dtpDateFrom, 0, 1);
            this.tblLastName.Controls.Add(this.lblDateFrom, 0, 0);
            this.tblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLastName.Location = new System.Drawing.Point(512, 3);
            this.tblLastName.Name = "tblLastName";
            this.tblLastName.RowCount = 2;
            this.tblLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLastName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLastName.Size = new System.Drawing.Size(503, 99);
            this.tblLastName.TabIndex = 1;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDateFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dtpDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpDateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(3, 42);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(497, 49);
            this.dtpDateFrom.TabIndex = 4;
            this.dtpDateFrom.Value = new System.DateTime(2023, 7, 30, 7, 34, 1, 0);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDateFrom.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(3, 6);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(497, 33);
            this.lblDateFrom.TabIndex = 3;
            this.lblDateFrom.Text = "Date From";
            // 
            // tblStudentNo
            // 
            this.tblStudentNo.ColumnCount = 1;
            this.tblStudentNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudentNo.Controls.Add(this.txtTermName, 0, 1);
            this.tblStudentNo.Controls.Add(this.lblLastName, 0, 0);
            this.tblStudentNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudentNo.Location = new System.Drawing.Point(3, 3);
            this.tblStudentNo.Name = "tblStudentNo";
            this.tblStudentNo.RowCount = 2;
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudentNo.Size = new System.Drawing.Size(503, 99);
            this.tblStudentNo.TabIndex = 0;
            // 
            // txtTermName
            // 
            this.txtTermName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtTermName.Location = new System.Drawing.Point(3, 42);
            this.txtTermName.Name = "txtTermName";
            this.txtTermName.Size = new System.Drawing.Size(497, 53);
            this.txtTermName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLastName.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(497, 33);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Term Name";
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
            // tblSecondLevel
            // 
            this.tblSecondLevel.ColumnCount = 6;
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tblSecondLevel.Controls.Add(this.btnCreateUpdate, 5, 0);
            this.tblSecondLevel.Controls.Add(this.btnDelete, 4, 0);
            this.tblSecondLevel.Controls.Add(this.btnClear, 3, 0);
            this.tblSecondLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSecondLevel.Location = new System.Drawing.Point(3, 114);
            this.tblSecondLevel.Name = "tblSecondLevel";
            this.tblSecondLevel.RowCount = 1;
            this.tblSecondLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSecondLevel.Size = new System.Drawing.Size(1528, 107);
            this.tblSecondLevel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(511, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 101);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtTermId, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(257, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(248, 101);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // txtTermId
            // 
            this.txtTermId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtTermId.Location = new System.Drawing.Point(3, 3);
            this.txtTermId.Name = "txtTermId";
            this.txtTermId.Size = new System.Drawing.Size(242, 53);
            this.txtTermId.TabIndex = 4;
            this.txtTermId.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel6.Controls.Add(this.rdbIsActive, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(248, 101);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // rdbIsActive
            // 
            this.rdbIsActive.AutoSize = true;
            this.rdbIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbIsActive.FlatAppearance.BorderSize = 0;
            this.rdbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbIsActive.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold);
            this.rdbIsActive.Location = new System.Drawing.Point(17, 3);
            this.rdbIsActive.Name = "rdbIsActive";
            this.rdbIsActive.Size = new System.Drawing.Size(125, 34);
            this.rdbIsActive.TabIndex = 0;
            this.rdbIsActive.TabStop = true;
            this.rdbIsActive.Text = "IsActive";
            this.rdbIsActive.UseVisualStyleBackColor = true;
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
            this.btnCreateUpdate.Location = new System.Drawing.Point(1288, 34);
            this.btnCreateUpdate.Margin = new System.Windows.Forms.Padding(18);
            this.btnCreateUpdate.Name = "btnCreateUpdate";
            this.btnCreateUpdate.Size = new System.Drawing.Size(222, 55);
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
            this.btnDelete.Location = new System.Drawing.Point(1034, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 55);
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
            this.btnClear.Location = new System.Drawing.Point(780, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(218, 55);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tblManageStudent
            // 
            this.tblManageStudent.ColumnCount = 1;
            this.tblManageStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblManageStudent.Controls.Add(this.tblHeader, 0, 0);
            this.tblManageStudent.Controls.Add(this.tblinputFields, 0, 2);
            this.tblManageStudent.Controls.Add(this.dgvTerm, 0, 1);
            this.tblManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblManageStudent.Location = new System.Drawing.Point(0, 0);
            this.tblManageStudent.Name = "tblManageStudent";
            this.tblManageStudent.RowCount = 3;
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tblManageStudent.Size = new System.Drawing.Size(1540, 846);
            this.tblManageStudent.TabIndex = 2;
            // 
            // dgvTerm
            // 
            this.dgvTerm.AllowUserToAddRows = false;
            this.dgvTerm.AllowUserToDeleteRows = false;
            this.dgvTerm.AllowUserToResizeColumns = false;
            this.dgvTerm.AllowUserToResizeRows = false;
            this.dgvTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTerm.BackgroundColor = System.Drawing.Color.White;
            this.dgvTerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dgvTerm.Location = new System.Drawing.Point(4, 71);
            this.dgvTerm.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTerm.Name = "dgvTerm";
            this.dgvTerm.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTerm.RowHeadersWidth = 51;
            this.dgvTerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerm.Size = new System.Drawing.Size(1532, 541);
            this.dgvTerm.TabIndex = 18;
            this.dgvTerm.TabStop = false;
            this.dgvTerm.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTerm_CellMouseDoubleClick);
            // 
            // ManageTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.tblManageStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageTerm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageTerm_Load);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblFirstName.ResumeLayout(false);
            this.tblFirstName.PerformLayout();
            this.tblfirstLevel.ResumeLayout(false);
            this.tblLastName.ResumeLayout(false);
            this.tblLastName.PerformLayout();
            this.tblStudentNo.ResumeLayout(false);
            this.tblStudentNo.PerformLayout();
            this.tblinputFields.ResumeLayout(false);
            this.tblSecondLevel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tblManageStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tblFirstName;
        private System.Windows.Forms.TableLayoutPanel tblfirstLevel;
        private System.Windows.Forms.TableLayoutPanel tblLastName;
        private System.Windows.Forms.TableLayoutPanel tblStudentNo;
        private System.Windows.Forms.TextBox txtTermName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TableLayoutPanel tblinputFields;
        private System.Windows.Forms.TableLayoutPanel tblSecondLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tblManageStudent;
        private System.Windows.Forms.DataGridView dgvTerm;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.RadioButton rdbIsActive;
        private System.Windows.Forms.TextBox txtTermId;
    }
}