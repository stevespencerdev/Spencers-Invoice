namespace Invoice
{
    partial class EmailLawn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailLawn));
            this.label7 = new System.Windows.Forms.Label();
            this.usernmtexbx = new System.Windows.Forms.TextBox();
            this.usernmlbl = new System.Windows.Forms.Label();
            this.smpttbx = new System.Windows.Forms.TextBox();
            this.browsehbtn = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.bodytbx = new System.Windows.Forms.TextBox();
            this.pwtbx = new System.Windows.Forms.TextBox();
            this.subtbx = new System.Windows.Forms.TextBox();
            this.attachbtx = new System.Windows.Forms.TextBox();
            this.emailaddtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.attachmentbx2 = new System.Windows.Forms.TextBox();
            this.browsebtn2 = new System.Windows.Forms.Button();
            this.comboBoxemailtst = new System.Windows.Forms.ComboBox();
            this.SnowcomboBoxemaillist = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.togglelbl = new System.Windows.Forms.Label();
            this.SnowdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todaysdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadSnowDataCheckbox = new System.Windows.Forms.CheckBox();
            this.LoadLawnDatacheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Smtp Server:";
            this.label7.UseMnemonic = false;
            this.label7.Visible = false;
            // 
            // usernmtexbx
            // 
            this.usernmtexbx.Location = new System.Drawing.Point(478, 403);
            this.usernmtexbx.Name = "usernmtexbx";
            this.usernmtexbx.Size = new System.Drawing.Size(181, 20);
            this.usernmtexbx.TabIndex = 41;
            this.usernmtexbx.Text = "spencerslawnmaint@gmail.com";
            this.usernmtexbx.Visible = false;
            // 
            // usernmlbl
            // 
            this.usernmlbl.AutoSize = true;
            this.usernmlbl.Location = new System.Drawing.Point(406, 406);
            this.usernmlbl.Name = "usernmlbl";
            this.usernmlbl.Size = new System.Drawing.Size(55, 13);
            this.usernmlbl.TabIndex = 40;
            this.usernmlbl.Text = "Username";
            this.usernmlbl.Visible = false;
            // 
            // smpttbx
            // 
            this.smpttbx.Location = new System.Drawing.Point(158, 403);
            this.smpttbx.Name = "smpttbx";
            this.smpttbx.Size = new System.Drawing.Size(233, 20);
            this.smpttbx.TabIndex = 39;
            this.smpttbx.Text = "smtp.gmail.com";
            this.smpttbx.Visible = false;
            // 
            // browsehbtn
            // 
            this.browsehbtn.Location = new System.Drawing.Point(540, 175);
            this.browsehbtn.Name = "browsehbtn";
            this.browsehbtn.Size = new System.Drawing.Size(98, 23);
            this.browsehbtn.TabIndex = 38;
            this.browsehbtn.Text = "Browse";
            this.browsehbtn.UseVisualStyleBackColor = true;
            this.browsehbtn.Click += new System.EventHandler(this.browsehbtn_Click);
            // 
            // Sendbtn
            // 
            this.Sendbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sendbtn.BackgroundImage")));
            this.Sendbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sendbtn.Location = new System.Drawing.Point(524, 281);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(135, 77);
            this.Sendbtn.TabIndex = 37;
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // bodytbx
            // 
            this.bodytbx.Location = new System.Drawing.Point(121, 261);
            this.bodytbx.Multiline = true;
            this.bodytbx.Name = "bodytbx";
            this.bodytbx.Size = new System.Drawing.Size(394, 136);
            this.bodytbx.TabIndex = 36;
            this.bodytbx.Text = "Dear,\r\n\r\nHere\'s your invoice! We appreciate your prompt payment.\r\n\r\nThanks for yo" +
    "ur business!\r\nSpencers Lawn Maintenance";
            this.bodytbx.TextChanged += new System.EventHandler(this.bodytbx_TextChanged);
            // 
            // pwtbx
            // 
            this.pwtbx.Location = new System.Drawing.Point(599, 249);
            this.pwtbx.Name = "pwtbx";
            this.pwtbx.PasswordChar = '*';
            this.pwtbx.Size = new System.Drawing.Size(144, 20);
            this.pwtbx.TabIndex = 35;
            this.pwtbx.Text = "specialized8955";
            this.pwtbx.Visible = false;
            // 
            // subtbx
            // 
            this.subtbx.Location = new System.Drawing.Point(121, 235);
            this.subtbx.Name = "subtbx";
            this.subtbx.Size = new System.Drawing.Size(405, 20);
            this.subtbx.TabIndex = 34;
            this.subtbx.Text = "Invoice from Spencers Lawn Maintenance";
            // 
            // attachbtx
            // 
            this.attachbtx.Location = new System.Drawing.Point(121, 177);
            this.attachbtx.Name = "attachbtx";
            this.attachbtx.Size = new System.Drawing.Size(405, 20);
            this.attachbtx.TabIndex = 33;
            // 
            // emailaddtbx
            // 
            this.emailaddtbx.Location = new System.Drawing.Point(121, 91);
            this.emailaddtbx.Name = "emailaddtbx";
            this.emailaddtbx.Size = new System.Drawing.Size(233, 20);
            this.emailaddtbx.TabIndex = 32;
            this.emailaddtbx.Text = "spencerslawnmaint@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Password:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Attach Invoice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Attach Invoice:";
            // 
            // attachmentbx2
            // 
            this.attachmentbx2.Location = new System.Drawing.Point(121, 210);
            this.attachmentbx2.Name = "attachmentbx2";
            this.attachmentbx2.Size = new System.Drawing.Size(405, 20);
            this.attachmentbx2.TabIndex = 45;
            // 
            // browsebtn2
            // 
            this.browsebtn2.Location = new System.Drawing.Point(539, 213);
            this.browsebtn2.Name = "browsebtn2";
            this.browsebtn2.Size = new System.Drawing.Size(98, 23);
            this.browsebtn2.TabIndex = 46;
            this.browsebtn2.Text = "Browse";
            this.browsebtn2.UseVisualStyleBackColor = true;
            this.browsebtn2.Click += new System.EventHandler(this.browsebtn2_Click);
            // 
            // comboBoxemailtst
            // 
            this.comboBoxemailtst.FormattingEnabled = true;
            this.comboBoxemailtst.Location = new System.Drawing.Point(121, 119);
            this.comboBoxemailtst.Name = "comboBoxemailtst";
            this.comboBoxemailtst.Size = new System.Drawing.Size(233, 21);
            this.comboBoxemailtst.TabIndex = 96;
            this.comboBoxemailtst.SelectedIndexChanged += new System.EventHandler(this.comboBoxemailtst_SelectedIndexChanged);
            // 
            // SnowcomboBoxemaillist
            // 
            this.SnowcomboBoxemaillist.FormattingEnabled = true;
            this.SnowcomboBoxemaillist.Location = new System.Drawing.Point(121, 150);
            this.SnowcomboBoxemaillist.Name = "SnowcomboBoxemaillist";
            this.SnowcomboBoxemaillist.Size = new System.Drawing.Size(233, 21);
            this.SnowcomboBoxemaillist.TabIndex = 103;
            this.SnowcomboBoxemaillist.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // togglelbl
            // 
            this.togglelbl.AutoSize = true;
            this.togglelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.togglelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglelbl.Location = new System.Drawing.Point(309, 9);
            this.togglelbl.Name = "togglelbl";
            this.togglelbl.Size = new System.Drawing.Size(2, 21);
            this.togglelbl.TabIndex = 108;
            // 
            // SnowdateTimePicker
            // 
            this.SnowdateTimePicker.Location = new System.Drawing.Point(448, 38);
            this.SnowdateTimePicker.Name = "SnowdateTimePicker";
            this.SnowdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.SnowdateTimePicker.TabIndex = 128;
            this.SnowdateTimePicker.Value = new System.DateTime(2015, 11, 16, 0, 0, 0, 0);
            this.SnowdateTimePicker.Visible = false;
            // 
            // todaysdateTimePicker
            // 
            this.todaysdateTimePicker.Location = new System.Drawing.Point(448, 12);
            this.todaysdateTimePicker.Name = "todaysdateTimePicker";
            this.todaysdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.todaysdateTimePicker.TabIndex = 127;
            this.todaysdateTimePicker.Value = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.todaysdateTimePicker.Visible = false;
            // 
            // LoadSnowDataCheckbox
            // 
            this.LoadSnowDataCheckbox.AutoSize = true;
            this.LoadSnowDataCheckbox.Location = new System.Drawing.Point(424, 150);
            this.LoadSnowDataCheckbox.Name = "LoadSnowDataCheckbox";
            this.LoadSnowDataCheckbox.Size = new System.Drawing.Size(143, 17);
            this.LoadSnowDataCheckbox.TabIndex = 129;
            this.LoadSnowDataCheckbox.Text = "Load Snow Data Bypass";
            this.LoadSnowDataCheckbox.UseVisualStyleBackColor = true;
            this.LoadSnowDataCheckbox.CheckedChanged += new System.EventHandler(this.LoadSnowDataCheckbox_CheckedChanged);
            // 
            // LoadLawnDatacheckBox
            // 
            this.LoadLawnDatacheckBox.AutoSize = true;
            this.LoadLawnDatacheckBox.Location = new System.Drawing.Point(424, 127);
            this.LoadLawnDatacheckBox.Name = "LoadLawnDatacheckBox";
            this.LoadLawnDatacheckBox.Size = new System.Drawing.Size(142, 17);
            this.LoadLawnDatacheckBox.TabIndex = 130;
            this.LoadLawnDatacheckBox.Text = "Load Lawn Data Bypass";
            this.LoadLawnDatacheckBox.UseVisualStyleBackColor = true;
            this.LoadLawnDatacheckBox.CheckedChanged += new System.EventHandler(this.LoadLawnDatacheckBox_CheckedChanged);
            // 
            // EmailLawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 451);
            this.Controls.Add(this.LoadLawnDatacheckBox);
            this.Controls.Add(this.LoadSnowDataCheckbox);
            this.Controls.Add(this.SnowdateTimePicker);
            this.Controls.Add(this.todaysdateTimePicker);
            this.Controls.Add(this.togglelbl);
            this.Controls.Add(this.SnowcomboBoxemaillist);
            this.Controls.Add(this.comboBoxemailtst);
            this.Controls.Add(this.browsebtn2);
            this.Controls.Add(this.attachmentbx2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernmtexbx);
            this.Controls.Add(this.usernmlbl);
            this.Controls.Add(this.smpttbx);
            this.Controls.Add(this.browsehbtn);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.bodytbx);
            this.Controls.Add(this.pwtbx);
            this.Controls.Add(this.subtbx);
            this.Controls.Add(this.attachbtx);
            this.Controls.Add(this.emailaddtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "EmailLawn";
            this.Text = "EmailLawn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernmtexbx;
        private System.Windows.Forms.Label usernmlbl;
        private System.Windows.Forms.TextBox smpttbx;
        private System.Windows.Forms.Button browsehbtn;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox bodytbx;
        private System.Windows.Forms.TextBox pwtbx;
        private System.Windows.Forms.TextBox subtbx;
        private System.Windows.Forms.TextBox attachbtx;
        private System.Windows.Forms.TextBox emailaddtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox attachmentbx2;
        private System.Windows.Forms.Button browsebtn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ComboBox SnowcomboBoxemaillist;
        public System.Windows.Forms.Label togglelbl;
        public System.Windows.Forms.ComboBox comboBoxemailtst;
        private System.Windows.Forms.DateTimePicker SnowdateTimePicker;
        private System.Windows.Forms.DateTimePicker todaysdateTimePicker;
        private System.Windows.Forms.CheckBox LoadSnowDataCheckbox;
        private System.Windows.Forms.CheckBox LoadLawnDatacheckBox;
    }
}