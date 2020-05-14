namespace TestX
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            this._GroupBox2 = new System.Windows.Forms.GroupBox();
            this._PicStudent = new System.Windows.Forms.PictureBox();
            this._PicStdCamera = new System.Windows.Forms.PictureBox();
            this._PicStdRemove = new System.Windows.Forms.PictureBox();
            this._PicStdBrowse = new System.Windows.Forms.PictureBox();
            this.cbUoM = new System.Windows.Forms.ComboBox();
            this._Label1 = new System.Windows.Forms.Label();
            this.cbProdGroup = new System.Windows.Forms.ComboBox();
            this.cbProdName = new System.Windows.Forms.ComboBox();
            this._Label5 = new System.Windows.Forms.Label();
            this._Label4 = new System.Windows.Forms.Label();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProdID = new System.Windows.Forms.ComboBox();
            this.txtMinSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvgSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbManufTrad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._LblRecord = new System.Windows.Forms.Label();
            this._Panel4 = new System.Windows.Forms.Panel();
            this.prodGrid = new System.Windows.Forms.DataGridView();
            this._Panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this._cmdPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this._GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PicStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdBrowse)).BeginInit();
            this._GroupBox1.SuspendLayout();
            this._Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).BeginInit();
            this._Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _GroupBox2
            // 
            this._GroupBox2.Controls.Add(this._PicStudent);
            this._GroupBox2.Controls.Add(this._PicStdCamera);
            this._GroupBox2.Controls.Add(this._PicStdRemove);
            this._GroupBox2.Controls.Add(this._PicStdBrowse);
            this._GroupBox2.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._GroupBox2.Location = new System.Drawing.Point(656, 6);
            this._GroupBox2.Name = "_GroupBox2";
            this._GroupBox2.Size = new System.Drawing.Size(170, 233);
            this._GroupBox2.TabIndex = 4;
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
            // cbUoM
            // 
            this.cbUoM.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUoM.Location = new System.Drawing.Point(173, 169);
            this.cbUoM.Name = "cbUoM";
            this.cbUoM.Size = new System.Drawing.Size(250, 29);
            this.cbUoM.TabIndex = 4;
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(12, 172);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(125, 23);
            this._Label1.TabIndex = 1229;
            this._Label1.Text = "Unit of Measure";
            // 
            // cbProdGroup
            // 
            this.cbProdGroup.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdGroup.Location = new System.Drawing.Point(173, 25);
            this.cbProdGroup.Name = "cbProdGroup";
            this.cbProdGroup.Size = new System.Drawing.Size(249, 29);
            this.cbProdGroup.TabIndex = 2;
            this.cbProdGroup.SelectedIndexChanged += new System.EventHandler(this.cbProdGroup_SelectedIndexChanged);
            // 
            // cbProdName
            // 
            this.cbProdName.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdName.Location = new System.Drawing.Point(173, 60);
            this.cbProdName.Name = "cbProdName";
            this.cbProdName.Size = new System.Drawing.Size(250, 29);
            this.cbProdName.TabIndex = 1;
            this.cbProdName.SelectedIndexChanged += new System.EventHandler(this.cbProdName_SelectedIndexChanged);
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label5.Location = new System.Drawing.Point(10, 28);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(114, 23);
            this._Label5.TabIndex = 1226;
            this._Label5.Text = "Product Group";
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label4.Location = new System.Drawing.Point(12, 63);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(113, 23);
            this._Label4.TabIndex = 1225;
            this._Label4.Text = "Product Name";
            // 
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this.cbProdID);
            this._GroupBox1.Controls.Add(this.txtMinSP);
            this._GroupBox1.Controls.Add(this.label4);
            this._GroupBox1.Controls.Add(this.txtMaxSP);
            this._GroupBox1.Controls.Add(this.label3);
            this._GroupBox1.Controls.Add(this.txtAvgSP);
            this._GroupBox1.Controls.Add(this.cbProdGroup);
            this._GroupBox1.Controls.Add(this._Label5);
            this._GroupBox1.Controls.Add(this.label2);
            this._GroupBox1.Controls.Add(this.cbManufTrad);
            this._GroupBox1.Controls.Add(this.label1);
            this._GroupBox1.Controls.Add(this.cbUoM);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Controls.Add(this.cbProdName);
            this._GroupBox1.Controls.Add(this._Label4);
            this._GroupBox1.Controls.Add(this._Label6);
            this._GroupBox1.Location = new System.Drawing.Point(12, 3);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Size = new System.Drawing.Size(643, 233);
            this._GroupBox1.TabIndex = 3;
            this._GroupBox1.TabStop = false;
            // 
            // cbProdID
            // 
            this.cbProdID.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdID.Location = new System.Drawing.Point(173, 95);
            this.cbProdID.Name = "cbProdID";
            this.cbProdID.Size = new System.Drawing.Size(249, 29);
            this.cbProdID.TabIndex = 0;
            // 
            // txtMinSP
            // 
            this.txtMinSP.BackColor = System.Drawing.Color.White;
            this.txtMinSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMinSP.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinSP.Location = new System.Drawing.Point(523, 24);
            this.txtMinSP.Name = "txtMinSP";
            this.txtMinSP.Size = new System.Drawing.Size(102, 22);
            this.txtMinSP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 1238;
            this.label4.Text = "Min. SP";
            // 
            // txtMaxSP
            // 
            this.txtMaxSP.BackColor = System.Drawing.Color.White;
            this.txtMaxSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaxSP.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSP.Location = new System.Drawing.Point(523, 55);
            this.txtMaxSP.Name = "txtMaxSP";
            this.txtMaxSP.Size = new System.Drawing.Size(102, 22);
            this.txtMaxSP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 1236;
            this.label3.Text = "Max. SP";
            // 
            // txtAvgSP
            // 
            this.txtAvgSP.BackColor = System.Drawing.Color.White;
            this.txtAvgSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAvgSP.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgSP.Location = new System.Drawing.Point(523, 87);
            this.txtAvgSP.Name = "txtAvgSP";
            this.txtAvgSP.Size = new System.Drawing.Size(102, 22);
            this.txtAvgSP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 1234;
            this.label2.Text = "Avg. SP";
            // 
            // cbManufTrad
            // 
            this.cbManufTrad.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManufTrad.Items.AddRange(new object[] {
            "Manufactured",
            "Traded"});
            this.cbManufTrad.Location = new System.Drawing.Point(173, 130);
            this.cbManufTrad.Name = "cbManufTrad";
            this.cbManufTrad.Size = new System.Drawing.Size(250, 29);
            this.cbManufTrad.TabIndex = 3;
            this.cbManufTrad.Text = "Manufactured";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1231;
            this.label1.Text = "Manuf/Traded";
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label6.Location = new System.Drawing.Point(11, 98);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(85, 23);
            this._Label6.TabIndex = 1224;
            this._Label6.Text = "Product ID";
            // 
            // _LblRecord
            // 
            this._LblRecord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LblRecord.ForeColor = System.Drawing.Color.Black;
            this._LblRecord.Location = new System.Drawing.Point(205, 627);
            this._LblRecord.Name = "_LblRecord";
            this._LblRecord.Size = new System.Drawing.Size(111, 18);
            this._LblRecord.TabIndex = 1186;
            this._LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Panel4
            // 
            this._Panel4.Controls.Add(this._GroupBox2);
            this._Panel4.Controls.Add(this._GroupBox1);
            this._Panel4.Location = new System.Drawing.Point(149, 12);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(833, 251);
            this._Panel4.TabIndex = 1178;
            // 
            // prodGrid
            // 
            this.prodGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.prodGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodGrid.Location = new System.Drawing.Point(12, 269);
            this.prodGrid.Name = "prodGrid";
            this.prodGrid.RowHeadersWidth = 51;
            this.prodGrid.RowTemplate.Height = 24;
            this.prodGrid.Size = new System.Drawing.Size(1238, 392);
            this.prodGrid.TabIndex = 2;
            this.prodGrid.DoubleClick += new System.EventHandler(this.prodGrid_DoubleClick);
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
            this._Panel2.Size = new System.Drawing.Size(131, 251);
            this._Panel2.TabIndex = 1196;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(7, 211);
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
            this._cmdPrint.Location = new System.Drawing.Point(7, 172);
            this._cmdPrint.Name = "_cmdPrint";
            this._cmdPrint.Size = new System.Drawing.Size(114, 37);
            this._cmdPrint.TabIndex = 6;
            this._cmdPrint.Text = "      &Print";
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
            this.btnRefresh.Location = new System.Drawing.Point(7, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "       &Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comfortaa", 8F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 91);
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
            this.btnEdit.Location = new System.Drawing.Point(7, 53);
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
            this.btnClear.Location = new System.Drawing.Point(7, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "    C&lear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Comfortaa", 7F, System.Drawing.FontStyle.Bold);
            this.btnAddProd.Location = new System.Drawing.Point(988, 173);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(129, 41);
            this.btnAddProd.TabIndex = 0;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Comfortaa", 7F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.Location = new System.Drawing.Point(988, 222);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(129, 41);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this._Panel2);
            this.Controls.Add(this.prodGrid);
            this.Controls.Add(this._LblRecord);
            this.Controls.Add(this._Panel4);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this._GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PicStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PicStdBrowse)).EndInit();
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            this._Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).EndInit();
            this._Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _GroupBox2;
        private System.Windows.Forms.PictureBox _PicStudent;
        private System.Windows.Forms.PictureBox _PicStdCamera;
        private System.Windows.Forms.PictureBox _PicStdRemove;
        private System.Windows.Forms.PictureBox _PicStdBrowse;
        private System.Windows.Forms.ComboBox cbUoM;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.ComboBox cbProdGroup;
        private System.Windows.Forms.ComboBox cbProdName;
        private System.Windows.Forms.Label _Label5;
        private System.Windows.Forms.Label _Label4;
        private System.Windows.Forms.GroupBox _GroupBox1;
        private System.Windows.Forms.Label _Label6;
        private System.Windows.Forms.Label _LblRecord;
        private System.Windows.Forms.Panel _Panel4;
        private System.Windows.Forms.DataGridView prodGrid;
        private System.Windows.Forms.Panel _Panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button _cmdPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.ComboBox cbManufTrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvgSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProdID;
        private System.Windows.Forms.Button btnExportExcel;
    }
}