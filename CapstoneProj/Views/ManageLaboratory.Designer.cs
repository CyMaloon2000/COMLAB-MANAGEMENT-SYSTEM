
namespace CapstoneProj.Views
{
    partial class ManageLaboratory
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
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblinputFields = new System.Windows.Forms.TableLayoutPanel();
            this.tblfirstLevel = new System.Windows.Forms.TableLayoutPanel();
            this.tblFirstName = new System.Windows.Forms.TableLayoutPanel();
            this.txtCompCount = new System.Windows.Forms.TextBox();
            this.lblpc = new System.Windows.Forms.Label();
            this.tblLastName = new System.Windows.Forms.TableLayoutPanel();
            this.txtLabCode = new System.Windows.Forms.TextBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.tblStudentNo = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tblSecondLevel = new System.Windows.Forms.TableLayoutPanel();
            this.txtLaboratoryId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvLaboratory = new System.Windows.Forms.DataGridView();
            this.tblManageStudent.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.tblinputFields.SuspendLayout();
            this.tblfirstLevel.SuspendLayout();
            this.tblFirstName.SuspendLayout();
            this.tblLastName.SuspendLayout();
            this.tblStudentNo.SuspendLayout();
            this.tblSecondLevel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratory)).BeginInit();
            this.SuspendLayout();
            // 
            // tblManageStudent
            // 
            this.tblManageStudent.ColumnCount = 1;
            this.tblManageStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblManageStudent.Controls.Add(this.tblHeader, 0, 0);
            this.tblManageStudent.Controls.Add(this.tblinputFields, 0, 2);
            this.tblManageStudent.Controls.Add(this.dgvLaboratory, 0, 1);
            this.tblManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblManageStudent.Location = new System.Drawing.Point(0, 0);
            this.tblManageStudent.Name = "tblManageStudent";
            this.tblManageStudent.RowCount = 3;
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblManageStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tblManageStudent.Size = new System.Drawing.Size(1540, 846);
            this.tblManageStudent.TabIndex = 3;
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
            this.lblHeader.Size = new System.Drawing.Size(316, 38);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Manage Laboratory";
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
            this.tblFirstName.Controls.Add(this.txtCompCount, 0, 1);
            this.tblFirstName.Controls.Add(this.lblpc, 0, 0);
            this.tblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFirstName.Location = new System.Drawing.Point(1021, 3);
            this.tblFirstName.Name = "tblFirstName";
            this.tblFirstName.RowCount = 2;
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFirstName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblFirstName.Size = new System.Drawing.Size(504, 99);
            this.tblFirstName.TabIndex = 2;
            // 
            // txtCompCount
            // 
            this.txtCompCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtCompCount.Location = new System.Drawing.Point(3, 42);
            this.txtCompCount.Name = "txtCompCount";
            this.txtCompCount.Size = new System.Drawing.Size(498, 53);
            this.txtCompCount.TabIndex = 5;
            // 
            // lblpc
            // 
            this.lblpc.AutoSize = true;
            this.lblpc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblpc.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpc.Location = new System.Drawing.Point(3, 6);
            this.lblpc.Name = "lblpc";
            this.lblpc.Size = new System.Drawing.Size(498, 33);
            this.lblpc.TabIndex = 4;
            this.lblpc.Text = "No. of Computers";
            // 
            // tblLastName
            // 
            this.tblLastName.ColumnCount = 1;
            this.tblLastName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLastName.Controls.Add(this.txtLabCode, 0, 1);
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
            // txtLabCode
            // 
            this.txtLabCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLabCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtLabCode.Location = new System.Drawing.Point(3, 42);
            this.txtLabCode.Name = "txtLabCode";
            this.txtLabCode.Size = new System.Drawing.Size(497, 53);
            this.txtLabCode.TabIndex = 4;
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
            this.lblDateFrom.Text = "LaboratoryCode";
            // 
            // tblStudentNo
            // 
            this.tblStudentNo.ColumnCount = 1;
            this.tblStudentNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStudentNo.Controls.Add(this.txtName, 0, 1);
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
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtName.Location = new System.Drawing.Point(3, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(497, 53);
            this.txtName.TabIndex = 3;
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
            this.lblLastName.Text = "Name";
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
            this.tblSecondLevel.Controls.Add(this.txtLaboratoryId, 0, 0);
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblSecondLevel.Controls.Add(this.tableLayoutPanel5, 0, 0);
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
            // txtLaboratoryId
            // 
            this.txtLaboratoryId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLaboratoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtLaboratoryId.Location = new System.Drawing.Point(511, 3);
            this.txtLaboratoryId.Name = "txtLaboratoryId";
            this.txtLaboratoryId.Size = new System.Drawing.Size(248, 53);
            this.txtLaboratoryId.TabIndex = 12;
            this.txtLaboratoryId.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(257, 3);
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
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbActive, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(248, 101);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Flaticon", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "IsAcive";
            // 
            // cmbActive
            // 
            this.cmbActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbActive.Location = new System.Drawing.Point(3, 43);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(242, 54);
            this.cmbActive.TabIndex = 4;
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
            // dgvLaboratory
            // 
            this.dgvLaboratory.AllowUserToAddRows = false;
            this.dgvLaboratory.AllowUserToDeleteRows = false;
            this.dgvLaboratory.AllowUserToResizeColumns = false;
            this.dgvLaboratory.AllowUserToResizeRows = false;
            this.dgvLaboratory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaboratory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvLaboratory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaboratory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaboratory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLaboratory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLaboratory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaboratory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(191)))));
            this.dgvLaboratory.Location = new System.Drawing.Point(4, 71);
            this.dgvLaboratory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLaboratory.Name = "dgvLaboratory";
            this.dgvLaboratory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaboratory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLaboratory.RowHeadersWidth = 51;
            this.dgvLaboratory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratory.Size = new System.Drawing.Size(1532, 541);
            this.dgvLaboratory.TabIndex = 18;
            this.dgvLaboratory.TabStop = false;
            this.dgvLaboratory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLaboratory_CellMouseDoubleClick);
            // 
            // ManageLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.tblManageStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageLaboratory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageLaboratory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageLaboratory_Load);
            this.tblManageStudent.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblinputFields.ResumeLayout(false);
            this.tblfirstLevel.ResumeLayout(false);
            this.tblFirstName.ResumeLayout(false);
            this.tblFirstName.PerformLayout();
            this.tblLastName.ResumeLayout(false);
            this.tblLastName.PerformLayout();
            this.tblStudentNo.ResumeLayout(false);
            this.tblStudentNo.PerformLayout();
            this.tblSecondLevel.ResumeLayout(false);
            this.tblSecondLevel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblManageStudent;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tblinputFields;
        private System.Windows.Forms.TableLayoutPanel tblfirstLevel;
        private System.Windows.Forms.TableLayoutPanel tblLastName;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TableLayoutPanel tblStudentNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TableLayoutPanel tblSecondLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvLaboratory;
        private System.Windows.Forms.TextBox txtLabCode;
        private System.Windows.Forms.TextBox txtLaboratoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.TableLayoutPanel tblFirstName;
        private System.Windows.Forms.TextBox txtCompCount;
        private System.Windows.Forms.Label lblpc;
    }
}