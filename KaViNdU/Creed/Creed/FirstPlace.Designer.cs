
namespace Creed
{
    partial class FirstPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPlace));
            this.LBox = new System.Windows.Forms.ListBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTX = new System.Windows.Forms.TextBox();
            this.NameTX = new System.Windows.Forms.TextBox();
            this.HouseTX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.TestTX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBox
            // 
            this.LBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBox.FormattingEnabled = true;
            this.LBox.ItemHeight = 19;
            this.LBox.Location = new System.Drawing.Point(62, 27);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(505, 61);
            this.LBox.TabIndex = 0;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.SystemColors.Control;
            this.lable1.Location = new System.Drawing.Point(253, 113);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(155, 36);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "Champion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // IDTX
            // 
            this.IDTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTX.Location = new System.Drawing.Point(198, 213);
            this.IDTX.Name = "IDTX";
            this.IDTX.Size = new System.Drawing.Size(131, 26);
            this.IDTX.TabIndex = 3;
            this.IDTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTX
            // 
            this.NameTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTX.Location = new System.Drawing.Point(363, 212);
            this.NameTX.Name = "NameTX";
            this.NameTX.ReadOnly = true;
            this.NameTX.Size = new System.Drawing.Size(204, 26);
            this.NameTX.TabIndex = 4;
            this.NameTX.Text = "Name";
            this.NameTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HouseTX
            // 
            this.HouseTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseTX.Location = new System.Drawing.Point(363, 266);
            this.HouseTX.Name = "HouseTX";
            this.HouseTX.ReadOnly = true;
            this.HouseTX.Size = new System.Drawing.Size(204, 26);
            this.HouseTX.TabIndex = 5;
            this.HouseTX.Text = "House";
            this.HouseTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(479, 367);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(88, 35);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // TestTX
            // 
            this.TestTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTX.Location = new System.Drawing.Point(363, 298);
            this.TestTX.Name = "TestTX";
            this.TestTX.Size = new System.Drawing.Size(204, 26);
            this.TestTX.TabIndex = 8;
            this.TestTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TestTX.Visible = false;
            // 
            // FirstPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.TestTX);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HouseTX);
            this.Controls.Add(this.NameTX);
            this.Controls.Add(this.IDTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.LBox);
            this.Name = "FirstPlace";
            this.Text = "FirstPlace";
            this.Load += new System.EventHandler(this.FirstPlace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBox;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTX;
        private System.Windows.Forms.TextBox NameTX;
        private System.Windows.Forms.TextBox HouseTX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox TestTX;
    }
}