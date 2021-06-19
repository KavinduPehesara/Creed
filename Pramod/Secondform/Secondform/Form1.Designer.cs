
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 167);
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
            this.TxtSIndex.Size = new System.Drawing.Size(374, 29);
            this.TxtSIndex.TabIndex = 4;
            // 
            // TxtSName
            // 
            this.TxtSName.Location = new System.Drawing.Point(196, 104);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(374, 29);
            this.TxtSName.TabIndex = 7;
            // 
            // SDOB
            // 
            this.SDOB.CustomFormat = "dd,mm,yyyy";
            this.SDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SDOB.Location = new System.Drawing.Point(196, 163);
            this.SDOB.Name = "SDOB";
            this.SDOB.Size = new System.Drawing.Size(255, 29);
            this.SDOB.TabIndex = 8;
            // 
            // BtnSSave
            // 
            this.BtnSSave.Location = new System.Drawing.Point(495, 160);
            this.BtnSSave.Name = "BtnSSave";
            this.BtnSSave.Size = new System.Drawing.Size(75, 32);
            this.BtnSSave.TabIndex = 9;
            this.BtnSSave.Text = "Save";
            this.BtnSSave.UseVisualStyleBackColor = true;
            this.BtnSSave.Click += new System.EventHandler(this.BtnSSave_Click);
            // 
            // BtnSUpdate
            // 
            this.BtnSUpdate.Location = new System.Drawing.Point(691, 41);
            this.BtnSUpdate.Name = "BtnSUpdate";
            this.BtnSUpdate.Size = new System.Drawing.Size(75, 32);
            this.BtnSUpdate.TabIndex = 10;
            this.BtnSUpdate.Text = "Update";
            this.BtnSUpdate.UseVisualStyleBackColor = true;
            this.BtnSUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSClear
            // 
            this.BtnSClear.Location = new System.Drawing.Point(691, 101);
            this.BtnSClear.Name = "BtnSClear";
            this.BtnSClear.Size = new System.Drawing.Size(75, 32);
            this.BtnSClear.TabIndex = 11;
            this.BtnSClear.Text = "Clear";
            this.BtnSClear.UseVisualStyleBackColor = true;
            // 
            // BtnSDelete
            // 
            this.BtnSDelete.Location = new System.Drawing.Point(597, 101);
            this.BtnSDelete.Name = "BtnSDelete";
            this.BtnSDelete.Size = new System.Drawing.Size(75, 32);
            this.BtnSDelete.TabIndex = 12;
            this.BtnSDelete.Text = "Delete";
            this.BtnSDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSFind
            // 
            this.BtnSFind.Location = new System.Drawing.Point(597, 41);
            this.BtnSFind.Name = "BtnSFind";
            this.BtnSFind.Size = new System.Drawing.Size(75, 32);
            this.BtnSFind.TabIndex = 13;
            this.BtnSFind.Text = "Find";
            this.BtnSFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(729, 228);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(813, 490);
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
    }
}

