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

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {
            gridList.ColumnCount = 1;
            gridList.Columns[0].Name = "Nombre";

            string[] row = new string[] {"Product 1" };
            gridList.Rows.Add(row);
            row = new string[] {"Product 2"};
            gridList.Rows.Add(row);
            row = new string[] {"Product 3"};
            gridList.Rows.Add(row);
            row = new string[] {"Product 4"};
            gridList.Rows.Add(row);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            gridList.Columns.Add(btn);
            btn.HeaderText = "Descargar";
            btn.Text = "Descargar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }
    }
}
