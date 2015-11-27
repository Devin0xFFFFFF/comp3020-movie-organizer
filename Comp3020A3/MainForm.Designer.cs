namespace Comp3020A3
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.profileLink = new System.Windows.Forms.Label();
            this.myListsLink = new System.Windows.Forms.Label();
            this.signOutLink = new System.Windows.Forms.Label();
            this.signInLink = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.titleLabel);
            this.flowLayoutPanel1.Controls.Add(this.searchLabel);
            this.flowLayoutPanel1.Controls.Add(this.searchBox);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Controls.Add(this.profileLink);
            this.flowLayoutPanel1.Controls.Add(this.myListsLink);
            this.flowLayoutPanel1.Controls.Add(this.signOutLink);
            this.flowLayoutPanel1.Controls.Add(this.signInLink);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(227, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Movie Organizer";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(236, 6);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(80, 25);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox.Location = new System.Drawing.Point(322, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(174, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.search);
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButton.Location = new System.Drawing.Point(502, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Advanced Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // profileLink
            // 
            this.profileLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.profileLink.AutoSize = true;
            this.profileLink.Location = new System.Drawing.Point(613, 9);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(36, 13);
            this.profileLink.TabIndex = 3;
            this.profileLink.Text = "Profile";
            this.profileLink.Click += new System.EventHandler(this.profileLink_Click);
            // 
            // myListsLink
            // 
            this.myListsLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.myListsLink.AutoSize = true;
            this.myListsLink.Location = new System.Drawing.Point(655, 9);
            this.myListsLink.Name = "myListsLink";
            this.myListsLink.Size = new System.Drawing.Size(45, 13);
            this.myListsLink.TabIndex = 4;
            this.myListsLink.Text = "My Lists";
            this.myListsLink.Click += new System.EventHandler(this.myListsLink_Click);
            // 
            // signOutLink
            // 
            this.signOutLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.signOutLink.AutoSize = true;
            this.signOutLink.Location = new System.Drawing.Point(706, 9);
            this.signOutLink.Name = "signOutLink";
            this.signOutLink.Size = new System.Drawing.Size(48, 13);
            this.signOutLink.TabIndex = 5;
            this.signOutLink.Text = "Sign Out";
            this.signOutLink.Click += new System.EventHandler(this.signOutLink_Click);
            // 
            // signInLink
            // 
            this.signInLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.signInLink.AutoSize = true;
            this.signInLink.Location = new System.Drawing.Point(3, 31);
            this.signInLink.Name = "signInLink";
            this.signInLink.Size = new System.Drawing.Size(65, 13);
            this.signInLink.TabIndex = 6;
            this.signInLink.Text = "Sign In / Up";
            this.signInLink.Click += new System.EventHandler(this.signInLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Movie Organizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApplication);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label profileLink;
        private System.Windows.Forms.Label myListsLink;
        private System.Windows.Forms.Label signOutLink;
        private System.Windows.Forms.Label signInLink;
    }
}