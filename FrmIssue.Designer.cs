namespace TestX
{
    partial class FrmIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIssue));
            this._Label13 = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label10 = new System.Windows.Forms.Label();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label5 = new System.Windows.Forms.Label();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this._Label16 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbIssuedTo = new System.Windows.Forms.ComboBox();
            this.cbIssuedBy = new System.Windows.Forms.ComboBox();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this.cbWONum = new System.Windows.Forms.ComboBox();
            this._Panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbPONum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.cbProductGroup = new System.Windows.Forms.ComboBox();
            this.cbRecID = new System.Windows.Forms.ComboBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnAddIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this._Panel2 = new System.Windows.Forms.Panel();
            this._BSearch = new System.Windows.Forms.Button();
            this._cmdPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this._cmdSave = new System.Windows.Forms.Button();
            this.issueGrid = new System.Windows.Forms.DataGridView();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this._Panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._GroupBox2.SuspendLayout();
            this._GroupBox1.SuspendLayout();
            this._Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _Label13
            // 
            this._Label13.AutoSize = true;
            this._Label13.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label13.Location = new System.Drawing.Point(6, 56);
            this._Label13.Name = "_Label13";
            this._Label13.Size = new System.Drawing.Size(35, 19);
            this._Label13.TabIndex = 131;
            this._Label13.Text = "QTY";
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label9.Location = new System.Drawing.Point(12, 79);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(92, 19);
            this._Label9.TabIndex = 128;
            this._Label9.Text = "DESCRIPTION";
            // 
            // _Label10
            // 
            this._Label10.AutoSize = true;
            this._Label10.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label10.Location = new System.Drawing.Point(12, 372);
            this._Label10.Name = "_Label10";
            this._Label10.Size = new System.Drawing.Size(76, 19);
            this._Label10.TabIndex = 124;
            this._Label10.Text = "RECORD ID";
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label1.Location = new System.Drawing.Point(12, 51);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(48, 19);
            this._Label1.TabIndex = 114;
            this._Label1.Text = "Group";
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label5.Location = new System.Drawing.Point(12, 23);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(43, 19);
            this._Label5.TabIndex = 113;
            this._Label5.Text = "WO #";
            // 
            // cbUOM
            // 
            this.cbUOM.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbUOM.Location = new System.Drawing.Point(119, 107);
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(159, 27);
            this.cbUOM.TabIndex = 1149;
            this.cbUOM.SelectedIndexChanged += new System.EventHandler(this.cbUOM_SelectedIndexChanged);
            // 
            // _Label16
            // 
            this._Label16.AutoSize = true;
            this._Label16.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label16.Location = new System.Drawing.Point(15, 110);
            this._Label16.Name = "_Label16";
            this._Label16.Size = new System.Drawing.Size(42, 19);
            this._Label16.TabIndex = 1148;
            this._Label16.Text = "UOM";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(119, 135);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 21);
            this.dtpDate.TabIndex = 1146;
            // 
            // cbIssuedTo
            // 
            this.cbIssuedTo.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbIssuedTo.Location = new System.Drawing.Point(101, 107);
            this.cbIssuedTo.Name = "cbIssuedTo";
            this.cbIssuedTo.Size = new System.Drawing.Size(171, 27);
            this.cbIssuedTo.TabIndex = 1145;
            // 
            // cbIssuedBy
            // 
            this.cbIssuedBy.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbIssuedBy.Location = new System.Drawing.Point(101, 78);
            this.cbIssuedBy.Name = "cbIssuedBy";
            this.cbIssuedBy.Size = new System.Drawing.Size(171, 27);
            this.cbIssuedBy.TabIndex = 1144;
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label4.Location = new System.Drawing.Point(6, 110);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(77, 19);
            this._Label4.TabIndex = 133;
            this._Label4.Text = "ISSUED TO";
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label3.Location = new System.Drawing.Point(6, 81);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(74, 19);
            this._Label3.TabIndex = 132;
            this._Label3.Text = "ISSUED BY";
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label6.Location = new System.Drawing.Point(15, 137);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(38, 19);
            this._Label6.TabIndex = 117;
            this._Label6.Text = "Date";
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.Location = new System.Drawing.Point(-332, 272);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(47, 24);
            this._Label2.TabIndex = 114;
            this._Label2.Text = "City:";
            // 
            // cbWONum
            // 
            this.cbWONum.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbWONum.Location = new System.Drawing.Point(119, 23);
            this.cbWONum.Name = "cbWONum";
            this.cbWONum.Size = new System.Drawing.Size(159, 27);
            this.cbWONum.TabIndex = 1143;
            this.cbWONum.SelectedIndexChanged += new System.EventHandler(this._CBWO_SelectedIndexChanged);
            // 
            // _Panel4
            // 
            this._Panel4.Controls.Add(this.groupBox1);
            this._Panel4.Controls.Add(this._GroupBox2);
            this._Panel4.Controls.Add(this._GroupBox1);
            this._Panel4.Location = new System.Drawing.Point(149, 12);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(966, 177);
            this._Panel4.TabIndex = 1166;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.cbPONum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(342, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 165);
            this.groupBox1.TabIndex = 1150;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.comboBox1.Location = new System.Drawing.Point(119, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 27);
            this.comboBox1.TabIndex = 1149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1148;
            this.label2.Text = "UOM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MMM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 21);
            this.dateTimePicker1.TabIndex = 1146;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.comboBox2.Location = new System.Drawing.Point(119, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 27);
            this.comboBox2.TabIndex = 1145;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.comboBox3.Location = new System.Drawing.Point(119, 51);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 27);
            this.comboBox3.TabIndex = 1144;
            // 
            // cbPONum
            // 
            this.cbPONum.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbPONum.Location = new System.Drawing.Point(119, 23);
            this.cbPONum.Name = "cbPONum";
            this.cbPONum.Size = new System.Drawing.Size(159, 27);
            this.cbPONum.TabIndex = 1143;
            this.cbPONum.SelectedIndexChanged += new System.EventHandler(this.cbPONum_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 128;
            this.label3.Text = "DESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 114;
            this.label4.Text = "Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label5.Location = new System.Drawing.Point(15, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 117;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 113;
            this.label6.Text = "PO #";
            // 
            // _GroupBox2
            // 
            this._GroupBox2.Controls.Add(this.txtStock);
            this._GroupBox2.Controls.Add(this.txtQuantity);
            this._GroupBox2.Controls.Add(this.label1);
            this._GroupBox2.Controls.Add(this.cbIssuedTo);
            this._GroupBox2.Controls.Add(this.cbIssuedBy);
            this._GroupBox2.Controls.Add(this._Label4);
            this._GroupBox2.Controls.Add(this._Label13);
            this._GroupBox2.Controls.Add(this._Label3);
            this._GroupBox2.Controls.Add(this._Label2);
            this._GroupBox2.Location = new System.Drawing.Point(679, 5);
            this._GroupBox2.Name = "_GroupBox2";
            this._GroupBox2.Size = new System.Drawing.Size(284, 165);
            this._GroupBox2.TabIndex = 1;
            this._GroupBox2.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantity.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtQuantity.Location = new System.Drawing.Point(101, 56);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(171, 21);
            this.txtQuantity.TabIndex = 1149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1150;
            this.label1.Text = "Opening Stock";
            // 
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this.cbUOM);
            this._GroupBox1.Controls.Add(this._Label16);
            this._GroupBox1.Controls.Add(this.dtpDate);
            this._GroupBox1.Controls.Add(this.cbDescription);
            this._GroupBox1.Controls.Add(this.cbProductGroup);
            this._GroupBox1.Controls.Add(this.cbWONum);
            this._GroupBox1.Controls.Add(this._Label9);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Controls.Add(this._Label6);
            this._GroupBox1.Controls.Add(this._Label5);
            this._GroupBox1.Location = new System.Drawing.Point(5, 7);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Size = new System.Drawing.Size(287, 165);
            this._GroupBox1.TabIndex = 0;
            this._GroupBox1.TabStop = false;
            // 
            // cbDescription
            // 
            this.cbDescription.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbDescription.Location = new System.Drawing.Point(119, 79);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(159, 27);
            this.cbDescription.TabIndex = 1145;
            this.cbDescription.SelectedIndexChanged += new System.EventHandler(this.cbDescription_SelectedIndexChanged);
            // 
            // cbProductGroup
            // 
            this.cbProductGroup.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbProductGroup.Location = new System.Drawing.Point(119, 51);
            this.cbProductGroup.Name = "cbProductGroup";
            this.cbProductGroup.Size = new System.Drawing.Size(159, 27);
            this.cbProductGroup.TabIndex = 1144;
            this.cbProductGroup.SelectedIndexChanged += new System.EventHandler(this.cbProductGroup_SelectedIndexChanged);
            // 
            // cbRecID
            // 
            this.cbRecID.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbRecID.Items.AddRange(new object[] {
            "M94",
            "M103",
            "M105",
            "M109",
            "M126",
            "M131",
            "M143",
            "M149",
            "M151",
            "M152",
            "M153",
            "M154",
            "M155",
            "M156",
            "M157",
            "M158",
            "M159",
            "M162",
            "M163",
            "M164",
            "M165",
            "M166",
            "M167",
            "M168",
            "M169",
            "M170",
            "M171",
            "M172"});
            this.cbRecID.Location = new System.Drawing.Point(12, 342);
            this.cbRecID.Name = "cbRecID";
            this.cbRecID.Size = new System.Drawing.Size(131, 27);
            this.cbRecID.TabIndex = 1150;
            this.cbRecID.SelectedIndexChanged += new System.EventHandler(this.cbRecID_SelectedIndexChanged);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Comfortaa", 6F);
            this.btnIssue.Location = new System.Drawing.Point(1121, 66);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(129, 41);
            this.btnIssue.TabIndex = 1202;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnAddIssue
            // 
            this.btnAddIssue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIssue.Font = new System.Drawing.Font("Comfortaa", 6F);
            this.btnAddIssue.Location = new System.Drawing.Point(1121, 19);
            this.btnAddIssue.Name = "btnAddIssue";
            this.btnAddIssue.Size = new System.Drawing.Size(129, 41);
            this.btnAddIssue.TabIndex = 1201;
            this.btnAddIssue.Text = "Add";
            this.btnAddIssue.UseVisualStyleBackColor = false;
            this.btnAddIssue.Click += new System.EventHandler(this.btnAddIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "   &Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _Panel2
            // 
            this._Panel2.Controls.Add(this._BSearch);
            this._Panel2.Controls.Add(this.btnClose);
            this._Panel2.Controls.Add(this._cmdPrint);
            this._Panel2.Controls.Add(this.btnRefresh);
            this._Panel2.Controls.Add(this.btnNew);
            this._Panel2.Controls.Add(this.btnDelete);
            this._Panel2.Controls.Add(this.btnEdit);
            this._Panel2.Controls.Add(this.btnClear);
            this._Panel2.Controls.Add(this._cmdSave);
            this._Panel2.Location = new System.Drawing.Point(12, 12);
            this._Panel2.Name = "_Panel2";
            this._Panel2.Size = new System.Drawing.Size(131, 324);
            this._Panel2.TabIndex = 1203;
            // 
            // _BSearch
            // 
            this._BSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._BSearch.FlatAppearance.BorderSize = 0;
            this._BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BSearch.Font = new System.Drawing.Font("Comfortaa", 8F);
            this._BSearch.Image = ((System.Drawing.Image)(resources.GetObject("_BSearch.Image")));
            this._BSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BSearch.Location = new System.Drawing.Point(7, 81);
            this._BSearch.Name = "_BSearch";
            this._BSearch.Size = new System.Drawing.Size(114, 37);
            this._BSearch.TabIndex = 2;
            this._BSearch.Text = "      Search";
            this._BSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BSearch.UseVisualStyleBackColor = false;
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._cmdPrint.FlatAppearance.BorderSize = 0;
            this._cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdPrint.Font = new System.Drawing.Font("Comfortaa", 8F);
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdPrint.Location = new System.Drawing.Point(7, 238);
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
            this.btnRefresh.Location = new System.Drawing.Point(7, 200);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "       &Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(7, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = " &New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 157);
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
            this.btnEdit.Location = new System.Drawing.Point(7, 119);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "    &Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(7, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "    C&lear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // _cmdSave
            // 
            this._cmdSave.Enabled = false;
            this._cmdSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("_cmdSave.Image")));
            this._cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdSave.Location = new System.Drawing.Point(7, 6);
            this._cmdSave.Name = "_cmdSave";
            this._cmdSave.Size = new System.Drawing.Size(114, 37);
            this._cmdSave.TabIndex = 0;
            this._cmdSave.Text = "  &Save";
            this._cmdSave.UseVisualStyleBackColor = true;
            this._cmdSave.Visible = false;
            // 
            // issueGrid
            // 
            this.issueGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.issueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueGrid.Location = new System.Drawing.Point(154, 195);
            this.issueGrid.Name = "issueGrid";
            this.issueGrid.ReadOnly = true;
            this.issueGrid.RowHeadersWidth = 51;
            this.issueGrid.RowTemplate.Height = 24;
            this.issueGrid.Size = new System.Drawing.Size(1096, 466);
            this.issueGrid.TabIndex = 1204;
            this.issueGrid.Click += new System.EventHandler(this.issueGrid_Click);
            this.issueGrid.DoubleClick += new System.EventHandler(this.issueGrid_DoubleClick);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Comfortaa", 6F);
            this.btnImportExcel.Location = new System.Drawing.Point(1121, 113);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(129, 41);
            this.btnImportExcel.TabIndex = 1205;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStock.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtStock.Location = new System.Drawing.Point(101, 31);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(171, 21);
            this.txtStock.TabIndex = 1152;
            // 
            // FrmIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cbRecID);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.issueGrid);
            this.Controls.Add(this._Panel2);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnAddIssue);
            this.Controls.Add(this._Label10);
            this.Controls.Add(this._Panel4);
            this.Name = "FrmIssue";
            this.Text = "FrmIssue";
            this._Panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._GroupBox2.ResumeLayout(false);
            this._GroupBox2.PerformLayout();
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            this._Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issueGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Label13;
        private System.Windows.Forms.Label _Label9;
        private System.Windows.Forms.Label _Label10;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.Label _Label5;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.Label _Label16;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbIssuedTo;
        private System.Windows.Forms.ComboBox cbIssuedBy;
        private System.Windows.Forms.Label _Label4;
        private System.Windows.Forms.Label _Label3;
        private System.Windows.Forms.Label _Label6;
        private System.Windows.Forms.Label _Label2;
        private System.Windows.Forms.ComboBox cbWONum;
        private System.Windows.Forms.Panel _Panel4;
        private System.Windows.Forms.GroupBox _GroupBox2;
        private System.Windows.Forms.GroupBox _GroupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbDescription;
        private System.Windows.Forms.ComboBox cbProductGroup;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnAddIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel _Panel2;
        private System.Windows.Forms.Button _BSearch;
        private System.Windows.Forms.Button _cmdPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button _cmdSave;
        private System.Windows.Forms.DataGridView issueGrid;
        private System.Windows.Forms.ComboBox cbRecID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbPONum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
    }
}