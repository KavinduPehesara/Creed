
namespace Creed
{
    partial class StudentDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDataEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.IndexTXT = new System.Windows.Forms.TextBox();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.FindBT = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.House = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaleB = new System.Windows.Forms.RadioButton();
            this.FemaleB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Index";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student D.O.B.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NameTXT
            // 
            this.NameTXT.Location = new System.Drawing.Point(199, 88);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(245, 29);
            this.NameTXT.TabIndex = 5;
            // 
            // IndexTXT
            // 
            this.IndexTXT.Location = new System.Drawing.Point(199, 23);
            this.IndexTXT.Name = "IndexTXT";
            this.IndexTXT.Size = new System.Drawing.Size(245, 29);
            this.IndexTXT.TabIndex = 6;
            // 
            // DTPicker
            // 
            this.DTPicker.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker.CustomFormat = "dd,mm,yyyy";
            this.DTPicker.Location = new System.Drawing.Point(199, 141);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(245, 29);
            this.DTPicker.TabIndex = 7;
            // 
            // FindBT
            // 
            this.FindBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FindBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBT.Location = new System.Drawing.Point(467, 84);
            this.FindBT.Name = "FindBT";
            this.FindBT.Size = new System.Drawing.Size(86, 35);
            this.FindBT.TabIndex = 8;
            this.FindBT.Text = "Find";
            this.FindBT.UseVisualStyleBackColor = false;
            this.FindBT.Click += new System.EventHandler(this.FindBT_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBT.Location = new System.Drawing.Point(467, 21);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(86, 35);
            this.ClearBT.TabIndex = 9;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = false;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.House.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.House.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.House.Location = new System.Drawing.Point(394, 206);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(159, 35);
            this.House.TabIndex = 10;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(467, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdateBT
            // 
            this.UpdateBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBT.Location = new System.Drawing.Point(341, 266);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(212, 35);
            this.UpdateBT.TabIndex = 12;
            this.UpdateBT.Text = "Update";
            this.UpdateBT.UseVisualStyleBackColor = false;
            this.UpdateBT.Click += new System.EventHandler(this.button5_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBT.Location = new System.Drawing.Point(40, 268);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(211, 35);
            this.SaveBT.TabIndex = 13;
            this.SaveBT.Text = "Save";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 129);
            this.dataGridView1.TabIndex = 14;
            // 
            // MaleB
            // 
            this.MaleB.AutoSize = true;
            this.MaleB.BackColor = System.Drawing.Color.Transparent;
            this.MaleB.Location = new System.Drawing.Point(199, 213);
            this.MaleB.Name = "MaleB";
            this.MaleB.Size = new System.Drawing.Size(62, 25);
            this.MaleB.TabIndex = 15;
            this.MaleB.TabStop = true;
            this.MaleB.Text = "Male";
            this.MaleB.UseVisualStyleBackColor = false;
            // 
            // FemaleB
            // 
            this.FemaleB.AutoSize = true;
            this.FemaleB.BackColor = System.Drawing.Color.Transparent;
            this.FemaleB.Location = new System.Drawing.Point(283, 213);
            this.FemaleB.Name = "FemaleB";
            this.FemaleB.Size = new System.Drawing.Size(78, 25);
            this.FemaleB.TabIndex = 16;
            this.FemaleB.TabStop = true;
            this.FemaleB.Text = "Female";
            this.FemaleB.UseVisualStyleBackColor = false;
            // 
            // StudentDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 478);
            this.Controls.Add(this.FemaleB);
            this.Controls.Add(this.MaleB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.House);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.FindBT);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.IndexTXT);
            this.Controls.Add(this.NameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentDataEntry";
            this.Text = "StudentDataEntry";
            this.Load += new System.EventHandler(this.StudentDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTXT;
        private System.Windows.Forms.TextBox IndexTXT;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.Button FindBT;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton MaleB;
        private System.Windows.Forms.RadioButton FemaleB;
    }
}