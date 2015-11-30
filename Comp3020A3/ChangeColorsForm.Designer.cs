namespace Comp3020A3
{
    partial class ChangeColorsForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pickTaskbarColorButton = new System.Windows.Forms.Button();
            this.pickWindowColorButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pickPopupWindowColorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(384, 335);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pickTaskbarColorButton);
            this.flowLayoutPanel1.Controls.Add(this.pickWindowColorButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pickTaskbarColorButton
            // 
            this.pickTaskbarColorButton.Location = new System.Drawing.Point(3, 3);
            this.pickTaskbarColorButton.Name = "pickTaskbarColorButton";
            this.pickTaskbarColorButton.Size = new System.Drawing.Size(110, 23);
            this.pickTaskbarColorButton.TabIndex = 0;
            this.pickTaskbarColorButton.Text = "Pick Taskbar Color";
            this.pickTaskbarColorButton.UseVisualStyleBackColor = true;
            this.pickTaskbarColorButton.Click += new System.EventHandler(this.pickTaskbarColorButton_Click);
            // 
            // pickWindowColorButton
            // 
            this.pickWindowColorButton.Location = new System.Drawing.Point(3, 32);
            this.pickWindowColorButton.Name = "pickWindowColorButton";
            this.pickWindowColorButton.Size = new System.Drawing.Size(110, 23);
            this.pickWindowColorButton.TabIndex = 1;
            this.pickWindowColorButton.Text = "Pick Window Color";
            this.pickWindowColorButton.UseVisualStyleBackColor = true;
            this.pickWindowColorButton.Click += new System.EventHandler(this.pickWindowColorButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pickPopupWindowColorButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 93);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(364, 63);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pickPopupWindowColorButton
            // 
            this.pickPopupWindowColorButton.Location = new System.Drawing.Point(3, 3);
            this.pickPopupWindowColorButton.Name = "pickPopupWindowColorButton";
            this.pickPopupWindowColorButton.Size = new System.Drawing.Size(110, 23);
            this.pickPopupWindowColorButton.TabIndex = 0;
            this.pickPopupWindowColorButton.Text = "Pick Popup Color";
            this.pickPopupWindowColorButton.UseVisualStyleBackColor = true;
            this.pickPopupWindowColorButton.Click += new System.EventHandler(this.pickPopupWindowColorButton_Click);
            // 
            // ChangeColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ChangeColorsForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button pickTaskbarColorButton;
        private System.Windows.Forms.Button pickWindowColorButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button pickPopupWindowColorButton;
    }
}
