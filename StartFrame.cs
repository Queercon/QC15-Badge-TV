using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QC15_TV_Forms;

namespace QC15_TV_Forms
{
    public partial class StartFrame : Form
    {
        FormState formState = new FormState();

        public StartFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formState.Maximize(this);
            btnFullScreen.Hide();
            btnRestore.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formState.Restore(this);
            btnFullScreen.Show();
            btnRestore.Show();
        }

    }
}
