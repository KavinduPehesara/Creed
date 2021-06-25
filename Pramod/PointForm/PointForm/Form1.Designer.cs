
namespace PointForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HouseTX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.LBox = new System.Windows.Forms.ListBox();
            this.TestTX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDTX
            // 
            this.IDTX.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTX.Location = new System.Drawing.Point(167, 225);
            this.IDTX.Name = "IDTX";
            this.IDTX.Size = new System.Drawing.Size(105, 26);
            this.IDTX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // NameTX
            // 
            this.NameTX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTX.Location = new System.Drawing.Point(303, 226);
            this.NameTX.Name = "NameTX";
            this.NameTX.ReadOnly = true;
            this.NameTX.Size = new System.Drawing.Size(235, 26);
            this.NameTX.TabIndex = 3;
            this.NameTX.Text = "Name";
            this.NameTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Place";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HouseTX
            // 
            this.HouseTX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HouseTX.Location = new System.Drawing.Point(422, 270);
            this.HouseTX.Name = "HouseTX";
            this.HouseTX.ReadOnly = true;
            this.HouseTX.Size = new System.Drawing.Size(116, 26);
            this.HouseTX.TabIndex = 6;
            this.HouseTX.Text = "House";
            this.HouseTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(422, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(288, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Test.Location = new System.Drawing.Point(156, 379);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(116, 33);
            this.Test.TabIndex = 11;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // LBox
            // 
            this.LBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBox.FormattingEnabled = true;
            this.LBox.ItemHeight = 17;
            this.LBox.Location = new System.Drawing.Point(43, 39);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(495, 38);
            this.LBox.TabIndex = 13;
            // 
            // TestTX
            // 
            this.TestTX.Location = new System.Drawing.Point(406, 334);
            this.TestTX.Name = "TestTX";
            this.TestTX.Size = new System.Drawing.Size(100, 23);
            this.TestTX.TabIndex = 14;
            this.TestTX.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.TestTX);
            this.Controls.Add(this.LBox);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HouseTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HouseTX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.ListBox LBox;
        private System.Windows.Forms.TextBox TestTX;
    }
}

