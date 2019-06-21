namespace CreateNewAuthString {
    partial class GetInputForm {
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
            this.lblDomain = new System.Windows.Forms.Label();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.lblAuthKey = new System.Windows.Forms.Label();
            this.tbxAuthKey = new System.Windows.Forms.TextBox();
            this.btnGenerateAuthKey = new System.Windows.Forms.Button();
            this.lblAuthKeyCopied = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(13, 13);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(68, 13);
            this.lblDomain.TabIndex = 0;
            this.lblDomain.Text = "Dyn-Domain:";
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(97, 10);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(175, 20);
            this.tbxDomain.TabIndex = 1;
            // 
            // lblAuthKey
            // 
            this.lblAuthKey.AutoSize = true;
            this.lblAuthKey.Location = new System.Drawing.Point(13, 39);
            this.lblAuthKey.Name = "lblAuthKey";
            this.lblAuthKey.Size = new System.Drawing.Size(78, 13);
            this.lblAuthKey.TabIndex = 2;
            this.lblAuthKey.Text = "Dein Auth-Key:";
            // 
            // tbxAuthKey
            // 
            this.tbxAuthKey.Location = new System.Drawing.Point(97, 36);
            this.tbxAuthKey.Name = "tbxAuthKey";
            this.tbxAuthKey.ReadOnly = true;
            this.tbxAuthKey.Size = new System.Drawing.Size(175, 20);
            this.tbxAuthKey.TabIndex = 3;
            // 
            // btnGenerateAuthKey
            // 
            this.btnGenerateAuthKey.Location = new System.Drawing.Point(12, 90);
            this.btnGenerateAuthKey.Name = "btnGenerateAuthKey";
            this.btnGenerateAuthKey.Size = new System.Drawing.Size(181, 23);
            this.btnGenerateAuthKey.TabIndex = 4;
            this.btnGenerateAuthKey.Text = "Auth-Key generieren";
            this.btnGenerateAuthKey.UseVisualStyleBackColor = true;
            this.btnGenerateAuthKey.Click += new System.EventHandler(this.btnGenerateAuthKey_Click);
            // 
            // lblAuthKeyCopied
            // 
            this.lblAuthKeyCopied.AutoSize = true;
            this.lblAuthKeyCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthKeyCopied.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthKeyCopied.Location = new System.Drawing.Point(114, 59);
            this.lblAuthKeyCopied.Name = "lblAuthKeyCopied";
            this.lblAuthKeyCopied.Size = new System.Drawing.Size(133, 17);
            this.lblAuthKeyCopied.TabIndex = 5;
            this.lblAuthKeyCopied.Text = "Auth-Key kopiert!";
            this.lblAuthKeyCopied.Visible = false;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(199, 90);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(73, 23);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.Text = "Schließen";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // GetInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblAuthKeyCopied);
            this.Controls.Add(this.btnGenerateAuthKey);
            this.Controls.Add(this.tbxAuthKey);
            this.Controls.Add(this.lblAuthKey);
            this.Controls.Add(this.tbxDomain);
            this.Controls.Add(this.lblDomain);
            this.Name = "GetInputForm";
            this.Text = "AuthKey genereien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.Label lblAuthKey;
        private System.Windows.Forms.TextBox tbxAuthKey;
        private System.Windows.Forms.Button btnGenerateAuthKey;
        private System.Windows.Forms.Label lblAuthKeyCopied;
        private System.Windows.Forms.Button btnCloseForm;
    }
}