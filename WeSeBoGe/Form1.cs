using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeSeBoGe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            String s = Prompt.ShowDialog("Enter a name", "Name");
            if (!(s == null))
            {
                this.Hide();
                new BookForm(s).Show();
            }
            
        }
    }
}
