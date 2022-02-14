using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            outputLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;

            outputLabel.Text = $"{hours} hours at ${pay} per hour equals ${earned}";
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            outputLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2\n\nThe cost to carpet this area at {costPerMeter} per square metre is ${totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double shirtCost = 12.49;
            double moneyGiven = 20;
            double taxRate = 0.13;
            double taxAmount = shirtCost * taxRate;
            double totalBill = shirtCost + taxAmount;
            double change = moneyGiven - totalBill;

            outputLabel.Text = $"Bill of Sale\n\nShirt:      {shirtCost}\n\nTax:        {taxAmount}\nTotal:      {totalBill}\n\nTendered:   {moneyGiven}\nChange:     {change}";
        }
    }
}
