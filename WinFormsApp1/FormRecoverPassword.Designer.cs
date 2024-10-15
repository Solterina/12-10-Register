namespace WinFormsApp1
{
    partial class FormRecoverPassword
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
            lblQuestion = new Label();
            txtawt1 = new Label();
            txtRecoverLogin = new TextBox();
            lblLogin = new Label();
            btnNext = new Button();
            btnSubmitAnswer = new Button();
            lblRecoveredPassword = new Label();
            label2 = new Label();
            txtAnswer = new TextBox();
            blQuestion = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Transparent;
            lblQuestion.Location = new Point(74, 196);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(244, 27);
            lblQuestion.TabIndex = 35;
            lblQuestion.Text = "Контрольный вопрос";
            lblQuestion.Visible = false;
            // 
            // txtawt1
            // 
            txtawt1.AutoSize = true;
            txtawt1.BackColor = Color.Transparent;
            txtawt1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtawt1.ForeColor = SystemColors.ButtonHighlight;
            txtawt1.Location = new Point(185, 37);
            txtawt1.Margin = new Padding(4, 0, 4, 0);
            txtawt1.Name = "txtawt1";
            txtawt1.Size = new Size(404, 41);
            txtawt1.TabIndex = 33;
            txtawt1.Text = "Востановление пароля";
            // 
            // txtRecoverLogin
            // 
            txtRecoverLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtRecoverLogin.ForeColor = Color.Black;
            txtRecoverLogin.Location = new Point(145, 127);
            txtRecoverLogin.Margin = new Padding(4, 3, 4, 3);
            txtRecoverLogin.Name = "txtRecoverLogin";
            txtRecoverLogin.Size = new Size(320, 35);
            txtRecoverLogin.TabIndex = 29;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(139, 92);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(173, 27);
            lblLogin.TabIndex = 28;
            lblLogin.Text = "Введите логин";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnNext.Location = new Point(506, 127);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 35);
            btnNext.TabIndex = 38;
            btnNext.Text = "Далее";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSubmitAnswer.Location = new Point(284, 299);
            btnSubmitAnswer.Margin = new Padding(4, 3, 4, 3);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(181, 39);
            btnSubmitAnswer.TabIndex = 39;
            btnSubmitAnswer.Text = "Проверить";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Visible = false;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // lblRecoveredPassword
            // 
            lblRecoveredPassword.AutoSize = true;
            lblRecoveredPassword.BackColor = Color.Transparent;
            lblRecoveredPassword.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecoveredPassword.ForeColor = Color.Transparent;
            lblRecoveredPassword.Location = new Point(211, 360);
            lblRecoveredPassword.Margin = new Padding(4, 0, 4, 0);
            lblRecoveredPassword.Name = "lblRecoveredPassword";
            lblRecoveredPassword.Size = new Size(145, 27);
            lblRecoveredPassword.TabIndex = 40;
            lblRecoveredPassword.Text = "Ваш пароль";
            lblRecoveredPassword.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(409, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 27);
            label2.TabIndex = 42;
            label2.Text = "Ответ на контрольный вопрос";
            label2.Visible = false;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAnswer.ForeColor = Color.Black;
            txtAnswer.Location = new Point(415, 233);
            txtAnswer.Margin = new Padding(4, 3, 4, 3);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(320, 35);
            txtAnswer.TabIndex = 41;
            txtAnswer.UseSystemPasswordChar = true;
            txtAnswer.Visible = false;
            // 
            // blQuestion
            // 
            blQuestion.Font = new Font("Segoe UI", 14F);
            blQuestion.Location = new Point(74, 231);
            blQuestion.Name = "blQuestion";
            blQuestion.Size = new Size(262, 35);
            blQuestion.TabIndex = 43;
            blQuestion.Visible = false;
            // 
            // FormRecoverPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._80824ca68c16f57fec97e144c6518cc23ff4820b;
            ClientSize = new Size(777, 450);
            Controls.Add(blQuestion);
            Controls.Add(label2);
            Controls.Add(txtAnswer);
            Controls.Add(lblRecoveredPassword);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Controls.Add(txtawt1);
            Controls.Add(txtRecoverLogin);
            Controls.Add(lblLogin);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRecoverPassword";
            Text = "FormRecoverPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label txtawt1;
        private System.Windows.Forms.TextBox txtRecoverLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblRecoveredPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private Label blQuestion;
    }
}