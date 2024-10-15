namespace WinFormsApp1
{
    partial class FormRegister
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
            btnConfirmRegister = new Button();
            lblLogin = new Label();
            txtNewLogin = new TextBox();
            txtNewPassword = new TextBox();
            lblPassword = new Label();
            txtawt1 = new Label();
            txtQuestion = new TextBox();
            label1 = new Label();
            txtAnswer = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConfirmRegister
            // 
            btnConfirmRegister.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnConfirmRegister.Location = new Point(286, 335);
            btnConfirmRegister.Margin = new Padding(4, 3, 4, 3);
            btnConfirmRegister.Name = "btnConfirmRegister";
            btnConfirmRegister.Size = new Size(273, 48);
            btnConfirmRegister.TabIndex = 10;
            btnConfirmRegister.Text = "Зарегистрироваться";
            btnConfirmRegister.UseVisualStyleBackColor = true;
            btnConfirmRegister.Click += btnConfirmRegister_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(77, 118);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(153, 27);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Новый логин";
            // 
            // txtNewLogin
            // 
            txtNewLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNewLogin.ForeColor = Color.Black;
            txtNewLogin.Location = new Point(83, 152);
            txtNewLogin.Margin = new Padding(4, 3, 4, 3);
            txtNewLogin.Name = "txtNewLogin";
            txtNewLogin.Size = new Size(318, 35);
            txtNewLogin.TabIndex = 8;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(83, 243);
            txtNewPassword.Margin = new Padding(4, 3, 4, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(318, 35);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(77, 209);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(170, 27);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Новый пароль";
            // 
            // txtawt1
            // 
            txtawt1.AutoSize = true;
            txtawt1.BackColor = Color.Transparent;
            txtawt1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtawt1.ForeColor = SystemColors.ButtonHighlight;
            txtawt1.Location = new Point(305, 58);
            txtawt1.Margin = new Padding(4, 0, 4, 0);
            txtawt1.Name = "txtawt1";
            txtawt1.Size = new Size(231, 41);
            txtawt1.TabIndex = 13;
            txtawt1.Text = "Регистрация";
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtQuestion.ForeColor = Color.Black;
            txtQuestion.Location = new Point(455, 152);
            txtQuestion.Margin = new Padding(4, 3, 4, 3);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(318, 35);
            txtQuestion.TabIndex = 14;
            txtQuestion.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(449, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 27);
            label1.TabIndex = 15;
            label1.Text = "Контрольный вопрос";
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAnswer.ForeColor = Color.Black;
            txtAnswer.Location = new Point(455, 243);
            txtAnswer.Margin = new Padding(4, 3, 4, 3);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(318, 35);
            txtAnswer.TabIndex = 16;
            txtAnswer.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(449, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 27);
            label2.TabIndex = 17;
            label2.Text = "Ответ на контрольный вопрос";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._80824ca68c16f57fec97e144c6518cc23ff4820b;
            ClientSize = new Size(832, 459);
            Controls.Add(label2);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(txtQuestion);
            Controls.Add(txtawt1);
            Controls.Add(lblPassword);
            Controls.Add(btnConfirmRegister);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewLogin);
            Controls.Add(lblLogin);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnConfirmRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label txtawt1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
    }
}