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

namespace CashRegister
{
    public partial class cashRegister : Form
    {
        //global constants and variables
        const double BURGERS_COST = 2.49;
        const double FRIES_COST = 1.89;
        const double DRINKS_COST = 0.99;
        const double TAX_RATE = 0.13;
        int burger = 0;
        int fries = 0;
        int drink = 0;
        double change;
        double price;
        double tax;
        double priceWithTax;
        double tendered;

        public cashRegister()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            burger = Convert.ToInt32(burgerBox.Text); //Your order is taken and the total is printed
            fries = Convert.ToInt32(friesBox.Text);
            drink = Convert.ToInt32(drinksBox.Text);

            price = burger + fries + drink;

            subtotalLabel.Text = price.ToString("$0.00");

            tax = price * TAX_RATE;

            priceWithTax = price + tax;

            taxLabel.Text = tax.ToString("C");

            totalLabel.Text = priceWithTax.ToString("C"); 

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            tendered = Convert.ToInt32(tenderedInput.Text); //The change is being made if need be
            
            change = tendered - priceWithTax;
            
             changeLabel.Text = change.ToString("C");

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //The graphics and text for the receipt are made and printed
            SolidBrush taxBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush = new SolidBrush(Color.Black);

            Font receiptFont = new Font("Courier New", 8); 
            formGraphics.FillRectangle(taxBrush, 200, 0, 340, 340);
            formGraphics.DrawString("Burgers ordered - " + burger, receiptFont,receiptBrush,200, 50);
            formGraphics.DrawString("Fries ordered   - " + fries, receiptFont, receiptBrush, 200, 70);
            formGraphics.DrawString("Drinks ordered - " + drink, receiptFont, receiptBrush, 200, 90); ;
            formGraphics.DrawString("Your total comes to " + price.ToString("$0.00"), receiptFont, receiptBrush, 200, 110); ;
            formGraphics.DrawString("Tax - " + tax.ToString("$0.00"), receiptFont, receiptBrush, 200, 130);
            formGraphics.DrawString("Your total with tax - " + priceWithTax.ToString("$0.00"), receiptFont, receiptBrush, 200, 150);
            formGraphics.DrawString("Amount tendered - " + tendered.ToString("$0.00"), receiptFont, receiptBrush, 200, 170);
            formGraphics.DrawString("Change - " + change.ToString("$0.00"), receiptFont, receiptBrush, 200, 190);

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //This gets rid of the receipt
            SolidBrush taxBrush = new SolidBrush(Color.PowderBlue);
            formGraphics.FillRectangle(taxBrush, 200, 0, 340, 340);
            burgerBox.Clear();
            friesBox.Clear();
            drinksBox.Clear();
            tenderedInput.Clear();

            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
            changeLabel.Text = "";
        }

    }
}
