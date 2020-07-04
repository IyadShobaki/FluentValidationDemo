using DashboardUI.Validators;
using DemoLibrary;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Dashboard : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();
            errorListBox.DataSource = errors;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            errors.Clear();
            if (!decimal.TryParse(accountBalanceText.Text, out decimal accountBalance))
            {
                errors.Add("Account Balance: Invalid Amount");
                MessageBox.Show(errors[0]);
                return;
            }

            PersonModel person = new PersonModel();
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;
            person.AccountBalance = accountBalance;
            person.DateOfBirth = dateOfBirthPicker.Value;

            // Validate my data
            PersonValidator validator = new PersonValidator();

            ValidationResult results = validator.Validate(person);
            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errors.Add(failure.ErrorMessage);
                }
            }
            // Insert into the database
            if (errors.Count == 1)
            {
                MessageBox.Show(errors[0]);
            }
            else if (errors.Count > 1)
            {
                MessageBox.Show("Check the errors list");
            }
            else
            {
                MessageBox.Show("Operation Complete");
            }
        
        }
    }
}
