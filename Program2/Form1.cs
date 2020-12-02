//Grading ID: K1791
//Program 2
//15 October 2020
//CIS 199-02
//This Program finds the best choice for a customer depending on the information they enter
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.ComponentModel.Design;

namespace Program2
{
    public partial class Form1 : Form
    {

        //Company A Variables

        const double aFourDay = 10.0;
        const double aSevenDay = 7.0;
        const double aPerPound = 1.0;

        const double aPerMile = .02;
        const double aOneDay = 20.0;
        const double aTwoDay = 17.0;
        const double aThreeDay = 15.0;
      
        //Company B Variables

        const double bTwoHundredPounds = 20.0;
        const double bOverTwoHundredPounds = .15;

        const double bPerMile = .10;
        const double bOneDay = 10.0;
        const double bFourDay = 7.0;
        const double bTenPounds = 3.0;
        const double bFiftyPounds = 5.0;
        const double bOneHundredPounds = 10.0;
        
        //Company C Variables
        const double cOneThousandMiles = 40.0;
       
        const double cTwoHundredMiles = 15.0;
        const double cZeroMiles = 10.0;
        const double cDays = 20.0;

        const double cPerPound = .25;
        const double cSevenFiftyMiles = 35.0;
        const double cFiveHundredMiles = 25.0;
        public Form1()
        {
            InitializeComponent();
        }




        //When the calculation button is pressed, the following calculations will take place
        private void calculationButton_Click(object sender, EventArgs e)
        {
            double weight, distance, distanceFee, weightFee, daysFee, totalFeesA, totalFeesB, totalFeesC;
            int days;
            string lowestCostCompany;

            //Validating weight
            if (double.TryParse(packageWeightTextBox.Text, out weight) && weight > 0)
            {
                //Validating distance
                if (double.TryParse(distanceTextBox.Text, out distance) && distance > 0)
                {
                    //Validating days
                    if (int.TryParse(deliveryTextBox.Text, out days) && days > 0)
                    {
                        //company A calculation
                        distanceFee = distance * aPerMile;
                        weightFee = weight * aPerPound;
                        if (days == 1)
                        {
                            daysFee = aOneDay;
                        }
                        else if (days == 2)
                        {
                            daysFee = aTwoDay;
                        }
                        else if (days == 3)
                        {
                            daysFee = aThreeDay;
                        }
                        else if (days >= 4 && days < 7)
                        {
                            daysFee = aFourDay;
                        }
                        else 
                        {
                            daysFee = aSevenDay;
                        }

                        totalFeesA = daysFee + weightFee + distanceFee;
                        companyAOutput.Text = totalFeesA.ToString("C");

                        //company B calculation
                        distanceFee = distance * bPerMile;
                        if (days == 1 && days < 4)
                        {
                            daysFee = bOneDay;
                        }
                        else 
                        {
                            daysFee = bFourDay;
                        }

                        if (weight < 10)
                        {
                            weightFee = bTenPounds;
                        }
                        else if (weight < 50)
                        {
                            weightFee = bFiftyPounds;
                        }
                        else if (weight < 100)
                        {
                            weightFee = bOneHundredPounds;
                        }
                        else if (weight < 200)
                        {
                            weightFee = bTwoHundredPounds;
                        }
                        else
                        {
                            weightFee = weight * bOverTwoHundredPounds;
                        }

                        totalFeesB = daysFee + weightFee + distanceFee;
                        companyBOutput.Text = totalFeesB.ToString("C");

                        //company C calculation
                        weightFee = weight * cPerPound;
                        daysFee = cDays;
                        if (distance < 200)
                        {
                            distanceFee = cZeroMiles;
                        }
                        else if (distance < 500)
                        {
                            distanceFee = cTwoHundredMiles;
                        }
                        else if (distance < 750)
                        {
                            distanceFee = cFiveHundredMiles;
                        }
                        else if (distance < 1000)
                        {
                            distanceFee = cSevenFiftyMiles;
                        }
                        else
                        {
                            distanceFee = cOneThousandMiles;
                        }

                        totalFeesC = daysFee + weightFee + distanceFee;
                        companyCOutput.Text = totalFeesC.ToString("C");

                        //Finding the lowest cost company
                        if (totalFeesA < totalFeesB && totalFeesA < totalFeesC)
                        {
                            lowestCostCompany = "A";
                        }
                        else if (totalFeesB < totalFeesA && totalFeesB < totalFeesC)
                        {
                            lowestCostCompany = "B";
                        }
                        else if (totalFeesC < totalFeesB && totalFeesC < totalFeesA)
                        {
                            lowestCostCompany = "C";
                        }
                        else
                        {
                            lowestCostCompany = "Two or More Companies have the same value";
                        }
                        lowestCostOutput.Text = $"The lowest cost company is: {lowestCostCompany}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance");
                }
            }
            else
            {
                MessageBox.Show("Invalid Weight");
            }

        }
    }
}

