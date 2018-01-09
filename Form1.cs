//Programmer: Katie Welzbacher

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class PayrollCalculator : Form
    {
        public PayrollCalculator()
        {
            InitializeComponent();

        }

        private void PayrollCalculator_Load(object sender, EventArgs e)
        {

        }
        //make click event for calculate button
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare variables
            string name, social;
            double payRate, hours, grossPay, federal, state, netPay;

            //make try catch for each textbox with exceptions
            try
            {
                name = nameTextBox.Text;
                if (name.Equals("")) throw new FormatException();
                try
                {
                    social = socialTextBox.Text;
                    if (social.Equals("")) throw new FormatException();
                    try
                    {
                        payRate = Convert.ToDouble(hourlyPayTextBox.Text);
                        if (payRate < 8.1 || payRate > 108.7) throw new FormatException();
                        try
                        {
                            hours = Convert.ToDouble(hoursTextBox.Text);
                            if (hours < 1 || hours > 80) throw new FormatException();

                            //calculations
                            grossPay = payRate * hours;
                            federal = grossPay * 0.15;
                            state = grossPay * 0.05;
                            netPay = grossPay - federal - state;
                            //make labels appear
                            payrollLabel.Visible = true;
                            grossPayLabel.Text = "Gross Pay: " + grossPay.ToString("c") + "\nFederal withholding: " + federal.ToString("c") + "\nState Withholding: " + state.ToString("c") + "\nNet Pay: " + netPay.ToString("c");
                            grossPayLabel.Visible = true;
                        } catch (FormatException iee)
                        {
                            MessageBox.Show("Hours worked valid values: 1-80.", "Invalid Data");
                            hoursTextBox.Focus();
                        }
                    } catch (FormatException ex)
                    {
                        MessageBox.Show("Pay rate valid values: 8.1-108.7.", "Invalid Data");
                        hourlyPayTextBox.Focus();
                    }
                } catch (FormatException exx)
                {
                    MessageBox.Show("Invalid social security number.", "Invalid Data");
                    socialTextBox.Focus();
                }
            }
            catch (FormatException ie)
            {
                MessageBox.Show("Enter a valid name.", "Invalid Data");
                nameTextBox.Focus();
            }
        }

        //close program
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
