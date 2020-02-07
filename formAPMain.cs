using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Session2RushYeeet
{
    public partial class formAPMain : Form
    {
        Employee _loggedInUser;
        public formAPMain(Employee loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }

        private void formEMReq_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                //get all avail assets
                var allAssets = from x in db.Assets
                                where x.EmployeeID == _loggedInUser.ID
                                select x;
                Console.WriteLine(allAssets.Count());
                foreach (var asset in allAssets)
                {
                    var closedEMCount = (from x in db.EmergencyMaintenances
                                         where x.AssetID == asset.ID && x.EMEndDate != null
                                         select x).Count();
                    var openEMCount = (from x in db.EmergencyMaintenances
                                       where x.AssetID == asset.ID && x.EMEndDate == null
                                       select x).Count();
                    var lastClosedEMDate = from x in db.EmergencyMaintenances
                                           where x.AssetID == asset.ID && x.EMEndDate != null
                                           orderby x.EMEndDate descending
                                           select x.EMEndDate;
                    var lastClosedEMDateString = "--";

                    if (lastClosedEMDate.Count() != 0)
                    {
                        lastClosedEMDateString = lastClosedEMDate.First().ToString();
                    }

                    var row = dgvAvailAsset.Rows.Add(asset.AssetSN, asset.AssetName, lastClosedEMDateString, closedEMCount);
                    if (openEMCount != 0)
                    {
                        dgvAvailAsset.Rows[row].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnSendEM_Click(object sender, EventArgs e)
        {
            //make new EM Req
            if (dgvAvailAsset.SelectedRows.Count == 1)
            {
                using (var db = new Session2Entities())
                {
                    var selectedSN = dgvAvailAsset.SelectedCells[0].Value.ToString();
                    var assetToEM = (from x in db.Assets
                                     where x.AssetSN == selectedSN
                                     select x).FirstOrDefault();

                    var formN = new formNewEMR(assetToEM, _loggedInUser);
                    formN.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("select one asset only pl0x");
            }
        }
    }
}
