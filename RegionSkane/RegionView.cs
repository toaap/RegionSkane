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

namespace RegionSkane
{
    public partial class RegionView : Form
    {
        public RegionView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private RegionController controller = new RegionController();
        private AddHandledareView nd = new AddHandledareView();

        public string LabelText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public void Geiv()
        {
            //textBox1.Text = Handläggares;
            nd.Close();
            this.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string artNr = textBox1.Text;
            DataSet ds = controller.ReadExcelToDataSet(artNr);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds; // dataset
            dataGridView1.DataMember = "table1"; // table name you need to show

            if (dataGridView1.DataSource != null)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
            /*
            int n;
            bool isNumeric = int.TryParse(artNr, out n);
            if (isNumeric || artNr == null || artNr == String.Empty)
            {
                DataSet ds = controller.ReadExcelToDataSet(artNr);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds; // dataset
                dataGridView1.DataMember = "Blad1$"; // table name you need to show

                if (dataGridView1.DataSource != null)
                {
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
            }
            else
            {
                textBox1.Text = "Endast siffror!";
            }
             * */ 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string companyName = textBox1.Text;
            string text = textBox2.Text;

            controller.printSamplePdf(companyName, text);
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string companyName = textBox2.Text;
            DataSet ds = (DataSet)dataGridView1.DataSource;
            DataTable dt = controller.GetCompanyArt(companyName, ds);
            dataGridView1.DataSource = dt;

            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if(dataGridView1.DataSource.GetType().ToString().Equals("System.Data.DataSet"))
            {
                DataSet ds = (DataSet)dataGridView1.DataSource;
                dt = ds.Tables["table1"];
            }
            else if (dataGridView1.DataSource.GetType().ToString().Equals("System.Data.DataTable"))
            {
                dt = (DataTable)dataGridView1.DataSource;
            }
            
            
            controller.Crud(dt);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Handläggare h = new Handläggare();
            h.HandläggarId = textBox3.Text;
            h.HandläggarNamn = "Janne";
            h.HandläggarTelefonNr = "070";

            DataTable dt = new DataTable();

            AddHandledareView newView = new AddHandledareView(this);
            newView.Show();


            try
            {
                DataSet ds = (DataSet)dataGridView1.DataSource;
                controller.AmountOfSuppliers(ds);
            }
            catch
            {
                textBox3.Text = "något blev fel";
            }
        }


    }
}
