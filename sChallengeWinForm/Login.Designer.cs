
namespace sChallengeWinForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginForm = new System.Windows.Forms.GroupBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.appTitle = new System.Windows.Forms.Label();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.loginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(28, 41);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(60, 15);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(30, 92);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(57, 15);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // loginForm
            // 
            this.loginForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginForm.Controls.Add(this.passInput);
            this.loginForm.Controls.Add(this.userInput);
            this.loginForm.Controls.Add(this.loginButton);
            this.loginForm.Controls.Add(this.userLabel);
            this.loginForm.Controls.Add(this.passLabel);
            this.loginForm.Location = new System.Drawing.Point(222, 154);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(366, 182);
            this.loginForm.TabIndex = 2;
            this.loginForm.TabStop = false;
            this.loginForm.Text = "User Login";
            this.loginForm.Enter += new System.EventHandler(this.loginForm_Enter);
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.Color.GhostWhite;
            this.passInput.Location = new System.Drawing.Point(128, 89);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(187, 23);
            this.passInput.TabIndex = 5;
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.GhostWhite;
            this.userInput.Location = new System.Drawing.Point(128, 38);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(187, 23);
            this.userInput.TabIndex = 3;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.AliceBlue;
            this.loginButton.Location = new System.Drawing.Point(152, 137);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(295, 92);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(214, 30);
            this.appTitle.TabIndex = 3;
            this.appTitle.Text = "COVID-19 Telehealth";
            this.appTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(284, 26);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(234, 61);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.companyLogo.TabIndex = 5;
            this.companyLogo.TabStop = false;
            // 
            // helpLink
            // 
            this.helpLink.AutoSize = true;
            this.helpLink.Location = new System.Drawing.Point(13, 423);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(32, 15);
            this.helpLink.TabIndex = 6;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "Help";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpLink);
            this.Controls.Add(this.companyLogo);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.loginForm);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginForm.ResumeLayout(false);
            this.loginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.GroupBox loginForm;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.LinkLabel helpLink;
    }
}

