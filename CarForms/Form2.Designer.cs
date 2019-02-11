namespace CarForms
{
    partial class Form2
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
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblCarMark = new System.Windows.Forms.Label();
            this.tbMaker = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbReleaseYear = new System.Windows.Forms.TextBox();
            this.tbRegistrationDate = new System.Windows.Forms.TextBox();
            this.tbCarMark = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(11, 119);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(89, 13);
            this.lblRegistrationDate.TabIndex = 19;
            this.lblRegistrationDate.Text = "Registration Date";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(11, 93);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(71, 13);
            this.lblReleaseYear.TabIndex = 18;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(11, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(11, 41);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(37, 13);
            this.lblMaker.TabIndex = 16;
            this.lblMaker.Text = "Maker";
            // 
            // lblCarMark
            // 
            this.lblCarMark.AutoSize = true;
            this.lblCarMark.Location = new System.Drawing.Point(11, 15);
            this.lblCarMark.Name = "lblCarMark";
            this.lblCarMark.Size = new System.Drawing.Size(50, 13);
            this.lblCarMark.TabIndex = 15;
            this.lblCarMark.Text = "Car Mark";
            // 
            // tbMaker
            // 
            this.tbMaker.Location = new System.Drawing.Point(127, 38);
            this.tbMaker.Name = "tbMaker";
            this.tbMaker.Size = new System.Drawing.Size(337, 20);
            this.tbMaker.TabIndex = 14;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(127, 64);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(337, 20);
            this.tbType.TabIndex = 13;
            // 
            // tbReleaseYear
            // 
            this.tbReleaseYear.BackColor = System.Drawing.SystemColors.Window;
            this.tbReleaseYear.Location = new System.Drawing.Point(127, 90);
            this.tbReleaseYear.Name = "tbReleaseYear";
            this.tbReleaseYear.Size = new System.Drawing.Size(337, 20);
            this.tbReleaseYear.TabIndex = 12;
            // 
            // tbRegistrationDate
            // 
            this.tbRegistrationDate.Location = new System.Drawing.Point(127, 116);
            this.tbRegistrationDate.Name = "tbRegistrationDate";
            this.tbRegistrationDate.Size = new System.Drawing.Size(337, 20);
            this.tbRegistrationDate.TabIndex = 11;
            // 
            // tbCarMark
            // 
            this.tbCarMark.Location = new System.Drawing.Point(127, 12);
            this.tbCarMark.Name = "tbCarMark";
            this.tbCarMark.Size = new System.Drawing.Size(337, 20);
            this.tbCarMark.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(127, 161);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 192);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMaker);
            this.Controls.Add(this.lblCarMark);
            this.Controls.Add(this.tbMaker);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbReleaseYear);
            this.Controls.Add(this.tbRegistrationDate);
            this.Controls.Add(this.tbCarMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Add car";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblCarMark;
        private System.Windows.Forms.TextBox tbMaker;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbReleaseYear;
        private System.Windows.Forms.TextBox tbRegistrationDate;
        private System.Windows.Forms.TextBox tbCarMark;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}