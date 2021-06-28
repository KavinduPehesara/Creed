
namespace Creed
{
    partial class SecondPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondPlace));
            this.Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HouseTX = new System.Windows.Forms.TextBox();
            this.NameTX = new System.Windows.Forms.TextBox();
            this.IDTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(483, 367);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(88, 35);
            this.Next.TabIndex = 15;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HouseTX
            // 
            this.HouseTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseTX.Location = new System.Drawing.Point(411, 247);
            this.HouseTX.Name = "HouseTX";
            this.HouseTX.Size = new System.Drawing.Size(160, 26);
            this.HouseTX.TabIndex = 13;
            this.HouseTX.Text = "House";
            this.HouseTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTX
            // 
            this.NameTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTX.Location = new System.Drawing.Point(411, 190);
            this.NameTX.Name = "NameTX";
            this.NameTX.Size = new System.Drawing.Size(160, 26);
            this.NameTX.TabIndex = 12;
            this.NameTX.Text = "Name";
            this.NameTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IDTX
            // 
            this.IDTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTX.Location = new System.Drawing.Point(178, 190);
            this.IDTX.Name = "IDTX";
            this.IDTX.Size = new System.Drawing.Size(184, 26);
            this.IDTX.TabIndex = 11;
            this.IDTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.SystemColors.Control;
            this.lable1.Location = new System.Drawing.Point(203, 74);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(228, 36);
            this.lable1.TabIndex = 9;
            this.lable1.Text = "First Runner Up";
            // 
            // SecondPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HouseTX);
            this.Controls.Add(this.NameTX);
            this.Controls.Add(this.IDTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Name = "SecondPlace";
            this.Text = "SecondPlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HouseTX;
        private System.Windows.Forms.TextBox NameTX;
        private System.Windows.Forms.TextBox IDTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
    }
}