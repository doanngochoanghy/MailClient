namespace MailClient
{
    partial class FrmMain
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNewMessage = new System.Windows.Forms.TabPage();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCc = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.lbxAttachment = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMailQuantity = new System.Windows.Forms.Label();
            this.lvwInbox = new System.Windows.Forms.ListView();
            this.clmFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMain.SuspendLayout();
            this.tabNewMessage.SuspendLayout();
            this.tabInbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.AutoSize = true;
            this.btnSignOut.Location = new System.Drawing.Point(1181, 21);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Location = new System.Drawing.Point(1266, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(2, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabNewMessage);
            this.tabMain.Controls.Add(this.tabInbox);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(1, 47);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1267, 614);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabNewMessage
            // 
            this.tabNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNewMessage.Controls.Add(this.txtContent);
            this.tabNewMessage.Controls.Add(this.txtCc);
            this.tabNewMessage.Controls.Add(this.txtSubject);
            this.tabNewMessage.Controls.Add(this.txtTo);
            this.tabNewMessage.Controls.Add(this.lblSubject);
            this.tabNewMessage.Controls.Add(this.lblCc);
            this.tabNewMessage.Controls.Add(this.lblTo);
            this.tabNewMessage.Controls.Add(this.btnSend);
            this.tabNewMessage.Location = new System.Drawing.Point(4, 29);
            this.tabNewMessage.Margin = new System.Windows.Forms.Padding(0);
            this.tabNewMessage.Name = "tabNewMessage";
            this.tabNewMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabNewMessage.Size = new System.Drawing.Size(1259, 581);
            this.tabNewMessage.TabIndex = 0;
            this.tabNewMessage.Text = "New Message";
            this.tabNewMessage.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 165);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1250, 410);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            // 
            // txtCc
            // 
            this.txtCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.Location = new System.Drawing.Point(91, 91);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(1159, 26);
            this.txtCc.TabIndex = 2;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(91, 133);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(1159, 26);
            this.txtSubject.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(91, 49);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(1159, 26);
            this.txtTo.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(7, 129);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(75, 30);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject:";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCc
            // 
            this.lblCc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCc.Location = new System.Drawing.Point(7, 87);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(75, 30);
            this.lblCc.TabIndex = 1;
            this.lblCc.Text = "Cc:";
            this.lblCc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(6, 45);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(75, 30);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(7, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.lbxAttachment);
            this.tabInbox.Controls.Add(this.webBrowser1);
            this.tabInbox.Controls.Add(this.btnRefresh);
            this.tabInbox.Controls.Add(this.lblMailQuantity);
            this.tabInbox.Controls.Add(this.lvwInbox);
            this.tabInbox.Location = new System.Drawing.Point(4, 29);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabInbox.Size = new System.Drawing.Size(1259, 581);
            this.tabInbox.TabIndex = 1;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            // 
            // lbxAttachment
            // 
            this.lbxAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAttachment.FormattingEnabled = true;
            this.lbxAttachment.ItemHeight = 20;
            this.lbxAttachment.Location = new System.Drawing.Point(512, 509);
            this.lbxAttachment.Name = "lbxAttachment";
            this.lbxAttachment.Size = new System.Drawing.Size(744, 64);
            this.lbxAttachment.TabIndex = 5;
            this.lbxAttachment.DoubleClick += new System.EventHandler(this.lbxAttachment_DoubleClick);
            this.lbxAttachment.Leave += new System.EventHandler(this.lbxAttachment_Leave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(512, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(744, 500);
            this.webBrowser1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMailQuantity
            // 
            this.lblMailQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailQuantity.Location = new System.Drawing.Point(117, 3);
            this.lblMailQuantity.Name = "lblMailQuantity";
            this.lblMailQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMailQuantity.Size = new System.Drawing.Size(100, 30);
            this.lblMailQuantity.TabIndex = 3;
            this.lblMailQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwInbox
            // 
            this.lvwInbox.AllowDrop = true;
            this.lvwInbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwInbox.AutoArrange = false;
            this.lvwInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFrom,
            this.clmTime,
            this.clmSubject});
            this.lvwInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInbox.FullRowSelect = true;
            this.lvwInbox.Location = new System.Drawing.Point(0, 39);
            this.lvwInbox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lvwInbox.MultiSelect = false;
            this.lvwInbox.Name = "lvwInbox";
            this.lvwInbox.Size = new System.Drawing.Size(509, 542);
            this.lvwInbox.TabIndex = 0;
            this.lvwInbox.UseCompatibleStateImageBehavior = false;
            this.lvwInbox.View = System.Windows.Forms.View.Details;
            this.lvwInbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwInbox_MouseClick);
            // 
            // clmFrom
            // 
            this.clmFrom.Text = "From";
            this.clmFrom.Width = 150;
            // 
            // clmTime
            // 
            this.clmTime.Text = "Time";
            this.clmTime.Width = 78;
            // 
            // clmSubject
            // 
            this.clmSubject.Text = "Subject";
            this.clmSubject.Width = 614;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 664);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSignOut);
            this.Name = "FrmMain";
            this.Text = "Viettel Mail System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.tabMain.ResumeLayout(false);
            this.tabNewMessage.ResumeLayout(false);
            this.tabNewMessage.PerformLayout();
            this.tabInbox.ResumeLayout(false);
            this.tabInbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNewMessage;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ListView lvwInbox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMailQuantity;
        private System.Windows.Forms.ColumnHeader clmFrom;
        private System.Windows.Forms.ColumnHeader clmTime;
        private System.Windows.Forms.ColumnHeader clmSubject;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox lbxAttachment;
    }
}