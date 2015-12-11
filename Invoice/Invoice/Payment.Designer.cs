namespace Invoice
{
    partial class Payment
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
            this.NamePaymentlabel = new System.Windows.Forms.Label();
            this.InvoiceNumberPaymentlabel = new System.Windows.Forms.Label();
            this.NamePaymentcomboBox = new System.Windows.Forms.ComboBox();
            this.InvoiceNumbercomboBox = new System.Windows.Forms.ComboBox();
            this.PaymentdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchtabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hiddenpayment2dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hiddenpaymentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerSnow = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.PaymentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdPaymentcombobox = new System.Windows.Forms.ComboBox();
            this.PaymentInvoicebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NameCombobox = new System.Windows.Forms.ComboBox();
            this.TotalPaidtextbox = new System.Windows.Forms.TextBox();
            this.InvoiceNumbertextbox = new System.Windows.Forms.TextBox();
            this.PaymentidTextbox = new System.Windows.Forms.TextBox();
            this.PaymentDatelabel = new System.Windows.Forms.Label();
            this.TotalPaidlabel = new System.Windows.Forms.Label();
            this.InvoiceNumberlabel = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NewPaymentdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentdataGridView)).BeginInit();
            this.SearchtabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPaymentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePaymentlabel
            // 
            this.NamePaymentlabel.AutoSize = true;
            this.NamePaymentlabel.Location = new System.Drawing.Point(7, 9);
            this.NamePaymentlabel.Name = "NamePaymentlabel";
            this.NamePaymentlabel.Size = new System.Drawing.Size(38, 13);
            this.NamePaymentlabel.TabIndex = 0;
            this.NamePaymentlabel.Text = "Name:";
            // 
            // InvoiceNumberPaymentlabel
            // 
            this.InvoiceNumberPaymentlabel.AutoSize = true;
            this.InvoiceNumberPaymentlabel.Location = new System.Drawing.Point(178, 12);
            this.InvoiceNumberPaymentlabel.Name = "InvoiceNumberPaymentlabel";
            this.InvoiceNumberPaymentlabel.Size = new System.Drawing.Size(85, 13);
            this.InvoiceNumberPaymentlabel.TabIndex = 1;
            this.InvoiceNumberPaymentlabel.Text = "Invoice Number:";
            // 
            // NamePaymentcomboBox
            // 
            this.NamePaymentcomboBox.FormattingEnabled = true;
            this.NamePaymentcomboBox.Location = new System.Drawing.Point(51, 9);
            this.NamePaymentcomboBox.Name = "NamePaymentcomboBox";
            this.NamePaymentcomboBox.Size = new System.Drawing.Size(121, 21);
            this.NamePaymentcomboBox.TabIndex = 2;
            this.NamePaymentcomboBox.SelectedIndexChanged += new System.EventHandler(this.NamePaymentcomboBox_SelectedIndexChanged);
            // 
            // InvoiceNumbercomboBox
            // 
            this.InvoiceNumbercomboBox.FormattingEnabled = true;
            this.InvoiceNumbercomboBox.Location = new System.Drawing.Point(269, 9);
            this.InvoiceNumbercomboBox.Name = "InvoiceNumbercomboBox";
            this.InvoiceNumbercomboBox.Size = new System.Drawing.Size(121, 21);
            this.InvoiceNumbercomboBox.TabIndex = 3;
            this.InvoiceNumbercomboBox.SelectedIndexChanged += new System.EventHandler(this.InvoiceNumbercomboBox_SelectedIndexChanged);
            // 
            // PaymentdataGridView
            // 
            this.PaymentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentdataGridView.Location = new System.Drawing.Point(3, 38);
            this.PaymentdataGridView.Name = "PaymentdataGridView";
            this.PaymentdataGridView.Size = new System.Drawing.Size(834, 227);
            this.PaymentdataGridView.TabIndex = 4;
            this.PaymentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentdataGridView_CellContentClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(396, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchtabControl
            // 
            this.SearchtabControl.Controls.Add(this.tabPage1);
            this.SearchtabControl.Controls.Add(this.tabPage3);
            this.SearchtabControl.Location = new System.Drawing.Point(12, 12);
            this.SearchtabControl.Name = "SearchtabControl";
            this.SearchtabControl.SelectedIndex = 0;
            this.SearchtabControl.Size = new System.Drawing.Size(1179, 603);
            this.SearchtabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hiddenpayment2dateTimePicker);
            this.tabPage1.Controls.Add(this.hiddenpaymentdateTimePicker);
            this.tabPage1.Controls.Add(this.PaymentdataGridView);
            this.tabPage1.Controls.Add(this.SearchButton);
            this.tabPage1.Controls.Add(this.NamePaymentcomboBox);
            this.tabPage1.Controls.Add(this.InvoiceNumbercomboBox);
            this.tabPage1.Controls.Add(this.NamePaymentlabel);
            this.tabPage1.Controls.Add(this.InvoiceNumberPaymentlabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1171, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hiddenpayment2dateTimePicker
            // 
            this.hiddenpayment2dateTimePicker.Location = new System.Drawing.Point(712, 10);
            this.hiddenpayment2dateTimePicker.Name = "hiddenpayment2dateTimePicker";
            this.hiddenpayment2dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hiddenpayment2dateTimePicker.TabIndex = 20;
            this.hiddenpayment2dateTimePicker.Value = new System.DateTime(2015, 11, 15, 0, 0, 0, 0);
            this.hiddenpayment2dateTimePicker.Visible = false;
            this.hiddenpayment2dateTimePicker.ValueChanged += new System.EventHandler(this.hiddenpayment2dateTimePicker_ValueChanged);
            // 
            // hiddenpaymentdateTimePicker
            // 
            this.hiddenpaymentdateTimePicker.Location = new System.Drawing.Point(506, 9);
            this.hiddenpaymentdateTimePicker.Name = "hiddenpaymentdateTimePicker";
            this.hiddenpaymentdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hiddenpaymentdateTimePicker.TabIndex = 19;
            this.hiddenpaymentdateTimePicker.Value = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.hiddenpaymentdateTimePicker.Visible = false;
            this.hiddenpaymentdateTimePicker.ValueChanged += new System.EventHandler(this.hiddenpaymentdateTimePicker_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePickerSnow);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.PaymentdateTimePicker);
            this.tabPage3.Controls.Add(this.IdPaymentcombobox);
            this.tabPage3.Controls.Add(this.PaymentInvoicebutton);
            this.tabPage3.Controls.Add(this.Addbutton);
            this.tabPage3.Controls.Add(this.Namelabel);
            this.tabPage3.Controls.Add(this.NameCombobox);
            this.tabPage3.Controls.Add(this.TotalPaidtextbox);
            this.tabPage3.Controls.Add(this.InvoiceNumbertextbox);
            this.tabPage3.Controls.Add(this.PaymentidTextbox);
            this.tabPage3.Controls.Add(this.PaymentDatelabel);
            this.tabPage3.Controls.Add(this.TotalPaidlabel);
            this.tabPage3.Controls.Add(this.InvoiceNumberlabel);
            this.tabPage3.Controls.Add(this.PaymentLabel);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.NewPaymentdataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1171, 577);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "New ";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dateTimePickerSnow
            // 
            this.dateTimePickerSnow.Location = new System.Drawing.Point(10, 296);
            this.dateTimePickerSnow.Name = "dateTimePickerSnow";
            this.dateTimePickerSnow.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSnow.TabIndex = 22;
            this.dateTimePickerSnow.Value = new System.DateTime(2015, 11, 15, 0, 0, 0, 0);
            this.dateTimePickerSnow.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 270);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.Value = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Visible = false;
            // 
            // PaymentdateTimePicker
            // 
            this.PaymentdateTimePicker.Location = new System.Drawing.Point(84, 191);
            this.PaymentdateTimePicker.Name = "PaymentdateTimePicker";
            this.PaymentdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.PaymentdateTimePicker.TabIndex = 16;
            this.PaymentdateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // IdPaymentcombobox
            // 
            this.IdPaymentcombobox.FormattingEnabled = true;
            this.IdPaymentcombobox.Location = new System.Drawing.Point(203, 111);
            this.IdPaymentcombobox.Name = "IdPaymentcombobox";
            this.IdPaymentcombobox.Size = new System.Drawing.Size(70, 21);
            this.IdPaymentcombobox.TabIndex = 15;
            this.IdPaymentcombobox.SelectedIndexChanged += new System.EventHandler(this.IdPaymentcombobox_SelectedIndexChanged);
            // 
            // PaymentInvoicebutton
            // 
            this.PaymentInvoicebutton.Location = new System.Drawing.Point(130, 232);
            this.PaymentInvoicebutton.Name = "PaymentInvoicebutton";
            this.PaymentInvoicebutton.Size = new System.Drawing.Size(115, 23);
            this.PaymentInvoicebutton.TabIndex = 14;
            this.PaymentInvoicebutton.Text = "Payment Invoice";
            this.PaymentInvoicebutton.UseVisualStyleBackColor = true;
            this.PaymentInvoicebutton.Click += new System.EventHandler(this.PaymentInvoicebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(9, 232);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(115, 23);
            this.Addbutton.TabIndex = 13;
            this.Addbutton.Text = "Add Payment";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(6, 87);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(38, 13);
            this.Namelabel.TabIndex = 12;
            this.Namelabel.Text = "Name:";
            // 
            // NameCombobox
            // 
            this.NameCombobox.FormattingEnabled = true;
            this.NameCombobox.Location = new System.Drawing.Point(97, 84);
            this.NameCombobox.Name = "NameCombobox";
            this.NameCombobox.Size = new System.Drawing.Size(121, 21);
            this.NameCombobox.TabIndex = 11;
            // 
            // TotalPaidtextbox
            // 
            this.TotalPaidtextbox.Location = new System.Drawing.Point(97, 168);
            this.TotalPaidtextbox.Name = "TotalPaidtextbox";
            this.TotalPaidtextbox.Size = new System.Drawing.Size(100, 20);
            this.TotalPaidtextbox.TabIndex = 9;
            // 
            // InvoiceNumbertextbox
            // 
            this.InvoiceNumbertextbox.Location = new System.Drawing.Point(97, 142);
            this.InvoiceNumbertextbox.Name = "InvoiceNumbertextbox";
            this.InvoiceNumbertextbox.Size = new System.Drawing.Size(100, 20);
            this.InvoiceNumbertextbox.TabIndex = 8;
            // 
            // PaymentidTextbox
            // 
            this.PaymentidTextbox.Location = new System.Drawing.Point(97, 116);
            this.PaymentidTextbox.Name = "PaymentidTextbox";
            this.PaymentidTextbox.Size = new System.Drawing.Size(100, 20);
            this.PaymentidTextbox.TabIndex = 7;
            // 
            // PaymentDatelabel
            // 
            this.PaymentDatelabel.AutoSize = true;
            this.PaymentDatelabel.Location = new System.Drawing.Point(6, 197);
            this.PaymentDatelabel.Name = "PaymentDatelabel";
            this.PaymentDatelabel.Size = new System.Drawing.Size(74, 13);
            this.PaymentDatelabel.TabIndex = 6;
            this.PaymentDatelabel.Text = "PaymentDate:";
            // 
            // TotalPaidlabel
            // 
            this.TotalPaidlabel.AutoSize = true;
            this.TotalPaidlabel.Location = new System.Drawing.Point(6, 171);
            this.TotalPaidlabel.Name = "TotalPaidlabel";
            this.TotalPaidlabel.Size = new System.Drawing.Size(55, 13);
            this.TotalPaidlabel.TabIndex = 5;
            this.TotalPaidlabel.Text = "TotalPaid:";
            // 
            // InvoiceNumberlabel
            // 
            this.InvoiceNumberlabel.AutoSize = true;
            this.InvoiceNumberlabel.Location = new System.Drawing.Point(6, 145);
            this.InvoiceNumberlabel.Name = "InvoiceNumberlabel";
            this.InvoiceNumberlabel.Size = new System.Drawing.Size(85, 13);
            this.InvoiceNumberlabel.TabIndex = 4;
            this.InvoiceNumberlabel.Text = "Invoice Number:";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Location = new System.Drawing.Point(7, 119);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(65, 13);
            this.PaymentLabel.TabIndex = 3;
            this.PaymentLabel.Text = "Payment ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Past Due";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPaymentdataGridView
            // 
            this.NewPaymentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewPaymentdataGridView.Location = new System.Drawing.Point(290, 0);
            this.NewPaymentdataGridView.Name = "NewPaymentdataGridView";
            this.NewPaymentdataGridView.Size = new System.Drawing.Size(875, 571);
            this.NewPaymentdataGridView.TabIndex = 0;
            this.NewPaymentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewPaymentdataGridView_CellContentClick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 639);
            this.Controls.Add(this.SearchtabControl);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentdataGridView)).EndInit();
            this.SearchtabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewPaymentdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NamePaymentlabel;
        private System.Windows.Forms.Label InvoiceNumberPaymentlabel;
        private System.Windows.Forms.ComboBox NamePaymentcomboBox;
        private System.Windows.Forms.ComboBox InvoiceNumbercomboBox;
        private System.Windows.Forms.DataGridView PaymentdataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TabControl SearchtabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView NewPaymentdataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.ComboBox NameCombobox;
        private System.Windows.Forms.TextBox TotalPaidtextbox;
        private System.Windows.Forms.TextBox InvoiceNumbertextbox;
        private System.Windows.Forms.TextBox PaymentidTextbox;
        private System.Windows.Forms.Label PaymentDatelabel;
        private System.Windows.Forms.Label TotalPaidlabel;
        private System.Windows.Forms.Label InvoiceNumberlabel;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button PaymentInvoicebutton;
        private System.Windows.Forms.ComboBox IdPaymentcombobox;
        private System.Windows.Forms.DateTimePicker PaymentdateTimePicker;
        private System.Windows.Forms.DateTimePicker hiddenpaymentdateTimePicker;
        private System.Windows.Forms.DateTimePicker hiddenpayment2dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerSnow;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}