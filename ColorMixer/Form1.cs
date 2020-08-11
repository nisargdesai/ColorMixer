using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        const int austin = 150, chicago = 225, dallas = 175, orlando = 300, pheonix = 175, raleigh = 150;
        const int regHandlingStress = 1000, regTimeManagement = 800, regSupervisionSkills = 1500, regNegotiation = 1300, regHowToInterview = 500;

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        int lodgeFees, total, days;
        public Form1()
        {
            InitializeComponent();
        }

        private void colorMixerRB_CheckedChanged(object sender, EventArgs e)
        {
            colorMixerPanel.Visible = true;
            workshopSelectorPanel.Visible = false;
        }

        private void workshopSelRB_CheckedChanged(object sender, EventArgs e)
        {
            colorMixerPanel.Visible = false;
            workshopSelectorPanel.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButtonColorPanel_Click(object sender, EventArgs e)
        {
            if(redColor1RB.Checked && redColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Red;
            }

            else if (redColor1RB.Checked && blueColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Purple;
            }

            else if (redColor1RB.Checked && yellowColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Orange;
            }

            else if (blueColor1RB.Checked && redColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Purple;
            }

            else if (blueColor1RB.Checked && blueColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Blue;
            }

            else if (blueColor1RB.Checked && yellowColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Green;
            }

            else if (yellowColor1RB.Checked && redColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Orange;
            }

            else if (yellowColor1RB.Checked && blueColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Green;
            }

            else if (yellowColor1RB.Checked && yellowColor2RB.Checked)
            {
                colorMixerPanel.BackColor = Color.Yellow;
            }

            else
            {
                colorMixerPanel.BackColor = Color.White;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            if (workshopListBox.SelectedItem != null && locationListBox.SelectedItem != null)
            {
                if (workshopListBox.SelectedIndex == 0)
                {
                    days = 3;
                    outputListBox.Items.Add("Registration fees: $" + regHandlingStress);
                }

                else if (workshopListBox.SelectedIndex == 1)
                {
                    days = 3;
                    outputListBox.Items.Add("Registration fees: $" + regTimeManagement);
                }

                else if (workshopListBox.SelectedIndex == 2)
                {
                    days = 3;
                    outputListBox.Items.Add("Registration fees: $" + regSupervisionSkills);
                }

                else if (workshopListBox.SelectedIndex == 3)
                {
                    days = 5;
                    outputListBox.Items.Add("Registration fees: $" + regNegotiation);
                }

                else
                {
                    days = 1;
                    outputListBox.Items.Add("Registration fees: $" + regHowToInterview);
                }

                switch (locationListBox.SelectedIndex)
                {
                    case 0:
                        lodgeFees = days * austin;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    case 1:
                        lodgeFees = days * chicago;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    case 2:
                        lodgeFees = days * dallas;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    case 3:
                        lodgeFees = days * orlando;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    case 4:
                        lodgeFees = days * pheonix;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    case 5:
                        lodgeFees = days * raleigh;
                        outputListBox.Items.Add("Lodging fees: $" + lodgeFees + " for " + days + " days.");
                        break;

                    default:
                        outputListBox.Items.Add("Please select a location");
                        break;
                }

                if (workshopListBox.SelectedIndex == 0)
                {
                    total = regHandlingStress + lodgeFees;
                    outputListBox.Items.Add("Total: $" + total);
                }

                else if (workshopListBox.SelectedIndex == 1)
                {
                    total = regTimeManagement + lodgeFees;
                    outputListBox.Items.Add("Total: $" + total);
                }

                else if (workshopListBox.SelectedIndex == 2)
                {
                    total = regSupervisionSkills + lodgeFees;
                    outputListBox.Items.Add("Total: $" + total);
                }

                else if (workshopListBox.SelectedIndex == 3)
                {
                    total = regNegotiation + lodgeFees;
                    outputListBox.Items.Add("Total: $" + total);
                }

                else if (workshopListBox.SelectedIndex == 4)
                {
                    total = regHowToInterview + lodgeFees;
                    outputListBox.Items.Add("Total: $" + total);
                }

            }
            else
            {
                outputListBox.Items.Add("Please select a workshop and a location for the listbox.");
            }
        }
    }
}

