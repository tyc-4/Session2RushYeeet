using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Session2RushYeeet
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login button
            using (var db = new Session2Entities())
            {
                var filteredUser = from x in db.Employees
                                   where x.Username == tbUser.Text && x.Password == tbPW.Text
                                   select x;
                if (filteredUser.Count() == 1)
                {
                    var loggedInUser = filteredUser.First();
                    if (loggedInUser.isAdmin == true)
                    {
                        //is manager
                        var formN = new formManagerMain();
                        formN.Show();
                        this.Hide();
                    }
                    else
                    {
                        //is accountable party
                        var formN = new formAPMain(loggedInUser);
                        formN.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
