using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionSkane
{
    public partial class AddHandledareView : Form
    {
        public AddHandledareView()
        {
            InitializeComponent();
        }

        private RegionView mainForm = null;

        public AddHandledareView(Form callingForm)
        {
            mainForm = callingForm as RegionView;
            mainForm.Enabled = false;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        }

        //Listner that enables mainView to work if user closes this form.
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainForm.LabelText = textBox1.Text;
            this.Close();
            //mainView.Geiv(textBox1.Text);
        }

        
    }
        
}
