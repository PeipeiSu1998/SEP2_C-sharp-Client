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
            bool validInput = false;

            IWMEController wMEController = new WMEController();

            if (textBoxCompanyID.Text == "") 
            {
                errorProvider1.SetError(textBoxCompanyID, "Please input company ID");
            }
            if (textBoxCompanyName.Text == "")
            {
                errorProvider1.SetError(textBoxCompanyName, "Please input company name");
            }
            if (textBoxCompanyEmail.Text == "")
            {
                errorProvider1.SetError(textBoxCompanyEmail, "Please input company email");
            }
            if (textBoxPhoneNumber.Text == "")
            {
                errorProvider1.SetError(textBoxPhoneNumber, "Please input company phone number");
            }
            if (textBoxCompanyID.Text.Length >= 1 && textBoxCompanyName.Text.Length >= 1 && textBoxCompanyEmail.Text.Length >= 1 && textBoxPhoneNumber.Text.Length >= 1)
            {
                validInput = true;
            }

            if (validInput)
            {
                Model.Company tempCompany = new Model.Company
                {
                    companyID = textBoxCompanyID.Text,
                    name = textBoxCompanyName.Text,
                    email = textBoxCompanyEmail.Text,
                    phone = int.Parse(textBoxPhoneNumber.Text)
                };

                wMEController.registerCompany(tempCompany);

                validInput = false;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
