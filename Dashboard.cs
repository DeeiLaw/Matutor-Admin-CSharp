﻿using Matutor_Admin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Matutor_Admin
{
    public partial class Dashboard : Form
    {
        private Form activeForm;
        private Button currentButton;
        public Dashboard()
        {
            InitializeComponent();
            button_dash.BackColor = Color.FromArgb(47, 60, 192);
            button_dash.ForeColor = SystemColors.ControlDarkDark;
            button_dash.Enabled = false;
            OpenChildForm(new Forms.FormDashboard());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                DisableButton();
                if(currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(47,60,192);
                    currentButton.ForeColor = SystemColors.ControlDarkDark;
                    currentButton.Enabled = false;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(60, 77, 248);
                    previousBtn.ForeColor = SystemColors.Control;
                    previousBtn.Enabled = true;
                }
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormDashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormRegistration());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormUserManagement());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormManageReview());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormDigitalContent());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormSubscriptions());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_notif_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotif());
            ActiivateButton(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormPosting());
        }

        private void button_booked_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormDashboard());
        }

        private void button_bookings_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormBookings());
        }

        private void button_dash_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormDashboard());
        }

        private void button_addTutor_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormAddTutor());
        }

        private void button_progressReport_Click(object sender, EventArgs e)
        {
            ActiivateButton(sender);
            OpenChildForm(new Forms.FormProgressReport());
        }
    }
}
