namespace ch14
{
    partial class FrmAdmin
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
            this.tbl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboQuestion = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRealname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUserShowAll = new System.Windows.Forms.Button();
            this.btnUserQuery = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtUserKey = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.照片 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnItemShowAll = new System.Windows.Forms.Button();
            this.btnItemQuery = new System.Windows.Forms.Button();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnItemDel = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.txtDeliver = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl
            // 
            this.tbl.Controls.Add(this.tabPage1);
            this.tbl.Controls.Add(this.tabPage2);
            this.tbl.Location = new System.Drawing.Point(17, 32);
            this.tbl.Margin = new System.Windows.Forms.Padding(4);
            this.tbl.Name = "tbl";
            this.tbl.SelectedIndex = 0;
            this.tbl.Size = new System.Drawing.Size(955, 559);
            this.tbl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnUserShowAll);
            this.tabPage1.Controls.Add(this.btnUserQuery);
            this.tabPage1.Controls.Add(this.cboType);
            this.tabPage1.Controls.Add(this.txtUserKey);
            this.tabPage1.Controls.Add(this.key);
            this.tabPage1.Controls.Add(this.dgvUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(947, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboQuestion);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cboLevel);
            this.groupBox2.Controls.Add(this.btnUserDel);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtRealname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(8, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // cboQuestion
            // 
            this.cboQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestion.FormattingEnabled = true;
            this.cboQuestion.Items.AddRange(new object[] {
            ""});
            this.cboQuestion.Location = new System.Drawing.Point(697, 81);
            this.cboQuestion.Name = "cboQuestion";
            this.cboQuestion.Size = new System.Drawing.Size(121, 23);
            this.cboQuestion.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pic);
            this.groupBox4.Location = new System.Drawing.Point(88, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 200);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "照片（可选 单击选择）";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pic.Location = new System.Drawing.Point(22, 22);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(197, 159);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 28;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboLevel.Location = new System.Drawing.Point(498, 154);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 23);
            this.cboLevel.TabIndex = 15;
            // 
            // btnUserDel
            // 
            this.btnUserDel.Location = new System.Drawing.Point(656, 193);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(75, 29);
            this.btnUserDel.TabIndex = 24;
            this.btnUserDel.Text = "删除";
            this.btnUserDel.UseVisualStyleBackColor = true;
            this.btnUserDel.Click += new System.EventHandler(this.btnUserDel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(536, 193);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "添加";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(697, 129);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(149, 25);
            this.txtAnswer.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(697, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 25);
            this.txtEmail.TabIndex = 16;
            // 
            // txtRealname
            // 
            this.txtRealname.Location = new System.Drawing.Point(498, 114);
            this.txtRealname.Name = "txtRealname";
            this.txtRealname.Size = new System.Drawing.Size(121, 25);
            this.txtRealname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "答案";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(498, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 25);
            this.txtPassword.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "问题";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(498, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 25);
            this.txtUsername.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "邮箱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "用户等级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "真实名字";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "密码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "用户名";
            // 
            // btnUserShowAll
            // 
            this.btnUserShowAll.Location = new System.Drawing.Point(562, 29);
            this.btnUserShowAll.Name = "btnUserShowAll";
            this.btnUserShowAll.Size = new System.Drawing.Size(85, 25);
            this.btnUserShowAll.TabIndex = 6;
            this.btnUserShowAll.Text = "显示全部";
            this.btnUserShowAll.UseVisualStyleBackColor = true;
            this.btnUserShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnUserQuery
            // 
            this.btnUserQuery.Location = new System.Drawing.Point(464, 29);
            this.btnUserQuery.Name = "btnUserQuery";
            this.btnUserQuery.Size = new System.Drawing.Size(85, 25);
            this.btnUserQuery.TabIndex = 5;
            this.btnUserQuery.Text = "查询";
            this.btnUserQuery.UseVisualStyleBackColor = true;
            this.btnUserQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "用户名",
            "名字",
            "等级",
            "邮箱"});
            this.cboType.Location = new System.Drawing.Point(330, 29);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 23);
            this.cboType.TabIndex = 4;
            // 
            // txtUserKey
            // 
            this.txtUserKey.Location = new System.Drawing.Point(217, 29);
            this.txtUserKey.Name = "txtUserKey";
            this.txtUserKey.Size = new System.Drawing.Size(100, 25);
            this.txtUserKey.TabIndex = 3;
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(152, 36);
            this.key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(52, 15);
            this.key.TabIndex = 1;
            this.key.Text = "关键字";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.username,
            this.password,
            this.realname,
            this.userlevel,
            this.email,
            this.question,
            this.answer,
            this.照片});
            this.dgvUser.Location = new System.Drawing.Point(8, 79);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(928, 208);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_CellMouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "userid";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 40;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // realname
            // 
            this.realname.DataPropertyName = "realname";
            this.realname.HeaderText = "名字";
            this.realname.Name = "realname";
            this.realname.ReadOnly = true;
            // 
            // userlevel
            // 
            this.userlevel.DataPropertyName = "userlevel";
            this.userlevel.HeaderText = "等级";
            this.userlevel.Name = "userlevel";
            this.userlevel.ReadOnly = true;
            this.userlevel.Width = 80;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // question
            // 
            this.question.DataPropertyName = "question";
            this.question.HeaderText = "问题";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            // 
            // answer
            // 
            this.answer.DataPropertyName = "answer";
            this.answer.HeaderText = "答案";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // 照片
            // 
            this.照片.DataPropertyName = "pic";
            this.照片.HeaderText = "pic";
            this.照片.Name = "照片";
            this.照片.ReadOnly = true;
            this.照片.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnItemShowAll);
            this.tabPage2.Controls.Add(this.btnItemQuery);
            this.tabPage2.Controls.Add(this.cboField);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtItemKey);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvCheckIn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(947, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "签到信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnItemShowAll
            // 
            this.btnItemShowAll.Location = new System.Drawing.Point(562, 29);
            this.btnItemShowAll.Name = "btnItemShowAll";
            this.btnItemShowAll.Size = new System.Drawing.Size(85, 25);
            this.btnItemShowAll.TabIndex = 4;
            this.btnItemShowAll.Text = "显示全部";
            this.btnItemShowAll.UseVisualStyleBackColor = true;
            this.btnItemShowAll.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnItemQuery
            // 
            this.btnItemQuery.Location = new System.Drawing.Point(464, 29);
            this.btnItemQuery.Name = "btnItemQuery";
            this.btnItemQuery.Size = new System.Drawing.Size(85, 25);
            this.btnItemQuery.TabIndex = 3;
            this.btnItemQuery.Text = "查询";
            this.btnItemQuery.UseVisualStyleBackColor = true;
            this.btnItemQuery.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "签到人",
            "活动id",
            "签到时间",
            "ip"});
            this.cboField.Location = new System.Drawing.Point(330, 29);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 23);
            this.cboField.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnItemDel);
            this.groupBox1.Controls.Add(this.btnItemAdd);
            this.groupBox1.Controls.Add(this.txtDeliver);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(8, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(928, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "活动信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(464, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(351, 178);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "目前的讲座";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 145);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnItemDel
            // 
            this.btnItemDel.Location = new System.Drawing.Point(225, 162);
            this.btnItemDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(100, 29);
            this.btnItemDel.TabIndex = 12;
            this.btnItemDel.Text = "删除";
            this.btnItemDel.UseVisualStyleBackColor = true;
            this.btnItemDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(93, 162);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(100, 29);
            this.btnItemAdd.TabIndex = 11;
            this.btnItemAdd.Text = "创建";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDeliver
            // 
            this.txtDeliver.Location = new System.Drawing.Point(120, 123);
            this.txtDeliver.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeliver.Name = "txtDeliver";
            this.txtDeliver.Size = new System.Drawing.Size(113, 25);
            this.txtDeliver.TabIndex = 8;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(120, 90);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(113, 25);
            this.txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(120, 57);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(113, 25);
            this.txtStart.TabIndex = 6;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(250, 48);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(180, 100);
            this.txtContent.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 25);
            this.txtName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "发起人：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "结束时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "起始时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "内容：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "题目：";
            // 
            // txtItemKey
            // 
            this.txtItemKey.Location = new System.Drawing.Point(217, 29);
            this.txtItemKey.Name = "txtItemKey";
            this.txtItemKey.Size = new System.Drawing.Size(100, 25);
            this.txtItemKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "关键字";
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.Column1,
            this.c3,
            this.c4,
            this.c5});
            this.dgvCheckIn.Location = new System.Drawing.Point(8, 79);
            this.dgvCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheckIn.MultiSelect = false;
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowTemplate.Height = 23;
            this.dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIn.Size = new System.Drawing.Size(896, 211);
            this.dgvCheckIn.TabIndex = 0;
            this.dgvCheckIn.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCheckIn_CellMouseDown);
            // 
            // c1
            // 
            this.c1.DataPropertyName = "checkid";
            this.c1.HeaderText = "id";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Visible = false;
            // 
            // c2
            // 
            this.c2.DataPropertyName = "username";
            this.c2.HeaderText = "签到人";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemid";
            this.Column1.HeaderText = "活动id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // c3
            // 
            this.c3.DataPropertyName = "itemname";
            this.c3.HeaderText = "活动id:活动名称";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 200;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "checktime";
            this.c4.HeaderText = "签到时间";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "ip";
            this.c5.HeaderText = "ip";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作OToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作OToolStripMenuItem
            // 
            this.操作OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户视图ToolStripMenuItem,
            this.管理员视图ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.操作OToolStripMenuItem.Name = "操作OToolStripMenuItem";
            this.操作OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.操作OToolStripMenuItem.Text = "操作(&O)";
            // 
            // 用户视图ToolStripMenuItem
            // 
            this.用户视图ToolStripMenuItem.Name = "用户视图ToolStripMenuItem";
            this.用户视图ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.用户视图ToolStripMenuItem.Text = "用户视图";
            this.用户视图ToolStripMenuItem.Click += new System.EventHandler(this.用户视图ToolStripMenuItem_Click);
            // 
            // 管理员视图ToolStripMenuItem
            // 
            this.管理员视图ToolStripMenuItem.Enabled = false;
            this.管理员视图ToolStripMenuItem.Name = "管理员视图ToolStripMenuItem";
            this.管理员视图ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.管理员视图ToolStripMenuItem.Text = "管理员视图";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "conMenu";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "删除";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 604);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbl);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdmin";
            this.Text = "管理员后台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tbl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.Button btnUserQuery;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtUserKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn realname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn 照片;
        private System.Windows.Forms.Button btnUserShowAll;
        private System.Windows.Forms.Button btnItemShowAll;
        private System.Windows.Forms.Button btnItemQuery;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.TextBox txtItemKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.TextBox txtDeliver;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnItemDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRealname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboQuestion;
    }
}