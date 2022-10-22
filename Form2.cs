using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_DL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            if (Form1.selectedVolumes.Count != 0)
            {
                for (var i = 0; i < Form1.selectedVolumes.Count; i++)
                {
                    listBox1.Items.Add(Form1.selectedVolumes[i]);
                }
            }
        }
    }
}
