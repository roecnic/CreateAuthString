using System;
using System.Windows.Forms;
using System.IO;

namespace CreateNewAuthString {
    public partial class MainForm : Form {

        GetInputForm getInputForm;

        public MainForm () {
            InitializeComponent();
            getInputForm = new GetInputForm(this);
            rtbxAuthStrings.Text = File.ReadAllText(@".\FILES\AuthStrings.txt");
        }

        public string[] GetAuthKeysOrHosts (string[] pEntry, bool getHosts) {
            /* Returns either all AuthKeys or all Hosts in an Array.
             * bool variable declares if Hosts or AuthKeys should be returned.
             * true = Hosts / false = AuthKeys
             */
            var entryArray = new string[pEntry.Length];
            for (var i = 0; i < pEntry.Length; i++) {
                if (getHosts)
                    entryArray[i] = pEntry[i].Substring(pEntry[i].IndexOf('.') + 1);
                else
                    entryArray[i] = pEntry[i].Substring(0, pEntry[i].IndexOf('.'));
            }
            return entryArray;
        }

        public string ReturnFile () {
            return File.ReadAllText(@".\FILES\AuthStrings.txt");
        }

        public string[] ReturnLines () {
            return File.ReadAllLines(@".\FILES\AuthStrings.txt");
        }

        private void btnCreateAuthStrings_Click (object sender, EventArgs e) {
            getInputForm.Show();
            getInputForm.FormClosed += GetInputForm_FormClosed;
        }

        private void GetInputForm_FormClosed (object sender, FormClosedEventArgs e) {
            rtbxAuthStrings.Text = "" + File.ReadAllText(@".\FILES\AuthStrings.txt");
        }
    }
}
