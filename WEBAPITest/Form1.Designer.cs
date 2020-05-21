namespace WEBAPITest
{
    partial class Form1
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbid_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.url_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.request_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.response_txt = new System.Windows.Forms.TextBox();
            this.loginUrl_txtfsa = new System.Windows.Forms.Label();
            this.loginUrl_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(824, 104);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "测试";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginUrl_txt);
            this.groupBox1.Controls.Add(this.loginUrl_txtfsa);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.user_txt);
            this.groupBox1.Controls.Add(this.dbid_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆信息配置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账套Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "登陆名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // dbid_txt
            // 
            this.dbid_txt.Location = new System.Drawing.Point(578, 18);
            this.dbid_txt.Name = "dbid_txt";
            this.dbid_txt.Size = new System.Drawing.Size(252, 21);
            this.dbid_txt.TabIndex = 3;
            this.dbid_txt.Text = "5ea0f099c8bbcf";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(54, 46);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(461, 21);
            this.user_txt.TabIndex = 4;
            this.user_txt.Text = "administrator";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(578, 46);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(252, 21);
            this.password_txt.TabIndex = 5;
            this.password_txt.Text = "888888";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "接口Url";
            // 
            // url_txt
            // 
            this.url_txt.Location = new System.Drawing.Point(89, 106);
            this.url_txt.Name = "url_txt";
            this.url_txt.Size = new System.Drawing.Size(717, 21);
            this.url_txt.TabIndex = 3;
            this.url_txt.Text = "http://desktop-ru7vte7/k3cloud/WSL.YY.K3.FIN.PlugIn.API.Cust.ExecuteService,WSL.Y" +
    "Y.K3.FIN.PlugIn.common.kdsvc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.request_txt);
            this.groupBox2.Location = new System.Drawing.Point(35, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 361);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请求信息";
            // 
            // request_txt
            // 
            this.request_txt.Location = new System.Drawing.Point(7, 21);
            this.request_txt.Multiline = true;
            this.request_txt.Name = "request_txt";
            this.request_txt.Size = new System.Drawing.Size(299, 334);
            this.request_txt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.response_txt);
            this.groupBox3.Location = new System.Drawing.Point(354, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 361);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "返回信息";
            // 
            // response_txt
            // 
            this.response_txt.Location = new System.Drawing.Point(7, 21);
            this.response_txt.Multiline = true;
            this.response_txt.Name = "response_txt";
            this.response_txt.Size = new System.Drawing.Size(538, 334);
            this.response_txt.TabIndex = 0;
            // 
            // loginUrl_txtfsa
            // 
            this.loginUrl_txtfsa.AutoSize = true;
            this.loginUrl_txtfsa.Location = new System.Drawing.Point(6, 27);
            this.loginUrl_txtfsa.Name = "loginUrl_txtfsa";
            this.loginUrl_txtfsa.Size = new System.Drawing.Size(23, 12);
            this.loginUrl_txtfsa.TabIndex = 6;
            this.loginUrl_txtfsa.Text = "Url";
            // 
            // loginUrl_txt
            // 
            this.loginUrl_txt.Location = new System.Drawing.Point(54, 19);
            this.loginUrl_txt.Name = "loginUrl_txt";
            this.loginUrl_txt.Size = new System.Drawing.Size(461, 21);
            this.loginUrl_txt.TabIndex = 7;
            this.loginUrl_txt.Text = "http://desktop-ru7vte7/k3cloud/Kingdee.BOS.WebApi.ServicesStub.AuthService.Valida" +
    "teUser.common.kdsvc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.url_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK_btn);
            this.Name = "Form1";
            this.Text = "CloudApi测试工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox dbid_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox url_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox request_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox response_txt;
        private System.Windows.Forms.TextBox loginUrl_txt;
        private System.Windows.Forms.Label loginUrl_txtfsa;
    }
}

