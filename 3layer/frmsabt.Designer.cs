namespace _3layer
{
    partial class Frmsabt
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
            this.btn_sabt = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cbx_course = new System.Windows.Forms.ComboBox();
            this.cbx_ostad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_sabt
            // 
            this.btn_sabt.Location = new System.Drawing.Point(188, 206);
            this.btn_sabt.Name = "btn_sabt";
            this.btn_sabt.Size = new System.Drawing.Size(74, 20);
            this.btn_sabt.TabIndex = 0;
            this.btn_sabt.Text = "ثبت";
            this.btn_sabt.UseVisualStyleBackColor = true;
            this.btn_sabt.Click += new System.EventHandler(this.btn_sabt_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(55, 206);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 20);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cbx_course
            // 
            this.cbx_course.DisplayMember = "name";
            this.cbx_course.FormattingEnabled = true;
            this.cbx_course.Location = new System.Drawing.Point(69, 31);
            this.cbx_course.Name = "cbx_course";
            this.cbx_course.Size = new System.Drawing.Size(121, 21);
            this.cbx_course.TabIndex = 2;
            this.cbx_course.ValueMember = "id";
            // 
            // cbx_ostad
            // 
            this.cbx_ostad.DisplayMember = "name";
            this.cbx_ostad.FormattingEnabled = true;
            this.cbx_ostad.Location = new System.Drawing.Point(69, 72);
            this.cbx_ostad.Name = "cbx_ostad";
            this.cbx_ostad.Size = new System.Drawing.Size(121, 21);
            this.cbx_ostad.TabIndex = 3;
            this.cbx_ostad.ValueMember = "id";
            // 
            // Frmsabt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbx_ostad);
            this.Controls.Add(this.cbx_course);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sabt);
            this.Name = "Frmsabt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Frmsabt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sabt;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cbx_course;
        private System.Windows.Forms.ComboBox cbx_ostad;
    }
}