
namespace sChallengeWinForm
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.covid_radio_yes = new System.Windows.Forms.RadioButton();
            this.covid_radio_no = new System.Windows.Forms.RadioButton();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.covidGroup = new System.Windows.Forms.GroupBox();
            this.postalLabel = new System.Windows.Forms.Label();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.appTitle = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.postalInput = new System.Windows.Forms.TextBox();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.provinceInput = new System.Windows.Forms.TextBox();
            this.notesInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.covidGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(41, 89);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(43, 135);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthLabel.Location = new System.Drawing.Point(30, 179);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(97, 21);
            this.birthLabel.TabIndex = 2;
            this.birthLabel.Text = "Date of Birth";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(476, 135);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 21);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetLabel.Location = new System.Drawing.Point(463, 86);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(50, 21);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provinceLabel.Location = new System.Drawing.Point(443, 179);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(70, 21);
            this.provinceLabel.TabIndex = 5;
            this.provinceLabel.Text = "Province";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(447, 227);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(66, 21);
            this.countryLabel.TabIndex = 6;
            this.countryLabel.Text = "Country";
            // 
            // covid_radio_yes
            // 
            this.covid_radio_yes.AutoSize = true;
            this.covid_radio_yes.Location = new System.Drawing.Point(22, 29);
            this.covid_radio_yes.Name = "covid_radio_yes";
            this.covid_radio_yes.Size = new System.Drawing.Size(42, 19);
            this.covid_radio_yes.TabIndex = 7;
            this.covid_radio_yes.TabStop = true;
            this.covid_radio_yes.Tag = "true";
            this.covid_radio_yes.Text = "Yes";
            this.covid_radio_yes.UseVisualStyleBackColor = true;
            this.covid_radio_yes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // covid_radio_no
            // 
            this.covid_radio_no.AutoSize = true;
            this.covid_radio_no.Location = new System.Drawing.Point(22, 61);
            this.covid_radio_no.Name = "covid_radio_no";
            this.covid_radio_no.Size = new System.Drawing.Size(41, 19);
            this.covid_radio_no.TabIndex = 9;
            this.covid_radio_no.TabStop = true;
            this.covid_radio_no.Tag = "false";
            this.covid_radio_no.Text = "No";
            this.covid_radio_no.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(79, 226);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(73, 273);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 21);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesLabel.Location = new System.Drawing.Point(226, 323);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 21);
            this.notesLabel.TabIndex = 12;
            this.notesLabel.Text = "Notes";
            // 
            // covidGroup
            // 
            this.covidGroup.BackColor = System.Drawing.Color.AliceBlue;
            this.covidGroup.Controls.Add(this.covid_radio_yes);
            this.covidGroup.Controls.Add(this.covid_radio_no);
            this.covidGroup.Location = new System.Drawing.Point(64, 325);
            this.covidGroup.Name = "covidGroup";
            this.covidGroup.Size = new System.Drawing.Size(96, 100);
            this.covidGroup.TabIndex = 13;
            this.covidGroup.TabStop = false;
            this.covidGroup.Text = "Has Covid?";
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalLabel.Location = new System.Drawing.Point(422, 275);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(91, 21);
            this.postalLabel.TabIndex = 14;
            this.postalLabel.Text = "Postal Code";
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(476, 16);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(141, 38);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.companyLogo.TabIndex = 15;
            this.companyLogo.TabStop = false;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(620, 28);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(129, 17);
            this.appTitle.TabIndex = 16;
            this.appTitle.Text = "COVID-19 Telehealth";
            // 
            // firstNameInput
            // 
            this.firstNameInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameInput.CausesValidation = false;
            this.firstNameInput.Location = new System.Drawing.Point(143, 87);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(178, 23);
            this.firstNameInput.TabIndex = 17;
            this.firstNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameInput_Validating);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkGray;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.Location = new System.Drawing.Point(27, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 33);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lastNameInput
            // 
            this.lastNameInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameInput.Location = new System.Drawing.Point(143, 133);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(178, 23);
            this.lastNameInput.TabIndex = 19;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(143, 178);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 23);
            this.birthDatePicker.TabIndex = 21;
            // 
            // postalInput
            // 
            this.postalInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postalInput.Location = new System.Drawing.Point(534, 275);
            this.postalInput.Name = "postalInput";
            this.postalInput.Size = new System.Drawing.Size(178, 23);
            this.postalInput.TabIndex = 22;
            // 
            // countryInput
            // 
            this.countryInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.countryInput.Location = new System.Drawing.Point(534, 225);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(178, 23);
            this.countryInput.TabIndex = 23;
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailInput.Location = new System.Drawing.Point(143, 225);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(178, 23);
            this.emailInput.TabIndex = 24;
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phoneInput.Location = new System.Drawing.Point(143, 271);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(178, 23);
            this.phoneInput.TabIndex = 25;
            // 
            // streetInput
            // 
            this.streetInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.streetInput.Location = new System.Drawing.Point(534, 87);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(178, 23);
            this.streetInput.TabIndex = 26;
            // 
            // cityInput
            // 
            this.cityInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cityInput.Location = new System.Drawing.Point(534, 134);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(178, 23);
            this.cityInput.TabIndex = 27;
            // 
            // provinceInput
            // 
            this.provinceInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.provinceInput.Location = new System.Drawing.Point(534, 178);
            this.provinceInput.Name = "provinceInput";
            this.provinceInput.Size = new System.Drawing.Size(178, 23);
            this.provinceInput.TabIndex = 28;
            // 
            // notesInput
            // 
            this.notesInput.AcceptsReturn = true;
            this.notesInput.AcceptsTab = true;
            this.notesInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notesInput.Location = new System.Drawing.Point(226, 347);
            this.notesInput.Multiline = true;
            this.notesInput.Name = "notesInput";
            this.notesInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesInput.Size = new System.Drawing.Size(409, 76);
            this.notesInput.TabIndex = 29;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.OliveDrab;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(674, 364);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 49);
            this.submitButton.TabIndex = 30;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.notesInput);
            this.Controls.Add(this.provinceInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.streetInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.postalInput);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.companyLogo);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.covidGroup);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phone";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.covidGroup.ResumeLayout(false);
            this.covidGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.RadioButton covid_radio_yes;
        private System.Windows.Forms.RadioButton covid_radio_no;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.GroupBox covidGroup;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox postalInput;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox streetInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox provinceInput;
        private System.Windows.Forms.TextBox notesInput;
        private System.Windows.Forms.Button submitButton;
    }
}