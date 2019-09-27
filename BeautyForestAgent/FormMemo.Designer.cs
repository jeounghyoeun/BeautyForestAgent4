namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFilDlg = new System.Windows.Forms.SaveFileDialog();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.txtReadFile = new System.Windows.Forms.TextBox();
            this.btnReadFileSelect = new System.Windows.Forms.Button();
            this.btnReadText = new System.Windows.Forms.Button();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.txtWriteFile = new System.Windows.Forms.TextBox();
            this.txtWriteText = new System.Windows.Forms.TextBox();
            this.btnWriteFileSelect = new System.Windows.Forms.Button();
            this.btnWriteText = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(309, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3215 정효은 - 파일 읽고 쓰기";
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            this.openFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFilDlg
            // 
            this.saveFilDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tpRead);
            this.tabMenu.Controls.Add(this.tpWrite);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(309, 242);
            this.tabMenu.TabIndex = 1;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtReadText);
            this.tpRead.Controls.Add(this.btnReadText);
            this.tpRead.Controls.Add(this.btnReadFileSelect);
            this.tpRead.Controls.Add(this.txtReadFile);
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(301, 216);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.btnWriteText);
            this.tpWrite.Controls.Add(this.btnWriteFileSelect);
            this.tpWrite.Controls.Add(this.txtWriteText);
            this.tpWrite.Controls.Add(this.txtWriteFile);
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(301, 216);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // txtReadFile
            // 
            this.txtReadFile.Location = new System.Drawing.Point(7, 7);
            this.txtReadFile.Name = "txtReadFile";
            this.txtReadFile.ReadOnly = true;
            this.txtReadFile.Size = new System.Drawing.Size(133, 21);
            this.txtReadFile.TabIndex = 0;
            // 
            // btnReadFileSelect
            // 
            this.btnReadFileSelect.Location = new System.Drawing.Point(142, 7);
            this.btnReadFileSelect.Name = "btnReadFileSelect";
            this.btnReadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnReadFileSelect.TabIndex = 1;
            this.btnReadFileSelect.Text = "파일 선택";
            this.btnReadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnReadText
            // 
            this.btnReadText.Location = new System.Drawing.Point(220, 7);
            this.btnReadText.Name = "btnReadText";
            this.btnReadText.Size = new System.Drawing.Size(75, 23);
            this.btnReadText.TabIndex = 2;
            this.btnReadText.Text = "불러오기";
            this.btnReadText.UseVisualStyleBackColor = true;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(9, 35);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.ReadOnly = true;
            this.txtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadText.Size = new System.Drawing.Size(284, 175);
            this.txtReadText.TabIndex = 3;
            // 
            // txtWriteFile
            // 
            this.txtWriteFile.Location = new System.Drawing.Point(7, 7);
            this.txtWriteFile.Name = "txtWriteFile";
            this.txtWriteFile.ReadOnly = true;
            this.txtWriteFile.Size = new System.Drawing.Size(129, 21);
            this.txtWriteFile.TabIndex = 0;
            // 
            // txtWriteText
            // 
            this.txtWriteText.Location = new System.Drawing.Point(9, 35);
            this.txtWriteText.Multiline = true;
            this.txtWriteText.Name = "txtWriteText";
            this.txtWriteText.ReadOnly = true;
            this.txtWriteText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWriteText.Size = new System.Drawing.Size(286, 175);
            this.txtWriteText.TabIndex = 1;
            // 
            // btnWriteFileSelect
            // 
            this.btnWriteFileSelect.Location = new System.Drawing.Point(142, 5);
            this.btnWriteFileSelect.Name = "btnWriteFileSelect";
            this.btnWriteFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFileSelect.TabIndex = 2;
            this.btnWriteFileSelect.Text = "파일 선택";
            this.btnWriteFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(220, 5);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(75, 23);
            this.btnWriteText.TabIndex = 3;
            this.btnWriteText.Text = "저장하기";
            this.btnWriteText.UseVisualStyleBackColor = true;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 264);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMemo";
            this.Text = "3215 정효은";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFilDlg;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.TextBox txtReadText;
        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.Button btnReadFileSelect;
        private System.Windows.Forms.TextBox txtReadFile;
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnWriteFileSelect;
        private System.Windows.Forms.TextBox txtWriteText;
        private System.Windows.Forms.TextBox txtWriteFile;
    }
}