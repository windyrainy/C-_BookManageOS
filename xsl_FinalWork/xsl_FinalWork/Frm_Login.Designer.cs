namespace xsl_FinalWork
{
    partial class Frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new xsl_FinalWork.TextBox_tm();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_Pwd);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(128, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 328);
            this.panel1.TabIndex = 0;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Pwd.Location = new System.Drawing.Point(135, 129);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(221, 29);
            this.txt_Pwd.TabIndex = 17;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(135, 72);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(221, 29);
            this.txt_Name.TabIndex = 16;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Exit.Location = new System.Drawing.Point(69, 225);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 40);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "退出(&E)";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.Location = new System.Drawing.Point(241, 225);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(104, 40);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "登录(&L)";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(65, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.SystemColors.Control;
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_User.Location = new System.Drawing.Point(136, 75);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(220, 22);
            this.txt_User.TabIndex = 11;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生德育管理系统";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private TextBox_tm txt_User;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_Name;
    }
}

