namespace Dialogs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpen = new Button();
            btnSave = new Button();
            btnExit = new Button();
            btnFont = new Button();
            btnColor = new Button();
            btnMyDlg = new Button();
            richTxtBox = new RichTextBox();
            dlgColor = new ColorDialog();
            dlgFont = new FontDialog();
            dlgOpen = new OpenFileDialog();
            dlgSave = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(234, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Location = new Point(456, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFont.Location = new Point(12, 318);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 3;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom;
            btnColor.Location = new Point(234, 319);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 4;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnMyDlg
            // 
            btnMyDlg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMyDlg.Location = new Point(456, 319);
            btnMyDlg.Name = "btnMyDlg";
            btnMyDlg.Size = new Size(75, 23);
            btnMyDlg.TabIndex = 5;
            btnMyDlg.Text = "MyDialog";
            btnMyDlg.UseVisualStyleBackColor = true;
            btnMyDlg.Click += btnMyDlg_Click;
            // 
            // richTxtBox
            // 
            richTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTxtBox.Location = new Point(12, 60);
            richTxtBox.Name = "richTxtBox";
            richTxtBox.Size = new Size(519, 233);
            richTxtBox.TabIndex = 6;
            richTxtBox.Text = "";
            // 
            // dlgOpen
            // 
            dlgOpen.InitialDirectory = "D:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 354);
            Controls.Add(richTxtBox);
            Controls.Add(btnMyDlg);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Editor";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnSave;
        private Button btnExit;
        private Button btnFont;
        private Button btnColor;
        private Button btnMyDlg;
        private RichTextBox richTxtBox;
        private ColorDialog dlgColor;
        private FontDialog dlgFont;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
    }
}
