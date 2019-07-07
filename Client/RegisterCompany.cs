using Client.Controller;
using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            IWMEController wMEController = new WMEController();

            Model.Company tempCompany = new Model.Company
            {
                companyID = textBoxCompanyID.Text,
                name = textBoxCompanyName.Text,
                email = textBoxCompanyEmail.Text,
                phone = int.Parse(textBoxPhoneNumber.Text)
            };

            wMEController.registerCompany(tempCompany);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
