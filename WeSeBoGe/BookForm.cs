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
    public partial class BookForm : Form
    {
        public BookForm(String name)
        {
            InitializeComponent();
            this.Text = name;
        }
    }
}
