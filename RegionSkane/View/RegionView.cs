using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegionSkane.Controller;
using RegionSkane.Entity_Framework;
using RegionSkane.View;
using RegionSkane.Utils;

namespace RegionSkane
{
    public partial class RegionView : Form
    {
        public RegionView()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private EntityController entityController = new EntityController();
        private UtilsController utilsController = new UtilsController();
        private CreateContractView nd = new CreateContractView();



        //LaddaAvtalBtn - when clicked.
        private void laddaAvtalBtn_Click(object sender, EventArgs e)
        {
            string avtalsNr = avtalsnrTxt.Text;

            if (avtalsNr != null && avtalsNr.Trim() != string.Empty)
            {
                try
                {
                    DataSet ds = utilsController.ReadExcelToDataSet(avtalsNr);

                    if (ds.Tables.Count > 0)
                    {
                        DataTable supplierTable = utilsController.ListOfSuppliersToDataTable(ds);

                        if (supplierTable.Rows.Count > 0)
                        {
                            CreateContractView newView = new CreateContractView(this, ds, supplierTable, avtalsNr);
                            newView.Show();
                        }
                        else
                        {
                            //Inget avtal, inga leverantörer
                        }
                    }
                    else
                    {
                        //inga tables i dataSet, förmodligen fel i excelen någonstans, (laddat in fel)
                    }

                }
                catch
                {
                    //textBox3.Text = "något blev fel";
                }
            }
            else
            {
                //Skriv ut att inget avtal hittades med det nummret.
            }
  
        }


        private void dsadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void avtalsnrLbl_Click(object sender, EventArgs e)
        {

        }

        private void avtalsnrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void handläggareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
        }

        // HANDLÄGGARE VIEW ***********************************************************

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            if (addAdminIdTxt.Text != null && addAdminIdTxt.Text.Trim() != String.Empty)
            {
                try
                {
                    Handläggare h = new Handläggare();
                    h.Id = addAdminIdTxt.Text;
                    h.Namn = addAdminNameTxt.Text;
                    h.Mail = addAdminMailTxt.Text;
                    h.TelefonNr = addAdminPhoneTxt.Text;

                    if (entityController.AddAdministrator(h))
                    {
                        editAdminMsgLbl.Text = "Handläggare skapad!";
                        addAdminIdTxt.Text = "";
                        addAdminNameTxt.Text = "";
                        addAdminMailTxt.Text = "";
                        addAdminPhoneTxt.Text = "";
                    }
                    else
                    {
                        editAdminMsgLbl.Text = "Gick inte att lägga till handläggare. Handläggare med de initialerna finns redan.";
                    }
                }
                catch(RegionException ex)
                {
                    MessageBox.Show(ex.errMsg);
                }
            }
            else
            {
                editAdminMsgLbl.Text = "Gick inte att lägga till handläggare. Initialer får inte vara tomma.";
            }
        }

        private void editAdminIdSearchBtn_Click(object sender, EventArgs e)
        {
            string id = editAdminIdTxt.Text;

            if (id != null && id.Trim() != string.Empty)
            {
                try
                {
                    Handläggare h = entityController.GetAdministrator(editAdminIdTxt.Text);

                    if (h != null)
                    {
                        editAdminMsgLbl.Text = "";
                        editAdminIdTxt.Text = h.Id;
                        editAdminNameTxt.Text = h.Namn;
                        editAdminPhoneTxt.Text = h.TelefonNr;
                        editAdminMailTxt.Text = h.Mail;

                        editAdminIdTxt.Enabled = false;
                        editAdminNameTxt.Enabled = true;
                        editAdminMailTxt.Enabled = true;
                        editAdminPhoneTxt.Enabled = true;
                    }
                    else
                    {
                        editAdminMsgLbl.Text = "Ingen handläggare funnen med de initialerna.";
                        editAdminIdTxt.Text = "";
                        editAdminNameTxt.Text = "";
                        editAdminPhoneTxt.Text = "";
                        editAdminMailTxt.Text = "";
                    }
                }
                catch (RegionException ex)
                {
                    MessageBox.Show(ex.errMsg);
                }
            }
            else
            {
                editAdminMsgLbl.Text = "Kan inte söka handläggare utan värden. Skriv in värde i sökfältet.";
            }
        }

        private void editAdminUpdateBtn_Click(object sender, EventArgs e)
        {
            string id = editAdminIdTxt.Text;

            try
            {
                if (id != null && id.Trim() != string.Empty)
                {
                    Handläggare h = new Handläggare();
                    h.Id = editAdminIdTxt.Text;
                    h.Namn = editAdminNameTxt.Text;
                    h.TelefonNr = editAdminPhoneTxt.Text;
                    h.Mail = editAdminMailTxt.Text;

                    if (entityController.UpdateAdministrator(h))
                    {
                        editAdminIdTxt.Enabled = true;
                        editAdminNameTxt.Enabled = false;
                        editAdminMailTxt.Enabled = false;
                        editAdminPhoneTxt.Enabled = false;

                        editAdminIdTxt.Text = "";
                        editAdminNameTxt.Text = "";
                        editAdminPhoneTxt.Text = "";
                        editAdminMailTxt.Text = "";

                        editAdminMsgLbl.Text = "Handläggare uppdaterad!";
                    }
                    else
                    {
                        editAdminMsgLbl.Text = "Handläggare kunde inte uppdateras.";
                    }
                }
                else
                {
                    editAdminMsgLbl.Text = "Handläggare kunde inte uppdateras, saknar värden.";
                }
            }
            catch (RegionException ex)
            {
                MessageBox.Show(ex.errMsg);
            }
        }

        private void avslutaProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAdminDeleteBtn_Click(object sender, EventArgs e)
        {
            string id = editAdminIdTxt.Text;

            try
            {
                if (id != null && id.Trim() != string.Empty)
                {
                    if (entityController.DeleteAdministrator(id))
                    {
                        editAdminIdTxt.Enabled = true;
                        editAdminNameTxt.Enabled = false;
                        editAdminMailTxt.Enabled = false;
                        editAdminPhoneTxt.Enabled = false;

                        editAdminIdTxt.Text = "";
                        editAdminNameTxt.Text = "";
                        editAdminPhoneTxt.Text = "";
                        editAdminMailTxt.Text = "";

                        editAdminMsgLbl.Text = "Handläggare borttagen!";
                    }
                    else{
                        editAdminMsgLbl.Text = "Handläggare kunde inte tas bort. Ingen handläggare finns med de initialer.";
                    }
                }
                else
                {
                   editAdminMsgLbl.Text = "Handläggare kunde inte tas bort. Initialer saknas."; 
                }
            }
            catch (RegionException ex)
            {
                MessageBox.Show(ex.errMsg);
            }
        }

        private void editAdminClearFieldsBtn_Click(object sender, EventArgs e)
        {
            editAdminIdTxt.Enabled = true;
            editAdminNameTxt.Enabled = false;
            editAdminMailTxt.Enabled = false;
            editAdminPhoneTxt.Enabled = false;

            editAdminIdTxt.Text = "";
            editAdminNameTxt.Text = "";
            editAdminPhoneTxt.Text = "";
            editAdminMailTxt.Text = "";

            editAdminMsgLbl.Text = "";
        }


    }
}
