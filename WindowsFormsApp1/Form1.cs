using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Did you notice how your new form doesnt need to do very much? All it
        // does is set properties on objects based on user input, and change its output
        // based on those properties. Think about how the code for user input and 
        // output is seperated from the code that does the calculation

        //Did you notice how your new form doesn't need to do very much? All it
        //does is set properties on objects based on user input, and change its
        // output based on those properties. Think about how the code for user 
        // input and output is serperated from the code that does the calculation

        
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numOfPeopleUpDwn.Value, healthyBox.Checked, fancyBox.Checked);

            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked,
                                                    cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        // The fancyBox, healthyBox, and numericUpDown1 event handlers and the
        // the DisplayPartyDinnerCost() method are identical to the ones in the
        // Dinner Party exercise at the end of Chapter 5.



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numOfPeopleUpDwn_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numOfPeopleUpDwn.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }
    }
}
