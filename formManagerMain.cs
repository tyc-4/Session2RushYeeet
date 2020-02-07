using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2RushYeeet
{
    public partial class formManagerMain : Form
    {
        public formManagerMain()
        {
            InitializeComponent();
        }

        private void formManagerMain_Load(object sender, EventArgs e)
        {
            using (var db = new Session2Entities())
            {
                var allOpenReq = from x in db.EmergencyMaintenances
                                 where x.EMEndDate == null
                                 orderby x.PriorityID
                                 orderby x.EMReportDate
                                 select x;
                foreach (var req in allOpenReq)
                {
                    var employeeFullName = $"{req.Asset.Employee.FirstName} {req.Asset.Employee.LastName}";
                    dgvAvailAsset.Rows.Add(req.Asset.AssetSN, req.Asset.AssetName, req.EMReportDate.ToString(), employeeFullName, req.Asset.DepartmentLocation.Department.Name);
                }
            }
        }

        private void btnSendEM_Click(object sender, EventArgs e)
        {
            if (dgvAvailAsset.SelectedRows.Count == 1)
            {
                //go edit
                using (var db = new Session2Entities())
                {
                    var assetSn = dgvAvailAsset.Rows[0].Cells[0].Value.ToString();
                    var EMReqToSend = (from x in db.EmergencyMaintenances
                                      where x.Asset.AssetSN == assetSn
                                      select x).FirstOrDefault();
                    var formN = new formEditEM(EMReqToSend);
                    formN.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please select one only pl0x");
            }
        }
    }
}
