namespace Comp3020A3
{
    partial class ProfileForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.reviewGrid = new System.Windows.Forms.DataGridView();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.followerCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listGrid = new System.Windows.Forms.DataGridView();
            this.followButton = new System.Windows.Forms.Button();
            this.manageFollowingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.editColorsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reviews";
            // 
            // reviewGrid
            // 
            this.reviewGrid.AllowUserToAddRows = false;
            this.reviewGrid.AllowUserToDeleteRows = false;
            this.reviewGrid.AllowUserToResizeColumns = false;
            this.reviewGrid.AllowUserToResizeRows = false;
            this.reviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reviewGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reviewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewGrid.Location = new System.Drawing.Point(3, 65);
            this.reviewGrid.Name = "reviewGrid";
            this.reviewGrid.ReadOnly = true;
            this.reviewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reviewGrid.RowHeadersVisible = false;
            this.reviewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reviewGrid.Size = new System.Drawing.Size(546, 351);
            this.reviewGrid.TabIndex = 1;
            this.reviewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectReview);
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(178, 39);
            this.userTitleLabel.TabIndex = 0;
            this.userTitleLabel.Text = "Username";
            // 
            // followerCountLabel
            // 
            this.followerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.followerCountLabel.AutoSize = true;
            this.followerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followerCountLabel.Location = new System.Drawing.Point(187, 7);
            this.followerCountLabel.Name = "followerCountLabel";
            this.followerCountLabel.Size = new System.Drawing.Size(116, 24);
            this.followerCountLabel.TabIndex = 1;
            this.followerCountLabel.Text = "Followers: X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lists";
            // 
            // listGrid
            // 
            this.listGrid.AllowUserToAddRows = false;
            this.listGrid.AllowUserToDeleteRows = false;
            this.listGrid.AllowUserToResizeColumns = false;
            this.listGrid.AllowUserToResizeRows = false;
            this.listGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGrid.ColumnHeadersVisible = false;
            this.listGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGrid.Location = new System.Drawing.Point(3, 65);
            this.listGrid.Name = "listGrid";
            this.listGrid.ReadOnly = true;
            this.listGrid.RowHeadersVisible = false;
            this.listGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listGrid.Size = new System.Drawing.Size(208, 351);
            this.listGrid.TabIndex = 1;
            this.listGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectList);
            // 
            // followButton
            // 
            this.followButton.Location = new System.Drawing.Point(346, 3);
            this.followButton.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.followButton.Name = "followButton";
            this.followButton.Size = new System.Drawing.Size(75, 23);
            this.followButton.TabIndex = 0;
            this.followButton.Text = "Follow";
            this.followButton.UseVisualStyleBackColor = true;
            this.followButton.Click += new System.EventHandler(this.followButton_Click);
            // 
            // manageFollowingButton
            // 
            this.manageFollowingButton.AutoSize = true;
            this.manageFollowingButton.Location = new System.Drawing.Point(464, 3);
            this.manageFollowingButton.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.manageFollowingButton.Name = "manageFollowingButton";
            this.manageFollowingButton.Size = new System.Drawing.Size(103, 23);
            this.manageFollowingButton.TabIndex = 1;
            this.manageFollowingButton.Text = "Manage Following";
            this.manageFollowingButton.UseVisualStyleBackColor = true;
            this.manageFollowingButton.Click += new System.EventHandler(this.manageFollowingButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.45382F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.54619F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(784, 498);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.27764F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.72237F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(778, 425);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.reviewGrid, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(223, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(552, 419);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.listGrid, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(214, 419);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.userTitleLabel);
            this.flowLayoutPanel4.Controls.Add(this.followerCountLabel);
            this.flowLayoutPanel4.Controls.Add(this.followButton);
            this.flowLayoutPanel4.Controls.Add(this.manageFollowingButton);
            this.flowLayoutPanel4.Controls.Add(this.editColorsButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(778, 61);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // editColorsButton
            // 
            this.editColorsButton.AutoSize = true;
            this.editColorsButton.Location = new System.Drawing.Point(610, 3);
            this.editColorsButton.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.editColorsButton.Name = "editColorsButton";
            this.editColorsButton.Size = new System.Drawing.Size(104, 23);
            this.editColorsButton.TabIndex = 2;
            this.editColorsButton.Text = "Edit Color Scheme";
            this.editColorsButton.UseVisualStyleBackColor = true;
            this.editColorsButton.Click += new System.EventHandler(this.editColorsButton_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "ProfileForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.reviewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.Label followerCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listGrid;
        private System.Windows.Forms.Button followButton;
        private System.Windows.Forms.DataGridView reviewGrid;
        private System.Windows.Forms.Button manageFollowingButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button editColorsButton;
    }
}
