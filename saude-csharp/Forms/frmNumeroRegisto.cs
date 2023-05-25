using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saude_csharp.Forms
{
    public partial class frmNumeroRegisto : Form
    {
        public frmNumeroRegisto()
        {
            InitializeComponent();
        }

        public int enterdCod;
        private void procurarENTER()
        {
            Console.WriteLine(txtId.Text, "OK");
            enterdCod = int.Parse(txtId.Text);
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNumeroRegisto_Load(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frmNumeroRegisto_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
                procurarENTER();
        }
    }
}
