namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.btnExit.Click += (sender, e) => this.Close();
            this.dlgOpen.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            this.dlgSave.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                this.richTxtBox.LoadFile(dlgOpen.FileName, (RichTextBoxStreamType)(dlgOpen.FilterIndex - 1));
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (richTxtBox.SelectedText.Length > 0)
                dlgFont.Font = richTxtBox.SelectionFont ?? this.Font;

            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.SelectionFont = dlgFont.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (richTxtBox.SelectedText.Length > 0)
                dlgColor.Color = richTxtBox.SelectionColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.SelectionColor = dlgColor.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.SaveFile(dlgSave.FileName, (RichTextBoxStreamType)(dlgSave.FilterIndex - 1));
            }
        }

        private void btnMyDlg_Click(object sender, EventArgs e)
        {
            MyDialog myDialog = new MyDialog();

            if(myDialog.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.AppendText($"\n{myDialog.MyTextBoxValue}");
            }
        }
    }
}
