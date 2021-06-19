
namespace Thirdform
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
            this.BtnSpFind = new System.Windows.Forms.Button();
            this.BtnSpDelete = new System.Windows.Forms.Button();
            this.BtnSpClear = new System.Windows.Forms.Button();
            this.BtnSpUpdate = new System.Windows.Forms.Button();
            this.BtnSpSave = new System.Windows.Forms.Button();
            this.TxtSpName = new System.Windows.Forms.TextBox();
            this.TxtSpNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioIndividual = new System.Windows.Forms.RadioButton();
            this.RadioTeam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SpDOH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpFind
            // 
            this.BtnSpFind.Location = new System.Drawing.Point(481, 47);
            this.BtnSpFind.Name = "BtnSpFind";
            this.BtnSpFind.Size = new System.Drawing.Size(75, 32);
            this.BtnSpFind.TabIndex = 23;
            this.BtnSpFind.Text = "Find";
            this.BtnSpFind.UseVisualStyleBackColor = true;
            this.BtnSpFind.Click += new System.EventHandler(this.BtnSFind_Click);
            // 
            // BtnSpDelete
            // 
            this.BtnSpDelete.Location = new System.Drawing.Point(481, 100);
            this.BtnSpDelete.Name = "BtnSpDelete";
            this.BtnSpDelete.Size = new System.Drawing.Size(75, 32);
            this.BtnSpDelete.TabIndex = 22;
            this.BtnSpDelete.Text = "Delete";
            this.BtnSpDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSpClear
            // 
            this.BtnSpClear.Location = new System.Drawing.Point(562, 100);
            this.BtnSpClear.Name = "BtnSpClear";
            this.BtnSpClear.Size = new System.Drawing.Size(75, 32);
            this.BtnSpClear.TabIndex = 21;
            this.BtnSpClear.Text = "Clear";
            this.BtnSpClear.UseVisualStyleBackColor = true;
            // 
            // BtnSpUpdate
            // 
            this.BtnSpUpdate.Location = new System.Drawing.Point(562, 47);
            this.BtnSpUpdate.Name = "BtnSpUpdate";
            this.BtnSpUpdate.Size = new System.Drawing.Size(75, 32);
            this.BtnSpUpdate.TabIndex = 20;
            this.BtnSpUpdate.Text = "Update";
            this.BtnSpUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSpSave
            // 
            this.BtnSpSave.Location = new System.Drawing.Point(481, 216);
            this.BtnSpSave.Name = "BtnSpSave";
            this.BtnSpSave.Size = new System.Drawing.Size(75, 32);
            this.BtnSpSave.TabIndex = 19;
            this.BtnSpSave.Text = "Save";
            this.BtnSpSave.UseVisualStyleBackColor = true;
            this.BtnSpSave.Click += new System.EventHandler(this.BtnSpSave_Click);
            // 
            // TxtSpName
            // 
            this.TxtSpName.Location = new System.Drawing.Point(207, 106);
            this.TxtSpName.Name = "TxtSpName";
            this.TxtSpName.Size = new System.Drawing.Size(239, 23);
            this.TxtSpName.TabIndex = 18;
            this.TxtSpName.TextChanged += new System.EventHandler(this.TxtSName_TextChanged);
            // 
            // TxtSpNumber
            // 
            this.TxtSpNumber.Location = new System.Drawing.Point(207, 50);
            this.TxtSpNumber.Name = "TxtSpNumber";
            this.TxtSpNumber.Size = new System.Drawing.Size(239, 23);
            this.TxtSpNumber.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sport Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sport Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sport Number";
            // 
            // RadioIndividual
            // 
            this.RadioIndividual.AutoSize = true;
            this.RadioIndividual.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioIndividual.Location = new System.Drawing.Point(207, 167);
            this.RadioIndividual.Name = "RadioIndividual";
            this.RadioIndividual.Size = new System.Drawing.Size(100, 23);
            this.RadioIndividual.TabIndex = 24;
            this.RadioIndividual.TabStop = true;
            this.RadioIndividual.Text = "Individual";
            this.RadioIndividual.UseVisualStyleBackColor = true;
            // 
            // RadioTeam
            // 
            this.RadioTeam.AutoSize = true;
            this.RadioTeam.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioTeam.Location = new System.Drawing.Point(313, 167);
            this.RadioTeam.Name = "RadioTeam";
            this.RadioTeam.Size = new System.Drawing.Size(64, 23);
            this.RadioTeam.TabIndex = 25;
            this.RadioTeam.TabStop = true;
            this.RadioTeam.Text = "Team";
            this.RadioTeam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date Of Holding";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(729, 228);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SpDOH
            // 
            this.SpDOH.CustomFormat = "dd,mm,yyyy";
            this.SpDOH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpDOH.Location = new System.Drawing.Point(207, 219);
            this.SpDOH.Name = "SpDOH";
            this.SpDOH.Size = new System.Drawing.Size(255, 23);
            this.SpDOH.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpDOH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioTeam);
            this.Controls.Add(this.RadioIndividual);
            this.Controls.Add(this.BtnSpFind);
            this.Controls.Add(this.BtnSpDelete);
            this.Controls.Add(this.BtnSpClear);
            this.Controls.Add(this.BtnSpUpdate);
            this.Controls.Add(this.BtnSpSave);
            this.Controls.Add(this.TxtSpName);
            this.Controls.Add(this.TxtSpNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSpFind;
        private System.Windows.Forms.Button BtnSpDelete;
        private System.Windows.Forms.Button BtnSpClear;
        private System.Windows.Forms.Button BtnSpUpdate;
        private System.Windows.Forms.Button BtnSpSave;
        private System.Windows.Forms.TextBox TxtSpName;
        private System.Windows.Forms.TextBox TxtSpNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioIndividual;
        private System.Windows.Forms.RadioButton RadioTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker SpDOH;
    }
}

