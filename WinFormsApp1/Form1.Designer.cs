namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            lblResult = new Label();
            txtawt = new Label();
            btnRegister = new Button();
            btnForgotPassword = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(255, 81);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(77, 27);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.ForeColor = SystemColors.ScrollBar;
            txtLogin.Location = new Point(261, 115);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(318, 35);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(261, 206);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(318, 35);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(352, 265);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(255, 172);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 27);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(410, 344);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtawt
            // 
            txtawt.AutoSize = true;
            txtawt.BackColor = Color.Transparent;
            txtawt.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtawt.ForeColor = SystemColors.ButtonHighlight;
            txtawt.Location = new Point(302, 30);
            txtawt.Margin = new Padding(4, 0, 4, 0);
            txtawt.Name = "txtawt";
            txtawt.Size = new Size(236, 41);
            txtawt.TabIndex = 6;
            txtawt.Text = "Авторизация";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(8, 12);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(195, 38);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnForgotPassword.Location = new Point(8, 56);
            btnForgotPassword.Margin = new Padding(4, 3, 4, 3);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(195, 38);
            btnForgotPassword.TabIndex = 8;
            btnForgotPassword.Text = "Забыли пароль?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._80824ca68c16f57fec97e144c6518cc23ff4820b;
            ClientSize = new Size(799, 442);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtawt);
            Controls.Add(lblResult);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblResult;
        private Label txtawt;
        private Button btnRegister;
        private Button btnForgotPassword;
    }
}

