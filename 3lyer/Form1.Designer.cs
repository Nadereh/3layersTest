namespace _3lyer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idvahed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomrh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codedaress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeostad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saateraeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvahed,
            this.nomrh,
            this.codedaress,
            this.codeostad,
            this.saateraeh});
            this.dataGridView1.Location = new System.Drawing.Point(45, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idvahed
            // 
            this.idvahed.DataPropertyName = "idvahed";
            this.idvahed.HeaderText = "کدواحد";
            this.idvahed.Name = "idvahed";
            // 
            // nomrh
            // 
            this.nomrh.DataPropertyName = "nomrh";
            this.nomrh.HeaderText = "نمره";
            this.nomrh.Name = "nomrh";
            // 
            // codedaress
            // 
            this.codedaress.DataPropertyName = "codedaress";
            this.codedaress.HeaderText = "کددرس";
            this.codedaress.Name = "codedaress";
            // 
            // codeostad
            // 
            this.codeostad.DataPropertyName = "codeostad";
            this.codeostad.HeaderText = "کداستاد";
            this.codeostad.Name = "codeostad";
            // 
            // saateraeh
            // 
            this.saateraeh.DataPropertyName = "saateraeh";
            this.saateraeh.HeaderText = "ساعت ارائه";
            this.saateraeh.Name = "saateraeh";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvahed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomrh;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedaress;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn saateraeh;
        private System.Windows.Forms.Button button2;
    }
}

