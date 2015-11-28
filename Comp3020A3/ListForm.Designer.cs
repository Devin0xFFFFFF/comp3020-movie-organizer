namespace Comp3020A3
{
    partial class ListForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.newListButton = new System.Windows.Forms.Button();
            this.listDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listIDLabel = new System.Windows.Forms.Label();
            this.editContentsButton = new System.Windows.Forms.Button();
            this.editNameButton = new System.Windows.Forms.Button();
            this.listTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 498);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.newListButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.listDataGrid, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 393);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // newListButton
            // 
            this.newListButton.Location = new System.Drawing.Point(3, 356);
            this.newListButton.Name = "newListButton";
            this.newListButton.Size = new System.Drawing.Size(75, 23);
            this.newListButton.TabIndex = 1;
            this.newListButton.Text = "New List";
            this.newListButton.UseVisualStyleBackColor = true;
            this.newListButton.Click += new System.EventHandler(this.newListButton_Click);
            // 
            // listDataGrid
            // 
            this.listDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDataGrid.Location = new System.Drawing.Point(3, 3);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.Size = new System.Drawing.Size(616, 347);
            this.listDataGrid.TabIndex = 0;
            this.listDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectCell);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listIDLabel);
            this.panel1.Controls.Add(this.editContentsButton);
            this.panel1.Controls.Add(this.editNameButton);
            this.panel1.Controls.Add(this.listTitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 93);
            this.panel1.TabIndex = 0;
            // 
            // listIDLabel
            // 
            this.listIDLabel.AutoSize = true;
            this.listIDLabel.Location = new System.Drawing.Point(15, 67);
            this.listIDLabel.Name = "listIDLabel";
            this.listIDLabel.Size = new System.Drawing.Size(103, 13);
            this.listIDLabel.TabIndex = 3;
            this.listIDLabel.Text = "0000000000000000";
            // 
            // editContentsButton
            // 
            this.editContentsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editContentsButton.AutoSize = true;
            this.editContentsButton.Location = new System.Drawing.Point(672, 44);
            this.editContentsButton.Name = "editContentsButton";
            this.editContentsButton.Size = new System.Drawing.Size(80, 23);
            this.editContentsButton.TabIndex = 2;
            this.editContentsButton.Text = "Edit Contents";
            this.editContentsButton.UseVisualStyleBackColor = true;
            this.editContentsButton.Click += new System.EventHandler(this.editContentsButton_Click);
            // 
            // editNameButton
            // 
            this.editNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editNameButton.Location = new System.Drawing.Point(591, 44);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(75, 23);
            this.editNameButton.TabIndex = 1;
            this.editNameButton.Text = "Edit Name";
            this.editNameButton.UseVisualStyleBackColor = true;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            // 
            // listTitleLabel
            // 
            this.listTitleLabel.AutoSize = true;
            this.listTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitleLabel.Location = new System.Drawing.Point(11, 25);
            this.listTitleLabel.Name = "listTitleLabel";
            this.listTitleLabel.Size = new System.Drawing.Size(156, 42);
            this.listTitleLabel.TabIndex = 0;
            this.listTitleLabel.Text = "List Title";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.DataGridView listDataGrid;
        private System.Windows.Forms.Button newListButton;
        private System.Windows.Forms.Button editContentsButton;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Label listIDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
