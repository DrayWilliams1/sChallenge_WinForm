using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sChallengeWinForm
{
    public partial class PatientForm : Form
    {
        private long userId;
        HttpOperations operations = HttpOperations.OperationsInstance;

        public Dashboard OwningWindowSettings { get; set; } // the dashboard form which invoked the patient form

        public PatientForm(long userId)
        {
            InitializeComponent();
            notesInput.Multiline = true; // allows notes textbox to be multiline
            this.userId = userId;
        }

        //private validate

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (OwningWindowSettings != null)
            {
                OwningWindowSettings.Show();
            }

            this.Close(); // hide the patient form
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(firstNameInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            try
            {
                bool hasCovid = false;

                // Using a for each maintains safety if multiple types of controls exist within form grouping (there are alternate solutions)
                foreach( Control c in covidGroup.Controls)
                {
                    if (c.GetType() == typeof(RadioButton))
                    {
                        RadioButton radio = c as RadioButton;
                        if (radio.Checked)
                        {
                            string value = radio.Tag.ToString();
                            
                            switch(value)
                            {
                                case "true":
                                    hasCovid = true;
                                    break;
                                case "false":
                                    hasCovid = false;
                                    break;
                            }
                        }
                    }
                }

                Uri patLocation = await operations.postPatient(new HttpOperations.Patient
                {
                    FirstName = firstNameInput.Text,
                    LastName = lastNameInput.Text,
                    BirthDate = birthDatePicker.Value.Date,
                    Street = streetInput.Text,
                    City = cityInput.Text,
                    Province = provinceInput.Text,
                    Country = countryInput.Text,
                    HasCovid = hasCovid,
                    Phone = phoneInput.Text,
                    Email = emailInput.Text,
                    Health_Notes = notesInput.Text,
                    Call_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                    AgentId = userId
                });

                MessageBox.Show("Success! Patient created at: " + patLocation);

                this.Close();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (OwningWindowSettings != null)
            {
                OwningWindowSettings.Show();
            }
        }

        private void firstNameInput_Validating(object sender, CancelEventArgs e)
        {
            /*if(string.IsNullOrEmpty(firstNameInput.Text))
            {
                e.Cancel = true;
                firstNameInput.Focus();
                fnErrorProvider.SetError(firstNameInput, "First Name required.");
            } else
            {
                e.Cancel = false;
                fnErrorProvider.SetError(firstNameInput, null);
            }*/
        }
    }
}
