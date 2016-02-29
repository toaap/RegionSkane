using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegionSkane;
using RegionSkane.Controller;
using RegionSkane.Entity_Framework;

namespace RegionSkane.View
{
    public partial class CreateHandView : Form
    {
        public CreateHandView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private CreateContractView mainForm = null;
        private UtilsController utilsController = new UtilsController();
        private EntityController entityController = new EntityController();


        public CreateHandView(Form callingForm)
        {
            mainForm = callingForm as CreateContractView;

            //Disables mainForm - if user exit we have a listner to enables it again.
            mainForm.Enabled = false;

            InitializeComponent();

            //Listner for event of FormClosing.
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        }

        //Listner that enables mainView to work if user closes this form.
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            string name = nameTxt.Text;
            string mail = mailTxt.Text;
            string phone = phoneTxt.Text;

            if (id != null && id.Trim() != string.Empty)
            {
                try
                {
                    Handläggare h = new Handläggare();
                    h.Id = id;
                    h.Namn = name;
                    h.Mail = mail;
                    h.TelefonNr = phone;
                    if (entityController.AddAdministrator(h))
                    {
                        mainForm.setAdministrator(h);
                        mainForm.FillHandComboBox();
                        this.Close();
                    }
                    else
                    {
                        returnMsgLbl.Text = "Gick inte att lägga till handläggare. Handläggare med de initialerna finns redan.";
                    }
                    
                }
                catch
                {
                    returnMsgLbl.Text = "Gick inte att lägga till handläggare.";
                }
            }
            else
            {
                returnMsgLbl.Text = "Initialer får inte vara tomma.";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
