namespace Lead.Prim.Cater.UI
{
    partial class Form_ManagerInfo
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
            this.grp_ManagerData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_UpdateAndDelete = new System.Windows.Forms.GroupBox();
            this.lbl_Notice2 = new System.Windows.Forms.Label();
            this.lbl_Notice1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.chk_Emp = new System.Windows.Forms.CheckBox();
            this.chk_Manager = new System.Windows.Forms.CheckBox();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.btn_Delete2 = new System.Windows.Forms.Button();
            this.grp_ManagerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_UpdateAndDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ManagerData
            // 
            this.grp_ManagerData.Controls.Add(this.dataGridView1);
            this.grp_ManagerData.Location = new System.Drawing.Point(13, 13);
            this.grp_ManagerData.Name = "grp_ManagerData";
            this.grp_ManagerData.Size = new System.Drawing.Size(391, 388);
            this.grp_ManagerData.TabIndex = 0;
            this.grp_ManagerData.TabStop = false;
            this.grp_ManagerData.Text = "列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.userName,
            this.userType});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(385, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // num
            // 
            this.num.HeaderText = "编号";
            this.num.MinimumWidth = 8;
            this.num.Name = "num";
            this.num.Width = 150;
            // 
            // userName
            // 
            this.userName.HeaderText = "用户名";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 150;
            // 
            // userType
            // 
            this.userType.HeaderText = "类型";
            this.userType.MinimumWidth = 8;
            this.userType.Name = "userType";
            this.userType.Width = 150;
            // 
            // grp_UpdateAndDelete
            // 
            this.grp_UpdateAndDelete.Controls.Add(this.btn_Delete2);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_Notice2);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_Notice1);
            this.grp_UpdateAndDelete.Controls.Add(this.btn_Cancel);
            this.grp_UpdateAndDelete.Controls.Add(this.btn_Insert);
            this.grp_UpdateAndDelete.Controls.Add(this.chk_Emp);
            this.grp_UpdateAndDelete.Controls.Add(this.chk_Manager);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_UserType);
            this.grp_UpdateAndDelete.Controls.Add(this.textBox2);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_Pwd);
            this.grp_UpdateAndDelete.Controls.Add(this.textBox1);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_UserName);
            this.grp_UpdateAndDelete.Controls.Add(this.txt_Num);
            this.grp_UpdateAndDelete.Controls.Add(this.lbl_Num);
            this.grp_UpdateAndDelete.Location = new System.Drawing.Point(408, 13);
            this.grp_UpdateAndDelete.Name = "grp_UpdateAndDelete";
            this.grp_UpdateAndDelete.Size = new System.Drawing.Size(380, 385);
            this.grp_UpdateAndDelete.TabIndex = 1;
            this.grp_UpdateAndDelete.TabStop = false;
            this.grp_UpdateAndDelete.Text = "添加/修改";
            // 
            // lbl_Notice2
            // 
            this.lbl_Notice2.AutoSize = true;
            this.lbl_Notice2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Notice2.Enabled = false;
            this.lbl_Notice2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Notice2.Location = new System.Drawing.Point(54, 316);
            this.lbl_Notice2.Name = "lbl_Notice2";
            this.lbl_Notice2.Size = new System.Drawing.Size(296, 18);
            this.lbl_Notice2.TabIndex = 12;
            this.lbl_Notice2.Text = "提示：双击表格项，可以在此处修改";
            // 
            // lbl_Notice1
            // 
            this.lbl_Notice1.AutoSize = true;
            this.lbl_Notice1.Enabled = false;
            this.lbl_Notice1.Location = new System.Drawing.Point(54, 197);
            this.lbl_Notice1.Name = "lbl_Notice1";
            this.lbl_Notice1.Size = new System.Drawing.Size(296, 18);
            this.lbl_Notice1.TabIndex = 11;
            this.lbl_Notice1.Text = "这里只是提示，与实际密码位数无关";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(237, 274);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 30);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(57, 274);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(104, 30);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "添加";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // chk_Emp
            // 
            this.chk_Emp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chk_Emp.AutoSize = true;
            this.chk_Emp.Location = new System.Drawing.Point(208, 246);
            this.chk_Emp.Name = "chk_Emp";
            this.chk_Emp.Size = new System.Drawing.Size(70, 22);
            this.chk_Emp.TabIndex = 8;
            this.chk_Emp.Text = "店员";
            this.chk_Emp.UseVisualStyleBackColor = true;
            // 
            // chk_Manager
            // 
            this.chk_Manager.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chk_Manager.AutoSize = true;
            this.chk_Manager.Location = new System.Drawing.Point(107, 246);
            this.chk_Manager.Name = "chk_Manager";
            this.chk_Manager.Size = new System.Drawing.Size(70, 22);
            this.chk_Manager.TabIndex = 7;
            this.chk_Manager.Text = "经理";
            this.chk_Manager.UseVisualStyleBackColor = true;
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Location = new System.Drawing.Point(37, 246);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(44, 18);
            this.lbl_UserType.TabIndex = 6;
            this.lbl_UserType.Text = "类型";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 28);
            this.textBox2.TabIndex = 5;
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(37, 160);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(44, 18);
            this.lbl_Pwd.TabIndex = 4;
            this.lbl_Pwd.Text = "密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 28);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(37, 107);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(62, 18);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "用户名";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(98, 51);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(243, 28);
            this.txt_Num.TabIndex = 1;
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Location = new System.Drawing.Point(37, 54);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(44, 18);
            this.lbl_Num.TabIndex = 0;
            this.lbl_Num.Text = "编号";
            // 
            // btn_Delete2
            // 
            this.btn_Delete2.Location = new System.Drawing.Point(88, 349);
            this.btn_Delete2.Name = "btn_Delete2";
            this.btn_Delete2.Size = new System.Drawing.Size(205, 30);
            this.btn_Delete2.TabIndex = 13;
            this.btn_Delete2.Text = "删除选中店员";
            this.btn_Delete2.UseVisualStyleBackColor = true;
            // 
            // Form_ManagerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_UpdateAndDelete);
            this.Controls.Add(this.grp_ManagerData);
            this.Name = "Form_ManagerInfo";
            this.Text = "店员管理";
            this.grp_ManagerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_UpdateAndDelete.ResumeLayout(false);
            this.grp_UpdateAndDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ManagerData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.GroupBox grp_UpdateAndDelete;
        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.CheckBox chk_Manager;
        private System.Windows.Forms.CheckBox chk_Emp;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Notice1;
        private System.Windows.Forms.Label lbl_Notice2;
        private System.Windows.Forms.Button btn_Delete2;
    }
}