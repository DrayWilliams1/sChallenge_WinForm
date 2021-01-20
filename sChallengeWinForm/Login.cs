using System;
using System.Windows.Forms;

namespace sChallengeWinForm
{
    public partial class Login : Form
    {
        HttpOperations operations = HttpOperations.OperationsInstance;

        public Login()
        {
            InitializeComponent();
            passInput.UseSystemPasswordChar = true; // hides the user's password input
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = userInput.Text;
            string password = passInput.Text;

            try // performing login operation within a try-catch block for safety
            {
                
                object req = await operations.login(username, password);

                bool success = (bool)req.GetType().GetProperty("success").GetValue(req);

                if(success)
                {
                    long userId = (long)req.GetType().GetProperty("userId").GetValue(req);

                    MessageBox.Show("Login Sucessful.");

                    Dashboard dashboard = new Dashboard(userId,username);   // sending the username to avoid an additional API call upon dashboard entry (to retrieve user object)
                    dashboard.OwningWindowSettings = this;
                    dashboard.Show();                                       // reveals the dashboard form
                    this.Hide();                                            // hides the login form
                } else
                {
                    MessageBox.Show("Invalid Username and/or Password.");
                }

                userInput.Text = ""; // reset username field
                passInput.Text = ""; // reset password field

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Enter(object sender, EventArgs e)
        {

        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to open selected link.");
            }
        }

        private void VisitLink()
        {
            var helpUrl = "https://github.com/DrayWilliams1/sChallenge_WinForm";
            helpLink.LinkVisited = true; // changes the colour of the link once it has been visited
            System.Diagnostics.Process.Start("explorer.exe", helpUrl); // Opens the link using the default browswer
        }
    }
}
