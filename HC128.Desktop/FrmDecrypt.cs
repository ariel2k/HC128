using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC128.Desktop
{
    public partial class FrmDecrypt : Form
    {
        public FrmDecrypt()
        {
            InitializeComponent();
        }

        private void UpdateListFiles()
        {
            listFiles.Items.Clear();
            listFiles.Items.Add("Item 4");
            listFiles.Items.Add("Item 3");
            listFiles.Items.Add("Item 1");
            listFiles.Items.Add("Item 2");
            listFiles.Items.Add("Item 4");
            listFiles.Items.Add("Item 3");
            listFiles.Items.Add("Item 1");
        }

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {
            UpdateListFiles();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateListFiles();
        }
        
    }
}
