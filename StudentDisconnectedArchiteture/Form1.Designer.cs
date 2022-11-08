namespace StudentDisconnectedArchiteture
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRollno = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubject1 = new System.Windows.Forms.Label();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSubject2 = new System.Windows.Forms.Label();
            this.lblSubject3 = new System.Windows.Forms.Label();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(595, 269);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRollno
            // 
            this.lblRollno.AutoSize = true;
            this.lblRollno.Location = new System.Drawing.Point(49, 30);
            this.lblRollno.Name = "lblRollno";
            this.lblRollno.Size = new System.Drawing.Size(128, 16);
            this.lblRollno.TabIndex = 5;
            this.lblRollno.Text = "Enter Student Rollno";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter Student Name";
            // 
            // lblSubject1
            // 
            this.lblSubject1.AutoSize = true;
            this.lblSubject1.Location = new System.Drawing.Point(47, 141);
            this.lblSubject1.Name = "lblSubject1";
            this.lblSubject1.Size = new System.Drawing.Size(126, 16);
            this.lblSubject1.TabIndex = 7;
            this.lblSubject1.Text = "Enter Subject1 Mark";
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(217, 24);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(100, 22);
            this.txtRollno.TabIndex = 8;
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(217, 135);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(100, 22);
            this.txtSub1.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 10;
            // 
            // lblSubject2
            // 
            this.lblSubject2.AutoSize = true;
            this.lblSubject2.Location = new System.Drawing.Point(47, 195);
            this.lblSubject2.Name = "lblSubject2";
            this.lblSubject2.Size = new System.Drawing.Size(126, 16);
            this.lblSubject2.TabIndex = 11;
            this.lblSubject2.Text = "Enter Subject2 Mark";
            // 
            // lblSubject3
            // 
            this.lblSubject3.AutoSize = true;
            this.lblSubject3.Location = new System.Drawing.Point(49, 249);
            this.lblSubject3.Name = "lblSubject3";
            this.lblSubject3.Size = new System.Drawing.Size(126, 16);
            this.lblSubject3.TabIndex = 12;
            this.lblSubject3.Text = "Enter Subject3 Mark";
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(217, 195);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(100, 22);
            this.txtSub2.TabIndex = 13;
            // 
            // txtSub3
            // 
            this.txtSub3.Location = new System.Drawing.Point(217, 246);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(100, 22);
            this.txtSub3.TabIndex = 14;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(49, 300);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(111, 16);
            this.lblPercentage.TabIndex = 15;
            this.lblPercentage.Text = "Enter Percentage";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(217, 300);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(332, 193);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.lblSubject3);
            this.Controls.Add(this.lblSubject2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.lblSubject1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollno);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRollno;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubject1;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSubject2;
        private System.Windows.Forms.Label lblSubject3;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub3;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

