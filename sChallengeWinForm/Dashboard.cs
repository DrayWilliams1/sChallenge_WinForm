﻿using System;
using System.Windows.Forms;

namespace sChallengeWinForm
{
    public partial class Dashboard : Form
    {
        private long userId;
        public Login OwningWindowSettings { get; set; } // the login form which invoked the dashboard
        public Dashboard(long userId, string username)
        {
            InitializeComponent();

            usernameLabel.Text = "Welcome " + username;
            this.userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if(OwningWindowSettings != null)
            {
                OwningWindowSettings.Show();
            } else
            {
                Login lf = new Login();
                lf.Show();
            }

            this.Close(); // hide the dashboard form
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm(userId);
            pf.OwningWindowSettings = this;
            pf.Show();

            this.Hide();
        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
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
