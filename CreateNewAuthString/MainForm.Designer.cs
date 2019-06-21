namespace CreateNewAuthString {
    partial class MainForm {
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.rtbxAuthStrings);
            this.Controls.Add(this.btnCreateAuthStrings);
            this.Name = "Form1";
            this.Text = "Create new AuthString";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAuthStrings;
        private System.Windows.Forms.RichTextBox rtbxAuthStrings;
    }
}

