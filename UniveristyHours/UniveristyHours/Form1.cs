/* 
 * Project: University Hours
 * Programmer: Rania Maaraba
 * Date: September 2022
 * Description: A button based system to display the hours of said department at the University of Toledo
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace UniveristyHours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentLearningButton_Click(object sender, EventArgs e)
        {
            // Diplay the Student Learning Center Hours

            messageLabel.Text = "10:00-18:00";
        }

        private void financialAidButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "09:00-16:45";
        }

        private void counsellingButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "09:00-17:00";
        }

        private void bookstoreButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "09:00-17:00";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}