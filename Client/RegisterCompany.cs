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
    public partial class RegisterCompany : Form
    {
        public RegisterCompany()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            IWMEController wMEController = new WMEController();

            Company tempCompany = new Company
            {
                CompanyID = textBoxCompanyName.Text,
                Name = textBoxCompanyName.Text,
                Email = textBoxCompanyEmail.Text,
                Phone = int.Parse(textBoxPhoneNumber.Text)
            };

            wMEController.registerCompany(tempCompany);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
