using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_LAB05.Forms
{
    public partial class SaveToBatchForm : Form
    {

        public SaveToBatchForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "+")
                textBox1.Visible = true;
            else
                textBox1.Visible = false;
        }
    }
}
