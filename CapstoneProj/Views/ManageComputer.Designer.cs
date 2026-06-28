
namespace CapstoneProj.Views
{
    partial class ManageComputer
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
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tblManageStudent = new System.Windows.Forms.TableLayoutPanel();
            this.tblinputFields = new System.Windows.Forms.TableLayoutPanel();
            this.tblfirstLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tblFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.txtComputerCode = new System.Windows.Forms.TextBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.tblLastName = new System.Windows.Forms.TableLayoutPanel();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.tblStudentNo = new System.Windows.Forms.TableLayoutPanel();
            this.cmbLaboratory = new System.Windows.Forms.ComboBox();
            this.lblLaboratory = new System.Windows.Forms.Label();
            this.tblSecondLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtComputerId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbIsActive = new System.Windows.Forms.RadioButton();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvComputer = new System.Windows.Forms.DataGridView();
            this.tblHeader.SuspendLayout();
            this.tblManageStudent.SuspendLayout();
            this.tblinputFields.SuspendLayout();
            this.tblfirstLevel.SuspendLayout();
            this.tblFirstName.SuspendLayout();
            this.tblLastName.SuspendLayout();
            this.tblStudentNo.SuspendLayout();
            this.tblSecondLevel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            this.SuspendLayout();
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
            this.lblHeader.Size = new System.Drawing.Size(301, 38);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Manage Computer";
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
            // tblManageStudent
            // 
            this.tblManageStudent.ColumnCount = 1;
            this.tblManageStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblManageStudent.Controls.Add(this.tblinputFields, 0, 2);
            this.tblManageStudent.Controls.Add(this.tblHeader, 0, 0);
            this.tblManageStudent.Controls.Add(this.dgvComputer, 0, 1);
            this.tblManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblManageStudent.Location = new System.Drawing.Point(0, 0);
            this.tblManageStudent.Name = "tblManageStudent";
            this.tblManageStudent.RowCount = 3;
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tblManageStudent.Size = new System.Drawing.Size(1540, 846);
            this.tblManageStudent.TabIndex = 4;
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
            this.tblinputFields.TabIndex = 19;
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
            // tblFirstName
            // 
            this.tblFirstName.ColumnCount = 1;
            this.tblFirstName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFirstName.Controls.Add(this.txtComputerCode, 0, 1);
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
            // txtComputerCode
            // 
            this.txtComputerCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComputerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtComputerCode.Location = new System.Drawing.Point(3, 42);
            this.txtComputerCode.Name = "txtComputerCode";
            this.txtComputerCode.Size = new System.Drawing.Size(498, 53);
            this.txtComputerCode.TabIndex = 5;
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
            this.lblDateTo.Text = "Computer Code Name";
            // 
            // tblLastName
            // 
            this.tblLastName.ColumnCount = 1;
            this.tblLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLastName.Controls.Add(this.txtComputerName, 0, 1);
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
            // txtComputerName
            // 
            this.txtComputerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtComputerName.Location = new System.Drawing.Point(3, 42);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(497, 53);
            this.txtComputerName.TabIndex = 5;
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
            this.lblDateFrom.Text = "Computer Name";
            // 
            // tblStudentNo
            // 
            this.tblStudentNo.ColumnCount = 1;
            this.tblStudentNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudentNo.Controls.Add(this.cmbLaboratory, 0, 1);
            this.tblStudentNo.Controls.Add(this.lblLaboratory, 0, 0);
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
            // cmbLaboratory
            // 
            this.cmbLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmbLaboratory.FormattingEnabled = true;
            this.cmbLaboratory.Location = new System.Drawing.Point(3, 42);
            this.cmbLaboratory.Name = "cmbLaboratory";
            this.cmbLaboratory.Size = new System.Drawing.Size(497, 54);
            this.cmbLaboratory.TabIndex = 3;
            this.cmbLaboratory.SelectedIndexChanged += new System.EventHandler(this.cmbLaboratory_SelectedIndexChanged);
            // 
            // lblLaboratory
            // 
            this.lblLaboratory.AutoSize = true;
            this.lblLaboratory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLaboratory.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratory.Location = new System.Drawing.Point(3, 6);
            this.lblLaboratory.Name = "lblLaboratory";
            this.lblLaboratory.Size = new System.Drawing.Size(497, 33);
            this.lblLaboratory.TabIndex = 2;
            this.lblLaboratory.Text = "Laboratory";
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
            this.tableLayoutPanel5.Controls.Add(this.txtComputerId, 0, 0);
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
            // txtComputerId
            // 
            this.txtComputerId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComputerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtComputerId.Location = new System.Drawing.Point(3, 3);
            this.txtComputerId.Name = "txtComputerId";
            this.txtComputerId.Size = new System.Drawing.Size(242, 53);
            this.txtComputerId.TabIndex = 4;
            this.txtComputerId.Visible = false;
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
            // dgvComputer
            // 
            this.dgvComputer.AllowUserToAddRows = false;
            this.dgvComputer.AllowUserToDeleteRows = false;
            this.dgvComputer.AllowUserToResizeColumns = false;
            this.dgvComputer.AllowUserToResizeRows = false;
            this.dgvComputer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComputer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvComputer.BackgroundColor = System.Drawing.Color.White;
            this.dgvComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComputer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComputer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dgvComputer.Location = new System.Drawing.Point(4, 71);
            this.dgvComputer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComputer.RowHeadersWidth = 51;
            this.dgvComputer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputer.Size = new System.Drawing.Size(1532, 541);
            this.dgvComputer.TabIndex = 18;
            this.dgvComputer.TabStop = false;
            this.dgvComputer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComputer_CellMouseDoubleClick);
            // 
            // ManageComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.tblManageStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageComputer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageComputer_Load);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblManageStudent.ResumeLayout(false);
            this.tblinputFields.ResumeLayout(false);
            this.tblfirstLevel.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.TableLayoutPanel tblManageStudent;
        private System.Windows.Forms.DataGridView dgvComputer;
        private System.Windows.Forms.TableLayoutPanel tblinputFields;
        private System.Windows.Forms.TableLayoutPanel tblfirstLevel;
        private System.Windows.Forms.TableLayoutPanel tblFirstName;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.TableLayoutPanel tblLastName;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TableLayoutPanel tblStudentNo;
        private System.Windows.Forms.Label lblLaboratory;
        private System.Windows.Forms.TableLayoutPanel tblSecondLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtComputerId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rdbIsActive;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtComputerCode;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.ComboBox cmbLaboratory;
    }
}