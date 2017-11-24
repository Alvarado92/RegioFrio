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
    public partial class Ingreso : Form
    {
        public Ingreso() => InitializeComponent();

        private void ingresoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menusForm = new Menu();
            menusForm.FormClosed += (s, args) => this.Close();
            menusForm.Show();
        }
    }
}
