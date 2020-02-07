using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Session2RushYeeet
{
    public partial class formNewEMR : Form
    {
        Asset _asset;
        Employee _user;
        public formNewEMR(Asset asset, Employee user)
        {
            InitializeComponent();
            _asset = asset;
            _user = user;
        }

        private void formNewEMR_Load(object sender, EventArgs e)
        {
            label2.Text = _asset.AssetSN;
            label4.Text = _asset.AssetName;
            label6.Text = _asset.DepartmentLocation.Department.Name;

            using (var db = new Session2Entities())
            {
                var priority = from x in db.Priorities
                               select x.Name;

                cboxPriority.DataSource = priority.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emReq = new EmergencyMaintenance();
            emReq.AssetID = _asset.ID;
            emReq.PriorityID = cboxPriority.SelectedIndex + 1;
            emReq.DescriptionEmergency = richTextBox1.Text;
            emReq.OtherConsiderations = richTextBox2.Text;
            emReq.EMReportDate = DateTime.Today;

            using (var db = new Session2Entities())
            {
                db.EmergencyMaintenances.Add(emReq);
                db.SaveChanges();
                MessageBox.Show("EM submitted");
                var formN = new formAPMain(_user);
                formN.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formN = new formAPMain(_user);
            formN.Show();
            this.Hide();
        }
    }
}
