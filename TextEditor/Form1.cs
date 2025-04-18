using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace TextEditor
{
    public partial class Form1: Form
    {
        private string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            setupping();
        }

        private void setupping()
        {


            // teksti arean setuppaus
            // koodi osiota varten dockfill että koko näytöllä koodi kohta on iso
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.WordWrap = false;
            txtEditor.Font = new Font("Consolas", 20);
            this.Controls.Add(txtEditor);

        }

        // tiedoston avaaminen
        private void OpenFile(TextBox editor)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    editor.Text = System.IO.File.ReadAllText(filePath);
                }
            }
        }

        // tiedoston tallentaminen
        private void SaveFile(TextBox editor)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(filePath, editor.Text);
                }
            }
        }
        // tiedoston tallentaminen eri nimellä
        private void SaveAsFile(TextBox editor)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(filePath, editor.Text);
                }
            }
        }

        // nappi tiedoston muuttoa varten encrypt base64
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string encryption = txtEditor.Text;
                byte[] encryptBytes = Encoding.UTF8.GetBytes(encryption);
                string base64 = Convert.ToBase64String(encryptBytes);
                txtEditor.Text = base64;

                Thread.Sleep(10);

                MessageBox.Show("Text Encrypted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile(editor: txtEditor);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveAsFile(editor: txtEditor);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile(editor: txtEditor);
        }

        // decryptaus encryptatulle filulle
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string decrypt = txtEditor.Text;
                byte[] decryptBytes = Convert.FromBase64String(decrypt);
                string decryptedText = Encoding.UTF8.GetString(decryptBytes);
                txtEditor.Text = decryptedText;

                // processori sleep commandi
                Thread.Sleep(10);
                MessageBox.Show("Text Decrypted");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // pelkkä github processin starttaaja
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Maurisio12345");
        }



    }
}
