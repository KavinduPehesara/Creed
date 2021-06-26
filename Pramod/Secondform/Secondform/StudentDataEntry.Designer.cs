
namespace Secondform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDataEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSIndex = new System.Windows.Forms.TextBox();
            this.TxtSName = new System.Windows.Forms.TextBox();
            this.SDOB = new System.Windows.Forms.DateTimePicker();
            this.BtnSSave = new System.Windows.Forms.Button();
            this.BtnSUpdate = new System.Windows.Forms.Button();
            this.BtnSClear = new System.Windows.Forms.Button();
            this.BtnSDelete = new System.Windows.Forms.Button();
            this.BtnSFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.House = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaleB = new System.Windows.Forms.RadioButton();
            this.FemaleB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student DOB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtSIndex
            // 
            this.TxtSIndex.Location = new System.Drawing.Point(196, 49);
            this.TxtSIndex.Name = "TxtSIndex";
            this.TxtSIndex.Size = new System.Drawing.Size(255, 29);
            this.TxtSIndex.TabIndex = 4;
            // 
            // TxtSName
            // 
            this.TxtSName.Location = new System.Drawing.Point(196, 104);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(255, 29);
            this.TxtSName.TabIndex = 7;
            // 
            // SDOB
            // 
            this.SDOB.CustomFormat = "dd,mm,yyyy";
            this.SDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SDOB.Location = new System.Drawing.Point(196, 154);
            this.SDOB.Name = "SDOB";
            this.SDOB.Size = new System.Drawing.Size(255, 29);
            this.SDOB.TabIndex = 8;
            // 
            // BtnSSave
            // 
            this.BtnSSave.Location = new System.Drawing.Point(37, 250);
            this.BtnSSave.Name = "BtnSSave";
            this.BtnSSave.Size = new System.Drawing.Size(233, 31);
            this.BtnSSave.TabIndex = 9;
            this.BtnSSave.Text = "Save";
            this.BtnSSave.UseVisualStyleBackColor = true;
            this.BtnSSave.Click += new System.EventHandler(this.BtnSSave_Click);
            // 
            // BtnSUpdate
            // 
            this.BtnSUpdate.Location = new System.Drawing.Point(327, 250);
            this.BtnSUpdate.Name = "BtnSUpdate";
            this.BtnSUpdate.Size = new System.Drawing.Size(233, 31);
            this.BtnSUpdate.TabIndex = 10;
            this.BtnSUpdate.Text = "Update";
            this.BtnSUpdate.UseVisualStyleBackColor = true;
            this.BtnSUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSClear
            // 
            this.BtnSClear.FlatAppearance.BorderSize = 0;
            this.BtnSClear.Location = new System.Drawing.Point(485, 49);
            this.BtnSClear.Name = "BtnSClear";
            this.BtnSClear.Size = new System.Drawing.Size(75, 31);
            this.BtnSClear.TabIndex = 11;
            this.BtnSClear.Text = "Clear";
            this.BtnSClear.UseVisualStyleBackColor = true;
            this.BtnSClear.Click += new System.EventHandler(this.BtnSClear_Click);
            // 
            // BtnSDelete
            // 
            this.BtnSDelete.Location = new System.Drawing.Point(485, 155);
            this.BtnSDelete.Name = "BtnSDelete";
            this.BtnSDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnSDelete.TabIndex = 12;
            this.BtnSDelete.Text = "Delete";
            this.BtnSDelete.UseVisualStyleBackColor = true;
            this.BtnSDelete.Click += new System.EventHandler(this.BtnSDelete_Click);
            // 
            // BtnSFind
            // 
            this.BtnSFind.Location = new System.Drawing.Point(485, 104);
            this.BtnSFind.Name = "BtnSFind";
            this.BtnSFind.Size = new System.Drawing.Size(75, 31);
            this.BtnSFind.TabIndex = 13;
            this.BtnSFind.Text = "Find";
            this.BtnSFind.UseVisualStyleBackColor = true;
            this.BtnSFind.Click += new System.EventHandler(this.BtnSFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(523, 126);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // House
            // 
            this.House.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.House.BackColor = System.Drawing.SystemColors.ControlLight;
            this.House.Cursor = System.Windows.Forms.Cursors.Default;
            this.House.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.House.Location = new System.Drawing.Point(391, 205);
            this.House.Name = "House";
            this.House.ReadOnly = true;
            this.House.Size = new System.Drawing.Size(169, 29);
            this.House.TabIndex = 15;
            this.House.Text = "House";
            this.House.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.House.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            // 
            // MaleB
            // 
            this.MaleB.AutoSize = true;
            this.MaleB.BackColor = System.Drawing.Color.Transparent;
            this.MaleB.Location = new System.Drawing.Point(196, 206);
            this.MaleB.Name = "MaleB";
            this.MaleB.Size = new System.Drawing.Size(62, 25);
            this.MaleB.TabIndex = 17;
            this.MaleB.TabStop = true;
            this.MaleB.Text = "Male";
            this.MaleB.UseVisualStyleBackColor = false;
            // 
            // FemaleB
            // 
            this.FemaleB.AutoSize = true;
            this.FemaleB.BackColor = System.Drawing.Color.Transparent;
            this.FemaleB.Location = new System.Drawing.Point(283, 206);
            this.FemaleB.Name = "FemaleB";
            this.FemaleB.Size = new System.Drawing.Size(78, 25);
            this.FemaleB.TabIndex = 18;
            this.FemaleB.TabStop = true;
            this.FemaleB.Text = "Female";
            this.FemaleB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 461);
            this.Controls.Add(this.FemaleB);
            this.Controls.Add(this.MaleB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.House);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSFind);
            this.Controls.Add(this.BtnSDelete);
            this.Controls.Add(this.BtnSClear);
            this.Controls.Add(this.BtnSUpdate);
            this.Controls.Add(this.BtnSSave);
            this.Controls.Add(this.SDOB);
            this.Controls.Add(this.TxtSName);
            this.Controls.Add(this.TxtSIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Student Data Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSIndex;
        private System.Windows.Forms.TextBox TxtSName;
        private System.Windows.Forms.DateTimePicker SDOB;
        private System.Windows.Forms.Button BtnSSave;
        private System.Windows.Forms.Button BtnSUpdate;
        private System.Windows.Forms.Button BtnSClear;
        private System.Windows.Forms.Button BtnSDelete;
        private System.Windows.Forms.Button BtnSFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton MaleB;
        private System.Windows.Forms.RadioButton FemaleB;
    }
}

