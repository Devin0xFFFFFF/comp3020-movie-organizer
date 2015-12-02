namespace Comp3020A3
{
    partial class FirstSignInForm
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.profileLink = new System.Windows.Forms.Label();
            this.listsLink = new System.Windows.Forms.Label();
            this.searchLink = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.profileLink, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.listsLink, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.searchLink, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 335);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanks for signing up with us! Now you can follow other users, write reviews, and" +
    " create lists of movies. We suggest you start out by: ";
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLink.Location = new System.Drawing.Point(3, 116);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(378, 67);
            this.profileLink.TabIndex = 1;
            this.profileLink.Text = "Going out your profile and editing the color scheme";
            this.profileLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileLink.Click += new System.EventHandler(this.profileLink_Click);
            this.profileLink.MouseEnter += new System.EventHandler(this.enterOption);
            this.profileLink.MouseLeave += new System.EventHandler(this.leaveOption);
            // 
            // listsLink
            // 
            this.listsLink.AutoSize = true;
            this.listsLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listsLink.Location = new System.Drawing.Point(3, 183);
            this.listsLink.Name = "listsLink";
            this.listsLink.Size = new System.Drawing.Size(378, 67);
            this.listsLink.TabIndex = 2;
            this.listsLink.Text = "Heading over to My Lists and creating your first list";
            this.listsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listsLink.Click += new System.EventHandler(this.listsLink_Click);
            this.listsLink.MouseEnter += new System.EventHandler(this.enterOption);
            this.listsLink.MouseLeave += new System.EventHandler(this.leaveOption);
            // 
            // searchLink
            // 
            this.searchLink.AutoSize = true;
            this.searchLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLink.Location = new System.Drawing.Point(3, 250);
            this.searchLink.Name = "searchLink";
            this.searchLink.Size = new System.Drawing.Size(378, 67);
            this.searchLink.TabIndex = 3;
            this.searchLink.Text = "Searching for a movie and writing a review";
            this.searchLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLink.Click += new System.EventHandler(this.searchLink_Click);
            this.searchLink.MouseEnter += new System.EventHandler(this.enterOption);
            this.searchLink.MouseLeave += new System.EventHandler(this.leaveOption);
            // 
            // FirstSignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FirstSignInForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profileLink;
        private System.Windows.Forms.Label listsLink;
        private System.Windows.Forms.Label searchLink;
    }
}
