using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Login : UserControl
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inventoryDataContext idc = new inventoryDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FASHAKINALEALEXANDER\Documents\FProjects\InventoryManagementSystem-master\InventoryManagement\InventoryManagement\inventory_management.mdf;Integrated Security=True");
            if (!tbUser.Text.Equals("") || !tbPass.Text.Equals(""))
            {
                
                    if (tbUser.Text.Equals("admin") || tbPass.Text.Equals("1"))
                        InventoryManagement.adminLoginButtonClicked();
                    else if (tbUser.Text.Equals("user") || tbPass.Text.Equals("2"))

                        InventoryManagement.UserBtnClicked();
                    else
                        MessageBox.Show("Password or username incorrect");

                

                
            }
            else
                MessageBox.Show("Please fill in the details");

            /* //int id = 0;
             if(!tbUser.Text.ToString().Equals(""))


             {
             if(!tbUser.Text.Equals(""))
             id = Convert.ToInt32(tbUser.Text.ToString());
             }
             
            string pass = tbPass.Text.ToString();

            var row = idc.logins.SingleOrDefault(r => r.user_id == id);
            var user_pass = row != null ? row.user_pass : String.Empty;
            var user_type = row != null ? row.user_type : String.Empty;

            if(id != 0 && !pass.Equals(""))
            {
                if(user_pass.ToString().Equals(pass))
                {
                    if(user_type.ToString().Equals("admin"))
                    {
                        InventoryManagement.adminLoginButtonClicked();
                    }
                    else
                    {
                        InventoryManagement.UserBtnClicked();
                    }
                }
                else
                {
                    MessageBox.Show("Password or username incorrect!");
                }
            }
            else
            {
                if(id == 0)
                {
                    MessageBox.Show("Username incorrect!!");
                }
                else
                {
                    MessageBox.Show("Username and Password field required!");
                }
            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
