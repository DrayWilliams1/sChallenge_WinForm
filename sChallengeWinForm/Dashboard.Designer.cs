
namespace sChallengeWinForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.logPatientButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.appTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkGray;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.Location = new System.Drawing.Point(713, 402);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 36);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(61, 150);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(132, 25);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = " {{User name}}";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // helpLink
            // 
            this.helpLink.AutoSize = true;
            this.helpLink.Location = new System.Drawing.Point(17, 420);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(32, 15);
            this.helpLink.TabIndex = 7;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "Help";
            // 
            // logPatientButton
            // 
            this.logPatientButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logPatientButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logPatientButton.ForeColor = System.Drawing.Color.White;
            this.logPatientButton.Location = new System.Drawing.Point(69, 213);
            this.logPatientButton.Name = "logPatientButton";
            this.logPatientButton.Size = new System.Drawing.Size(284, 113);
            this.logPatientButton.TabIndex = 8;
            this.logPatientButton.Text = "Add Patient Details";
            this.logPatientButton.UseVisualStyleBackColor = false;
            this.logPatientButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(432, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 113);
            this.button2.TabIndex = 9;
            this.button2.Text = "Coming Soon...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(61, 27);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(234, 61);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.companyLogo.TabIndex = 10;
            this.companyLogo.TabStop = false;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(61, 89);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(214, 30);
            this.appTitle.TabIndex = 11;
            this.appTitle.Text = "COVID-19 Telehealth";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.companyLogo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logPatientButton);
            this.Controls.Add(this.helpLink);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logoutButton);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel helpLink;
        private System.Windows.Forms.Button logPatientButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label appTitle;
    }
}