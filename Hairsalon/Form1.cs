/* I, CHIRAG BARANDA, 
 * student number 000759867, 
 * certify that all code submitted is my own work; 
 * that I have not copied it from any other source.
 * I also certify that I have not allowed my work to be copied by others.
 * 
 * 
 * Authoer: CHIRAG BARANDA
 * Date: 12-OCT-2018
 * Program Description: This is a program for the Hairsalon, which is a GUI application
 * containing 4 groupboxes of radiobutton, checkbox and textbos.
 * User select those values as per theie requirement and than program calculate the total payable value for the user.
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairsalon
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is a clear button which clears the textbox and set the first value as a default values iin checkbox and radiobuttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            NumberOfClientsVisitsTextBox.Text = String.Empty;
            PriceDisplayLabel.Text = "$ 00.00";
            JaneRB.Checked = true;
            AdultRB.Checked = true;
            HairCutCB.Checked = ColourCB.Checked = HighlightsCB.Checked = ExtensionCB.Checked = false;

        }
        /// <summary>
        /// The calculate button, which takes values from the radibutton and checkbox and assign the values accordingly, to the varible
        /// and from textbox as well
        /// and caluclate the total values for that and caluclate the discount
        /// shows the total value on provided label and
        /// if there is any exceptions, give user exception messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal HairDresserFees =0m , ServiceCharge = 0m;

            //Hairdresser charge
            //Assign variable value accoring the radiobutton selected

            if(JaneRB.Checked)
            {
                HairDresserFees = 30;
            }
            else if(PatRB.Checked)
            {
                HairDresserFees = 45;
            }
            else if(RonRB.Checked)
            {
                HairDresserFees = 40;
            }
            else if (SueRB.Checked)
            {
                HairDresserFees = 50;
            }
            else if (LauraRB.Checked)
            {
                HairDresserFees = 55;
            }

            //services charge
            //Assign values to the variable according to checked checkbox
            //gives an error if not selected
            if (!(HairCutCB.Checked) && !(ColourCB.Checked) && !(HighlightsCB.Checked) && !(ExtensionCB.Checked))
                {
                MessageBox.Show("At least One Service needs to be selected!");
                }
            else
                { 
                        if(HairCutCB.Checked)
                        {
                            ServiceCharge = ServiceCharge + 30;
                        }
                        if (ColourCB.Checked)
                        {
                            ServiceCharge = ServiceCharge + 40;
                        }
                        if (HighlightsCB.Checked)
                        {
                            ServiceCharge = ServiceCharge + 50;
                        }
                        if (ExtensionCB.Checked)
                        {
                            ServiceCharge = ServiceCharge + 200;
                        }
            }


            //client type
            //assign the value to the variable for the client type aaccording tot eh selection of the radio button
            decimal discount = 0m;
            if (AdultRB.Checked)
            {
                discount = 0;
            }
            else if (ChildRB.Checked)
            {
                discount = 10;
            }
            else if (StudentRB.Checked)
            {
                discount = 5;
            }
            else if (SeniorCitizenRB.Checked)
            {
                discount = 15;
            }

            //Nuber of clients visit
            
            decimal ExtraDiscount = 0m;
            string ClientVisitCount= NumberOfClientsVisitsTextBox.Text;
            int Clients;
            Boolean flag= true;
            ////gives an error if not entred an value is 0, or invalid input
            if (NumberOfClientsVisitsTextBox.Text == String.Empty || Convert.ToInt32(NumberOfClientsVisitsTextBox.Text) == 0)
                {
                    MessageBox.Show("PLease Enter a value for number of visits! Thank you!");
                }
            else //or else assign the values to the variables
                {
                    for(int i= 0; i < ClientVisitCount.Length;i++)
                        {
                            if(!char.IsDigit(ClientVisitCount[i]))
                            {
                                    flag = false;
                            }
                        }

                    if(flag)
                    {
                            Clients = Convert.ToInt32(ClientVisitCount);
                            if (Clients >= 1 && Clients <= 3)
                            {
                                ExtraDiscount = 0;
                            }
                            else if (Clients >= 4 && Clients <= 8)
                            {
                                ExtraDiscount = 5;
                            }
                            else if (Clients >= 9 && Clients <= 13)
                            {
                                ExtraDiscount = 10;
                            }
                            else if (Clients > 14)
                            {
                                ExtraDiscount = 15;
                            }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input!! Please Try Again!","Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
            //total for the service charge and the hair dresser charge
            decimal total = HairDresserFees + ServiceCharge;
            
            //discount 1 aplied for the c;ient type
            if(discount == 0)
            {
                total = total;
            }
            else
            {
                total = total - ((total) * (discount / 100));
            }
            //discount applied for the numberofclient visit
            if(ExtraDiscount == 0)
            {
                total = total;
            }
            else
            {
                total = total - ((total) * (ExtraDiscount / 100));
            }
            
            

            PriceDisplayLabel.Text = total.ToString("C");
            
        } // end of calculate button


        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
