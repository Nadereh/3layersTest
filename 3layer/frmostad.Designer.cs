namespace _3layer
{
    partial class frmostad
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
            this.dgvostad = new System.Windows.Forms.DataGridView();
            this.iddaneshjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedaneshjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomrh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvostad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvostad
            // 
            this.dgvostad.AllowUserToAddRows = false;
            this.dgvostad.AllowUserToDeleteRows = false;
            this.dgvostad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvostad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddaneshjo,
            this.namedaneshjo,
            this.iddars,
            this.namedars,
            this.nomrh});
            this.dgvostad.Location = new System.Drawing.Point(12, 12);
            this.dgvostad.Name = "dgvostad";
            this.dgvostad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvostad.Size = new System.Drawing.Size(541, 237);
            this.dgvostad.TabIndex = 0;
            this.dgvostad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvostad_CellContentClick);
            this.dgvostad.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvostad_CellEndEdit);
            // 
            // iddaneshjo
            // 
            this.iddaneshjo.DataPropertyName = "iddaneshjo";
            this.iddaneshjo.HeaderText = "کد دانشجو";
            this.iddaneshjo.Name = "iddaneshjo";
            this.iddaneshjo.ReadOnly = true;
            // 
            // namedaneshjo
            // 
            this.namedaneshjo.DataPropertyName = "namedaneshjo";
            this.namedaneshjo.HeaderText = "نام دانشجو";
            this.namedaneshjo.Name = "namedaneshjo";
            this.namedaneshjo.ReadOnly = true;
            // 
            // iddars
            // 
            this.iddars.DataPropertyName = "iddars";
            this.iddars.HeaderText = "کددرس";
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
            // nomrh
            // 
            this.nomrh.DataPropertyName = "nomrh";
            this.nomrh.HeaderText = "نمره";
            this.nomrh.Name = "nomrh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmostad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(565, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvostad);
            this.Name = "frmostad";
            this.Text = "ostad";
            this.Load += new System.EventHandler(this.ostad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvostad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvostad;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddaneshjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedaneshjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddars;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedars;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomrh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}