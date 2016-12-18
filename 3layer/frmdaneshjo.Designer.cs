namespace _3layer
{
    partial class frmdaneshjo
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
            this.dgvvahed = new System.Windows.Forms.DataGridView();
            this.iddars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idostad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameostad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomrh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvahed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvahed
            // 
            this.dgvvahed.AllowUserToAddRows = false;
            this.dgvvahed.AllowUserToDeleteRows = false;
            this.dgvvahed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvahed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddars,
            this.namedars,
            this.idostad,
            this.nameostad,
            this.nomrh});
            this.dgvvahed.Location = new System.Drawing.Point(22, 12);
            this.dgvvahed.MultiSelect = false;
            this.dgvvahed.Name = "dgvvahed";
            this.dgvvahed.ReadOnly = true;
            this.dgvvahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvvahed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvahed.Size = new System.Drawing.Size(494, 150);
            this.dgvvahed.TabIndex = 0;
            // 
            // iddars
            // 
            this.iddars.DataPropertyName = "iddars";
            this.iddars.HeaderText = "کد درس";
            this.iddars.Name = "iddars";
            this.iddars.ReadOnly = true;
            // 
            // namedars
            // 
            this.namedars.DataPropertyName = "namedars";
            this.namedars.HeaderText = "نام درس";
            this.namedars.Name = "namedars";
            this.namedars.ReadOnly = true;
            // 
            // idostad
            // 
            this.idostad.DataPropertyName = "idostad";
            this.idostad.HeaderText = "کداستاد";
            this.idostad.Name = "idostad";
            this.idostad.ReadOnly = true;
            // 
            // nameostad
            // 
            this.nameostad.DataPropertyName = "nameostad";
            this.nameostad.HeaderText = "نام استاد";
            this.nameostad.Name = "nameostad";
            this.nameostad.ReadOnly = true;
            // 
            // nomrh
            // 
            this.nomrh.DataPropertyName = "nomrh";
            this.nomrh.HeaderText = "نمره";
            this.nomrh.Name = "nomrh";
            this.nomrh.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(397, 200);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "اضافه";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // frmdaneshjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvvahed);
            this.Name = "frmdaneshjo";
            this.Text = "daneshjo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvahed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvahed;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddars;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedars;
        private System.Windows.Forms.DataGridViewTextBoxColumn idostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomrh;
    }
}