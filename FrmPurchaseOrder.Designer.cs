namespace TestX
{
    partial class FrmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseOrder));
            this._Label10 = new System.Windows.Forms.Label();
            this.btnDelAll = new System.Windows.Forms.Button();
            this._GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.txtWONum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSupGST = new System.Windows.Forms.TextBox();
            this._Label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupAdd = new System.Windows.Forms.TextBox();
            this.txtSupCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._Panel4 = new System.Windows.Forms.Panel();
            this._GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrepBy = new System.Windows.Forms.ComboBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShiptoAdd = new System.Windows.Forms.TextBox();
            this._Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBilltoAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPOStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRBDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.labelPONum = new System.Windows.Forms.Label();
            this.cbPONum = new System.Windows.Forms.ComboBox();
            this.dtpPODate = new System.Windows.Forms.DateTimePicker();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label1 = new System.Windows.Forms.Label();
            this.poGrid = new System.Windows.Forms.DataGridView();
            this._Panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this._cmdPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this._cmdSave = new System.Windows.Forms.Button();
            this.txtUnitRate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cbProdGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGSTAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this._Label20 = new System.Windows.Forms.Label();
            this._GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUoM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this._Label27 = new System.Windows.Forms.Label();
            this.txtSpecialNotes = new System.Windows.Forms.TextBox();
            this._Label7 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this._Label22 = new System.Windows.Forms.Label();
            this.btnPOAddProd = new System.Windows.Forms.Button();
            this.btnDelPOWO = new System.Windows.Forms.Button();
            this.lblGridSource = new System.Windows.Forms.Label();
            this.btnEditPO = new System.Windows.Forms.Button();
            this.chkboxEdit = new System.Windows.Forms.CheckBox();
            this._GroupBox3.SuspendLayout();
            this._Panel4.SuspendLayout();
            this._GroupBox2.SuspendLayout();
            this._GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poGrid)).BeginInit();
            this._Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Label10
            // 
            this._Label10.AutoSize = true;
            this._Label10.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label10.Location = new System.Drawing.Point(7, 23);
            this._Label10.Name = "_Label10";
            this._Label10.Size = new System.Drawing.Size(40, 19);
            this._Label10.TabIndex = 124;
            this._Label10.Text = "PO #";
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelAll.FlatAppearance.BorderSize = 0;
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAll.Font = new System.Drawing.Font("Comfortaa", 6.5F);
            this.btnDelAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAll.Image")));
            this.btnDelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAll.Location = new System.Drawing.Point(7, 165);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(115, 37);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "Del PO";
            this.btnDelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // _GroupBox3
            // 
            this._GroupBox3.Controls.Add(this.cbSupName);
            this._GroupBox3.Controls.Add(this.txtWONum);
            this._GroupBox3.Controls.Add(this.label15);
            this._GroupBox3.Controls.Add(this.txtSupGST);
            this._GroupBox3.Controls.Add(this._Label14);
            this._GroupBox3.Controls.Add(this.label10);
            this._GroupBox3.Controls.Add(this.label13);
            this._GroupBox3.Controls.Add(this.txtSupAdd);
            this._GroupBox3.Controls.Add(this.txtSupCode);
            this._GroupBox3.Controls.Add(this.label11);
            this._GroupBox3.Controls.Add(this.label12);
            this._GroupBox3.Location = new System.Drawing.Point(666, 5);
            this._GroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox3.Name = "_GroupBox3";
            this._GroupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox3.Size = new System.Drawing.Size(332, 172);
            this._GroupBox3.TabIndex = 0;
            this._GroupBox3.TabStop = false;
            // 
            // cbSupName
            // 
            this.cbSupName.BackColor = System.Drawing.SystemColors.Menu;
            this.cbSupName.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(137, 23);
            this.cbSupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(180, 27);
            this.cbSupName.TabIndex = 1160;
            this.cbSupName.SelectedIndexChanged += new System.EventHandler(this.cbSupName_SelectedIndexChanged);
            // 
            // txtWONum
            // 
            this.txtWONum.BackColor = System.Drawing.Color.White;
            this.txtWONum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWONum.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtWONum.Location = new System.Drawing.Point(137, 132);
            this.txtWONum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWONum.Name = "txtWONum";
            this.txtWONum.Size = new System.Drawing.Size(180, 21);
            this.txtWONum.TabIndex = 1177;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label15.Location = new System.Drawing.Point(15, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 19);
            this.label15.TabIndex = 1176;
            this.label15.Text = "WO Num";
            // 
            // txtSupGST
            // 
            this.txtSupGST.BackColor = System.Drawing.Color.White;
            this.txtSupGST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupGST.Enabled = false;
            this.txtSupGST.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtSupGST.Location = new System.Drawing.Point(137, 105);
            this.txtSupGST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupGST.Name = "txtSupGST";
            this.txtSupGST.Size = new System.Drawing.Size(180, 21);
            this.txtSupGST.TabIndex = 1175;
            // 
            // _Label14
            // 
            this._Label14.AutoSize = true;
            this._Label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label14.Location = new System.Drawing.Point(-332, 272);
            this._Label14.Name = "_Label14";
            this._Label14.Size = new System.Drawing.Size(47, 24);
            this._Label14.TabIndex = 114;
            this._Label14.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label10.Location = new System.Drawing.Point(15, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 1174;
            this.label10.Text = "Supplier GST";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label13.Location = new System.Drawing.Point(15, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 1168;
            this.label13.Text = "Supplier Code";
            // 
            // txtSupAdd
            // 
            this.txtSupAdd.BackColor = System.Drawing.Color.White;
            this.txtSupAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupAdd.Enabled = false;
            this.txtSupAdd.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtSupAdd.Location = new System.Drawing.Point(137, 78);
            this.txtSupAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupAdd.Name = "txtSupAdd";
            this.txtSupAdd.Size = new System.Drawing.Size(180, 21);
            this.txtSupAdd.TabIndex = 1173;
            // 
            // txtSupCode
            // 
            this.txtSupCode.BackColor = System.Drawing.Color.White;
            this.txtSupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupCode.Enabled = false;
            this.txtSupCode.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtSupCode.Location = new System.Drawing.Point(137, 51);
            this.txtSupCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupCode.Name = "txtSupCode";
            this.txtSupCode.Size = new System.Drawing.Size(180, 21);
            this.txtSupCode.TabIndex = 1169;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label11.Location = new System.Drawing.Point(15, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 1172;
            this.label11.Text = "Supplier Add ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label12.Location = new System.Drawing.Point(15, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 1170;
            this.label12.Text = "Supplier Name";
            // 
            // _Panel4
            // 
            this._Panel4.Controls.Add(this._GroupBox3);
            this._Panel4.Controls.Add(this._GroupBox2);
            this._Panel4.Controls.Add(this._GroupBox1);
            this._Panel4.Location = new System.Drawing.Point(149, 12);
            this._Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(1006, 180);
            this._Panel4.TabIndex = 1174;
            // 
            // _GroupBox2
            // 
            this._GroupBox2.Controls.Add(this.cbPrepBy);
            this._GroupBox2.Controls.Add(this.txtContactNum);
            this._GroupBox2.Controls.Add(this.label8);
            this._GroupBox2.Controls.Add(this.label9);
            this._GroupBox2.Controls.Add(this.txtShiptoAdd);
            this._GroupBox2.Controls.Add(this._Label2);
            this._GroupBox2.Controls.Add(this.label6);
            this._GroupBox2.Controls.Add(this.txtBilltoAdd);
            this._GroupBox2.Controls.Add(this.label7);
            this._GroupBox2.Location = new System.Drawing.Point(334, 2);
            this._GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox2.Name = "_GroupBox2";
            this._GroupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox2.Size = new System.Drawing.Size(326, 172);
            this._GroupBox2.TabIndex = 1;
            this._GroupBox2.TabStop = false;
            // 
            // cbPrepBy
            // 
            this.cbPrepBy.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPrepBy.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbPrepBy.FormattingEnabled = true;
            this.cbPrepBy.Location = new System.Drawing.Point(135, 105);
            this.cbPrepBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPrepBy.Name = "cbPrepBy";
            this.cbPrepBy.Size = new System.Drawing.Size(177, 27);
            this.cbPrepBy.TabIndex = 1178;
            // 
            // txtContactNum
            // 
            this.txtContactNum.BackColor = System.Drawing.Color.White;
            this.txtContactNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactNum.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtContactNum.Location = new System.Drawing.Point(135, 135);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(177, 21);
            this.txtContactNum.TabIndex = 1167;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label8.Location = new System.Drawing.Point(12, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 1166;
            this.label8.Text = "Contact #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 1164;
            this.label9.Text = "Prepared by";
            // 
            // txtShiptoAdd
            // 
            this.txtShiptoAdd.BackColor = System.Drawing.Color.White;
            this.txtShiptoAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShiptoAdd.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtShiptoAdd.Location = new System.Drawing.Point(135, 49);
            this.txtShiptoAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShiptoAdd.Multiline = true;
            this.txtShiptoAdd.Name = "txtShiptoAdd";
            this.txtShiptoAdd.Size = new System.Drawing.Size(177, 54);
            this.txtShiptoAdd.TabIndex = 1163;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 1162;
            this.label6.Text = "Ship to Add";
            // 
            // txtBilltoAdd
            // 
            this.txtBilltoAdd.BackColor = System.Drawing.Color.White;
            this.txtBilltoAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBilltoAdd.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtBilltoAdd.Location = new System.Drawing.Point(135, 23);
            this.txtBilltoAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBilltoAdd.Name = "txtBilltoAdd";
            this.txtBilltoAdd.Size = new System.Drawing.Size(177, 21);
            this.txtBilltoAdd.TabIndex = 1161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 1160;
            this.label7.Text = "Bill to Add";
            // 
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this.cbPOStatus);
            this._GroupBox1.Controls.Add(this.label4);
            this._GroupBox1.Controls.Add(this.dtpRBDate);
            this._GroupBox1.Controls.Add(this.label5);
            this._GroupBox1.Controls.Add(this.txtGSTIN);
            this._GroupBox1.Controls.Add(this.labelPONum);
            this._GroupBox1.Controls.Add(this.cbPONum);
            this._GroupBox1.Controls.Add(this.dtpPODate);
            this._GroupBox1.Controls.Add(this._Label3);
            this._GroupBox1.Controls.Add(this._Label10);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Location = new System.Drawing.Point(9, 2);
            this._GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox1.Size = new System.Drawing.Size(319, 169);
            this._GroupBox1.TabIndex = 0;
            this._GroupBox1.TabStop = false;
            // 
            // cbPOStatus
            // 
            this.cbPOStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPOStatus.Enabled = false;
            this.cbPOStatus.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbPOStatus.FormattingEnabled = true;
            this.cbPOStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "B",
            "C"});
            this.cbPOStatus.Location = new System.Drawing.Point(128, 135);
            this.cbPOStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPOStatus.Name = "cbPOStatus";
            this.cbPOStatus.Size = new System.Drawing.Size(177, 27);
            this.cbPOStatus.TabIndex = 1158;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 1159;
            this.label4.Text = "PO Status";
            // 
            // dtpRBDate
            // 
            this.dtpRBDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpRBDate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.dtpRBDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRBDate.Location = new System.Drawing.Point(128, 110);
            this.dtpRBDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRBDate.Name = "dtpRBDate";
            this.dtpRBDate.Size = new System.Drawing.Size(177, 21);
            this.dtpRBDate.TabIndex = 1153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label5.Location = new System.Drawing.Point(5, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 1154;
            this.label5.Text = "Req by Date";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.BackColor = System.Drawing.Color.White;
            this.txtGSTIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGSTIN.Enabled = false;
            this.txtGSTIN.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtGSTIN.Location = new System.Drawing.Point(128, 79);
            this.txtGSTIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.ReadOnly = true;
            this.txtGSTIN.Size = new System.Drawing.Size(177, 21);
            this.txtGSTIN.TabIndex = 1157;
            // 
            // labelPONum
            // 
            this.labelPONum.AutoSize = true;
            this.labelPONum.Font = new System.Drawing.Font("Calibri", 5.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPONum.Location = new System.Drawing.Point(-3, 6);
            this.labelPONum.Name = "labelPONum";
            this.labelPONum.Size = new System.Drawing.Size(26, 13);
            this.labelPONum.TabIndex = 1156;
            this.labelPONum.Text = "PO #";
            // 
            // cbPONum
            // 
            this.cbPONum.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPONum.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbPONum.FormattingEnabled = true;
            this.cbPONum.Location = new System.Drawing.Point(128, 21);
            this.cbPONum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPONum.Name = "cbPONum";
            this.cbPONum.Size = new System.Drawing.Size(177, 27);
            this.cbPONum.TabIndex = 0;
            this.cbPONum.SelectedIndexChanged += new System.EventHandler(this.cbPONum_SelectedIndexChanged);
            // 
            // dtpPODate
            // 
            this.dtpPODate.CustomFormat = "dd/MMM/yyyy";
            this.dtpPODate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPODate.Location = new System.Drawing.Point(128, 50);
            this.dtpPODate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPODate.Name = "dtpPODate";
            this.dtpPODate.Size = new System.Drawing.Size(177, 21);
            this.dtpPODate.TabIndex = 0;
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label3.Location = new System.Drawing.Point(7, 52);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(60, 19);
            this._Label3.TabIndex = 132;
            this._Label3.Text = "PO Date";
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label1.Location = new System.Drawing.Point(5, 79);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(47, 19);
            this._Label1.TabIndex = 114;
            this._Label1.Text = "GSTIN";
            // 
            // poGrid
            // 
            this.poGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.poGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poGrid.Location = new System.Drawing.Point(13, 370);
            this.poGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poGrid.Name = "poGrid";
            this.poGrid.ReadOnly = true;
            this.poGrid.RowHeadersWidth = 51;
            this.poGrid.RowTemplate.Height = 24;
            this.poGrid.Size = new System.Drawing.Size(1233, 290);
            this.poGrid.TabIndex = 1176;
            this.poGrid.DoubleClick += new System.EventHandler(this.poGrid_DoubleClick);
            // 
            // _Panel2
            // 
            this._Panel2.Controls.Add(this.chkboxEdit);
            this._Panel2.Controls.Add(this.btnDelAll);
            this._Panel2.Controls.Add(this.btnClose);
            this._Panel2.Controls.Add(this._cmdPrint);
            this._Panel2.Controls.Add(this.btnRefresh);
            this._Panel2.Controls.Add(this.btnNew);
            this._Panel2.Controls.Add(this.btnDelete);
            this._Panel2.Controls.Add(this.btnClear);
            this._Panel2.Controls.Add(this._cmdSave);
            this._Panel2.Location = new System.Drawing.Point(12, 12);
            this._Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._Panel2.Name = "_Panel2";
            this._Panel2.Size = new System.Drawing.Size(131, 324);
            this._Panel2.TabIndex = 1173;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 280);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
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
            this._cmdPrint.Location = new System.Drawing.Point(7, 240);
            this._cmdPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.Size = new System.Drawing.Size(115, 37);
            this._cmdPrint.TabIndex = 7;
            this._cmdPrint.Text = "Print";
            this._cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cmdPrint.UseVisualStyleBackColor = false;
            this._cmdPrint.Click += new System.EventHandler(this._cmdPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(7, 202);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 37);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
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
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 6.5F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Del Line Item";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
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
            this._cmdSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmdSave.Name = "_cmdSave";
            this._cmdSave.Size = new System.Drawing.Size(115, 37);
            this._cmdSave.TabIndex = 0;
            this._cmdSave.Text = "  &Save";
            this._cmdSave.UseVisualStyleBackColor = true;
            this._cmdSave.Visible = false;
            // 
            // txtUnitRate
            // 
            this.txtUnitRate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtUnitRate.Location = new System.Drawing.Point(137, 44);
            this.txtUnitRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitRate.Name = "txtUnitRate";
            this.txtUnitRate.Size = new System.Drawing.Size(174, 21);
            this.txtUnitRate.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtQuantity.Location = new System.Drawing.Point(137, 19);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(174, 21);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblUnitRate
            // 
            this.lblUnitRate.AutoSize = true;
            this.lblUnitRate.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.lblUnitRate.Location = new System.Drawing.Point(16, 46);
            this.lblUnitRate.Name = "lblUnitRate";
            this.lblUnitRate.Size = new System.Drawing.Size(66, 19);
            this.lblUnitRate.TabIndex = 87;
            this.lblUnitRate.Text = "Unit Rate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.lblQuantity.Location = new System.Drawing.Point(16, 21);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 19);
            this.lblQuantity.TabIndex = 89;
            this.lblQuantity.Text = "Quantity";
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbColor.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Broken White",
            "Signal White",
            "Pure White",
            "Gray",
            "Black"});
            this.cbColor.Location = new System.Drawing.Point(469, 26);
            this.cbColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(177, 27);
            this.cbColor.TabIndex = 107;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 71);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(80, 19);
            this.lblTotalAmount.TabIndex = 106;
            this.lblTotalAmount.Text = "Tot Amount";
            // 
            // cbProdGroup
            // 
            this.cbProdGroup.BackColor = System.Drawing.SystemColors.Control;
            this.cbProdGroup.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbProdGroup.FormattingEnabled = true;
            this.cbProdGroup.Location = new System.Drawing.Point(137, 27);
            this.cbProdGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProdGroup.Name = "cbProdGroup";
            this.cbProdGroup.Size = new System.Drawing.Size(177, 27);
            this.cbProdGroup.TabIndex = 1237;
            this.cbProdGroup.SelectedIndexChanged += new System.EventHandler(this.cbProdGroup_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnitRate);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblUnitRate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.txtGSTAmount);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Location = new System.Drawing.Point(666, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 135);
            this.groupBox1.TabIndex = 1236;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label14.Location = new System.Drawing.Point(15, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 19);
            this.label14.TabIndex = 116;
            this.label14.Text = "GST";
            // 
            // txtGSTAmount
            // 
            this.txtGSTAmount.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtGSTAmount.Location = new System.Drawing.Point(137, 94);
            this.txtGSTAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGSTAmount.Name = "txtGSTAmount";
            this.txtGSTAmount.Size = new System.Drawing.Size(174, 21);
            this.txtGSTAmount.TabIndex = 115;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtTotalAmount.Location = new System.Drawing.Point(137, 69);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(174, 21);
            this.txtTotalAmount.TabIndex = 11;
            // 
            // _Label20
            // 
            this._Label20.AutoSize = true;
            this._Label20.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label20.Location = new System.Drawing.Point(346, 30);
            this._Label20.Name = "_Label20";
            this._Label20.Size = new System.Drawing.Size(43, 19);
            this._Label20.TabIndex = 98;
            this._Label20.Text = "Color";
            // 
            // _GroupBox4
            // 
            this._GroupBox4.Controls.Add(this.cbProdGroup);
            this._GroupBox4.Controls.Add(this.groupBox1);
            this._GroupBox4.Controls.Add(this.txtProdCode);
            this._GroupBox4.Controls.Add(this.label3);
            this._GroupBox4.Controls.Add(this.label2);
            this._GroupBox4.Controls.Add(this.cbUoM);
            this._GroupBox4.Controls.Add(this.label1);
            this._GroupBox4.Controls.Add(this.cbProductName);
            this._GroupBox4.Controls.Add(this._Label27);
            this._GroupBox4.Controls.Add(this.cbColor);
            this._GroupBox4.Controls.Add(this.txtSpecialNotes);
            this._GroupBox4.Controls.Add(this._Label7);
            this._GroupBox4.Controls.Add(this.txtDetails);
            this._GroupBox4.Controls.Add(this._Label20);
            this._GroupBox4.Controls.Add(this._Label22);
            this._GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._GroupBox4.Font = new System.Drawing.Font("Comfortaa", 9F);
            this._GroupBox4.Location = new System.Drawing.Point(149, 198);
            this._GroupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox4.Name = "_GroupBox4";
            this._GroupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._GroupBox4.Size = new System.Drawing.Size(1006, 155);
            this._GroupBox4.TabIndex = 1175;
            this._GroupBox4.TabStop = false;
            this._GroupBox4.Text = "Product Details";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtProdCode.Location = new System.Drawing.Point(137, 90);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(177, 21);
            this.txtProdCode.TabIndex = 1234;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1158;
            this.label3.Text = "Product Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1233;
            this.label2.Text = "Product Code";
            // 
            // cbUoM
            // 
            this.cbUoM.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbUoM.Items.AddRange(new object[] {
            "SQM",
            "LM",
            "PC"});
            this.cbUoM.Location = new System.Drawing.Point(137, 116);
            this.cbUoM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUoM.Name = "cbUoM";
            this.cbUoM.Size = new System.Drawing.Size(177, 27);
            this.cbUoM.TabIndex = 1230;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.label1.Location = new System.Drawing.Point(16, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1231;
            this.label1.Text = "Unit of Measure";
            // 
            // cbProductName
            // 
            this.cbProductName.BackColor = System.Drawing.SystemColors.Control;
            this.cbProductName.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(137, 58);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(177, 27);
            this.cbProductName.TabIndex = 108;
            this.cbProductName.SelectedIndexChanged += new System.EventHandler(this.cbProductName_SelectedIndexChanged);
            // 
            // _Label27
            // 
            this._Label27.AutoSize = true;
            this._Label27.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label27.Location = new System.Drawing.Point(346, 102);
            this._Label27.Name = "_Label27";
            this._Label27.Size = new System.Drawing.Size(93, 19);
            this._Label27.TabIndex = 102;
            this._Label27.Text = "Special Notes";
            // 
            // txtSpecialNotes
            // 
            this.txtSpecialNotes.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtSpecialNotes.Location = new System.Drawing.Point(469, 100);
            this.txtSpecialNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialNotes.Multiline = true;
            this.txtSpecialNotes.Name = "txtSpecialNotes";
            this.txtSpecialNotes.Size = new System.Drawing.Size(177, 40);
            this.txtSpecialNotes.TabIndex = 3;
            // 
            // _Label7
            // 
            this._Label7.AutoSize = true;
            this._Label7.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label7.Location = new System.Drawing.Point(346, 54);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(50, 19);
            this._Label7.TabIndex = 100;
            this._Label7.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.txtDetails.Location = new System.Drawing.Point(469, 55);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(177, 40);
            this.txtDetails.TabIndex = 2;
            // 
            // _Label22
            // 
            this._Label22.AutoSize = true;
            this._Label22.Font = new System.Drawing.Font("Comfortaa", 7F);
            this._Label22.Location = new System.Drawing.Point(16, 62);
            this._Label22.Name = "_Label22";
            this._Label22.Size = new System.Drawing.Size(98, 19);
            this._Label22.TabIndex = 74;
            this._Label22.Text = "Product Name";
            // 
            // btnPOAddProd
            // 
            this.btnPOAddProd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPOAddProd.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.btnPOAddProd.Location = new System.Drawing.Point(1162, 86);
            this.btnPOAddProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPOAddProd.Name = "btnPOAddProd";
            this.btnPOAddProd.Size = new System.Drawing.Size(88, 30);
            this.btnPOAddProd.TabIndex = 12;
            this.btnPOAddProd.Text = "Add PO";
            this.btnPOAddProd.UseVisualStyleBackColor = false;
            this.btnPOAddProd.Click += new System.EventHandler(this.btnSOAddProd_Click);
            // 
            // btnDelPOWO
            // 
            this.btnDelPOWO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelPOWO.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.btnDelPOWO.Location = new System.Drawing.Point(1162, 159);
            this.btnDelPOWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelPOWO.Name = "btnDelPOWO";
            this.btnDelPOWO.Size = new System.Drawing.Size(88, 30);
            this.btnDelPOWO.TabIndex = 1236;
            this.btnDelPOWO.Text = "Del POs of WO";
            this.btnDelPOWO.UseVisualStyleBackColor = false;
            this.btnDelPOWO.Click += new System.EventHandler(this.btnDelPOWO_Click);
            // 
            // lblGridSource
            // 
            this.lblGridSource.AutoSize = true;
            this.lblGridSource.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.lblGridSource.Location = new System.Drawing.Point(1161, 66);
            this.lblGridSource.Name = "lblGridSource";
            this.lblGridSource.Size = new System.Drawing.Size(60, 19);
            this.lblGridSource.TabIndex = 1318;
            this.lblGridSource.Text = "PO Num";
            // 
            // btnEditPO
            // 
            this.btnEditPO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditPO.Font = new System.Drawing.Font("Comfortaa", 7F);
            this.btnEditPO.Location = new System.Drawing.Point(1162, 122);
            this.btnEditPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPO.Name = "btnEditPO";
            this.btnEditPO.Size = new System.Drawing.Size(88, 30);
            this.btnEditPO.TabIndex = 1319;
            this.btnEditPO.Text = "Edit PO";
            this.btnEditPO.UseVisualStyleBackColor = false;
            this.btnEditPO.Click += new System.EventHandler(this.btnEditPO_Click);
            // 
            // chkboxEdit
            // 
            this.chkboxEdit.AutoEllipsis = true;
            this.chkboxEdit.Font = new System.Drawing.Font("Comfortaa", 6.5F);
            this.chkboxEdit.Location = new System.Drawing.Point(3, 83);
            this.chkboxEdit.Name = "chkboxEdit";
            this.chkboxEdit.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.chkboxEdit.Size = new System.Drawing.Size(125, 36);
            this.chkboxEdit.TabIndex = 10;
            this.chkboxEdit.Text = "Edit Mode";
            this.chkboxEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkboxEdit.UseVisualStyleBackColor = false;
            this.chkboxEdit.CheckedChanged += new System.EventHandler(this.chkboxEdit_CheckedChanged);
            // 
            // FrmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.btnEditPO);
            this.Controls.Add(this.lblGridSource);
            this.Controls.Add(this.btnDelPOWO);
            this.Controls.Add(this._Panel4);
            this.Controls.Add(this.poGrid);
            this.Controls.Add(this._Panel2);
            this.Controls.Add(this._GroupBox4);
            this.Controls.Add(this.btnPOAddProd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPurchaseOrder";
            this.Text = "PurchaseOrder";
            this._GroupBox3.ResumeLayout(false);
            this._GroupBox3.PerformLayout();
            this._Panel4.ResumeLayout(false);
            this._GroupBox2.ResumeLayout(false);
            this._GroupBox2.PerformLayout();
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poGrid)).EndInit();
            this._Panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._GroupBox4.ResumeLayout(false);
            this._GroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _Label10;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.GroupBox _GroupBox3;
        private System.Windows.Forms.Label _Label14;
        private System.Windows.Forms.Panel _Panel4;
        private System.Windows.Forms.GroupBox _GroupBox2;
        private System.Windows.Forms.DateTimePicker dtpPODate;
        private System.Windows.Forms.Label _Label3;
        private System.Windows.Forms.Label _Label2;
        private System.Windows.Forms.GroupBox _GroupBox1;
        private System.Windows.Forms.Label labelPONum;
        private System.Windows.Forms.ComboBox cbPONum;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.DataGridView poGrid;
        private System.Windows.Forms.Panel _Panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button _cmdPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button _cmdSave;
        private System.Windows.Forms.TextBox txtUnitRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUnitRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ComboBox cbProdGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label _Label20;
        private System.Windows.Forms.GroupBox _GroupBox4;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Label _Label27;
        private System.Windows.Forms.TextBox txtSpecialNotes;
        private System.Windows.Forms.Label _Label7;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnPOAddProd;
        private System.Windows.Forms.Label _Label22;
        private System.Windows.Forms.DateTimePicker dtpRBDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShiptoAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBilltoAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSupGST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSupAdd;
        private System.Windows.Forms.TextBox txtSupCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGSTAmount;
        private System.Windows.Forms.TextBox txtWONum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDelPOWO;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.Label lblGridSource;
        private System.Windows.Forms.ComboBox cbPOStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPrepBy;
        private System.Windows.Forms.Button btnEditPO;
        private System.Windows.Forms.CheckBox chkboxEdit;
    }
}