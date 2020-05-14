namespace TestX
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this._Label4 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this.dtpEmpDOJ = new System.Windows.Forms.DateTimePicker();
            this._Label1 = new System.Windows.Forms.Label();
            this.cbEmpDesig = new System.Windows.Forms.ComboBox();
            this._Label5 = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this._GroupBox2 = new System.Windows.Forms.GroupBox();
            this._PicStudent = new System.Windows.Forms.PictureBox();
            this._PicStdCamera = new System.Windows.Forms.PictureBox();
            this._PicStdRemove = new System.Windows.Forms.PictureBox();
            this._PicStdBrowse = new System.Windows.Forms.PictureBox();
            this._Label2 = new System.Windows.Forms.Label();
            this._Panel4 = new System.Windows.Forms.Panel();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmpStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpWages = new System.Windows.Forms.ComboBox();
            this.cbEmpName = new System.Windows.Forms.ComboBox();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this._Panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this._cmdPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEmpAddEmp = new System.Windows.Forms.Button();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this._GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PicStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdBrowse)).BeginInit();
            this._Panel4.SuspendLayout();
            this._GroupBox1.SuspendLayout();
            this._Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label4.Location = new System.Drawing.Point(16, 170);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(56, 23);
            this._Label4.TabIndex = 1169;
            this._Label4.Text = "Wages";
            this._Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label6.Location = new System.Drawing.Point(16, 54);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(101, 23);
            this._Label6.TabIndex = 1168;
            this._Label6.Text = "Employee ID";
            this._Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label3.Location = new System.Drawing.Point(16, 145);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(120, 23);
            this._Label3.TabIndex = 1166;
            this._Label3.Text = "Date of Joining";
            this._Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEmpDOJ
            // 
            this.dtpEmpDOJ.CustomFormat = "dd/MMM/yyyy";
            this.dtpEmpDOJ.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpDOJ.Location = new System.Drawing.Point(183, 144);
            this.dtpEmpDOJ.Name = "dtpEmpDOJ";
            this.dtpEmpDOJ.Size = new System.Drawing.Size(257, 22);
            this.dtpEmpDOJ.TabIndex = 1165;
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(16, 84);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(97, 23);
            this._Label1.TabIndex = 1163;
            this._Label1.Text = "Designation";
            this._Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEmpDesig
            // 
            this.cbEmpDesig.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpDesig.Location = new System.Drawing.Point(183, 83);
            this.cbEmpDesig.Name = "cbEmpDesig";
            this.cbEmpDesig.Size = new System.Drawing.Size(257, 29);
            this.cbEmpDesig.TabIndex = 1161;
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label5.Location = new System.Drawing.Point(16, 20);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(53, 23);
            this._Label5.TabIndex = 1160;
            this._Label5.Text = "Name";
            this._Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.CustomFormat = "dd/MMM/yyyy";
            this.dtpEmpDOB.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpDOB.Location = new System.Drawing.Point(183, 117);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(257, 22);
            this.dtpEmpDOB.TabIndex = 1162;
            // 
            // _GroupBox2
            // 
            this._GroupBox2.Controls.Add(this._PicStudent);
            this._GroupBox2.Controls.Add(this._PicStdCamera);
            this._GroupBox2.Controls.Add(this._PicStdRemove);
            this._GroupBox2.Controls.Add(this._PicStdBrowse);
            this._GroupBox2.Font = new System.Drawing.Font("Comfortaa", 8F);
            this._GroupBox2.Location = new System.Drawing.Point(844, 5);
            this._GroupBox2.Name = "_GroupBox2";
            this._GroupBox2.Size = new System.Drawing.Size(165, 240);
            this._GroupBox2.TabIndex = 2;
            this._GroupBox2.TabStop = false;
            this._GroupBox2.Text = "Employee Photo";
            // 
            // _PicStudent
            // 
            this._PicStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PicStudent.Image = ((System.Drawing.Image)(resources.GetObject("_PicStudent.Image")));
            this._PicStudent.Location = new System.Drawing.Point(7, 21);
            this._PicStudent.Name = "_PicStudent";
            this._PicStudent.Size = new System.Drawing.Size(150, 139);
            this._PicStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._PicStudent.TabIndex = 17;
            this._PicStudent.TabStop = false;
            // 
            // _PicStdCamera
            // 
            this._PicStdCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PicStdCamera.Image = ((System.Drawing.Image)(resources.GetObject("_PicStdCamera.Image")));
            this._PicStdCamera.Location = new System.Drawing.Point(58, 164);
            this._PicStdCamera.Name = "_PicStdCamera";
            this._PicStdCamera.Size = new System.Drawing.Size(48, 41);
            this._PicStdCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._PicStdCamera.TabIndex = 16;
            this._PicStdCamera.TabStop = false;
            // 
            // _PicStdRemove
            // 
            this._PicStdRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PicStdRemove.Image = ((System.Drawing.Image)(resources.GetObject("_PicStdRemove.Image")));
            this._PicStdRemove.Location = new System.Drawing.Point(109, 169);
            this._PicStdRemove.Name = "_PicStdRemove";
            this._PicStdRemove.Size = new System.Drawing.Size(32, 25);
            this._PicStdRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._PicStdRemove.TabIndex = 14;
            this._PicStdRemove.TabStop = false;
            // 
            // _PicStdBrowse
            // 
            this._PicStdBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PicStdBrowse.Image = ((System.Drawing.Image)(resources.GetObject("_PicStdBrowse.Image")));
            this._PicStdBrowse.Location = new System.Drawing.Point(23, 169);
            this._PicStdBrowse.Name = "_PicStdBrowse";
            this._PicStdBrowse.Size = new System.Drawing.Size(32, 25);
            this._PicStdBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._PicStdBrowse.TabIndex = 13;
            this._PicStdBrowse.TabStop = false;
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.Location = new System.Drawing.Point(16, 116);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(102, 23);
            this._Label2.TabIndex = 1164;
            this._Label2.Text = "Date of Birth";
            this._Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _Panel4
            // 
            this._Panel4.Controls.Add(this._GroupBox1);
            this._Panel4.Controls.Add(this._GroupBox2);
            this._Panel4.Location = new System.Drawing.Point(149, 12);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(1020, 249);
            this._Panel4.TabIndex = 1178;
            // 
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this.cbEmpStatus);
            this._GroupBox1.Controls.Add(this.label1);
            this._GroupBox1.Controls.Add(this.cbEmpWages);
            this._GroupBox1.Controls.Add(this.cbEmpName);
            this._GroupBox1.Controls.Add(this.cbEmpID);
            this._GroupBox1.Controls.Add(this._Label4);
            this._GroupBox1.Controls.Add(this._Label6);
            this._GroupBox1.Controls.Add(this._Label3);
            this._GroupBox1.Controls.Add(this.dtpEmpDOJ);
            this._GroupBox1.Controls.Add(this._Label2);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Controls.Add(this.cbEmpDesig);
            this._GroupBox1.Controls.Add(this._Label5);
            this._GroupBox1.Controls.Add(this.dtpEmpDOB);
            this._GroupBox1.Location = new System.Drawing.Point(14, 3);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Size = new System.Drawing.Size(449, 240);
            this._GroupBox1.TabIndex = 3;
            this._GroupBox1.TabStop = false;
            // 
            // cbEmpStatus
            // 
            this.cbEmpStatus.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpStatus.FormattingEnabled = true;
            this.cbEmpStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cbEmpStatus.Location = new System.Drawing.Point(183, 202);
            this.cbEmpStatus.Name = "cbEmpStatus";
            this.cbEmpStatus.Size = new System.Drawing.Size(257, 29);
            this.cbEmpStatus.TabIndex = 1176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 1175;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEmpWages
            // 
            this.cbEmpWages.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpWages.FormattingEnabled = true;
            this.cbEmpWages.Location = new System.Drawing.Point(183, 169);
            this.cbEmpWages.Name = "cbEmpWages";
            this.cbEmpWages.Size = new System.Drawing.Size(257, 29);
            this.cbEmpWages.TabIndex = 1174;
            // 
            // cbEmpName
            // 
            this.cbEmpName.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpName.FormattingEnabled = true;
            this.cbEmpName.Location = new System.Drawing.Point(183, 18);
            this.cbEmpName.Name = "cbEmpName";
            this.cbEmpName.Size = new System.Drawing.Size(257, 29);
            this.cbEmpName.TabIndex = 1173;
            this.cbEmpName.SelectedIndexChanged += new System.EventHandler(this.cbEmpName_SelectedIndexChanged);
            // 
            // cbEmpID
            // 
            this.cbEmpID.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(183, 50);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(257, 29);
            this.cbEmpID.TabIndex = 1171;
            // 
            // _Panel2
            // 
            this._Panel2.Controls.Add(this.btnClose);
            this._Panel2.Controls.Add(this._cmdPrint);
            this._Panel2.Controls.Add(this.btnRefresh);
            this._Panel2.Controls.Add(this.btnDelete);
            this._Panel2.Controls.Add(this.btnEdit);
            this._Panel2.Controls.Add(this.btnClear);
            this._Panel2.Location = new System.Drawing.Point(12, 12);
            this._Panel2.Name = "_Panel2";
            this._Panel2.Size = new System.Drawing.Size(131, 249);
            this._Panel2.TabIndex = 1187;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "   &Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._cmdPrint.FlatAppearance.BorderSize = 0;
            this._cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdPrint.Font = new System.Drawing.Font("Comfortaa", 8F);
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdPrint.Location = new System.Drawing.Point(7, 167);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.Size = new System.Drawing.Size(114, 37);
            this._cmdPrint.TabIndex = 6;
            this._cmdPrint.Text = "      &Print";
            this._cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cmdPrint.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(7, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "       &Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "       &Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(7, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "    &Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(7, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "    C&lear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEmpAddEmp
            // 
            this.btnEmpAddEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAddEmp.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAddEmp.Location = new System.Drawing.Point(1175, 194);
            this.btnEmpAddEmp.Name = "btnEmpAddEmp";
            this.btnEmpAddEmp.Size = new System.Drawing.Size(75, 41);
            this.btnEmpAddEmp.TabIndex = 16;
            this.btnEmpAddEmp.Text = "Add";
            this.btnEmpAddEmp.UseVisualStyleBackColor = false;
            this.btnEmpAddEmp.Click += new System.EventHandler(this.btnEmpAddEmp_Click);
            // 
            // empGrid
            // 
            this.empGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.empGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Location = new System.Drawing.Point(12, 267);
            this.empGrid.Name = "empGrid";
            this.empGrid.ReadOnly = true;
            this.empGrid.RowHeadersWidth = 51;
            this.empGrid.RowTemplate.Height = 24;
            this.empGrid.Size = new System.Drawing.Size(1238, 394);
            this.empGrid.TabIndex = 1188;
            this.empGrid.DoubleClick += new System.EventHandler(this.empGrid_DoubleClick);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.btnEmpAddEmp);
            this.Controls.Add(this._Panel2);
            this.Controls.Add(this._Panel4);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this._GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PicStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdBrowse)).EndInit();
            this._Panel4.ResumeLayout(false);
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            this._Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _Label4;
        private System.Windows.Forms.Label _Label6;
        private System.Windows.Forms.Label _Label3;
        private System.Windows.Forms.DateTimePicker dtpEmpDOJ;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.ComboBox cbEmpDesig;
        private System.Windows.Forms.Label _Label5;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.GroupBox _GroupBox2;
        private System.Windows.Forms.PictureBox _PicStudent;
        private System.Windows.Forms.PictureBox _PicStdCamera;
        private System.Windows.Forms.PictureBox _PicStdRemove;
        private System.Windows.Forms.PictureBox _PicStdBrowse;
        private System.Windows.Forms.Label _Label2;
        private System.Windows.Forms.Panel _Panel4;
        private System.Windows.Forms.GroupBox _GroupBox1;
        private System.Windows.Forms.Panel _Panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button _cmdPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbEmpID;
        private System.Windows.Forms.Button btnEmpAddEmp;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.ComboBox cbEmpName;
        private System.Windows.Forms.ComboBox cbEmpWages;
        private System.Windows.Forms.ComboBox cbEmpStatus;
        private System.Windows.Forms.Label label1;
    }
}