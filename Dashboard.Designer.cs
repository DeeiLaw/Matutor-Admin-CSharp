namespace Matutor_Admin
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.button_notif = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_sender = new System.Windows.Forms.PictureBox();
            this.button_dash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.button_addTutor = new System.Windows.Forms.Button();
            this.label_mgmt = new System.Windows.Forms.Label();
            this.button_users = new System.Windows.Forms.Button();
            this.button_bookings = new System.Windows.Forms.Button();
            this.button_reviews = new System.Windows.Forms.Button();
            this.button_progressReport = new System.Windows.Forms.Button();
            this.button_contents = new System.Windows.Forms.Button();
            this.button_postings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sender)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.panelMenu.Controls.Add(this.panel_user);
            this.panelMenu.Controls.Add(this.button_dash);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.button_reg);
            this.panelMenu.Controls.Add(this.button_addTutor);
            this.panelMenu.Controls.Add(this.label_mgmt);
            this.panelMenu.Controls.Add(this.button_users);
            this.panelMenu.Controls.Add(this.button_bookings);
            this.panelMenu.Controls.Add(this.button_reviews);
            this.panelMenu.Controls.Add(this.button_progressReport);
            this.panelMenu.Controls.Add(this.button_contents);
            this.panelMenu.Controls.Add(this.button_postings);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(182, 536);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.WrapContents = false;
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.button_notif);
            this.panel_user.Controls.Add(this.label_position);
            this.panel_user.Controls.Add(this.label_username);
            this.panel_user.Controls.Add(this.pictureBox_sender);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(3, 3);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(176, 57);
            this.panel_user.TabIndex = 1;
            // 
            // button_notif
            // 
            this.button_notif.BackColor = System.Drawing.Color.Transparent;
            this.button_notif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_notif.FlatAppearance.BorderSize = 0;
            this.button_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notif.ForeColor = System.Drawing.SystemColors.Control;
            this.button_notif.Image = ((System.Drawing.Image)(resources.GetObject("button_notif.Image")));
            this.button_notif.Location = new System.Drawing.Point(141, 11);
            this.button_notif.Name = "button_notif";
            this.button_notif.Size = new System.Drawing.Size(35, 30);
            this.button_notif.TabIndex = 9;
            this.button_notif.UseVisualStyleBackColor = false;
            this.button_notif.Click += new System.EventHandler(this.button_notif_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Montserrat", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(120)))));
            this.label_position.Location = new System.Drawing.Point(54, 31);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(79, 14);
            this.label_position.TabIndex = 14;
            this.label_position.Text = "Administrator";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(54, 16);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(81, 15);
            this.label_username.TabIndex = 13;
            this.label_username.Text = "User Name";
            // 
            // pictureBox_sender
            // 
            this.pictureBox_sender.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sender.Image")));
            this.pictureBox_sender.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_sender.Name = "pictureBox_sender";
            this.pictureBox_sender.Size = new System.Drawing.Size(48, 44);
            this.pictureBox_sender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sender.TabIndex = 12;
            this.pictureBox_sender.TabStop = false;
            // 
            // button_dash
            // 
            this.button_dash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_dash.BackColor = System.Drawing.Color.Transparent;
            this.button_dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dash.FlatAppearance.BorderSize = 0;
            this.button_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dash.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dash.ForeColor = System.Drawing.SystemColors.Control;
            this.button_dash.Image = global::Matutor_Admin.Properties.Resources.dash_s;
            this.button_dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dash.Location = new System.Drawing.Point(21, 66);
            this.button_dash.Name = "button_dash";
            this.button_dash.Size = new System.Drawing.Size(158, 32);
            this.button_dash.TabIndex = 0;
            this.button_dash.Text = "     Dashboard";
            this.button_dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dash.UseVisualStyleBackColor = false;
            this.button_dash.Click += new System.EventHandler(this.button_dash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Users";
            // 
            // button_reg
            // 
            this.button_reg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reg.FlatAppearance.BorderSize = 0;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reg.ForeColor = System.Drawing.SystemColors.Control;
            this.button_reg.Image = global::Matutor_Admin.Properties.Resources.register_s;
            this.button_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reg.Location = new System.Drawing.Point(21, 129);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(158, 32);
            this.button_reg.TabIndex = 2;
            this.button_reg.Text = "     Registrations";
            this.button_reg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_addTutor
            // 
            this.button_addTutor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_addTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_addTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addTutor.FlatAppearance.BorderSize = 0;
            this.button_addTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addTutor.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addTutor.ForeColor = System.Drawing.SystemColors.Control;
            this.button_addTutor.Image = global::Matutor_Admin.Properties.Resources.addTutor_s;
            this.button_addTutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTutor.Location = new System.Drawing.Point(21, 167);
            this.button_addTutor.Name = "button_addTutor";
            this.button_addTutor.Size = new System.Drawing.Size(158, 32);
            this.button_addTutor.TabIndex = 11;
            this.button_addTutor.Text = "     Add Tutor ";
            this.button_addTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_addTutor.UseVisualStyleBackColor = false;
            this.button_addTutor.Click += new System.EventHandler(this.button_addTutor_Click);
            // 
            // label_mgmt
            // 
            this.label_mgmt.AutoSize = true;
            this.label_mgmt.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_mgmt.ForeColor = System.Drawing.Color.White;
            this.label_mgmt.Location = new System.Drawing.Point(3, 202);
            this.label_mgmt.Name = "label_mgmt";
            this.label_mgmt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_mgmt.Size = new System.Drawing.Size(95, 25);
            this.label_mgmt.TabIndex = 9;
            this.label_mgmt.Text = "Management";
            // 
            // button_users
            // 
            this.button_users.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_users.FlatAppearance.BorderSize = 0;
            this.button_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_users.ForeColor = System.Drawing.SystemColors.Control;
            this.button_users.Image = global::Matutor_Admin.Properties.Resources.user_managemment_s;
            this.button_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_users.Location = new System.Drawing.Point(21, 230);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(158, 32);
            this.button_users.TabIndex = 3;
            this.button_users.Text = "     Users";
            this.button_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_bookings
            // 
            this.button_bookings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_bookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bookings.FlatAppearance.BorderSize = 0;
            this.button_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bookings.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bookings.ForeColor = System.Drawing.SystemColors.Control;
            this.button_bookings.Image = global::Matutor_Admin.Properties.Resources.booking_s;
            this.button_bookings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bookings.Location = new System.Drawing.Point(21, 268);
            this.button_bookings.Name = "button_bookings";
            this.button_bookings.Size = new System.Drawing.Size(158, 32);
            this.button_bookings.TabIndex = 8;
            this.button_bookings.Text = "     Bookings";
            this.button_bookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bookings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_bookings.UseVisualStyleBackColor = false;
            this.button_bookings.Click += new System.EventHandler(this.button_bookings_Click);
            // 
            // button_reviews
            // 
            this.button_reviews.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_reviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_reviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reviews.FlatAppearance.BorderSize = 0;
            this.button_reviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reviews.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reviews.ForeColor = System.Drawing.SystemColors.Control;
            this.button_reviews.Image = global::Matutor_Admin.Properties.Resources.review_s;
            this.button_reviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reviews.Location = new System.Drawing.Point(21, 306);
            this.button_reviews.Name = "button_reviews";
            this.button_reviews.Size = new System.Drawing.Size(158, 32);
            this.button_reviews.TabIndex = 4;
            this.button_reviews.Text = "     Reviews";
            this.button_reviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_reviews.UseVisualStyleBackColor = false;
            this.button_reviews.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_progressReport
            // 
            this.button_progressReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_progressReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_progressReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_progressReport.FlatAppearance.BorderSize = 0;
            this.button_progressReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_progressReport.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_progressReport.ForeColor = System.Drawing.SystemColors.Control;
            this.button_progressReport.Image = global::Matutor_Admin.Properties.Resources.progress_s;
            this.button_progressReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_progressReport.Location = new System.Drawing.Point(21, 344);
            this.button_progressReport.Name = "button_progressReport";
            this.button_progressReport.Size = new System.Drawing.Size(158, 32);
            this.button_progressReport.TabIndex = 12;
            this.button_progressReport.Text = "     Progress Reports";
            this.button_progressReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_progressReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_progressReport.UseVisualStyleBackColor = true;
            this.button_progressReport.Click += new System.EventHandler(this.button_progressReport_Click);
            // 
            // button_contents
            // 
            this.button_contents.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_contents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_contents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contents.FlatAppearance.BorderSize = 0;
            this.button_contents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contents.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_contents.ForeColor = System.Drawing.SystemColors.Control;
            this.button_contents.Image = global::Matutor_Admin.Properties.Resources.content_s;
            this.button_contents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_contents.Location = new System.Drawing.Point(21, 382);
            this.button_contents.Name = "button_contents";
            this.button_contents.Size = new System.Drawing.Size(158, 32);
            this.button_contents.TabIndex = 5;
            this.button_contents.Text = "     Contents";
            this.button_contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_contents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_contents.UseVisualStyleBackColor = false;
            this.button_contents.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_postings
            // 
            this.button_postings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_postings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_postings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_postings.FlatAppearance.BorderSize = 0;
            this.button_postings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_postings.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_postings.ForeColor = System.Drawing.SystemColors.Control;
            this.button_postings.Image = global::Matutor_Admin.Properties.Resources.posting_s;
            this.button_postings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_postings.Location = new System.Drawing.Point(21, 420);
            this.button_postings.Name = "button_postings";
            this.button_postings.Size = new System.Drawing.Size(158, 32);
            this.button_postings.TabIndex = 0;
            this.button_postings.Text = "     Postings";
            this.button_postings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_postings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_postings.UseVisualStyleBackColor = true;
            this.button_postings.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Matutor_Admin.Properties.Resources.box_placeholder;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(21, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "     Subscriptions";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 41);
            this.panel2.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Red;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.button_logout.Location = new System.Drawing.Point(5, 7);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(51, 23);
            this.button_logout.TabIndex = 8;
            this.button_logout.Text = "log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 10);
            this.label2.TabIndex = 16;
            this.label2.Text = "Backend Access";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Matutor_Admin.Properties.Resources.logo_copy;
            this.pictureBox1.Location = new System.Drawing.Point(99, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(188, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(808, 508);
            this.panelMain.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1008, 532);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matutor Backend Access ";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sender)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_reviews;
        private System.Windows.Forms.Button button_contents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_postings;
        private System.Windows.Forms.Button button_bookings;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Button button_dash;
        private System.Windows.Forms.Button button_notif;
        private System.Windows.Forms.Label label_mgmt;
        private System.Windows.Forms.Button button_addTutor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_sender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button_progressReport;
    }
}
