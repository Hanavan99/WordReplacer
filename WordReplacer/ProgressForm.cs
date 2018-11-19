using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordReplacer
{
    public partial class ProgressForm : Form
    {
        private MainForm mainForm;

        public ProgressForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {

        }

        public ProgressBar GetProgressBar()
        {
            return uxProgress;
        }

        public Label GetProgressLabel()
        {
            return uxProgressLabel;
        }

        public Button GetCancelButton()
        {
            return uxCancel;
        }
    }
}
