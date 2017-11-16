using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfoApp
{
    public partial class ingresoForm : Form
    {
        public ingresoForm() => InitializeComponent();

        private void ingresoButton_Click(object sender, EventArgs e)
        {
            menusForm menusForm = new menusForm();
            menusForm.Show();
            this.Hide();
        }
    }
}
