using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {

        // refrefrence variables...
        Label firstClicked = null;
        Label secondClicked = null;


        // Create a Random Object
        Random random = new Random();

        // create a list for storing symbols...
        List<string> icons = new List<string>()
        {
            "!","!","k","k","N","N",",",",",
            "b","b","w","w","v","v","z","z"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        // This game requires to add images to grid randomely...using random assigning
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor; // sets icon color fore and back as same... 
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            // Timer 
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                //clickedLabel.ForeColor = Color.Black;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                //match found ......
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();




            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        public void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("You've matched all icons !! , Congratulations...");
            Close();
        }
    }
}
