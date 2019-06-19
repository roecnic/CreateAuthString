namespace CreateNewAuthString {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.btnCreateAuthStrings = new System.Windows.Forms.Button();
            this.rtbxAuthStrings = new System.Windows.Forms.RichTextBox();
            this.btnCopySelectedAuthString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAuthStrings
            // 
            this.btnCreateAuthStrings.Location = new System.Drawing.Point(13, 13);
            this.btnCreateAuthStrings.Name = "btnCreateAuthStrings";
            this.btnCreateAuthStrings.Size = new System.Drawing.Size(259, 23);
            this.btnCreateAuthStrings.TabIndex = 0;
            this.btnCreateAuthStrings.Text = "Neuen AuthString erstellen";
            this.btnCreateAuthStrings.UseVisualStyleBackColor = true;
            this.btnCreateAuthStrings.Click += new System.EventHandler(this.btnCreateAuthStrings_Click);
            // 
            // rtbxAuthStrings
            // 
            this.rtbxAuthStrings.Location = new System.Drawing.Point(13, 43);
            this.rtbxAuthStrings.Name = "rtbxAuthStrings";
            this.rtbxAuthStrings.Size = new System.Drawing.Size(259, 171);
            this.rtbxAuthStrings.TabIndex = 1;
            this.rtbxAuthStrings.Text = "";
            // 
            // btnCopySelectedAuthString
            // 
            this.btnCopySelectedAuthString.Location = new System.Drawing.Point(13, 221);
            this.btnCopySelectedAuthString.Name = "btnCopySelectedAuthString";
            this.btnCopySelectedAuthString.Size = new System.Drawing.Size(259, 23);
            this.btnCopySelectedAuthString.TabIndex = 2;
            this.btnCopySelectedAuthString.Text = "AuthString kopieren";
            this.btnCopySelectedAuthString.UseVisualStyleBackColor = true;
            this.btnCopySelectedAuthString.Click += new System.EventHandler(this.btnCopySelectedAuthString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCopySelectedAuthString);
            this.Controls.Add(this.rtbxAuthStrings);
            this.Controls.Add(this.btnCreateAuthStrings);
            this.Name = "Form1";
            this.Text = "Create new AuthString";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAuthStrings;
        private System.Windows.Forms.RichTextBox rtbxAuthStrings;
        private System.Windows.Forms.Button btnCopySelectedAuthString;
    }
}

