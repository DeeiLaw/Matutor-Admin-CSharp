namespace Matutor_Admin.Forms
{
    partial class FormManageReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageReview));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_sender = new System.Windows.Forms.PictureBox();
            this.pictureBox_receiver = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_receiver = new System.Windows.Forms.Label();
            this.label_sender = new System.Windows.Forms.Label();
            this.label_reviewID = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_receiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(325, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Search User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(490, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sent by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(693, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sent to";
            // 
            // pictureBox_sender
            // 
            this.pictureBox_sender.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sender.Image")));
            this.pictureBox_sender.Location = new System.Drawing.Point(462, 56);
            this.pictureBox_sender.Name = "pictureBox_sender";
            this.pictureBox_sender.Size = new System.Drawing.Size(125, 122);
            this.pictureBox_sender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sender.TabIndex = 7;
            this.pictureBox_sender.TabStop = false;
            // 
            // pictureBox_receiver
            // 
            this.pictureBox_receiver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_receiver.Image")));
            this.pictureBox_receiver.Location = new System.Drawing.Point(659, 56);
            this.pictureBox_receiver.Name = "pictureBox_receiver";
            this.pictureBox_receiver.Size = new System.Drawing.Size(125, 122);
            this.pictureBox_receiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_receiver.TabIndex = 8;
            this.pictureBox_receiver.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(462, 253);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 191);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label_receiver
            // 
            this.label_receiver.AutoSize = true;
            this.label_receiver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_receiver.Location = new System.Drawing.Point(659, 192);
            this.label_receiver.Name = "label_receiver";
            this.label_receiver.Size = new System.Drawing.Size(115, 21);
            this.label_receiver.TabIndex = 11;
            this.label_receiver.Text = "Receiver Name";
            // 
            // label_sender
            // 
            this.label_sender.AutoSize = true;
            this.label_sender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sender.Location = new System.Drawing.Point(471, 192);
            this.label_sender.Name = "label_sender";
            this.label_sender.Size = new System.Drawing.Size(105, 21);
            this.label_sender.TabIndex = 10;
            this.label_sender.Text = "Sender Name";
            // 
            // label_reviewID
            // 
            this.label_reviewID.AutoSize = true;
            this.label_reviewID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_reviewID.Location = new System.Drawing.Point(462, 235);
            this.label_reviewID.Name = "label_reviewID";
            this.label_reviewID.Size = new System.Drawing.Size(118, 15);
            this.label_reviewID.TabIndex = 12;
            this.label_reviewID.Text = "Review ID: 000000000";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(248)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.Location = new System.Drawing.Point(562, 450);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(125, 29);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Save Edit";
            this.button_save.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(693, 450);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(97, 29);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "Delete Review";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(388, 413);
            this.dataGridView1.TabIndex = 15;
            // 
            // FormManageReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_reviewID);
            this.Controls.Add(this.label_receiver);
            this.Controls.Add(this.label_sender);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox_receiver);
            this.Controls.Add(this.pictureBox_sender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormManageReview";
            this.Text = "FormManageReview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_receiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_sender;
        private System.Windows.Forms.PictureBox pictureBox_receiver;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_receiver;
        private System.Windows.Forms.Label label_sender;
        private System.Windows.Forms.Label label_reviewID;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}