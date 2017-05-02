namespace Nhân_Viên
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label manvLabel;
            System.Windows.Forms.Label tennvLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label socmtLabel;
            System.Windows.Forms.Label congviecLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label luongLabel;
            this.nvstDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNV = new Nhân_Viên.tbNV();
            this.manvTextBox = new System.Windows.Forms.TextBox();
            this.tennvTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.socmtTextBox = new System.Windows.Forms.TextBox();
            this.congviecTextBox = new System.Windows.Forms.TextBox();
            this.ghichuTextBox = new System.Windows.Forms.TextBox();
            this.luongTextBox = new System.Windows.Forms.TextBox();
            this.btnF = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gprThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nvstTableAdapter = new Nhân_Viên.tbNVTableAdapters.nvstTableAdapter();
            this.tableAdapterManager = new Nhân_Viên.tbNVTableAdapters.TableAdapterManager();
            manvLabel = new System.Windows.Forms.Label();
            tennvLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            socmtLabel = new System.Windows.Forms.Label();
            congviecLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            luongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nvstDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNV)).BeginInit();
            this.gprThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // manvLabel
            // 
            manvLabel.AutoSize = true;
            manvLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            manvLabel.Location = new System.Drawing.Point(9, 24);
            manvLabel.Name = "manvLabel";
            manvLabel.Size = new System.Drawing.Size(78, 13);
            manvLabel.TabIndex = 2;
            manvLabel.Text = "Mã Nhân Viên:";
            // 
            // tennvLabel
            // 
            tennvLabel.AutoSize = true;
            tennvLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            tennvLabel.Location = new System.Drawing.Point(5, 50);
            tennvLabel.Name = "tennvLabel";
            tennvLabel.Size = new System.Drawing.Size(82, 13);
            tennvLabel.TabIndex = 4;
            tennvLabel.Text = "Tên Nhân Viên:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ngaysinhLabel.Location = new System.Drawing.Point(28, 76);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(59, 13);
            ngaysinhLabel.TabIndex = 6;
            ngaysinhLabel.Text = "Ngày Sinh:";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            gioitinhLabel.Location = new System.Drawing.Point(33, 102);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(54, 13);
            gioitinhLabel.TabIndex = 8;
            gioitinhLabel.Text = "Giới Tính:";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            diachiLabel.Location = new System.Drawing.Point(43, 128);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(44, 13);
            diachiLabel.TabIndex = 10;
            diachiLabel.Text = "Địa Chỉ:";
            // 
            // socmtLabel
            // 
            socmtLabel.AutoSize = true;
            socmtLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            socmtLabel.Location = new System.Drawing.Point(331, 24);
            socmtLabel.Name = "socmtLabel";
            socmtLabel.Size = new System.Drawing.Size(49, 13);
            socmtLabel.TabIndex = 12;
            socmtLabel.Text = "Số CMT:";
            // 
            // congviecLabel
            // 
            congviecLabel.AutoSize = true;
            congviecLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            congviecLabel.Location = new System.Drawing.Point(321, 50);
            congviecLabel.Name = "congviecLabel";
            congviecLabel.Size = new System.Drawing.Size(59, 13);
            congviecLabel.TabIndex = 14;
            congviecLabel.Text = "Công Việc:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ghichuLabel.Location = new System.Drawing.Point(332, 76);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(48, 13);
            ghichuLabel.TabIndex = 16;
            ghichuLabel.Text = "Ghi Chú:";
            // 
            // luongLabel
            // 
            luongLabel.AutoSize = true;
            luongLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            luongLabel.Location = new System.Drawing.Point(308, 175);
            luongLabel.Name = "luongLabel";
            luongLabel.Size = new System.Drawing.Size(72, 13);
            luongLabel.TabIndex = 18;
            luongLabel.Text = "Lương/tháng:";
            // 
            // nvstDataGridView
            // 
            this.nvstDataGridView.AutoGenerateColumns = false;
            this.nvstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nvstDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.nvstDataGridView.DataSource = this.nvstBindingSource;
            this.nvstDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nvstDataGridView.Location = new System.Drawing.Point(0, 257);
            this.nvstDataGridView.Name = "nvstDataGridView";
            this.nvstDataGridView.Size = new System.Drawing.Size(986, 277);
            this.nvstDataGridView.TabIndex = 1;
            this.nvstDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nvstDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "manv";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tennv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhân Viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngaysinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gioitinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "socmt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số CMT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "congviec";
            this.dataGridViewTextBoxColumn7.HeaderText = "Công Việc";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ghichu";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "luong";
            this.dataGridViewTextBoxColumn9.HeaderText = "Lương/tháng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // nvstBindingSource
            // 
            this.nvstBindingSource.DataMember = "nvst";
            this.nvstBindingSource.DataSource = this.tbNV;
            // 
            // tbNV
            // 
            this.tbNV.DataSetName = "tbNV";
            this.tbNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manvTextBox
            // 
            this.manvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "manv", true));
            this.manvTextBox.Location = new System.Drawing.Point(93, 21);
            this.manvTextBox.Name = "manvTextBox";
            this.manvTextBox.Size = new System.Drawing.Size(145, 20);
            this.manvTextBox.TabIndex = 3;
            // 
            // tennvTextBox
            // 
            this.tennvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "tennv", true));
            this.tennvTextBox.Location = new System.Drawing.Point(93, 47);
            this.tennvTextBox.Name = "tennvTextBox";
            this.tennvTextBox.Size = new System.Drawing.Size(189, 20);
            this.tennvTextBox.TabIndex = 5;
            // 
            // ngaysinhTextBox
            // 
            this.ngaysinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "ngaysinh", true));
            this.ngaysinhTextBox.Location = new System.Drawing.Point(93, 73);
            this.ngaysinhTextBox.Name = "ngaysinhTextBox";
            this.ngaysinhTextBox.Size = new System.Drawing.Size(121, 20);
            this.ngaysinhTextBox.TabIndex = 7;
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "gioitinh", true));
            this.gioitinhTextBox.Location = new System.Drawing.Point(93, 99);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(71, 20);
            this.gioitinhTextBox.TabIndex = 9;
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(93, 125);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(138, 20);
            this.diachiTextBox.TabIndex = 11;
            // 
            // socmtTextBox
            // 
            this.socmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "socmt", true));
            this.socmtTextBox.Location = new System.Drawing.Point(386, 21);
            this.socmtTextBox.Name = "socmtTextBox";
            this.socmtTextBox.Size = new System.Drawing.Size(160, 20);
            this.socmtTextBox.TabIndex = 13;
            // 
            // congviecTextBox
            // 
            this.congviecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "congviec", true));
            this.congviecTextBox.Location = new System.Drawing.Point(386, 47);
            this.congviecTextBox.Name = "congviecTextBox";
            this.congviecTextBox.Size = new System.Drawing.Size(121, 20);
            this.congviecTextBox.TabIndex = 15;
            // 
            // ghichuTextBox
            // 
            this.ghichuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "ghichu", true));
            this.ghichuTextBox.Location = new System.Drawing.Point(386, 73);
            this.ghichuTextBox.Multiline = true;
            this.ghichuTextBox.Name = "ghichuTextBox";
            this.ghichuTextBox.Size = new System.Drawing.Size(178, 95);
            this.ghichuTextBox.TabIndex = 17;
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nvstBindingSource, "luong", true));
            this.luongTextBox.Location = new System.Drawing.Point(386, 172);
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Size = new System.Drawing.Size(164, 20);
            this.luongTextBox.TabIndex = 19;
            // 
            // btnF
            // 
            this.btnF.ForeColor = System.Drawing.Color.Indigo;
            this.btnF.Location = new System.Drawing.Point(6, 19);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 29);
            this.btnF.TabIndex = 20;
            this.btnF.Text = "<<";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnP
            // 
            this.btnP.ForeColor = System.Drawing.Color.Indigo;
            this.btnP.Location = new System.Drawing.Point(87, 19);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 29);
            this.btnP.TabIndex = 21;
            this.btnP.Text = "<";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnN
            // 
            this.btnN.ForeColor = System.Drawing.Color.Indigo;
            this.btnN.Location = new System.Drawing.Point(168, 19);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 29);
            this.btnN.TabIndex = 22;
            this.btnN.Text = ">";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnL
            // 
            this.btnL.ForeColor = System.Drawing.Color.Indigo;
            this.btnL.Location = new System.Drawing.Point(249, 19);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 29);
            this.btnL.TabIndex = 23;
            this.btnL.Text = ">>";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Indigo;
            this.btnThem.Location = new System.Drawing.Point(6, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Indigo;
            this.btnXoa.Location = new System.Drawing.Point(80, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Indigo;
            this.btnSua.Location = new System.Drawing.Point(168, 54);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Indigo;
            this.btnLuu.Location = new System.Drawing.Point(249, 54);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ForeColor = System.Drawing.Color.Indigo;
            this.btnHuy.Location = new System.Drawing.Point(6, 89);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(318, 29);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // gprThongTin
            // 
            this.gprThongTin.Controls.Add(manvLabel);
            this.gprThongTin.Controls.Add(this.manvTextBox);
            this.gprThongTin.Controls.Add(tennvLabel);
            this.gprThongTin.Controls.Add(this.tennvTextBox);
            this.gprThongTin.Controls.Add(ngaysinhLabel);
            this.gprThongTin.Controls.Add(this.ngaysinhTextBox);
            this.gprThongTin.Controls.Add(gioitinhLabel);
            this.gprThongTin.Controls.Add(this.gioitinhTextBox);
            this.gprThongTin.Controls.Add(diachiLabel);
            this.gprThongTin.Controls.Add(this.diachiTextBox);
            this.gprThongTin.Controls.Add(socmtLabel);
            this.gprThongTin.Controls.Add(this.socmtTextBox);
            this.gprThongTin.Controls.Add(congviecLabel);
            this.gprThongTin.Controls.Add(this.congviecTextBox);
            this.gprThongTin.Controls.Add(ghichuLabel);
            this.gprThongTin.Controls.Add(this.ghichuTextBox);
            this.gprThongTin.Controls.Add(luongLabel);
            this.gprThongTin.Controls.Add(this.luongTextBox);
            this.gprThongTin.ForeColor = System.Drawing.Color.DarkRed;
            this.gprThongTin.Location = new System.Drawing.Point(16, 41);
            this.gprThongTin.Name = "gprThongTin";
            this.gprThongTin.Size = new System.Drawing.Size(603, 209);
            this.gprThongTin.TabIndex = 29;
            this.gprThongTin.TabStop = false;
            this.gprThongTin.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnL);
            this.groupBox1.Controls.Add(this.btnN);
            this.groupBox1.Controls.Add(this.btnP);
            this.groupBox1.Controls.Add(this.btnF);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(627, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 209);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÁC VỤ";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(6, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 29);
            this.button2.TabIndex = 30;
            this.button2.Text = "Báo Cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(6, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ KHÁCH SẠN CENTURY";
            // 
            // nvstTableAdapter
            // 
            this.nvstTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nvstTableAdapter = this.nvstTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nhân_Viên.tbNVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gprThongTin);
            this.Controls.Add(this.nvstDataGridView);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "PHẦN MỀM QUẢN LÝ NHÂN SỰ KHÁCH SẠN CENTURY - V1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvstDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNV)).EndInit();
            this.gprThongTin.ResumeLayout(false);
            this.gprThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tbNV tbNV;
        private System.Windows.Forms.BindingSource nvstBindingSource;
        private tbNVTableAdapters.nvstTableAdapter nvstTableAdapter;
        private tbNVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nvstDataGridView;
        private System.Windows.Forms.TextBox manvTextBox;
        private System.Windows.Forms.TextBox tennvTextBox;
        private System.Windows.Forms.TextBox ngaysinhTextBox;
        private System.Windows.Forms.TextBox gioitinhTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox socmtTextBox;
        private System.Windows.Forms.TextBox congviecTextBox;
        private System.Windows.Forms.TextBox ghichuTextBox;
        private System.Windows.Forms.TextBox luongTextBox;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox gprThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button2;
    }
}

