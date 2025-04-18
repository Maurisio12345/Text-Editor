namespace TextEditor
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRun.BackColor = System.Drawing.Color.Wheat;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(383, 405);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(85, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Encrypt";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditor.Location = new System.Drawing.Point(12, 48);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(776, 334);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.BackColor = System.Drawing.Color.Wheat;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(702, 19);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(80, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.BackColor = System.Drawing.Color.Wheat;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Location = new System.Drawing.Point(621, 19);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Save As File";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Wheat;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(534, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDecrypt.BackColor = System.Drawing.Color.Wheat;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.Location = new System.Drawing.Point(292, 405);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(85, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(470, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Github";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Text Editor Software!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button button1;
    }
}

