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

namespace RegionSkane
{
    public partial class CreateContractView : Form
    {
        public CreateContractView()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private UtilsController utilsController = new UtilsController();
        private EntityController entityController = new EntityController();


        private RegionView mainForm = null;
        private DataSet originalDs = null;
        private DataTable supplierDt = null;
        private string contractNbr = null;

        public CreateContractView(Form callingForm, DataSet dataSet, DataTable supplierList, string avtalsNr)
        {
            mainForm = callingForm as RegionView;
            originalDs = dataSet;
            supplierDt = supplierList;
            contractNbr = avtalsNr;

            //Disables mainForm - if user exit we have a listner to enable it again.
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

        void LoadData()
        {
            //Load 'Avtalsnummer' in avtalsTextbox
            avtalsnrTxt.Text = contractNbr;

            //Adds name for 'Varugrupp','Artgrupp' and 'Huvudgrupp'
            originalDs = utilsController.LoadDataSetWithNameFromDb(originalDs);

            //Load 'Löpnummer'-dataTable in dataGridView
            lopnrDataGrid.DataSource = supplierDt;
            foreach (DataGridViewColumn col in lopnrDataGrid.Columns)
            {
                if (col.Index.Equals(0) || col.Index.Equals(1))
                {
                    col.ReadOnly = true;
                }
            }

            //Format dateTimePicker
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "yyyy-MM-dd";

            stopDateTimePicker.Format = DateTimePickerFormat.Custom;
            stopDateTimePicker.CustomFormat = "yyyy-MM-dd";

            //Fill comboBox with suppliers
            FillHandComboBox();
        }

        public void setAdministrator(Handläggare h)
        {
            if (h != null)
            {
                handIdTxt.Text = h.Id;
                handNamnTxt.Text = h.Namn;
                handTelTxt.Text = h.TelefonNr;
                handMailTxt.Text = h.Mail;
            }
            
        }

        private void searchAdministrator_Click(object sender, EventArgs e)
        {
            string id = searchHandTxt.Text;

            if (id != null && id.Trim() != string.Empty)
            {
                Handläggare h = entityController.GetAdministrator(id);

                if (h != null)
                {
                    msgLbl.Text = "";
                    handIdTxt.Text = h.Id;
                    handNamnTxt.Text = h.Namn;
                    handTelTxt.Text = h.TelefonNr;
                    handMailTxt.Text = h.Mail;
                }
                else
                {
                    msgLbl.Text = "Ingen handläggare funnen med de initialerna.";
                    handIdTxt.Text = "";
                    handNamnTxt.Text = "";
                    handTelTxt.Text = "";
                    handMailTxt.Text = "";
                }
            }
            else
            {
                msgLbl.Text = "Kan inte söka handläggare utan värden. Skriv in värde i sökfältet.";
            }
            
        }

        private void AddHandledareView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void FillHandComboBox()
        {

            Dictionary<Handläggare, string> listComboBox = new Dictionary<Handläggare, string>();
            try
            {
                foreach (Handläggare admin in entityController.GetAllAdministrators())
                {
                    listComboBox.Add(admin, admin.Namn);
                }
            }
            catch 
            {
                //Felmeddelande
                //MessageBox.Show(ex.errorMessage);
            }

            handComboBox.DataSource = new BindingSource(listComboBox, null);
            handComboBox.DisplayMember = "Value";
            handComboBox.ValueMember = "Key";
            handComboBox.SelectedValue = 0;
        }

        public void changedValueCombo(){
            Handläggare h = handComboBox.SelectedValue as Handläggare;

            if (h != null)
            {
                handIdTxt.Text = h.Id;
                handNamnTxt.Text = h.Namn;
                handTelTxt.Text = h.TelefonNr;
                handMailTxt.Text = h.Mail;
            }
            

        }
        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Skicka över alla funktioner i Utils
            
            
            //Krävs check av löpnummer

            DataTable newData = (DataTable)lopnrDataGrid.DataSource;
            DataSet ds = utilsController.AddColumnData(originalDs, newData);
            originalDs = ds;
            DataSet printDs = utilsController.GetPrintSets(originalDs);

            List<string> savePaths = utilsController.OpenFolderDialog(originalDs, contractNbr);

            //Check if amount of paths and Tables match, other abort
            if (utilsController.CheckEqualsTablesPath(printDs, savePaths))
            {
                //Creates pdf:s
                utilsController.CreatePdfDocuments(printDs, savePaths, contractNbr);
                this.Enabled = false;
                MessageBox.Show("Avtal skapat! Filer ligger nu i respektive sökväg.");
                this.Close();
            }
            else
            {
                msgLbl.Text = "Inte tillräckligt med fakta för att skapa avtal. Saknar sökvägar (välj mapp) för filer.";
            }


        }

        private void SendDataCreatePdf(DataSet dataSet, List<string> savePathList, Handläggare handläggare, string startDate, string endDate, string avtalNr )
        {
            //StartCreation of sperate pdf:s

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateHandView newView = new CreateHandView(this);
            newView.Show();
        }

        private void handComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedValueCombo();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Not in use

        private void handLbl_Click(object sender, EventArgs e)
        {

        }

        private void searchHandTxt_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void handMailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void eMailLbl_Click(object sender, EventArgs e)
        {

        }

        private void handNamnTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void namnLbl_Click(object sender, EventArgs e)
        {

        }

        private void handTelLbl_Click(object sender, EventArgs e)
        {

        }

        private void handTelTxt_TextChanged(object sender, EventArgs e)
        {

        }

       
        
    }
        
}
