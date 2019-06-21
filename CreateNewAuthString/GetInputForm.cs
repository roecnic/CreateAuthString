using System;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace CreateNewAuthString {
    public partial class GetInputForm : Form {

        MainForm mainForm;

        public GetInputForm (MainForm parent) {
            InitializeComponent();
            mainForm = parent;
        }

        private void btnGenerateAuthKey_Click (object sender, EventArgs e) {
            try {
                if (tbxDomain.Text != "") {
                    var newDomain = tbxDomain.Text;

                    if (mainForm.GetAuthKeysOrHosts(mainForm.ReturnLines(), true).Contains(newDomain))
                        throw new Exception("Domain bereits vorhanden!");

                    //Fill CharString with content, except special characters
                    var charString = "";
                    var forbiddenChars = new int[] { 58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 96 };
                    for (var i = 48; i <= 122; i++) {
                        if (!forbiddenChars.Contains(i))
                            charString += (char) i;
                    }

                    //Create an AuthString and check, wheather it already exists. Then create a new one.
                    var newAuthKey = "";

                    do {
                        newAuthKey = GenerateAuthKey(charString);
                    } while (mainForm.GetAuthKeysOrHosts(mainForm.ReturnLines(), false).Contains(newAuthKey));

                    tbxAuthKey.Text = newAuthKey;
                    Clipboard.SetText(newAuthKey);
                    lblAuthKeyCopied.Visible = true;

                    File.WriteAllText(@".\FILES\AuthStrings.txt", newAuthKey + "." + newDomain + '\n' + mainForm.ReturnFile());
                } else {
                    MessageBox.Show("Bitte einen Domain-Namen angeben.", "Hinweis", MessageBoxButtons.OK);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Warnung", MessageBoxButtons.OK);
            }
        }

        private string GenerateAuthKey (string pCharString) {
            var randomClass = new Random();
            return new string(Enumerable.Repeat(pCharString, 12).Select(s => s[randomClass.Next(s.Length)]).ToArray());
        }

        private void btnCloseForm_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
