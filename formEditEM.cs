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
    public partial class formEditEM : Form
    {
        EmergencyMaintenance _EMReq;
        public formEditEM(EmergencyMaintenance EMReq)
        {
            InitializeComponent();
            _EMReq = EMReq;
        }

        private void formEditEM_Load(object sender, EventArgs e)
        {
            label2.Text = _EMReq.Asset.AssetSN;
            label4.Text = _EMReq.Asset.AssetName;
            label6.Text = _EMReq.Asset.DepartmentLocation.Department.Name;

            if (_EMReq.EMStartDate != null)
            {
                dateTimePicker1.Value = _EMReq.EMStartDate.GetValueOrDefault();
            }

            richTextBox1.Text = _EMReq.EMTechnicianNote;

            using (var db = new Session2Entities())
            {
                var parts = from x in db.Parts
                            select x.Name;
                comboBox1.DataSource = parts.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text, numericUpDown1.Value, "Remove");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var db = new Session2Entities())
            {
                var emreqtoupdate = (from x in db.EmergencyMaintenances
                                    where x.ID == _EMReq.ID
                                    select x).FirstOrDefault();
                emreqtoupdate.EMStartDate = dateTimePicker1.Value;
                emreqtoupdate.EMEndDate = dateTimePicker2.Value;
                emreqtoupdate.EMTechnicianNote = richTextBox1.Text;
                db.SaveChanges();
            }
        }
    }
}
