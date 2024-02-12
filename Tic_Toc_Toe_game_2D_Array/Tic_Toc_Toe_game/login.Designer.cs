namespace Tic_Toc_Toe_game
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            buttonLogin = new Button();
            buttonCancel = new Button();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonRate = new Button();
            buttonFB = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(363, 130);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(82, 31);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(469, 130);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 31);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(408, 20);
            textBoxUserName.Margin = new Padding(3, 2, 3, 2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(110, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(408, 67);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(81, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(295, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(305, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // buttonRate
            // 
            buttonRate.BackgroundImage = Properties.Resources.rate;
            buttonRate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRate.Location = new Point(172, 121);
            buttonRate.Margin = new Padding(3, 2, 3, 2);
            buttonRate.Name = "buttonRate";
            buttonRate.Size = new Size(82, 40);
            buttonRate.TabIndex = 7;
            buttonRate.UseVisualStyleBackColor = true;
            // 
            // buttonFB
            // 
            buttonFB.BackgroundImage = (Image)resources.GetObject("buttonFB.BackgroundImage");
            buttonFB.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFB.Location = new Point(50, 121);
            buttonFB.Margin = new Padding(3, 2, 3, 2);
            buttonFB.Name = "buttonFB";
            buttonFB.Size = new Size(116, 40);
            buttonFB.TabIndex = 6;
            buttonFB.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.champion_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(571, 170);
            Controls.Add(buttonRate);
            Controls.Add(buttonFB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonCancel;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonRate;
        private Button buttonFB;
    }
}