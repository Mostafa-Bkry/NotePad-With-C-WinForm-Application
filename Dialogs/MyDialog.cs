using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class MyDialog : Form
    {
        public MyDialog()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        public string MyTextBoxValue 
        {
            get => myTxtBox.Text;
            set => myTxtBox.Text = value; 
        }
    }
}
