namespace TestX
{
    partial class FrmManHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManHours));
            this._CBEmpName = new System.Windows.Forms.ComboBox();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._CBWO2 = new System.Windows.Forms.ComboBox();
            this._CBEmpCode = new System.Windows.Forms.ComboBox();
            this._TextBox5 = new System.Windows.Forms.TextBox();
            this._TextBox4 = new System.Windows.Forms.TextBox();
            this._txtCustomer = new System.Windows.Forms.TextBox();
            this._WO_BRIEF = new System.Windows.Forms.Panel();
            this._txtPlanComDate = new System.Windows.Forms.TextBox();
            this._txtIssueDate = new System.Windows.Forms.TextBox();
            this._Panel1 = new System.Windows.Forms.Panel();
            this._Label17 = new System.Windows.Forms.Label();
            this._Label7 = new System.Windows.Forms.Label();
            this._Label15 = new System.Windows.Forms.Label();
            this._Label14 = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this._Label12 = new System.Windows.Forms.Label();
            this._Label19 = new System.Windows.Forms.Label();
            this._LblRecord = new System.Windows.Forms.Label();
            this._CBActivity = new System.Windows.Forms.ComboBox();
            this._Panel4 = new System.Windows.Forms.Panel();
            this._GroupBox2 = new System.Windows.Forms.GroupBox();
            this._CBStartTime = new System.Windows.Forms.ComboBox();
            this._Label13 = new System.Windows.Forms.Label();
            this._txtHours = new System.Windows.Forms.TextBox();
            this._CBEndTime = new System.Windows.Forms.ComboBox();
            this._Label18 = new System.Windows.Forms.Label();
            this._Label16 = new System.Windows.Forms.Label();
            this._dtpDate = new System.Windows.Forms.DateTimePicker();
            this._Label6 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this._CBProduct = new System.Windows.Forms.ComboBox();
            this._CBWO = new System.Windows.Forms.ComboBox();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this._Panel2 = new System.Windows.Forms.Panel();
            this._cmdPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.manhourGrid = new System.Windows.Forms.DataGridView();
            this._WO_BRIEF.SuspendLayout();
            this._Panel1.SuspendLayout();
            this._Panel4.SuspendLayout();
            this._GroupBox2.SuspendLayout();
            this._GroupBox1.SuspendLayout();
            this._Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manhourGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _CBEmpName
            // 
            this._CBEmpName.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBEmpName.Location = new System.Drawing.Point(100, 49);
            this._CBEmpName.Name = "_CBEmpName";
            this._CBEmpName.Size = new System.Drawing.Size(176, 27);
            this._CBEmpName.TabIndex = 1149;
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label4.Location = new System.Drawing.Point(10, 52);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(76, 19);
            this._Label4.TabIndex = 1147;
            this._Label4.Text = "Emp Name";
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label3.Location = new System.Drawing.Point(10, 23);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(72, 19);
            this._Label3.TabIndex = 1146;
            this._Label3.Text = "Emp Code";
            // 
            // _CBWO2
            // 
            this._CBWO2.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBWO2.FormattingEnabled = true;
            this._CBWO2.Items.AddRange(new object[] {
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
            this._CBWO2.Location = new System.Drawing.Point(128, 6);
            this._CBWO2.Name = "_CBWO2";
            this._CBWO2.Size = new System.Drawing.Size(107, 27);
            this._CBWO2.TabIndex = 8;
            // 
            // _CBEmpCode
            // 
            this._CBEmpCode.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBEmpCode.Items.AddRange(new object[] {
            "NAE0001",
            "NAE0002",
            "NAE0003",
            "NAE0004",
            "NAE0005",
            "NAE0006",
            "NAE0007",
            "NAE0008",
            "NAE0009",
            "NAE0010",
            "NAE0011",
            "NAE0012",
            "NAE0013",
            "NAE0014",
            "NAE0015",
            "NAE0016",
            "NAE0017",
            "NAE0018",
            "NAE0019",
            "NAE0020"});
            this._CBEmpCode.Location = new System.Drawing.Point(100, 20);
            this._CBEmpCode.Name = "_CBEmpCode";
            this._CBEmpCode.Size = new System.Drawing.Size(176, 27);
            this._CBEmpCode.TabIndex = 1148;
            // 
            // _TextBox5
            // 
            this._TextBox5.BackColor = System.Drawing.Color.White;
            this._TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._TextBox5.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._TextBox5.Location = new System.Drawing.Point(128, 150);
            this._TextBox5.Name = "_TextBox5";
            this._TextBox5.ReadOnly = true;
            this._TextBox5.Size = new System.Drawing.Size(107, 21);
            this._TextBox5.TabIndex = 1318;
            this._TextBox5.Text = "HOW CAN I CAPTURE THIS VALUE";
            // 
            // _TextBox4
            // 
            this._TextBox4.BackColor = System.Drawing.Color.White;
            this._TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._TextBox4.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._TextBox4.Location = new System.Drawing.Point(128, 122);
            this._TextBox4.Name = "_TextBox4";
            this._TextBox4.ReadOnly = true;
            this._TextBox4.Size = new System.Drawing.Size(107, 21);
            this._TextBox4.TabIndex = 1317;
            this._TextBox4.Text = "HOW CAN I CAPTURE THIS VALUE";
            // 
            // _txtCustomer
            // 
            this._txtCustomer.BackColor = System.Drawing.Color.White;
            this._txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txtCustomer.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._txtCustomer.Location = new System.Drawing.Point(128, 94);
            this._txtCustomer.Name = "_txtCustomer";
            this._txtCustomer.ReadOnly = true;
            this._txtCustomer.Size = new System.Drawing.Size(107, 21);
            this._txtCustomer.TabIndex = 1316;
            // 
            // _WO_BRIEF
            // 
            this._WO_BRIEF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._WO_BRIEF.Controls.Add(this._TextBox5);
            this._WO_BRIEF.Controls.Add(this._TextBox4);
            this._WO_BRIEF.Controls.Add(this._txtCustomer);
            this._WO_BRIEF.Controls.Add(this._txtPlanComDate);
            this._WO_BRIEF.Controls.Add(this._txtIssueDate);
            this._WO_BRIEF.Controls.Add(this._Panel1);
            this._WO_BRIEF.Controls.Add(this._Label7);
            this._WO_BRIEF.Controls.Add(this._Label15);
            this._WO_BRIEF.Controls.Add(this._Label14);
            this._WO_BRIEF.Controls.Add(this._Label8);
            this._WO_BRIEF.Controls.Add(this._Label12);
            this._WO_BRIEF.Controls.Add(this._Label19);
            this._WO_BRIEF.Controls.Add(this._CBWO2);
            this._WO_BRIEF.Location = new System.Drawing.Point(744, 12);
            this._WO_BRIEF.Name = "_WO_BRIEF";
            this._WO_BRIEF.Size = new System.Drawing.Size(423, 179);
            this._WO_BRIEF.TabIndex = 1175;
            this._WO_BRIEF.Tag = "";
            // 
            // _txtPlanComDate
            // 
            this._txtPlanComDate.BackColor = System.Drawing.Color.White;
            this._txtPlanComDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txtPlanComDate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._txtPlanComDate.Location = new System.Drawing.Point(128, 66);
            this._txtPlanComDate.Name = "_txtPlanComDate";
            this._txtPlanComDate.ReadOnly = true;
            this._txtPlanComDate.Size = new System.Drawing.Size(107, 21);
            this._txtPlanComDate.TabIndex = 1315;
            // 
            // _txtIssueDate
            // 
            this._txtIssueDate.BackColor = System.Drawing.Color.White;
            this._txtIssueDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txtIssueDate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._txtIssueDate.Location = new System.Drawing.Point(128, 38);
            this._txtIssueDate.Name = "_txtIssueDate";
            this._txtIssueDate.ReadOnly = true;
            this._txtIssueDate.Size = new System.Drawing.Size(107, 21);
            this._txtIssueDate.TabIndex = 1314;
            // 
            // _Panel1
            // 
            this._Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Panel1.Controls.Add(this._Label17);
            this._Panel1.Location = new System.Drawing.Point(253, 3);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(167, 170);
            this._Panel1.TabIndex = 15;
            // 
            // _Label17
            // 
            this._Label17.AutoSize = true;
            this._Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Label17.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label17.Location = new System.Drawing.Point(3, 8);
            this._Label17.Name = "_Label17";
            this._Label17.Size = new System.Drawing.Size(72, 21);
            this._Label17.TabIndex = 10;
            this._Label17.Text = "LIST & QTY";
            // 
            // _Label7
            // 
            this._Label7.AutoSize = true;
            this._Label7.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label7.Location = new System.Drawing.Point(7, 151);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(98, 19);
            this._Label7.TabIndex = 14;
            this._Label7.Text = "PLANNED HRS";
            // 
            // _Label15
            // 
            this._Label15.AutoSize = true;
            this._Label15.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label15.Location = new System.Drawing.Point(7, 123);
            this._Label15.Name = "_Label15";
            this._Label15.Size = new System.Drawing.Size(107, 19);
            this._Label15.TabIndex = 13;
            this._Label15.Text = "TOTAL HRS YTD";
            // 
            // _Label14
            // 
            this._Label14.AutoSize = true;
            this._Label14.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label14.Location = new System.Drawing.Point(7, 95);
            this._Label14.Name = "_Label14";
            this._Label14.Size = new System.Drawing.Size(81, 19);
            this._Label14.TabIndex = 12;
            this._Label14.Text = "CUSTOMER";
            // 
            // _Label8
            // 
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label8.Location = new System.Drawing.Point(7, 67);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(122, 19);
            this._Label8.TabIndex = 11;
            this._Label8.Text = "PLAN COMP. DATE";
            // 
            // _Label12
            // 
            this._Label12.AutoSize = true;
            this._Label12.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label12.Location = new System.Drawing.Point(7, 39);
            this._Label12.Name = "_Label12";
            this._Label12.Size = new System.Drawing.Size(91, 19);
            this._Label12.TabIndex = 10;
            this._Label12.Text = "ISSUED DATE";
            // 
            // _Label19
            // 
            this._Label19.AutoSize = true;
            this._Label19.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label19.Location = new System.Drawing.Point(7, 11);
            this._Label19.Name = "_Label19";
            this._Label19.Size = new System.Drawing.Size(104, 19);
            this._Label19.TabIndex = 9;
            this._Label19.Text = "WORK ORDER #";
            // 
            // _LblRecord
            // 
            this._LblRecord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LblRecord.ForeColor = System.Drawing.Color.Black;
            this._LblRecord.Location = new System.Drawing.Point(205, 627);
            this._LblRecord.Name = "_LblRecord";
            this._LblRecord.Size = new System.Drawing.Size(111, 18);
            this._LblRecord.TabIndex = 1174;
            this._LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _CBActivity
            // 
            this._CBActivity.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBActivity.Items.AddRange(new object[] {
            "ASSEMBLY",
            "BENDING",
            "BLADE CRIMPING",
            "BRAKEDOWN MAINTANCE",
            "CHEMICAL PRE TREATMENT",
            "CLEANING",
            "CORNER CRIMPING",
            "CUT-OFF ",
            "CUTTING PROFILE",
            "DAILY ROUTINE MAINT",
            "DRILLING",
            "FILING/DEBURRING",
            "FOAMING",
            "GASKETING",
            "GRINDING",
            "HAMMERING",
            "HELPER",
            "HOLE PUNCHING ",
            "HOUSE KEEPING",
            "IDENTIFICATION MARKING",
            "MATERIAL HANDLING",
            "NIBBLING",
            "NOTCHING",
            "PACKING",
            "PAINTING",
            "PLANNING",
            "POWDER COATING",
            "ROLLING",
            "SHEARING",
            "SITE WORK",
            "SPOT WELDING",
            "SUB ASSEMBLY",
            "TOOL SETTING",
            "WELDING"});
            this._CBActivity.Location = new System.Drawing.Point(100, 135);
            this._CBActivity.Name = "_CBActivity";
            this._CBActivity.Size = new System.Drawing.Size(178, 27);
            this._CBActivity.TabIndex = 1145;
            // 
            // _Panel4
            // 
            this._Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Panel4.Controls.Add(this._GroupBox2);
            this._Panel4.Controls.Add(this._GroupBox1);
            this._Panel4.Location = new System.Drawing.Point(149, 12);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(589, 179);
            this._Panel4.TabIndex = 1166;
            // 
            // _GroupBox2
            // 
            this._GroupBox2.Controls.Add(this._CBStartTime);
            this._GroupBox2.Controls.Add(this._Label13);
            this._GroupBox2.Controls.Add(this._txtHours);
            this._GroupBox2.Controls.Add(this._CBEndTime);
            this._GroupBox2.Controls.Add(this._Label18);
            this._GroupBox2.Controls.Add(this._Label16);
            this._GroupBox2.Controls.Add(this._dtpDate);
            this._GroupBox2.Controls.Add(this._Label6);
            this._GroupBox2.Controls.Add(this._Label2);
            this._GroupBox2.Location = new System.Drawing.Point(297, 2);
            this._GroupBox2.Name = "_GroupBox2";
            this._GroupBox2.Size = new System.Drawing.Size(284, 168);
            this._GroupBox2.TabIndex = 1;
            this._GroupBox2.TabStop = false;
            // 
            // _CBStartTime
            // 
            this._CBStartTime.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBStartTime.Items.AddRange(new object[] {
            "09:00am",
            "09:30am"});
            this._CBStartTime.Location = new System.Drawing.Point(114, 23);
            this._CBStartTime.Name = "_CBStartTime";
            this._CBStartTime.Size = new System.Drawing.Size(161, 27);
            this._CBStartTime.TabIndex = 1154;
            // 
            // _Label13
            // 
            this._Label13.AutoSize = true;
            this._Label13.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label13.Location = new System.Drawing.Point(9, 23);
            this._Label13.Name = "_Label13";
            this._Label13.Size = new System.Drawing.Size(82, 19);
            this._Label13.TabIndex = 1153;
            this._Label13.Text = "START TIME";
            // 
            // _txtHours
            // 
            this._txtHours.BackColor = System.Drawing.Color.White;
            this._txtHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._txtHours.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._txtHours.Location = new System.Drawing.Point(114, 77);
            this._txtHours.Name = "_txtHours";
            this._txtHours.ReadOnly = true;
            this._txtHours.Size = new System.Drawing.Size(161, 21);
            this._txtHours.TabIndex = 1152;
            // 
            // _CBEndTime
            // 
            this._CBEndTime.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBEndTime.Items.AddRange(new object[] {
            "09:00am",
            "09:30am"});
            this._CBEndTime.Location = new System.Drawing.Point(114, 49);
            this._CBEndTime.Name = "_CBEndTime";
            this._CBEndTime.Size = new System.Drawing.Size(161, 27);
            this._CBEndTime.TabIndex = 1151;
            // 
            // _Label18
            // 
            this._Label18.AutoSize = true;
            this._Label18.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label18.Location = new System.Drawing.Point(9, 77);
            this._Label18.Name = "_Label18";
            this._Label18.Size = new System.Drawing.Size(99, 19);
            this._Label18.TabIndex = 1150;
            this._Label18.Text = "HOURS TOTAL";
            // 
            // _Label16
            // 
            this._Label16.AutoSize = true;
            this._Label16.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label16.Location = new System.Drawing.Point(9, 51);
            this._Label16.Name = "_Label16";
            this._Label16.Size = new System.Drawing.Size(71, 19);
            this._Label16.TabIndex = 1149;
            this._Label16.Text = "END TIME";
            // 
            // _dtpDate
            // 
            this._dtpDate.CustomFormat = "dd/MMM/yyyy";
            this._dtpDate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpDate.Location = new System.Drawing.Point(114, 104);
            this._dtpDate.Name = "_dtpDate";
            this._dtpDate.Size = new System.Drawing.Size(161, 21);
            this._dtpDate.TabIndex = 1146;
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label6.Location = new System.Drawing.Point(9, 110);
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
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this._CBEmpName);
            this._GroupBox1.Controls.Add(this._CBEmpCode);
            this._GroupBox1.Controls.Add(this._Label4);
            this._GroupBox1.Controls.Add(this._Label3);
            this._GroupBox1.Controls.Add(this._CBActivity);
            this._GroupBox1.Controls.Add(this._CBProduct);
            this._GroupBox1.Controls.Add(this._CBWO);
            this._GroupBox1.Controls.Add(this._Label9);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Controls.Add(this._Label5);
            this._GroupBox1.Location = new System.Drawing.Point(5, 2);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Size = new System.Drawing.Size(287, 168);
            this._GroupBox1.TabIndex = 0;
            this._GroupBox1.TabStop = false;
            // 
            // _CBProduct
            // 
            this._CBProduct.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBProduct.Items.AddRange(new object[] {
            "Grilles ",
            "Al Louver ",
            "Collar damper ",
            "Diffuser ",
            "1 Slot Diff  ",
            "2 Slot Diff  ",
            "3 Slot Diff  ",
            "4 Slot Diff  ",
            "5 Slot Diff  ",
            "6 Slot Diff  ",
            "Disc Valve",
            "2 Way Grile",
            "Single SkinPlenum ",
            "ButterFly damper ",
            "VCD ",
            "Double Skin Plenum ",
            "Al Volume control louver",
            "Sound Attenuator"});
            this._CBProduct.Location = new System.Drawing.Point(100, 107);
            this._CBProduct.Name = "_CBProduct";
            this._CBProduct.Size = new System.Drawing.Size(178, 27);
            this._CBProduct.TabIndex = 1144;
            // 
            // _CBWO
            // 
            this._CBWO.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._CBWO.Items.AddRange(new object[] {
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
            this._CBWO.Location = new System.Drawing.Point(100, 79);
            this._CBWO.Name = "_CBWO";
            this._CBWO.Size = new System.Drawing.Size(178, 27);
            this._CBWO.TabIndex = 1143;
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label9.Location = new System.Drawing.Point(12, 135);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(65, 19);
            this._Label9.TabIndex = 128;
            this._Label9.Text = "ACTIVITY";
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label1.Location = new System.Drawing.Point(12, 107);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(70, 19);
            this._Label1.TabIndex = 114;
            this._Label1.Text = "PRODUCT";
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label5.Location = new System.Drawing.Point(12, 79);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(43, 19);
            this._Label5.TabIndex = 113;
            this._Label5.Text = "WO #";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "   &Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
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
            this._Panel2.Size = new System.Drawing.Size(131, 261);
            this._Panel2.TabIndex = 1198;
            // 
            // _cmdPrint
            // 
            this._cmdPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._cmdPrint.FlatAppearance.BorderSize = 0;
            this._cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdPrint.Font = new System.Drawing.Font("Comfortaa", 8F);
            this._cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("_cmdPrint.Image")));
            this._cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdPrint.Location = new System.Drawing.Point(7, 176);
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
            this.btnRefresh.Location = new System.Drawing.Point(7, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "       &Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "       &Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(7, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "    &Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(7, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "    C&lear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.btnExportExcel.Location = new System.Drawing.Point(1170, 145);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(80, 41);
            this.btnExportExcel.TabIndex = 1204;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.btnAddProd.Location = new System.Drawing.Point(1170, 102);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(80, 41);
            this.btnAddProd.TabIndex = 1203;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // manhourGrid
            // 
            this.manhourGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.manhourGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manhourGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manhourGrid.Location = new System.Drawing.Point(155, 197);
            this.manhourGrid.Name = "manhourGrid";
            this.manhourGrid.RowHeadersWidth = 51;
            this.manhourGrid.RowTemplate.Height = 24;
            this.manhourGrid.Size = new System.Drawing.Size(1095, 464);
            this.manhourGrid.TabIndex = 1205;
            // 
            // FrmManHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.manhourGrid);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this._Panel2);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this._WO_BRIEF);
            this.Controls.Add(this._LblRecord);
            this.Controls.Add(this._Panel4);
            this.Name = "FrmManHours";
            this.Text = "FrmManHours";
            this._WO_BRIEF.ResumeLayout(false);
            this._WO_BRIEF.PerformLayout();
            this._Panel1.ResumeLayout(false);
            this._Panel1.PerformLayout();
            this._Panel4.ResumeLayout(false);
            this._GroupBox2.ResumeLayout(false);
            this._GroupBox2.PerformLayout();
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            this._Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manhourGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _CBEmpName;
        private System.Windows.Forms.Label _Label4;
        private System.Windows.Forms.Label _Label3;
        private System.Windows.Forms.ComboBox _CBWO2;
        private System.Windows.Forms.ComboBox _CBEmpCode;
        private System.Windows.Forms.TextBox _TextBox5;
        private System.Windows.Forms.TextBox _TextBox4;
        private System.Windows.Forms.TextBox _txtCustomer;
        private System.Windows.Forms.Panel _WO_BRIEF;
        private System.Windows.Forms.TextBox _txtPlanComDate;
        private System.Windows.Forms.TextBox _txtIssueDate;
        private System.Windows.Forms.Panel _Panel1;
        private System.Windows.Forms.Label _Label17;
        private System.Windows.Forms.Label _Label7;
        private System.Windows.Forms.Label _Label15;
        private System.Windows.Forms.Label _Label14;
        private System.Windows.Forms.Label _Label8;
        private System.Windows.Forms.Label _Label12;
        private System.Windows.Forms.Label _Label19;
        private System.Windows.Forms.Label _LblRecord;
        private System.Windows.Forms.ComboBox _CBActivity;
        private System.Windows.Forms.Panel _Panel4;
        private System.Windows.Forms.GroupBox _GroupBox2;
        private System.Windows.Forms.ComboBox _CBStartTime;
        private System.Windows.Forms.Label _Label13;
        private System.Windows.Forms.TextBox _txtHours;
        private System.Windows.Forms.ComboBox _CBEndTime;
        private System.Windows.Forms.Label _Label18;
        private System.Windows.Forms.Label _Label16;
        private System.Windows.Forms.DateTimePicker _dtpDate;
        private System.Windows.Forms.Label _Label6;
        private System.Windows.Forms.Label _Label2;
        private System.Windows.Forms.GroupBox _GroupBox1;
        private System.Windows.Forms.ComboBox _CBProduct;
        private System.Windows.Forms.ComboBox _CBWO;
        private System.Windows.Forms.Label _Label9;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.Label _Label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel _Panel2;
        private System.Windows.Forms.Button _cmdPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.DataGridView manhourGrid;
    }
}