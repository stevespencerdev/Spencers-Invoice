namespace Invoice
{
    partial class SearchInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.SearchInvoiceNumbercomboBox = new System.Windows.Forms.ComboBox();
            this.NamePaymentlabel = new System.Windows.Forms.Label();
            this.InvoiceNumberPaymentlabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.SearchInvoicedataGridView = new System.Windows.Forms.DataGridView();
            this.ActivitylistBox = new System.Windows.Forms.ListBox();
            this.Importbutton = new System.Windows.Forms.Button();
            this.DatelistBox = new System.Windows.Forms.ListBox();
            this.InvoicelistBox = new System.Windows.Forms.ListBox();
            this.InvoiceidlistBox = new System.Windows.Forms.ListBox();
            this.PrevBallistBox = new System.Windows.Forms.ListBox();
            this.TotalDuelistBox = new System.Windows.Forms.ListBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.EditInvoicecheckBox = new System.Windows.Forms.CheckBox();
            this.ActivityEdittextBox = new System.Windows.Forms.TextBox();
            this.EditInvoicepanel = new System.Windows.Forms.Panel();
            this.Reloadbutton = new System.Windows.Forms.Button();
            this.invoicenumedittextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmountEdittextBox = new System.Windows.Forms.TextBox();
            this.prevbaleditextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInvoicedataGridView)).BeginInit();
            this.EditInvoicepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "invoice Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Activity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Total Amount Due:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Previous Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Invoice Id:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(961, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 75;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NameSearchcomboBox
            // 
            this.NameSearchcomboBox.FormattingEnabled = true;
            this.NameSearchcomboBox.Location = new System.Drawing.Point(616, 16);
            this.NameSearchcomboBox.Name = "NameSearchcomboBox";
            this.NameSearchcomboBox.Size = new System.Drawing.Size(121, 21);
            this.NameSearchcomboBox.TabIndex = 73;
            this.NameSearchcomboBox.SelectedIndexChanged += new System.EventHandler(this.NamePaymentcomboBox_SelectedIndexChanged);
            // 
            // SearchInvoiceNumbercomboBox
            // 
            this.SearchInvoiceNumbercomboBox.FormattingEnabled = true;
            this.SearchInvoiceNumbercomboBox.Location = new System.Drawing.Point(834, 16);
            this.SearchInvoiceNumbercomboBox.Name = "SearchInvoiceNumbercomboBox";
            this.SearchInvoiceNumbercomboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchInvoiceNumbercomboBox.TabIndex = 74;
            // 
            // NamePaymentlabel
            // 
            this.NamePaymentlabel.AutoSize = true;
            this.NamePaymentlabel.Location = new System.Drawing.Point(572, 16);
            this.NamePaymentlabel.Name = "NamePaymentlabel";
            this.NamePaymentlabel.Size = new System.Drawing.Size(38, 13);
            this.NamePaymentlabel.TabIndex = 71;
            this.NamePaymentlabel.Text = "Name:";
            // 
            // InvoiceNumberPaymentlabel
            // 
            this.InvoiceNumberPaymentlabel.AutoSize = true;
            this.InvoiceNumberPaymentlabel.Location = new System.Drawing.Point(743, 19);
            this.InvoiceNumberPaymentlabel.Name = "InvoiceNumberPaymentlabel";
            this.InvoiceNumberPaymentlabel.Size = new System.Drawing.Size(85, 13);
            this.InvoiceNumberPaymentlabel.TabIndex = 72;
            this.InvoiceNumberPaymentlabel.Text = "Invoice Number:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(124, 16);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(33, 13);
            this.Datelabel.TabIndex = 76;
            this.Datelabel.Text = "Date:";
            // 
            // SearchInvoicedataGridView
            // 
            this.SearchInvoicedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchInvoicedataGridView.Location = new System.Drawing.Point(575, 55);
            this.SearchInvoicedataGridView.Name = "SearchInvoicedataGridView";
            this.SearchInvoicedataGridView.Size = new System.Drawing.Size(582, 349);
            this.SearchInvoicedataGridView.TabIndex = 79;
            // 
            // ActivitylistBox
            // 
            this.ActivitylistBox.FormattingEnabled = true;
            this.ActivitylistBox.Location = new System.Drawing.Point(239, 62);
            this.ActivitylistBox.Name = "ActivitylistBox";
            this.ActivitylistBox.Size = new System.Drawing.Size(243, 173);
            this.ActivitylistBox.TabIndex = 80;
            this.ActivitylistBox.SelectedIndexChanged += new System.EventHandler(this.ActivitylistBox_SelectedIndexChanged);
            // 
            // Importbutton
            // 
            this.Importbutton.Location = new System.Drawing.Point(1042, 16);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(76, 23);
            this.Importbutton.TabIndex = 78;
            this.Importbutton.Text = "Import";
            this.Importbutton.UseVisualStyleBackColor = true;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // DatelistBox
            // 
            this.DatelistBox.FormattingEnabled = true;
            this.DatelistBox.Location = new System.Drawing.Point(239, 16);
            this.DatelistBox.Name = "DatelistBox";
            this.DatelistBox.Size = new System.Drawing.Size(100, 17);
            this.DatelistBox.TabIndex = 81;
            // 
            // InvoicelistBox
            // 
            this.InvoicelistBox.FormattingEnabled = true;
            this.InvoicelistBox.Location = new System.Drawing.Point(239, 39);
            this.InvoicelistBox.Name = "InvoicelistBox";
            this.InvoicelistBox.Size = new System.Drawing.Size(100, 17);
            this.InvoicelistBox.TabIndex = 82;
            this.InvoicelistBox.SelectedIndexChanged += new System.EventHandler(this.InvoicelistBox_SelectedIndexChanged);
            // 
            // InvoiceidlistBox
            // 
            this.InvoiceidlistBox.FormattingEnabled = true;
            this.InvoiceidlistBox.Location = new System.Drawing.Point(239, 249);
            this.InvoiceidlistBox.Name = "InvoiceidlistBox";
            this.InvoiceidlistBox.Size = new System.Drawing.Size(100, 17);
            this.InvoiceidlistBox.TabIndex = 83;
            // 
            // PrevBallistBox
            // 
            this.PrevBallistBox.FormattingEnabled = true;
            this.PrevBallistBox.Location = new System.Drawing.Point(239, 272);
            this.PrevBallistBox.Name = "PrevBallistBox";
            this.PrevBallistBox.Size = new System.Drawing.Size(100, 17);
            this.PrevBallistBox.TabIndex = 84;
            this.PrevBallistBox.SelectedIndexChanged += new System.EventHandler(this.PrevBallistBox_SelectedIndexChanged);
            // 
            // TotalDuelistBox
            // 
            this.TotalDuelistBox.FormattingEnabled = true;
            this.TotalDuelistBox.Location = new System.Drawing.Point(239, 295);
            this.TotalDuelistBox.Name = "TotalDuelistBox";
            this.TotalDuelistBox.Size = new System.Drawing.Size(100, 17);
            this.TotalDuelistBox.TabIndex = 85;
            this.TotalDuelistBox.SelectedIndexChanged += new System.EventHandler(this.TotalDuelistBox_SelectedIndexChanged);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(24, 236);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 86;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // EditInvoicecheckBox
            // 
            this.EditInvoicecheckBox.AutoSize = true;
            this.EditInvoicecheckBox.Location = new System.Drawing.Point(386, 15);
            this.EditInvoicecheckBox.Name = "EditInvoicecheckBox";
            this.EditInvoicecheckBox.Size = new System.Drawing.Size(82, 17);
            this.EditInvoicecheckBox.TabIndex = 87;
            this.EditInvoicecheckBox.Text = "Edit Invoice";
            this.EditInvoicecheckBox.UseVisualStyleBackColor = true;
            this.EditInvoicecheckBox.CheckedChanged += new System.EventHandler(this.EditInvoicecheckBox_CheckedChanged);
            // 
            // ActivityEdittextBox
            // 
            this.ActivityEdittextBox.Location = new System.Drawing.Point(112, 55);
            this.ActivityEdittextBox.Multiline = true;
            this.ActivityEdittextBox.Name = "ActivityEdittextBox";
            this.ActivityEdittextBox.Size = new System.Drawing.Size(201, 105);
            this.ActivityEdittextBox.TabIndex = 88;
            // 
            // EditInvoicepanel
            // 
            this.EditInvoicepanel.Controls.Add(this.Reloadbutton);
            this.EditInvoicepanel.Controls.Add(this.invoicenumedittextBox);
            this.EditInvoicepanel.Controls.Add(this.label5);
            this.EditInvoicepanel.Controls.Add(this.TotalAmountEdittextBox);
            this.EditInvoicepanel.Controls.Add(this.prevbaleditextBox);
            this.EditInvoicepanel.Controls.Add(this.label4);
            this.EditInvoicepanel.Controls.Add(this.label3);
            this.EditInvoicepanel.Controls.Add(this.label2);
            this.EditInvoicepanel.Controls.Add(this.ActivityEdittextBox);
            this.EditInvoicepanel.Controls.Add(this.Updatebutton);
            this.EditInvoicepanel.Location = new System.Drawing.Point(127, 62);
            this.EditInvoicepanel.Name = "EditInvoicepanel";
            this.EditInvoicepanel.Size = new System.Drawing.Size(355, 274);
            this.EditInvoicepanel.TabIndex = 89;
            this.EditInvoicepanel.Visible = false;
            // 
            // Reloadbutton
            // 
            this.Reloadbutton.Location = new System.Drawing.Point(174, 237);
            this.Reloadbutton.Name = "Reloadbutton";
            this.Reloadbutton.Size = new System.Drawing.Size(75, 23);
            this.Reloadbutton.TabIndex = 90;
            this.Reloadbutton.Text = "Reload";
            this.Reloadbutton.UseVisualStyleBackColor = true;
            this.Reloadbutton.Click += new System.EventHandler(this.Reloadbutton_Click);
            // 
            // invoicenumedittextBox
            // 
            this.invoicenumedittextBox.Location = new System.Drawing.Point(112, 10);
            this.invoicenumedittextBox.Name = "invoicenumedittextBox";
            this.invoicenumedittextBox.Size = new System.Drawing.Size(161, 20);
            this.invoicenumedittextBox.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Invoice Number:";
            // 
            // TotalAmountEdittextBox
            // 
            this.TotalAmountEdittextBox.Location = new System.Drawing.Point(112, 188);
            this.TotalAmountEdittextBox.Name = "TotalAmountEdittextBox";
            this.TotalAmountEdittextBox.Size = new System.Drawing.Size(161, 20);
            this.TotalAmountEdittextBox.TabIndex = 91;
            // 
            // prevbaleditextBox
            // 
            this.prevbaleditextBox.Location = new System.Drawing.Point(112, 163);
            this.prevbaleditextBox.Name = "prevbaleditextBox";
            this.prevbaleditextBox.Size = new System.Drawing.Size(161, 20);
            this.prevbaleditextBox.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Total Amount Due:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Previous Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Activity:";
            // 
            // SearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 440);
            this.Controls.Add(this.EditInvoicepanel);
            this.Controls.Add(this.EditInvoicecheckBox);
            this.Controls.Add(this.TotalDuelistBox);
            this.Controls.Add(this.PrevBallistBox);
            this.Controls.Add(this.InvoiceidlistBox);
            this.Controls.Add(this.InvoicelistBox);
            this.Controls.Add(this.DatelistBox);
            this.Controls.Add(this.ActivitylistBox);
            this.Controls.Add(this.SearchInvoicedataGridView);
            this.Controls.Add(this.Importbutton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameSearchcomboBox);
            this.Controls.Add(this.SearchInvoiceNumbercomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NamePaymentlabel);
            this.Controls.Add(this.InvoiceNumberPaymentlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "SearchInvoice";
            this.Text = "SearchInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.SearchInvoicedataGridView)).EndInit();
            this.EditInvoicepanel.ResumeLayout(false);
            this.EditInvoicepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox NameSearchcomboBox;
        private System.Windows.Forms.ComboBox SearchInvoiceNumbercomboBox;
        private System.Windows.Forms.Label NamePaymentlabel;
        private System.Windows.Forms.Label InvoiceNumberPaymentlabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DataGridView SearchInvoicedataGridView;
        private System.Windows.Forms.ListBox ActivitylistBox;
        private System.Windows.Forms.Button Importbutton;
        private System.Windows.Forms.ListBox DatelistBox;
        private System.Windows.Forms.ListBox InvoicelistBox;
        private System.Windows.Forms.ListBox InvoiceidlistBox;
        private System.Windows.Forms.ListBox PrevBallistBox;
        private System.Windows.Forms.ListBox TotalDuelistBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.CheckBox EditInvoicecheckBox;
        private System.Windows.Forms.TextBox ActivityEdittextBox;
        private System.Windows.Forms.Panel EditInvoicepanel;
        private System.Windows.Forms.TextBox TotalAmountEdittextBox;
        private System.Windows.Forms.TextBox prevbaleditextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoicenumedittextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Reloadbutton;
    }
}