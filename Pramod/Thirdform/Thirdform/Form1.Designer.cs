
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Individual = new System.Windows.Forms.RadioButton();
            this.Team = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SpDOH = new System.Windows.Forms.DateTimePicker();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpFind
            // 
            this.BtnSpFind.Location = new System.Drawing.Point(538, 50);
            this.BtnSpFind.Name = "BtnSpFind";
            this.BtnSpFind.Size = new System.Drawing.Size(75, 32);
            this.BtnSpFind.TabIndex = 23;
            this.BtnSpFind.Text = "Find";
            this.BtnSpFind.UseVisualStyleBackColor = true;
            this.BtnSpFind.Click += new System.EventHandler(this.BtnSFind_Click);
            // 
            // BtnSpDelete
            // 
            this.BtnSpDelete.Location = new System.Drawing.Point(538, 163);
            this.BtnSpDelete.Name = "BtnSpDelete";
            this.BtnSpDelete.Size = new System.Drawing.Size(75, 32);
            this.BtnSpDelete.TabIndex = 22;
            this.BtnSpDelete.Text = "Delete";
            this.BtnSpDelete.UseVisualStyleBackColor = true;
            this.BtnSpDelete.Click += new System.EventHandler(this.BtnSpDelete_Click);
            // 
            // BtnSpClear
            // 
            this.BtnSpClear.Location = new System.Drawing.Point(538, 105);
            this.BtnSpClear.Name = "BtnSpClear";
            this.BtnSpClear.Size = new System.Drawing.Size(75, 32);
            this.BtnSpClear.TabIndex = 21;
            this.BtnSpClear.Text = "Clear";
            this.BtnSpClear.UseVisualStyleBackColor = true;
            this.BtnSpClear.Click += new System.EventHandler(this.BtnSpClear_Click);
            // 
            // BtnSpUpdate
            // 
            this.BtnSpUpdate.Location = new System.Drawing.Point(538, 213);
            this.BtnSpUpdate.Name = "BtnSpUpdate";
            this.BtnSpUpdate.Size = new System.Drawing.Size(75, 32);
            this.BtnSpUpdate.TabIndex = 20;
            this.BtnSpUpdate.Text = "Update";
            this.BtnSpUpdate.UseVisualStyleBackColor = true;
            this.BtnSpUpdate.Click += new System.EventHandler(this.BtnSpUpdate_Click);
            // 
            // BtnSpSave
            // 
            this.BtnSpSave.Location = new System.Drawing.Point(431, 163);
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
            this.TxtSpName.Size = new System.Drawing.Size(307, 23);
            this.TxtSpName.TabIndex = 18;
            this.TxtSpName.TextChanged += new System.EventHandler(this.TxtSName_TextChanged);
            // 
            // TxtSpNumber
            // 
            this.TxtSpNumber.Location = new System.Drawing.Point(207, 50);
            this.TxtSpNumber.Name = "TxtSpNumber";
            this.TxtSpNumber.Size = new System.Drawing.Size(307, 23);
            this.TxtSpNumber.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sport Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sport Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sport Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Individual
            // 
            this.Individual.AutoSize = true;
            this.Individual.BackColor = System.Drawing.Color.Transparent;
            this.Individual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Individual.Location = new System.Drawing.Point(207, 167);
            this.Individual.Name = "Individual";
            this.Individual.Size = new System.Drawing.Size(101, 23);
            this.Individual.TabIndex = 24;
            this.Individual.Text = "Individual";
            this.Individual.UseVisualStyleBackColor = false;
            // 
            // Team
            // 
            this.Team.AutoSize = true;
            this.Team.BackColor = System.Drawing.Color.Transparent;
            this.Team.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Team.Location = new System.Drawing.Point(333, 167);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(68, 23);
            this.Team.TabIndex = 25;
            this.Team.Text = "Team";
            this.Team.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date Of Holding";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(567, 158);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SpDOH
            // 
            this.SpDOH.CustomFormat = "dd,mm,yyyy";
            this.SpDOH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpDOH.Location = new System.Drawing.Point(207, 219);
            this.SpDOH.MinDate = new System.DateTime(1898, 12, 28, 0, 0, 0, 0);
            this.SpDOH.Name = "SpDOH";
            this.SpDOH.Size = new System.Drawing.Size(299, 23);
            this.SpDOH.TabIndex = 29;
            this.SpDOH.Value = new System.DateTime(2021, 6, 20, 22, 46, 9, 0);
            // 
            // DropDown
            // 
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Under 19",
            "Under 17",
            "Under 15",
            "Under 13"});
            this.DropDown.Location = new System.Drawing.Point(207, 273);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(299, 23);
            this.DropDown.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Age Categories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.SpDOH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.Individual);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.RadioButton Individual;
        private System.Windows.Forms.RadioButton Team;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker SpDOH;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.Label label5;
    }
}

