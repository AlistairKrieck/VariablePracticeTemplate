using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            delay();
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputLabel.Text = "Player " + playerName + " is " + playerNumber;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            delay();
            double hoursWorked = 25;
            double payRate = 18.75;
            double totalPay;
            totalPay = Math.Round(hoursWorked * payRate,2);
            outputLabel.Text = $"You worked for {hoursWorked} hours";
            outputLabel.Text += $"\nYou make {payRate} an hour";
            outputLabel.Text += $"\nYou made {totalPay} before taxes stole it all";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            delay();
            double shirtCost = 12.49;
            double taxRate = 0.13;
            double taxAmount;
            double totalCost;
            double amountPaid = 20;
            double changeDue;
            taxAmount = shirtCost * taxRate;
            totalCost = Math.Round(shirtCost + taxAmount,2);
            changeDue = amountPaid - totalCost;
            outputLabel.Text = $"This shirt costs: {shirtCost}";
            outputLabel.Text += $"\nYour local taxe rate is: {taxRate}";
            outputLabel.Text += $"\nThe final price is: {totalCost}";
            outputLabel.Text += $"\nYou have paid: {amountPaid}";
            outputLabel.Text += $"\nYou are owed: {changeDue}";
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            delay();
            double radius = 15;
                double pi = 3.14;
            double area;
            area = (radius * pi);
            outputLabel.Text = $"The radius of this circle is: {radius}";
            outputLabel.Text += $"\n {pi} * {radius} will get you the area";
            outputLabel.Text += $"\nThe area of this circle is {area} units squared";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            delay();
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area;
            double totalCost;
            area = (length * width);
            totalCost = Math.Round(costPerMeter * area,2);
            outputLabel.Text = $"The length of the room is {length}";
            outputLabel.Text += $"\nThe width of the room is {width}";
            outputLabel.Text += $"\nThe area of the room is {area}";
            outputLabel.Text += $"\nThis carpet costs ${costPerMeter} per meter";
            outputLabel.Text += $"\nThe total cost of the carpet is ${totalCost}";


        }
        private void delay()
        {
            for (int i = 0; i < 3; i++)
            {
                outputLabel.Text = ".";
                Thread.Sleep(500);
                Refresh();
                outputLabel.Text = "..";
                Thread.Sleep(500);
                Refresh();
                outputLabel.Text = "...";
                Thread.Sleep(500);
                Refresh();
            }
        }
    }
}

